/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
    14212 -> нет
    12821 -> да
    23432 -> да
*/

// приведу два варианта решения: оперирование строкой и оперирование числом

Console.Write("Введите пятизначное число: ");
string num = Console.ReadLine();
int number = int.Parse(num);

while(num.Length !=5 || num[0]=='0')
{
    Console.Write("Неверно! Введите ПЯТИЗНАЧНОЕ число: ");
    num = Console.ReadLine();
    number = int.Parse(num);
}

//1 вариант (самый эффективный) - строковым представлением числа
bool p = true;
int n = num.Length ;
for(int i=0; i < n / 2; i++)
    if (num[i] != num[n-i-1])
    {
        Console.WriteLine("нет");
        p = false;
        break;
    }
if(p)Console.WriteLine("да");

//2 вариант - оперирование числом
if(number / 10000 == number % 10 && number / 1000 % 10 == number / 10 % 10)
     Console.WriteLine("да");
else 
     Console.WriteLine("нет");     


