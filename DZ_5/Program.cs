// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
// int [] array = new int [10];
// int countEvenNumber = 0;
// for(int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(100, 1000);
// }
// Console.WriteLine($"[{String.Join(", ", array)}]");

// for(int i = 0; i < array.Length; i++)
// {
//     if (array[i] % 2 == 0)
 
//     {
//         countEvenNumber++;
//     }
// }
// Console.WriteLine($"Количество чётных чисел - {countEvenNumber}");


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
// стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// Ищем сумму чисел стоящих именно на нечетных позициях, то есть, с четными индексами,
// если нужны с нечетными индексами, тогда: if(i % 2 != 0)

// int [] array = new int [4];
// int oddPositionSum = 0;
// for(int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(1, 10);
// }
// Console.WriteLine($"[{String.Join(", ", array)}]");
// for(int i = 0; i < array.Length; i++)
// {
//     if(i % 2 == 0)
//     {
//         oddPositionSum += array[i];
//     }
// }
// Console.WriteLine($"Сумма чисел стоящих на нечётных позициях - {oddPositionSum}");


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным 
// и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// double [] array = new double[10];
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().NextDouble() + new Random().Next(1, 100);
// }
// Console.WriteLine($"{String.Join(", ", array)}");

// int j = 0; 
// double min = array[j]; 
// double max = array[j];
// while (j < array.Length)
// {
//     if (array[j] < min) min = array[j];
//     if (array[j] > max) max = array[j];
//     j++; 
// }
// Console.WriteLine($"Разница между максимальным и минимальным числами - {max - min}");

