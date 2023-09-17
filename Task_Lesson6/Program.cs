using System;
using System.Collections;
using System.ComponentModel.Design;
using System.Threading.Channels;

/* Apilcation of customs for vehicles & technical inspection for vehicles
* Mark 
* Model
* Year
* Color
* Type
* EngineType
* EngineSize
* Mileage
* Wheels
* Transmision
* PlaceCount
* CustomsDuty
* Value-AddenTex
*/

string mark;
//string model = " ";
//int year = 0;
//string color = "Black ";
//string type = "Sedan";
//string engineType = "";
//int engineSize = 0;
//int mileage = 0;
//int wheels = 0;
//string transmision = " ";
//int placeCount = 1;
//double customDuty = 0D;
//double valueAddenTax = 0D;

Console.WriteLine("Siz mashininizin gomruk prasidurasi ");
Console.WriteLine("Marka :");
mark = Console.ReadLine ();
Console.WriteLine("Year :");
int year = int.Parse(Console.ReadLine());
Console.WriteLine("Color :");
string color =Console.ReadLine();
color = color.ToUpper();
Console.WriteLine("Type :");
string type = Console.ReadLine();
Console.WriteLine("EngineType :");
string engineType = Console.ReadLine();
Console.WriteLine("EngineSize :");
int engineSize = int.Parse(Console.ReadLine());
Console.WriteLine("Mileage :");
int mileage = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Wheels :");
int wheels = int.Parse(Console.ReadLine());
Console.WriteLine("PlaceCount :");
int placeCount = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("CustomDuty :");
double customDuty = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("ValueAddenTax :");
double valueAddenTax = double.Parse(Console.ReadLine());
int customOfCar =(int)(customDuty + valueAddenTax);

Console.Clear();
Console.WriteLine("Siz mashininizin gomruk prasidurasi ");

if (year < 2000 || year == 2000) 
{
    Console.WriteLine("Mashinin buraxilish ili 2000 den yuxari olmalidir!!!" );
}
  if (year < 2010 & year < 2015) 
{
    Console.WriteLine("Sizin mashinizin elave \"Rusumu 3000 \"olacaq");
}
  else  
{ 
    Console.WriteLine("Bu Mashinilar olkeye buraxilmir !!!");
       
}
switch (color)
{
    case "Black":
    case "White":
    case "Green":

        Console.WriteLine("Mashinin rengi uygundu !!!");
        break;
    case "Metalic":

        Console.WriteLine("Mashinin rengine gore eleve \" 300 azn \" rusum odenilecek !!!");
        break;
    default:

        Console.WriteLine("Bu regli mashin olkeye buraxilmir !!!");
        break;


}
switch (type)
{
    case "Sedan":
    case "Cupe":
    case "Furqon":
    case "Cip":
        Console.WriteLine("Minik Avrtombili ");
        break;
    case "Vito":
    case "FordTranzit":
    case "Sprinter":
        break;
 
    default :
        Console.WriteLine("Zehmet olmasa \\ avtomobil tipini duzgun daxil edin !\\");
            break;

}
switch (engineType)
{
    case "Benzin":
    case "Dizel":
    case "Qaz":
        Console.WriteLine("Sizin avtodan eleve rusum alinacaq");
        break;
    case "Elektrik":
    case "Hibrid":
        Console.WriteLine("Sizin avto rusumdan azaddir");
        break;
    default:
        Console.WriteLine("Sizin avto olkeye buraxilmir ");
        break;
}

if (engineSize >= 1000 || engineSize  <= 1500) 
{
    Console.WriteLine("Motosikil");
}
if (engineSize >= 2000 || engineSize <= 2500) 
{
    Console.WriteLine("Minik Avtomobili");
}
   else if (engineSize >= 2500 & engineSize <= 3000) 
{
    Console.WriteLine("Yuk Mashini");
}
else
{
    Console.WriteLine(" Muherik hecmini duzdun daxil edin !");
}
if (mileage >=0 & mileage <= 5000 || mileage >= 10000)
{
    Console.WriteLine("Sizin avtonun rusumu \" 10000\" azndir");
}
 if (mileage >10000 || mileage <= 20000 )
{
    Console.WriteLine("Sizin avtonun rusumu \" 5000 \" azndir");
}
 else if (mileage >20000 || mileage <= 50000)
{
    Console.WriteLine("Sizin avtonun rusumu \" 3000 \" azndir");
}
 switch (wheels)
{
    case (4):
    case (6):
        Console.WriteLine("Minik avtomobili");
        break;
    case (2):
        Console.WriteLine("Moped");
        break;
        default: 
        Console.WriteLine("Yuk Avtomobili");
        break;







}
placeCount = 2;
if (placeCount <=2||placeCount >=4)
{
    Console.WriteLine("Minik Avto");
}
if (placeCount >=5 || placeCount <=15 )
{
    Console.WriteLine("Sernishin Avto");
}    
else
{
    Console.WriteLine("Metro ve ya Qatar");
}
if (customOfCar <= 10000 & engineSize <= 1000 & mileage == 0)
{
    Console.WriteLine(" Avto yenidir ");
}
 if ((customOfCar >10000 & engineSize <= 2000))

 {
    Console.WriteLine(" Avto ishlenmishdir");
 }
 else
{
    Console.WriteLine("Avto qrupda yoxdur ");
}






