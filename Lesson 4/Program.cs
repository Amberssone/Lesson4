// Exercice nr.1

int a, b, sum = 0;

    Console.WriteLine("Enter the fist number ");
    a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the second number ");
    b = Convert.ToInt32(Console.ReadLine());

  if (a<b){

    for (int x = a+1; x < b; x++)
    {

        sum += x * x;

    }
     Console.WriteLine(sum);
  }
    else{
        Console.WriteLine("Wrong input!");
    }
    Console.ReadLine();

// Exercice nr.2

namespace Program
{
class Program
{
    static void Main(string[] args)
    {
        int num, sum = 0, r;
        Console.WriteLine("Enter a Number : ");
        num = int.Parse(Console.ReadLine());
        while (num != 0)
        {
            r = num % 10;
            num = num / 10;
            sum = sum + r;
        }
        Console.WriteLine("Sum of Digits of the Number : "+sum);
        Console.ReadLine();

    }
}
}

// Exercise nr.3

static void Print1(string[] toPrint)
{
    foreach(string s in toPrint)
    {
        Console.Write(s);
    }
}

static void Print2(string[] toPrint)
{
    toPrint.ToList().ForEach(Console.Write);
}

static void Print3(string[] toPrint)
{
    Console.WriteLine(string.Join("", toPrint));
}

static void Print4(string[] toPrint)
{
    Array.ForEach(toPrint, Console.Write);
}
