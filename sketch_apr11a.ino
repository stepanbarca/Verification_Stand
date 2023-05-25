#define WIFI_SERIAL    Serial1

// Длительность отсутствия/присутствия питанаия (мс)
unsigned long supply_time_gap = 1000;
// Интервал сбора данных (мс)
unsigned long saving_time_gap = 5000;

// Информация об схеме
const int n_res = 1;
const int n_multi = 3;

//Время последний проверки
unsigned long time_last_measurement = 0;

//Время последнего переключения
unsigned long time_last_turning = 0;

// нижняя граница и верхняя граница по току
float lower_bound = -500;
float upper_bound = 500;

//Напряжение поддается?
boolean is_power_supply_applied = true;

// Длительность каждого этапа
unsigned long stage[4] = {600000UL, 60000UL, 60000UL, 60000UL};

// Текущий этап
int current_stage = 0;

// Время перехода на следующий этап
unsigned long next_stage_time = stage[0];

// Время начала паузы
unsigned long pause_time;

//Пин первого ключа (подразумевается что все остальные ключи подключены последовательно)
int first_key_pin = 28;

int control_pins[6][3] = {
  {2, 3, 4},
  {5, 6, 7},
  {8, 9, 10},
  {11, 12, 13},
  {22, 23, 24},
  {25, 26, 27}
};

// Флаги живых резисторов
boolean is_res_alive[n_res];

const float ref_voltage = 5 ; // Фактическое напряжение на пине AREF
const float cf = ref_voltage / 5.025; // Поправочный коэффициент для напряжения

float voltage_array[n_res];
float current_array[n_res];
float power_array[n_res]; // Не лучшая идея считать мощность на ардуино


const int averageValue = 50; // Сколько раз считываем измерение для усреднения (желательно четное)
boolean start_flag = false;
const int multi_delay = 1; // Задержка после смены управляющего сигнала на мультплексора


float power = 0; // Мощность на резисторе
float voltage = 0; // Напряжение на резисторе
float current = 0; // Ток на резисторе

// Пришедшее сообщение
String msg;


//int control_pins[3] = {2, 3, 4};

void multiplexer(int pins[3], int signal) // Подаем массив номеров пинов управляющих (от младшего к старшему) и номер входа на мультиплексоре
{
    for(int i=0; i < 3; i++)
    {
      digitalWrite(pins[i], LOW);
      if(bitRead(signal, i))
      {
        digitalWrite(pins[i], HIGH);
      }
    }
    delay(multi_delay); // Немного подождем для стабильности
}


float voltage_meas(int analog_pin)
{
  long long value = 0;
  for (int i = 0; i < averageValue; i++)
  {	
     value += analogRead(analog_pin);
     delay(2);
     
  }
  //Serial.println(value *1.0 / averageValue);
  return value * ref_voltage / averageValue / 1023;
}


double current_meas(int analog_pin)
{
   long long value = 0;
   for (int i = 0; i < averageValue; i++)
   {	
      value += analogRead(analog_pin);
      //Serial.println(value);
      //delay(5);
   }
   //Serial.println(value *1.0 / averageValue);
  //double current = (value * cf / averageValue / 1023.0   - 2.5) / 0.187;
  
  double current = (value - averageValue*512.5);
  current = current /  37.88 / averageValue;      // Расчет тока
  if (current >= 0) { return current; }
  else {return current * -1;}
  return current;
  }


//Функция ожидания старта
void wait_for_start()
{
  while (!start_flag) // Синхронизация запуска и записи
  {
    msg =Serial.readStringUntil(';');
    if(msg == "START") 
    {
    
      //n_res = Serial.readStringUntil(';').toInt();
      //n_multi = Serial.readStringUntil(';').toInt();
      
      
      start_flag = true;
      for(int i=0;i<4;i++)
      {
	 stage[i] = strtoul(Serial.readStringUntil(';').c_str(), NULL, 10);
      }
      
      supply_time_gap = strtoul(Serial.readStringUntil(';').c_str(), NULL, 10); // Длительность импульсов (мс)
      saving_time_gap = strtoul(Serial.readStringUntil(';').c_str(), NULL, 10); // Как часто отравлять данные (мс)
      
      
      lower_bound = Serial.readStringUntil(';').toFloat();
      upper_bound = Serial.readStringUntil(';').toFloat();
      
      current_stage = 0;
      next_stage_time = stage[0] + millis();
    }
    else if(msg == "RESUME")
    {
      start_flag = true;
      next_stage_time = next_stage_time + millis() - pause_time;
    }
    delay(500);
  }  
}

//Проверка на паузу
void pause_check()
{
  msg =Serial.readStringUntil(';');
  if(msg == "PAUSE")
  {
      start_flag = false;
      pause_time = millis();
  }
}

void setup() 
{
  analogReference(EXTERNAL);
  Serial.begin(9600);               //  Открываем последовательную связь на скорости 9600
  Serial.setTimeout(50); // Время ожидания команды от ПК
  
  for(int i=0; i < n_multi; i++)
  {
   for(int j=0; j<3; j++)
   {
      pinMode(control_pins[i][j], OUTPUT);
   }
   // Натсраиваем пины ключей
   for(int i=0; i < n_res;i++)
   {
      pinMode(i + first_key_pin, OUTPUT);
   }
   // Включаем пины ключей
   for(int i=0; i < n_res;i++)
   {
      digitalWrite(i + first_key_pin, HIGH);
   }
    
   //Объявляем массив истинными значениями
   for(int i=0; i < n_res;i++)
   {
      is_res_alive[i] = true;
   }
   
  }
}

void switcher(boolean state) // Функция для переключения ключа на живых резисторах
{
   for(int i=0; i < n_res; i++)
      {
	 if(is_res_alive[i])
	 {
	    digitalWrite(i + first_key_pin, state);
	 }
      }
}

boolean alive(float value, float lower_bound, float upper_bound) // Функция для проверки живости резистора
{
   if(value < lower_bound || value > upper_bound)
   {
      return false;
   }
   else
   {
      return true;
   }
}

void next_stage_check()
{
   if(next_stage_time < millis())
   {
      current_stage++;
      if(current_stage > 3)
      {
	 Serial.println("over");// Что еще делать?
	 while(true)
	 {
	    delay(10000);
	 }
      }
      else
      {
	 next_stage_time = next_stage_time + stage[current_stage];
      }
      
   }
}

// Считывать два временных числа
// Верхнюю и нижнюю границу тока


void loop() 
{
   wait_for_start();
   if(millis() - time_last_measurement > saving_time_gap) // Время (мс) с последней проверки > время сбора данных
   {
      time_last_measurement = millis();
      for(int i=0; i < n_res; i++)
      {
	 if(!is_power_supply_applied)
	 {
	    switcher(true);
	    is_power_supply_applied = true;
	    time_last_turning = millis();
	    delay(10); // Нужна ли задержка?
	 }
      
	 if(is_res_alive[i])
	 {
	    multiplexer(control_pins[i / 8], i % 8);
	    voltage_array[i] = voltage_meas(i / 8);

	    multiplexer(control_pins[i / 8], i % 8 + 1);
	    voltage_array[i] -= voltage_meas(i / 8);

	    multiplexer(control_pins[i / 8], i % 8 + 2);
	    current_array[i] = current_meas(i / 8);

	    power_array[i] = voltage_array[i]*current_array[i];
	    
	    if (!alive(voltage_array[i] / current_array[i], lower_bound, upper_bound))
	    {
	       is_res_alive[i] = false; // Что отправлять на ПК?
         digitalWrite(i + 28, 0);
	       voltage_array[i] = 0;
	       current_array[i] = 0;
	       power_array[i] = 0;
	    }
	 }
	 
      }
      
      for(int i= 0; i < n_res;i++)
      {
	  Serial.println(String(voltage_array[i], 3));
	  Serial.println(String(current_array[i], 3)); 
	  Serial.println(String(power_array[i], 3));
	  Serial.println(String(is_res_alive[i]));
      };
      Serial.println("end");
      
   }
   
   // Переключаем питание
   if((current_stage == 2) && (millis() - time_last_turning > supply_time_gap))
   {
      switcher(!is_power_supply_applied);
      is_power_supply_applied = !is_power_supply_applied;
      time_last_turning = millis();
   }
   
   next_stage_check();
   pause_check();
}
