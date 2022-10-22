//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

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

