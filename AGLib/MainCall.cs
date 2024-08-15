﻿namespace AGCrypt
{
    public static class MainCall
    {
        private static int[] cryptedIndexGB = new int[] { 31, 41, 59, 26, 53, 58, 97, 93, 23, 84, 62, 64, 33, 83, 27, 95, 02, 88, 42, 99, 17, 91, 9, 37, 51, 05, 82, 09, 74, 94, 45, 92, 30, 78, 16, 40, 63, 86, 20, 89, 90, 66, 80, 34, 81, 54, 43, 11, 70 }; // Padrão: baseado no Pi, com algumas alterações
        private static char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', ' ', '!', '.', '*', '-', '_', '+', '?', '@', '$', ',', '/', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' }; // Variavel Array, armazena o alfabeto QWERT, numeros e caracteres
        public static string EnCrypt(string text, int key)
        {
            Crypt crypt = new Crypt(text, key, cryptedIndexGB, alphabet); // Instacia a classe Crypt, e o objeto recebe os parametros key e text
            return crypt.returnValCrypt();
        }
        public static string DesCrypt(string disText, int disKey)
        {
            DesCrypt descrypt = new DesCrypt(disText, disKey, cryptedIndexGB, alphabet); // Instacia a classe DesCrypt, e o objeto recebe os parametros key e text
            return descrypt.returnValDesCrypt();
        }
    }
}