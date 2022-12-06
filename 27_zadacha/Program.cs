// SeЗадача 27: Напишите программу, которая принимает 
//на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
Console.Clear();
Console.Write("Введите число a: ");
string a = String(Console.ReadLine());
int size = a.Length;
int sum = 0;
for (int i = 0; i < size; i++) sum += i;
return sum;