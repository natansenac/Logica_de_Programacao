// Ex28 - Criar e Imprimir um Array

// int a = 10;
// int b = 20;
// int c = 30;
// int d = 40;
// int e = 50;

using System;

Console.WriteLine($"Os números são {a}, {b}, {c}, {d}, e {e}");

int[] numeros = { 10, 20, 30, 40, 50 };

Console.WriteLine(numeros[0]);
Console.WriteLine(numeros[1]);
Console.WriteLine(numeros[2]);
Console.WriteLine(numeros[3]);
Console.WriteLine(numeros[4]);

for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($" Na posição {i} o número é {numeros[i]}");
}

string[] nome = { "Ana", "Pedro", "Joana", "Paulo" };
Console.WriteLine(nome[0]);
Console.WriteLine(nome[1]);
Console.WriteLine(nome[2]);
Console.WriteLine(nome[3]);
Console.WriteLine(nome[4]);
for (int i = 0;i < nome.Length; i++)
{
    Console.WriteLine($"O nome na posição {i} é {nome [i]}");
}
