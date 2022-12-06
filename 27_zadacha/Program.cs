// SeЗадача 27: Напишите программу, которая принимает 
//на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
Console.Clear();
Console.Write("Введите число: ");
string number = Console.ReadLine();
int sum = 0;
int size = number.Length;

for (int i = 0; i < size; i++) sum += number[i];

Console.WriteLine(sum);