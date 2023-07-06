// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


Console.WriteLine("2 задача");
void Task2()
{
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
if (a>=b)
{
    Console.WriteLine(a + " - наибольшее число, " + b + " - наименьшее число");
}
else
{
    Console.WriteLine(b + " - наибольшее число, " + a + " - наименьшее число");
}
}
Task2();




Console.WriteLine("4 задача");
void Task4()
{
 int c = Convert.ToInt32(Console.ReadLine());
 int d = Convert.ToInt32(Console.ReadLine());
 int i = Convert.ToInt32(Console.ReadLine());
 int max = c;
 if(max >= d)
 {
    if (max >= i)
    {
        Console.WriteLine(max + " - максимальное число");
    }
    else
    {
        Console.WriteLine(i + " - максимальное число");
    }
 }
 else if (d >= i)
 {
    Console.WriteLine(d + " - максимальное число");
 }
 else if (i > d)
 {
    Console.WriteLine(i + " - максимальное число");
 }
}
Task4();


Console.WriteLine("6 задача");
void Task6()
{
int f = Convert.ToInt32(Console.ReadLine());
if(f % 2 == 0)
{
    Console.WriteLine("да");
}    
else
{
    Console.WriteLine("нет");
}
}
Task6();




Console.WriteLine("8 задача");
void Task8()
{
int N = Convert.ToInt32(Console.ReadLine());
int S = 0;
while (S <= N)
{
    if (S % 2 == 0)
    {
        Console.WriteLine(S);
    }
S++;
} 
}
Task8();
