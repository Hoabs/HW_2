Console.WriteLine("Enter any integer number");
int num = int.Parse(Console.ReadLine());
int numCorrect = num;

if (numCorrect < 0)
{
    numCorrect = -numCorrect;
}

string numStr = numCorrect.ToString();
int numLen = numStr.Length;

if (numLen >= 3)
{
    int resTemp = numCorrect % (Convert.ToInt32(Math.Pow(10,numLen - 2)));
    int res = resTemp / (Convert.ToInt32(Math.Pow(10,numLen - 3)));
    Console.WriteLine(res);
}
else
{
    Console.WriteLine("Third digit does not exist");
}