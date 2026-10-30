using System;
using System.Security.Cryptography;

class SecureRandomGenerator
{
    public static byte[] GenerateRndBytes(int length)
    {
        var rnd = RandomNumberGenerator.Create();
        byte[] random = new byte[length];
        rnd.GetBytes(random);
        return random;
    }

    static void Main()
    {
        for (int i = 1; i <= 3; i++)
        {
            string randomNumber = Convert.ToBase64String(
                SecureRandomGenerator.GenerateRndBytes(32));

            Console.WriteLine($"Попытка {i}: {randomNumber}");
        }
    }
}