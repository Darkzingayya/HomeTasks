﻿Console.Clear();
int m1 = 1, m2 = 1, a = 1;
Console.WriteLine("Введите последовательность натуральных чисел чисел: ");
while (a > 0) {
a = Convert.ToInt32 (Console.ReadLine());
if (a > m1) {m2 = m1; m1 = a;} //Сохранение старого максимума и объявление нового
else 
   if (m1 > a && a > m2) m2 = a;} // В случае 2х максимальных чисел оба максимума будут равны, поэтому выполняется эта проверка
Console.WriteLine($"Второе по величине число в последовательности: {m2}");