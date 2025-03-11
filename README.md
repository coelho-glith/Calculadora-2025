# Calculadora 2025

### Introdução 
---
! [https://i.imgur.com/qWcv675.gif]

Calculadora simplificada mas eficiente

## Funcionalidades
---
- Operações Básicas: Soma, Mutiplicação, subtração e Divisão com rapidez.
- Suporte a Decimais: Aparece duas casas decimais.
- Validação de Entrada: eficiente para não dar erro na calculadora
- Tratamento de Divisão por Zero: calculadora capaz de mostrar os erros de divisão por zero.
- Tabuada: mostra a tabuada do número selecionado até o 10.
- Histórico de Operações:A calculadora é capaz de armazenar um histórico de operações até 100.

Como utilizar
---
1. Clone o repositório ou baixe o código fonte.
2. Abra o terminal ou o prompt de comando e navegue até a pasta raiz
3. Utilize o comando abaixo para restaurar as dependências do projeto.
```
dotnet restore
```
4. Em seguida, compile a solução utilizando o comando:
```
dotnet build --configuration Release
```
5.Para executar o projeto compilando em tempo real
```
dotnet run --project Calculadora.ConsoleApp
```
6.Para executar o arquivo compilado, navegue até a pasta ./Calculadora.ConsoleApp/bin/Release/net8.0/ e execute o arquivo:
```
Calculdora.ConsoleApp.exe
```

## Requisitos
---
- .NET SDK (recomendado .NET 8.0 ou superior) para compilação e execução do projeto.