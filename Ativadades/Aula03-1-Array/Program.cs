﻿// Array Unidimensional
int[] numbers;
numbers = new int[5];

//Atribuição de valor direita
//ao indice do vetor
numbers[0] = 1;
numbers[1] = 2;
numbers[2] = 3;
numbers[3] = 4;
numbers[4] = 5;

//Declaração Inicializado
string[] names = 
{ "Eu", "Tu", "Ele","Nós","Vós","Eles"};

//Exemplo Vetor com os nomes dos meses
string[] mounths = new string[12];
for (int i = 1; i <= 12; i++)
{
     DateTime firstDay =
        new DateTime(
        DateTime.Now.Year, i, 1
      );
    String name =
    firstDay.ToString("MMMM");
    mounths [i-1] = name;
}

foreach (string m in mounths)
{
    Console.WriteLine(m);
}