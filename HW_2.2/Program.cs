Console.WriteLine("Enter any integer number");
int num = int.Parse(Console.ReadLine());

if (num < 0)
{
    num = -num;
}

string numStr = num.ToString();
int numLen = numStr.Length;

if (numLen >= 3)
{
    int resTemp = num % (Convert.ToInt32(Math.Pow(10,numLen - 2)));
    int res = resTemp / (Convert.ToInt32(Math.Pow(10,numLen - 3)));
    Console.WriteLine(res);
}
else
{
    Console.WriteLine("Third digit does not exist");
}