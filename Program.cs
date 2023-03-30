/*Задача 34: Задайте массив заполненный случайными положительными 
трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2*/

int size;

Console.WriteLine("Vvedite kolichestvo simvolov v massive");
int.TryParse(Console.ReadLine(), out size);

int [] array = CreateArray (size, 100, 999);

int [] CreateArray (int size, int min, int max){
    int [] array = new int [size];
    for (int i = 0; i<array.Length; i++){
        array [i]=new Random().Next(min, max + 1);
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
    return array;
}

int Kolich (int[]array){
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]%2==0){count++;}
    }return count;
}
Console.WriteLine($"kolichesto chetnix chisel v massive {Kolich(array)}");
