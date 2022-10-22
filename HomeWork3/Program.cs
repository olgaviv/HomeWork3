//Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

/*
bool Palindrom(int number)
{
    int n5 = number % 10;
    int n4 = (number % 100) / 10;
    int n2 = (number / 1000) % 10;
    int n1 = number / 10000;

    
    if (n5 == n1 && n4 == n2)
    {
        return true;
    }
    else
    {
       return false;
    }

}


Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());

bool res = Palindrom (number);
if (res==false)
{
    Console.WriteLine($"Число {number} не является палиндромом");
}
else 
{
    Console.WriteLine($"Число {number} является палиндромом");
}

*/

// Задача 21  Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
double Theorem(double numX1, double numY1, double numX2, double numY2, double numX3, double numY3)
{
    double catet1 = numX1 - numX2;
    catet1 = Math.Pow(catet1, 2);

    double catet2 = numY1 - numY2;
    catet2 = Math.Pow(catet2, 2);

    double catet3 = numY3 - numY3;
    catet2 = Math.Pow(catet3, 2);

    double Hypotenus = catet1 + catet2 + catet3;
    Hypotenus = Math.Sqrt (Hypotenus);
    return Hypotenus;
}

Console.Write("Input first x1  ");
double x1= Convert.ToDouble(Console.ReadLine());
Console.Write("Input first y1 ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input second x2  ");
double x2= Convert.ToDouble(Console.ReadLine());
Console.Write("Input first y2 ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input first x3  ");
double x3= Convert.ToDouble(Console.ReadLine());
Console.Write("Input first y3  ");
double y3= Convert.ToDouble(Console.ReadLine());



double res = Theorem (x1,y1,x2,y2,x3,y3);
Console.WriteLine($"Расстояние между точками: {res}");

*/

// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N

void Cube(int n)
{
    int number = 1;
    while (number <= n)
    {
        Console.Write(Math.Pow(number, 3) + " ");
        number++;
    } 
}
Console.WriteLine("Введите положительное число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n<0)
{
    Console.WriteLine ("Число отрицательное!");
}
Cube(n);
