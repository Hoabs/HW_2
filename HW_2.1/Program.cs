Console.WriteLine("Anter a three-digit number");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 0)
{
    num = -num;
}
int res = (num % 100) / 10;
Console.WriteLine(res);
