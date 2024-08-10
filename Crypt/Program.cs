using System;

class Program
{
    private static int[] cryptedIndexGB = {31,42,59,26,53,58,98,94,23,84,62,64,33,83,27,95,02,88,41,97,16,93,99,37,51};

    static void Main(string[] args)
    {
        double a = Math.PI;
        Console.WriteLine(a);
        DesCrypt(Console.ReadLine()+"",821691);
    }
    private static void EnCrypt(string text, int key)
    {
        Crypt crypt = new Crypt(text, key, cryptedIndexGB); // Instacia a classe Crypt, e o objeto recebe os parametros key e text
        Console.WriteLine(crypt.concatText.ToString());
    } private static void DesCrypt(string disText, int disKey)
    {
        DesCrypt descrypt = new DesCrypt(disText, disKey,cryptedIndexGB); // Instacia a classe DesCrypt, e o objeto recebe os parametros key e text
        foreach(string s in descrypt.ret)
        {
            Console.Write(s);
        }
    }
}