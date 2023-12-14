//: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29

int ReadInt(string str)
{
    Console.WriteLine(str);
    return Convert.ToInt32(Console.ReadLine());
}

int Numbers(int number1, int number2) //number1=m, number2=n
{
    if(number1==0) return number2+1;
    else if(number1>0 && number2==0) 
    {
        return Numbers(number1-1,1);
    }
    else
    {
        return Numbers(number1-1, Numbers(number1,number2-1));
    }

}
int m = ReadInt("Введите число m");
int n = ReadInt("Введите число n");
int result =  Numbers(m,n);
Console.WriteLine(result);

