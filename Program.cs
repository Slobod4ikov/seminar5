/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/


int size;

Console.WriteLine("Vvedite koli4estvo simvolov v massive");
int.TryParse(Console.ReadLine(), out size);

int min;
Console.WriteLine("Vvedite min 4islo");
int.TryParse(Console.ReadLine(), out min);

int max;
Console.WriteLine("Vvedite max 4islo");
int.TryParse(Console.ReadLine(), out max);

int [] CreateArray (int size, int min, int max){
    int [] array = new int [size];
    for (int i = 0; i<array.Length; i++){
        array [i]=new Random().Next(min, max + 1);
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
    return array;
}

int Sum4et (int[]array){
    int sum = 0;
    for (int i = 1; i < array.Length; i=i+2){
        sum=sum+array[i];
    }
    return sum;
}
Console.WriteLine($"symma 4etnix elementov v massive {Sum4et(CreateArray(size,min,max))}");