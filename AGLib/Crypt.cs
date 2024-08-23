class Crypt // Classe Crypt
{
    private string concatText = "";
    
    public Crypt(string text, int key, long[] CI, char[] alphabet) // Construtor, realiza a conversão, parametros: text, key, e array do CI
    {
        long[] cryptedIndex = CI; // Variavel Array, armazena o alfabeto encriptado, letra por letra
        string[] convertedText = new string[text.Length]; // Variavel Array, responsavel por guardar cada letra
        for (int j = 0; j < text.Length; j++) // Loop, Tamanho do texto Input, Parametro da Classe/Construtor
        {            
            char[] c; // Variavel Array, guarda cada letra do text (Input)
            text = text.ToLower(); // Deixa text em minusculo
            c = text.ToCharArray(); // Separa text em index, da variavel Array: char[]
            for (int i = 0; i < alphabet.Length; i++) // Loop, Verifica as letras do text de acordo com o alfabeto
            {
                if (c[j] == alphabet[i]) // Condicional
                {
                    long bin = cryptedIndex[i] * key; // Cria o codigo de acordo com cryptedIndex X key
                    convertedText[j] = bin.ToString(); // Transforma os resultados (cada letra, ja convertida) em uma string Array
                }
            }
        }
        for (int i = 0; i < convertedText.Length; i++) // Loop, Concatena o array
        {
            concatText = concatText + convertedText[i] + "-";
        }
    }
    public string returnValCrypt()
    {
        return this.concatText.ToString();
    }
}
class DesCrypt // Classe DesCrypt
{
    private List<string> ret = new List<string>();
    public DesCrypt(string text, int key, long[] CI, char[] alphabet)
    {
        text = text.Trim('-'); // Remover os delimitadores iniciais e finais
        string[] splited = text.Split('-'); // Dividir a string usando o caractere '-'

        foreach (string s in splited)
        {
            if (s != "")
            {
                if (int.TryParse(s, out int sI))
                {
                    sI /= key;
                    int index = Array.IndexOf(CI, sI); // Encontrar o índice no array CI

                    if (index != -1) // Verificar se o valor existe em CI
                    {
                        ret.Add(alphabet[index].ToString());
                    }
                }
            }
            else
            {
                ret.Add(" ");
            }
        }
    }
    public string returnValDesCrypt()
    {
        string desText = "";
        foreach (string s in ret)
        {
            desText += s;
        }
        return desText;
    }
}
