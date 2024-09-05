using System.Collections;

//Utilizando a Lista Simples
ArrayList arrlist = new();
arrlist.Add(5);
arrlist.Add("Wesley");
//E possivel adicionar um conjunto 
//de valores de uma so vez
arrlist.AddRange(new int []{1,2,3});
// o metodo .Add() insere o valor
//ao final do vetor
arrlist.Insert(1, 15);
//Já o metodo insert, me permite
//incluir o valor desejado na posição
//especificada no primeiro parametro;

//Lendo valores da lista 
object primeiro = arrlist[0]!;
int quarto = (int)arrlist[3]!;

//percorrendo a lista com foreach
foreach (object obj in arrlist)
{
    Console.Write($" | {obj}");
}

// obtendo tamanho total da lista
//quantos Elementos tem
int tamanho = arrlist.Count;
//obter a capacidade 
//quantos poder ser armazenados
int capacidade = arrlist.Capacity;

//percorrendo no modo classico
for(int i = 0; i < arrlist.Count; i++)
{
    Console.Write($"| {arrlist[i]}");
}

//recursos importates da lista
//verificar se um valor e contido na lista
bool contemNome  = arrlist.Contains("Wesley");
if(!contemNome)
    Console.WriteLine("Nome Wesley nao econtrado");

//Para saber o indice que contem o valor buscado
//Neste caso se o valor existir na lista
//ele retorna o indice(numero inteiro)
//Caso o calor nao exista na lista, retorna -1
int indiceDoValor = arrlist.IndexOf("Wesley");
if(indiceDoValor >= 0)
    Console.WriteLine($"Wesley esta em[{indiceDoValor}]");
else
    Console.WriteLine("E,realemente nao tem");

//e possivel tambem remover itens da lista
arrlist.Remove("Wesley"); //remove pelo valor
arrlist.RemoveAt(4);//remove o indice
arrlist.RemoveRange (0,2);
//o primeiro parametro e o indice
// e o segundo e quantas casas apos o indice

