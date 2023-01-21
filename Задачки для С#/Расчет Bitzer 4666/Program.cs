double EXW, Conv, TransToArm, CommisionInArm, Insuranse1, Insuranse2, TransportArmSV;
double duty, VAT, DC, Broker, EURRUB;

EURRUB = 73.11;

System.Console.WriteLine("Введите значение: EXW ");
EXW = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите значение: Конвертация в % ");
Conv = Convert.ToInt32(Console.ReadLine());
double result1 = (EXW*(Conv/100));

System.Console.WriteLine("Введите значение: Транспорт в Армению EUR ");
TransToArm = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите значение: Комиссия партнера в Армении в % ");
CommisionInArm = Convert.ToInt32(Console.ReadLine());
double result2 = (EXW*(CommisionInArm/100));


Insuranse1 = (EXW*0.002);


double result3 = (TransToArm + EXW + result1 + result2 + Insuranse1);
double result4 = result3*EURRUB;

System.Console.WriteLine("В Армении товар будет стоить в ЕВРО: " + result3); 
System.Console.WriteLine("В Рублях: " + result4);

Insuranse2 = (result3*0.002);

System.Console.WriteLine("Введите значение: Транспорт Армения - Севастополь EUR ");
TransportArmSV = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите значение: Пошлина в % ");
duty = Convert.ToInt32(Console.ReadLine());
double result5 = (Insuranse2+result3);
double result6 = result5*(duty/100);
System.Console.WriteLine("Пошлина в EUR = " + result6);

System.Console.WriteLine("Введите значение: НДС в % ");
VAT = Convert.ToInt32(Console.ReadLine());
double result7 = (result5 + duty);
double result8 = result7*(VAT/100);
System.Console.WriteLine("НДС в EUR = " + result8);

DC = 341.95;
Broker = 683.9;

double result9 = (result3 + result6 + result8 + DC + VAT + TransportArmSV + Broker);
double result10 = result9*EURRUB;
double result11 = (result9/EXW);

System.Console.WriteLine("Итого DDP Севастополь в ЕВРО: " + result9); 
System.Console.WriteLine("Итого DDP Севастополь в Рублях: " + result10);
System.Console.WriteLine("Коэфицент DDP " + result11);








