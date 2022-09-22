/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
    14212 -> нет
    12821 -> да
    23432 -> да
*/

/*
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
*/


/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
    A (3,6,8); B (2,1,-7), -> 15.84
    A (7,-5, 0); B (1,-1,9) -> 11.53
*/

/*
Console.Write("Введите координаты x,y,z точки А через пробел: ");
string []s = Console.ReadLine().Split();
int ax = int.Parse(s[0]), ay = int.Parse(s[1]), az = int.Parse(s[2]);

Console.Write("Введите координаты x,y,z точки В через пробел: ");
s = Console.ReadLine().Split();
int bx = int.Parse(s[0]), by = int.Parse(s[1]), bz = int.Parse(s[2]);

double r = Math.Sqrt((ax-bx)*(ax-bx) + (ay-by)*(ay-by) + (az-bz)*(az-bz));
Console.WriteLine($"рассточние между точками равно {r}");
*/


/*
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
    3 -> 1, 8, 27
    5 -> 1, 8, 27, 64, 125
*/

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());

for(int i=1; i<=N; i++)
    Console.Write(i*i*i + " ");





