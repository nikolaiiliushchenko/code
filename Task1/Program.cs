using System;

Random random1 = new Random(1234);
Console.WriteLine("Одинаковый seed (1234) - попытка 1:");
for (int i = 0; i < 5; i++)
{
    Console.Write(random1.Next(1, 101) + " ");
}

Random random2 = new Random(1234);
Console.WriteLine("\nОдинаковый seed (1234) - попытка 2:");
for (int i = 0; i < 5; i++)
{
    Console.Write(random2.Next(1, 101) + " ");
}

Random random3 = new Random(5555);
Console.WriteLine("\nРазный seed (5555):");
for (int i = 0; i < 5; i++)
{
    Console.Write(random3.Next(1, 101) + " ");
}
Console.WriteLine();