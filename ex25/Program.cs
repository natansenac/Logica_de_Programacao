﻿//Ex25: Implemente um programa que permita ao usuário inserir números inteiros. O programa deve continuar solicitando números até que o usuário digite 0. 

// Ao final, quando 0 for digitado, o programa deve calcular e exibir a soma de todos os números inseridos (exceto o 0).

int soma = 0;
for (int numero = -1; numero !=0; //Inicializr com um valor diferente de 0
    {
    Console.Write("Digite um número (0 para sair): ");
    numero = Convert.ToInt32(Console.ReadLine()); // Lê o número digitado

    if (numero !=0) // Add  a soma apenas se o valor diferente de zero
    {
        soma += numero; // add o numero a soma
   }
Console.WriteLine("Soma total:" + soma);
}
