Console.WriteLine("Введите число1: ");
var число1 = Console.ReadLine()!;
Console.WriteLine("Введите число2: ");
var число2 = Console.ReadLine()!;

 var parse1 = int.TryParse(число1, out int Z ); 
 var parse2 =(int.TryParse(число2, out int X));
 int c= 0 ;
 if (parse1 & parse2 ) 
 {
   c = Z / X;
 }
 Console.WriteLine(c);
 

