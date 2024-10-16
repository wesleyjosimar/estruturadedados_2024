using DobbleSort;
int[] inteiros = {0, 12, 7, 1, 2, 8};

Console.Write("{");
foreach(int i in inteiros){
    Console.Write($"{i} ");
}
Console.Write("}");
DobbleSort.DobbleSort.Sort<int>(inteiros);

Console.Write("{");
foreach(int i in inteiros){
    Console.Write($"{i} ");
}
Console.Write("}");