using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionTutorial
{
class HelloException
{
public static void Main(string[] args)
{
Console.WriteLine("Первое");
int value = 10 / 2;
Console.WriteLine("Второе");
value = 10 / 1;
Console.WriteLine("Третье");
int d = 0;

value = 10 / d;
Console.WriteLine("Результат");

Console.Read();
}
}
}