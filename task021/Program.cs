// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.WriteLine("Введите пятизначное число N: ");
int N = Convert.ToInt32(Console.ReadLine());

string numberText = Convert.ToString(N); // общая конвертация в текст, чтобы потом не делать конвертацию в каждой строке

if (N > 9999 && N < 100000)
{
   if ( numberText[0] == numberText[4] && numberText[1] == numberText[3] )
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