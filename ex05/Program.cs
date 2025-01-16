// Calcular que recebe 2 números e apresenta + - * / 

Console.Write("Informe o 1° número:");
double num1 = double.Parse(Console.ReadLine());

Console.Write("Informe o 2° número:");
double num2 = double.Parse(Console.ReadLine());

Console.Clear();
Console.WriteLine("Soma : " + (num1 + num2));
Console.WriteLine("Subtração : " + (num1 - num2));
Console.WriteLine("Multiplicação : " +  (num1 * num2));

if (num2 != 0)
{
    Console.WriteLine("Divisão : " + (num1 / num2));
}
else
{
    Console.WriteLine("Divisão por ZERO não permitida.");
}


  


