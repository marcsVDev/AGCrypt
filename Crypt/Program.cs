using System;

class Program
{
    private static int[] cryptedIndexGB = { 98, 30, 69, 17, 13, 21, 56, 36, 78, 50, 37, 92, 26, 8, 94, 7, 88, 93, 22, 43, 14, 63, 74, 91, 18, 51 };
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