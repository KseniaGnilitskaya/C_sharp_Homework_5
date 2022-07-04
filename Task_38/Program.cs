/* Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.*/


int[] array = new int[10];

for (int i = 0; i < array.Length; i++) {
    array[i] = new Random().Next(1,100);
    Console.Write(array[i] + " ");
}
Console.WriteLine();

Array.Sort(array); // я отсортировала массив от наименьшего к наибольшему
foreach (int i in array) {
    Console.Write(i + " ");
}
Console.WriteLine();

int min = array[0];
int max = array.Last();
Console.WriteLine(max-min);


