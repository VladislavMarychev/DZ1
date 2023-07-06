//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее. 
Console.WriteLine ("Введите число A");

 int numberA = Convert.ToInt32(Console.ReadLine()!);

 Console.WriteLine("Введите число B"); 

 int numberB = Convert.ToInt32(Console.ReadLine()!);

 if(numberA > numberB) 

 { 
    Console.WriteLine ("{0} Максимальное число", numberA ); 
    Console.WriteLine ("{0} Минимальное число", numberB ); 
    } 
 else {
     Console.WriteLine ("{0} Максимальное число", numberB );
     Console.WriteLine ("{0} Минимальное число", numberA ); 
     }