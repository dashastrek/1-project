Console.WriteLine ("Введите число");
string usernumber = Console.ReadLine();
int x = int.Parse (usernumber);
if(x >= 100 && x <= 999 )
{
    int result = x % 10;
    Console.WriteLine($"Last number {result}");
}
else
{
    Console.WriteLine("Need other number");
}
