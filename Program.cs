// Задача 25. семинар 4  Напишите программу, которая принимает 
// на вход числа (A и B) и возводит число A в натуральную степень B.

//Console.Write("Введите число A: ");
//int a = Convert.ToInt32(Console.ReadLine());
//Console.Write("Введите число B: ");
//int b = Convert.ToInt32(Console.ReadLine());
//int step = a;
//for (int i=1; i < b; i++)
//{
   // step = step * a;
//}
//Console.WriteLine($"Натуральная степень числа A в степени числа B равна {step}");

// Задача 27. семинар 4  Напишите программу, которая принимает 
// на вход число и выдаёт сумму цифр в числе.

// Console.WriteLine("введите число");
// int i = Convert.ToInt32(Console.ReadLine());
// int sum = 0;

// while (i > 0)
// {
// int num = i % 10;
// i = i / 10;
// sum = sum + num;
// }
// Console.WriteLine("сумма всех цифр в числе равна: " + sum);

// Задача 29. семинар 4    Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран.

void RanArray(int[] number)
{
  int lenght = number.Length;
  int index = 0;
   while(index < lenght)
   {
     number[index] = new Random().Next(1,100);
      index ++;
   }
}
void PrintArray(int[] num1)
{
   int count = num1.Length;
   int position = 0;
   while (position < count)
   {
      Console.WriteLine(num1[position]);
      position++;
   }
}
int[] array = new int[8];
RanArray(array);
PrintArray(array);

