

// Задача 43: Напишите программу, которая найдёт точку пересечения 
// двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


// Console.Write("введите b1: ");
// double b1=Convert.ToInt32(Console.ReadLine());
// Console.Write("введите k1: ");
// double k1=Convert.ToInt32(Console.ReadLine());
// Console.Write("введите b2: ");
// double b2=Convert.ToInt32(Console.ReadLine());
// Console.Write("введите k2: ");
// double k2=Convert.ToInt32(Console.ReadLine());

// double x=(b2-b1)/(k1-k2);
// double y=k1 * x + b1;


// Console.Write($"{x};{y}");





// Задача 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3


// Console.Write($"Введи (количество чисел) M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[m];

// void Numbers(int m){
// for (int i = 0; i < m; i++){
//     Console.Write($"Введи {i+1} число: ");
//     array[i] = Convert.ToInt32(Console.ReadLine());
//   }
// }

// int Countt(int[] array){
//   int count = 0;
//   for (int i = 0; i < array.Length; i++){
//     if(array[i] > 0 ) count ++; 
//   }
//   return count;
// }

// Numbers(m);

// Console.WriteLine($"Введено чисел > 0: {Countt(array)} ");