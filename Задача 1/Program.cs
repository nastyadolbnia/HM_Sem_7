//Задача 1 Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
//Использовать рекурсию, не использовать циклы.

int ReadInt (string str)
{
    Console.WriteLine(str);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintNumbers( int number1, int number2)
{
    if(number1>number2) return;
    Console.Write(number1+ " ");
    PrintNumbers(number1+1,number2);
    
}

int m = ReadInt("Введите первое число");
int n = ReadInt("Введите второе число");
PrintNumbers(m,n);
