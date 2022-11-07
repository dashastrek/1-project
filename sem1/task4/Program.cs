 //Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
//4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
//2 -> " -2, -1, 0, 1, 2"
Console.WriteLine ("Write a number");
string usernumber = Console.ReadLine ();
int N = int.Parse (usernumber);
for (int i = -N; i < N; i++)
{
    Console.Write($"{i}, ");
}
