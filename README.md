# AGCrypt

## Informação Gerais:

O AGCrypt é uma criptografia que usa dois alfabetos, um alfabeto numérico, o cryptedIndex (CI) e um alfabeto comum, o alphabet, onde o Indice das matrizes dos dois alfabetos são equivalentes, valor numerico (CI + Index) que é dado ao alphabet. Além dos dois alfabetos temos a key, que também é um numero, no caso a key multiplica o valor do indice da matriz do CI por ela mesma. As letras já criptografadas são separadas por "-".
Ex: a = 32 * key; b = 33 * key, e assim por diante __(Obs: quanto maior a key maior a segurança da criptografia, isto vale também ao CI. Lembrando que a key possui valor inteiro e não pode passar de seus 32 bits)__

Por padrão o AGCrypt vem com o alphabet: 

> 'a' 'b' 'c' 'd' 'e' 'f' 'g' 'h' 'i' 'j' 'k' 'l' 'm' 'n' 'o' 'p' 'q' 'r' 's' 't' 'u' 'v' 'w' 'x' 'y' 'z' ' ' '!' '.' '*' '-' '_' '+' '?' '@' '$' ' ' '/' '1' '2' '3' '4' '5' '6' '7' '8' '9' '0'
 

e o CI: 

> 31, 41, 59, 26, 53, 58, 97, 93, 23, 84, 62, 64, 33, 83, 27, 95, 02, 88, 42, 99, 17, 91, 09, 37, 51, 05, 82, 11, 74, 94, 45, 92, 30, 78, 16, 40, 63, 86, 20, 89, 90, 66, 80, 34, 81, 54, 43, 12

## Metodos da classe MainCall:

O AGCrypt tem três Metodos Principais, sendo eles:

- EnCrypt -> Reponsavel por criptografar um texto, recebe dois parametros: string text e int key, sendo o texto que deseja criptografar e a key que deseja utilizar. Retorna o valor criptografado.
  
- DesCrypt -> Reponsavel por descriptografar um texto criptografado, recebe dois parametros: string disText e int disKey, sendo o texto que deseja descriptografar e a chave correta para descriptografa-lo. Retorna o valor descriptografado.
  
- ModyACI -> Responsavel por mudar o alphabet e o CI, recebe dois parametros: char[] alpha (matriz de caracteres) long[] CI (matriz de longs), sendo a matriz de caracteres que será utilizado como alphabet e o CI que será o codificador do alphabet. Retorna o status do metodo. __(Obs: As letras e numeros das matrizes não podem ser iguais e nem haver uma matriz maior que a outra, caso aconteça o retorno de ModyACI indicará o local do erro!)__

## Função do .json no projeto

O .json é usado para troca de dados entre as aplicações, que utiliza de tags para realizar a leitura.

No AGCrypt você pode utilizar de um aruivo .json para salvar o CI e o Alphabet, pega-lo e utiliza-lo em seu projeto.

### Metodos da classe MainJson:

- SetJsonData -> Reponsalvel pro alterar o arquivo .json, recebe dois parametros:  char[] alphabet e long[] CI, que serão escritos no arquivo que será criado .json
- GetJsonData -> Responsvel por obter o arquivo .json, e pegar sua informações, ele retorna dois valores Tuple char[] e long[], que podem ser obtidos desta forma:
```C#
var mainJson = new MainJson();
Tuple<char[], long[]> arraysACI = mainJson.GetJsonData();
char[] alphabet = arraysACI.Item1;
long[] CI = arraysACI.Item2;
```
__(Obs: caso o retorno de GetJsonData seja "010" e "º", saiba que o metodo não conseguiu pegar o alphabet e/ou o Ci no arquivo .json!)__

### Outros:

- Você pode alterar o caminho do arquivo e nome do arquivo .json, mudando na variavel jsonPath, que por padrão será criada no diretório atual com nome AGCrypt.json
- Ao instanciar MainCall com false, você fará com que um metodo pegue as informações do arquivo .json, você pode obter o retorno desta ação que será feita pelo ModyACI na string returnCJTACI
  
# AGLib

## Informações Gerais:

A AGLib é a biblioteca do AGCrypt, que você pode implementar em seu projeto (C#):
-  Você pode baixar a biblioteca pelo Nuget:
- Como baixar [AQUI](https://github.com/marcsVDev/AGCrypt?tab=readme-ov-file#como-baixar)
- Você deve instaciar a classe MainCall para ter acesso aos metodos do AGCrypt


Acessar a biblioteca AGLib pelo namespace AGCrypt:
 ```C#
using AGCrypt;
```
Instacia a classe principal MainCall, recebe true ou false, sendo true para trabalhar __sem arquivo .json__, e false para trabalhar __com arquivo .json__:
```C#
var MC = new MainCall(true);
```
Exemplo de Alphabet e CI:
```C#
long[] newCryptedIndexGB = new long[] { 31, 41, 59, 26, 53, 58, 97, 93, 23, 84, 62, 64, 33, 83, 27, 95, 02, 88, 42, 99, 17, 91, 09, 37, 51, 05, 82, 11, 74, 94, 45, 92, 30, 78, 16, 40, 63, 86, 20, 89, 90, 66, 80, 34, 81, 54, 43, 12};
        
char[] newAlphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', ' ', '!', '.', '*', '-', '_', '+', '?', '@', '$', ',', '/', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
```
Modifica os alfabetos pelo Metodos ModyACI e guarda seu retorno em uma string:
```C#
string MCCheck = MC.ModyACI(newAlphabet,newCryptedIndexGB);
```
Exibe status da modificação: 
```C#
Console.WriteLine(MCCheck);
```
Chama e exibi retorno do metodo EnCrypt, utilizando a chave 32. Depois chama e exibe o retorno do metodo DesCrypt que o descriptografa logo após o EnCrypt:
```C#
string encrypted = MC.EnCrypt("abcdefghijklmnopqrstuvwxyz !.*-_+?@$,/1234567890", 32);
Console.WriteLine(encrypted);

string descrypted = MC.DesCrypt(encrypted, key);
Console.WriteLine(descrypted);
```

# Como Baixar?

## 1:

- Faça o Download com:
  > dotnet add package AGLib-v1.0 --version 1.0.0

## 2:

- Abra o Visual Studio e abra o projeto que deseja implementar o AGLib

- Selecione o Projeto > Gerenciar pacotes Nuget, e pesquise por AGLib

# Créditos:

Créditos sempre são bem vindo! Você pode adicionar [a logo do AGCrypt](https://github.com/marcsVDev/AGCrypt/blob/main/agcrypt.png) em seu projeto.

*Copyright (c) 2024 marcsVDev, CC0 1.0 Universal*
