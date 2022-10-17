
Console.WriteLine ("Введите 2 числа");
string numberA = Console.ReadLine();
string numberB = Console.ReadLine();
int numberAA = int.Parse(numberA);
int numberBB = int.Parse(numberB);
int result = numberBB * numberBB;
if(result == numberAA)
{
    Console.WriteLine("yes");
}
else
{
    Console.WriteLine("no");
}



 // На вход два числа, проверка второе это квадрат первого?
