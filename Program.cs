/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76*/


int size;

Console.WriteLine("Vvedite kolichestvo 4icel v massive");
int.TryParse(Console.ReadLine(), out size);

double min;
Console.WriteLine("Vvedite min chislo");
double.TryParse(Console.ReadLine(), out min);

double max;
Console.WriteLine("Vvedite max chislo");
double.TryParse(Console.ReadLine(), out max);

double [] CreateArray (int size, double min, double max){
    
    double [] array = new double [size];
    for (int i = 0; i<array.Length; i++){
        array [i]=new Random( ).NextDouble()*(max-min)+min;
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
    return array;
}

double Razn (double [] array){
    double min = array[0];
    double max = array[0];
    double result;
    for (int i = 0; i < array.Length; i++)
        {if(array [i]>max){max=array[i];}
        else if (array[i]<min){min=array[i];}
    }
    result = max - min;
    return result;
}

Console.WriteLine($"Raznica mezdy max i min = {Razn(CreateArray(size,min,max))}");