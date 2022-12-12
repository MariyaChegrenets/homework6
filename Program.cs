// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// Точки для уравнений пользователь вводит с клавиатуры, можно через несколько ReadLine
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223 -> 4
// Вводим сразу все числа в одну линию, не через бесконечное кол-во ReadLine.

Console.Write("Выберите задачу: ");
int n = Convert.ToInt32(Console.ReadLine());
if(n == 1)
    Task43();
else if(n == 2)
    Task41();

void Task43() // ( 1 )
{
Console.Write("input k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("input b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("input k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("input b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("[{0}; {1}]",SearchX(k1,b1,k2,b2),SearchY(k1,b1,k2,b2));
}

double SearchX(double k1, double b1, double k2, double b2)
{
    double x = (b2-b1)/(k1-k2);
    return x;
}

double SearchY(double k1, double b1, double k2, double b2)
{
    double y = ((b2-b1)/(k1-k2))*k2+b2;
    return y;
}

void Task41()  // ( 2 )
{
Console.WriteLine("Enter numbers with commas");
int[] array = Console.ReadLine().Split(',').Select(x => int.Parse(x)).ToArray();
Console.WriteLine(CountPositive(array));
}

int CountPositive(int[] array)
{
    int count =0;
    for(int i=0; i<array.Length; i++)
    {
        if(array[i] > 0)
            count++;
    }
    return count;
}