/* Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.*/

int[] array = new int[10];

for (int i = 0; i < array.Length; i++){
    array[i] = new Random().Next(1, 100);
    Console.Write(array[i] + " ");
}

int sum = 0;
for (int i = 1; i < array.Length; i=i+2){
    sum = sum + array[i]; 
}
Console.WriteLine();
Console.WriteLine($"Sum of odd numbers in array is {sum}");
 