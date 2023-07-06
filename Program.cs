/*задача 2
Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    Console.Write("максимальнное число " + a);
}
else
{
    Console.Write("максимальное число " + b);
}


//Задача 4
Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());

if (a > b && a > c)
{
    Console.Write("максимальнное число " + a);
}
if (b > a && b > c)
{
    Console.Write("максимальное число " + b);
}
if (c > b && c > a)
{
    Console.Write("максимальнное число " + c);
} 
*/
//задача 6
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 0 && number % 2 == 0)

{
    Console.Write("число " + number + " является четным ");
}
else
{
    Console.WriteLine("число " + number + " не является четным ");
}