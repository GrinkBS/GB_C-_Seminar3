// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.WriteLine("Введите пятизначное число N: ");
int N = Convert.ToInt32(Console.ReadLine());

if (N > 9999 && N < 100000)
{
   if ( N.ToString()[0] == N.ToString()[4] && N.ToString()[1] == N.ToString()[3] )
   {
   Console.WriteLine($"{N} -> да");
   }
   else
   {
    Console.WriteLine($"{N} -> нет");  
   }
}
else
{
   Console.WriteLine("input 5 digits number");
}