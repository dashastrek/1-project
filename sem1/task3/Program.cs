//Напишите программу, которая будет выдавать название дня недели по заданному номеру.
//3 -> Среда
//5 -> Пятница
Console.WriteLine ("Write a number");
string daynumber = Console.ReadLine();
int ddnumber = int.Parse (daynumber);
if(ddnumber == 1) Console.WriteLine ("пн");
if(ddnumber == 2) Console.WriteLine ("вт");
if(ddnumber == 3) Console.WriteLine ("ср");
if(ddnumber == 4) Console.WriteLine ("чт");
if(ddnumber == 5) Console.WriteLine ("пт");
if(ddnumber == 6) Console.WriteLine ("сб");
if(ddnumber == 7) Console.WriteLine ("вск");