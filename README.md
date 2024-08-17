# AGCrypt

## Informação Gerais:

O AGCrypt é uma criptografia que usa dois alfabetos, um alfabeto numérico, o cryptedIndex (CI) e um alfabeto comum, o alphabet, onde o Indice das matrizes dos dois alfabetos são equivalentes, valor numerico (CI + Index) que é dado ao alphabet. Além dos dois alfabetos temos a key, que também é um numero, no caso a key multiplica o valor do indice da matriz do CI por ela mesma. As letras já criptografadas são separadas por "-".
Ex: a = 32 * key; b = 33 * key, e assim por diante __(Obs: quanto maior a key maior a segurança da criptografia, isto vale também ao CI. Lembrando que são valores inteiros e não podem passar de seus 32 bits)__

Por padrão o AGCrypt vem com o alphabet: 

> 'a' 'b' 'c' 'd' 'e' 'f' 'g' 'h' 'i' 'j' 'k' 'l' 'm' 'n' 'o' 'p' 'q' 'r' 's' 't' 'u' 'v' 'w' 'x' 'y' 'z' ' ' '!' '.' '*' '-' '_' '+' '?' '@' '$' ' ' '/' '1' '2' '3' '4' '5' '6' '7' '8' '9' '0'
 

e o CI: 

> 31, 41, 59, 26, 53, 58, 97, 93, 23, 84, 62, 64, 33, 83, 27, 95, 02, 88, 42, 99, 17, 91, 09, 37, 51, 05, 82, 11, 74, 94, 45, 92, 30, 78, 16, 40, 63, 86, 20, 89, 90, 66, 80, 34, 81, 54, 43, 12

## Metodos:

O AGCrypt tem três Metodos Principais, sendo eles:

- EnCrypt -> Reponsavel por criptografar um texto, recebe dois parametros: string text e int key, sendo o texto que deseja criptografar e a key que deseja utilizar. Retorna o valor criptografado.
  
- DesCrypt -> Reponsavel por descriptografar um texto criptografado, recebe dois parametros: string disText e int disKey, sendo o texto que deseja descriptografar e a chave correta para descriptografa-lo. Retorna o valor descriptografado.
  
- ModyACI -> Responsavel por mudar o alphabet e o CI, recebe dois parametros: char[] alpha (matriz de caracteres) int[] CI (matriz de inteiros), sendo a matriz de caracteres que será utilizado como alphabet e o CI que será o codificador do alphabet. Retorna o status do metodo. __(Obs: As letras e numeros das matrizes não podem ser iguais e nem haver uma matriz maior que a outra, caso aconteça o retorno de ModyACI indicará o local do erro!)__

# AGLib

## Informações Gerais:

A AGLib é a biblioteca do AGCrypt, que você pode implementar em seu projeto (C#):
-  Você pode baixar a biblioteca pelo arquivo .dll:
> [Download](https://github.com/marcsVDev/AGCrypt/blob/main/AGLib.dll) da Biblioteca AGLib
- Como baixar [AQUI](https://github.com/marcsVDev/AGCrypt?tab=readme-ov-file#como-baixar)
- Você deve instaciar a classe MainCall para ter acesso aos metodos do AGCrypt

## Exemplo:
```C#
using AGCrypt;

class ProgramTest
{
    static void Main(string[] args)
    {
        // Instacia Maincall

        var MC = new MainCall();

        // Key

        int key = 32;
        
        // Novos arrays

        int[] newCryptedIndexGB = new int[] { 31, 41, 59, 26, 53, 58, 97, 93, 23, 84, 62, 64, 33, 83, 27, 95, 02, 88, 42, 99, 17, 91, 09, 37, 51, 05, 82, 11, 74, 94, 45, 92, 30, 78, 16, 40, 63, 86, 20, 89, 90, 66, 80, 34, 81, 54, 43, 12};
        
        char[] newAlphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', ' ', '!', '.', '*', '-', '_', '+', '?', '@', '$', ',', '/', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };

        // Modifica os arrays pelo metodo ModyACI

        string MCCheck = MC.ModyACI(newAlphabet,newCryptedIndexGB);

        // Verifica status da modificação

        Console.WriteLine(MCCheck);

        // EnCrypt 

        string encrypted = MC.EnCrypt("abcdefghijklmnopqrstuvwxyz !.*-_+?@$,/1234567890", key);
        Console.WriteLine(encrypted);

        // DesCrypt

        string descrypted = MC.DesCrypt(encrypted, key);
        Console.WriteLine(descrypted);
    }
}

```
# Como Baixar?
- Faça o Download em [AGLib](https://github.com/marcsVDev/AGCrypt?tab=readme-ov-file#aglib)

- Abra o Visual Studio e abra o projeto que deseja implementar o AGLib

- Na parte superior do projeto: Projeto > Adicionar Referência > Procurar, selecione o arquivo .dll e aperte OK

Créditos sempre são bem vindo! Você pode adicionar [a logo do AGCrypt](https://github.com/marcsVDev/AGCrypt/blob/main/agcrypt.png) em seu projeto.

*Copyright (c) 2024 marcsVDev, CC0 1.0 Universal*



