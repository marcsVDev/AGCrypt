using System;

class Program
{
    private static int[] cryptedIndexGB = {31,41,59,26,53,58,97,93,23,84,62,64,33,83,27,95,02,88,42,99,17,91,9,37,51,05,82,09,74,94,45,92,30,78,16,40,63,86,20,89,90,66,80,34,81,54,43,11,70}; // Padrão: baseado no Pi, com algumas alterações

    static void Main(string[] args)
    {
        int key = 23134;
        Console.WriteLine("En or Des: e or d");
        string mssg = Console.ReadLine()+"";
        if(mssg == "e"){EnCrypt(Console.ReadLine()+"",key);}else if(mssg == "d"){DesCrypt(Console.ReadLine()+"",key);}else{Console.WriteLine("Closing...");} 
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