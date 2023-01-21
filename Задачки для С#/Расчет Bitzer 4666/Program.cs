double EXW, Conv, TransToArm, CommisionInArm, Insuranse1, SaleArmRF, Insuranse2, TransportArmSV;
double duty, VAT, DC, Broker, FinalDDPSVEUR, FinalDDPSVRUR, EURRUB;

EURRUB = 73.11;

System.Console.WriteLine("Введите значение: exw ");
EXW = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите значение: Конвертация в % ");
Conv = Convert.ToInt32(Console.ReadLine());
double result1 = (EXW*(Conv/100));

System.Console.WriteLine("Введите значение: Транспорт в Армению ");
TransToArm = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите значение: Комиссия партнера в Армении в % ");
CommisionInArm = Convert.ToInt32(Console.ReadLine());
double result2 = (EXW*(CommisionInArm/100));


Insuranse1 = (EXW*0.002);


double result3 = (TransToArm + EXW + result1 + result2 + Insuranse1);
double result4 = result3*EURRUB;

System.Console.WriteLine("В Армении товар будет стоить в ЕВРО: " + result3); 
System.Console.WriteLine("В Рублях: " + result4);


