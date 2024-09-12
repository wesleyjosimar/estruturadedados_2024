//JegueArray e o array do Ceará
//JaggedArray e tambem conhecido como
//um vetor de etores
int[][] numbers = int [4][];
//Nesse Caso [][] indica que é
//um verot de vetor, neste exemplo
//umvetor de 4 posicoes contendo
//vetores de tam. indefinido
numbers[0] = new int [] {1, 2, 3,};
numbers[1] = new int [] {4, 3, 2, 1, 0};
numbers[2] = new int [] {1, 2, 0};
numbers[3] = new int [] {57};
numbers[4] = null!;

//para obter valor de jaggerArray
int valor = numbers[0][2];
Console.WriteLine(valor);

//para atribuir valor em um jaggedArray
numbers[1][2] = 0
Console.WriteLine ( numbers[1][2] );
