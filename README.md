# AGCrypt v1.1

### Bem vindo ao meu script, intruções da criptografia AGCrypt:

-O programa é simples: ao chamar o metodo EnCrypt, voce deve dar a ele os parametros de text e key, text: texto que você deseja encriptar (Somente texto), key: chave de 
acesso/Multiplicador do alfabeto cryptedIndexGB (Somente numeros inteiros). O metodo DesCrypt age de forma parecida, porém ele tranforma a criptografia em texto legivel, ele recebe disText e disKey, disText: 
texto encriptado ex: 212-2123-43, disKey: recebe a chave usada no EnCrypt (Caso a key ou o cryptedIndexGB sejam diferentes dos originais, o texto não será descriptado)

-cryptedIndexGB: (No Program.cs) é um array que guarda 47 numeros aleatorios, cada numero equivale a uma letra do alfabeto 
QWERT, numeros e caracteres especias, ex: primeiro numero = a segundo numero = b...

-key: multiplica o array cryptedIndexGB, fazendo com que alem do "alfabeto" cryptedIndexGB você precise de também uma chave para ter acesso ao texto encriptado

Copyright (c) 2024 marcsVDev, CC0 1.0 Universal

# AGLib v1.0 

## Test

-Você pode baixar a biblioteca pelo arquivo .dll

-A Biblioteca usa do AGCrypt, onde você pode implementar em seus programas .dotnet C#



