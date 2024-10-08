﻿using System.Runtime.InteropServices;
using System.Text.Json;
class DataJson
{
    public long[]? CI { get; set; }
    public char[]? Alphabet { get; set; }

}

namespace AGCrypt
{
    public class MainCall
    {
        public string returnCJTACI = "";
        private long[] cryptedIndexGB = new long[] { 31, 41, 59, 26, 53, 58, 97, 93, 23, 84, 62, 64, 33, 83, 27, 95, 02, 88, 42, 99, 17, 91, 09, 37, 51, 05, 82, 11, 74, 94, 45, 92, 30, 78, 16, 40, 63, 86, 20, 89, 90, 66, 80, 34, 81, 54, 43, 12 }; // Padrão: baseado no Pi, com algumas alterações
        private char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', ' ', '!', '.', '*', '-', '_', '+', '?', '@', '$', ',', '/', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' }; // Variavel Array, armazena o alfabeto QWERT, numeros e caracteres
        public MainCall(bool jsonSetACI)
        {
            if (jsonSetACI)
                return;
            ConvertJsonToACI();
        }
        private void ConvertJsonToACI()
        {
            var mainJson = new MainJson();
            Tuple<char[], long[]> arraysACI = mainJson.GetJsonData();
            string retMody = ModyACI(arraysACI.Item1,arraysACI.Item2);
            returnCJTACI = retMody;
        }
        public string EnCrypt(string text, int key)
        {
            Crypt crypt = new Crypt(text, key, cryptedIndexGB, alphabet); // Instacia a classe Crypt, e o objeto recebe os parametros key e text
            return crypt.returnValCrypt();
        }
        public string DesCrypt(string disText, int disKey)
        {
            DesCrypt descrypt = new DesCrypt(disText, disKey, cryptedIndexGB, alphabet); // Instacia a classe DesCrypt, e o objeto recebe os parametros key e text
            return descrypt.returnValDesCrypt();
        }
        public string ModyACI(char[] alpha, long[] CI)
        {
            return alpha.Length != CI.Length ? "The Lenght of the arrays is different!" : verify();
            string verify()
            {
                for (int i = 0; i < alpha.Length; i++)
                {
                    for (int j = 0; j < alpha.Length; j++)
                    {
                        if (alpha[i].ToString() != alpha[j].ToString() && CI[i] != CI[j] || j == i)
                        {
                            continue;
                        }
                        else
                        {
                            return $"This {alpha[i].ToString()} and {alpha[j].ToString()} or {CI[i]} and {CI[j]} is equal!";
                        }
                    }
                }
                cryptedIndexGB = CI;
                alphabet = alpha;
                return "Seted!";
            }
        }
    }
    public class MainJson
    {
        public string jsonPath = "AGCrypt.json";
        public void SetJsonData(char[] alphabet, long[] CI)
        {
            DataJson dataJson = new DataJson
            {
                CI = CI,
                Alphabet = alphabet,
            };
            string jsonString = JsonSerializer.Serialize(dataJson);
            File.WriteAllText(jsonPath, jsonString);
        }
        public Tuple<char[], long[]> GetJsonData()
        {
            string jsonContent = File.ReadAllText(jsonPath);

            DataJson? deserializeJson = JsonSerializer.Deserialize<DataJson>(jsonContent);
            if (deserializeJson?.Alphabet != null && deserializeJson.CI != null)
            {
                return new Tuple<char[], long[]>(deserializeJson.Alphabet, deserializeJson.CI);
            }
            char[] charR = new char[] { 'º' };
            long[] intR = new long[] { 010 };
            return new Tuple<char[], long[]>(charR, intR);
        }
    }
}