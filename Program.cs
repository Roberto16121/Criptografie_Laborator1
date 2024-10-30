using Cripto_01;
using Cripto_01.BaseClasses;

class Program
{
    static void Main()
    {
        Console.WriteLine("Introduceti textul : ");

        string plainText = "THISMESSAGEISNOTSECURE";
        //string plainText = Console.ReadLine();

        Console.WriteLine("Introduceti cheia : ");

        string key = "CIFRU";
        //string key = Console.ReadLine();

        Console.WriteLine("\nCifrul Vigenere \n");
        CifruVigenere vigenere = new CifruVigenere(plainText, 26, key);
        vigenere.Print();

        Console.WriteLine("\nCifrul lui Cezar \n");
        CifrulCezar cezar = new CifrulCezar(plainText);
        cezar.Print();

        Console.WriteLine("\nCifrul ROT13 \n");
        Rot13 rot13 = new Rot13(plainText);
        rot13.Print();

    }
}



