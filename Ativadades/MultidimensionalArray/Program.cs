// Criando um vetor multidimensional com 5 linhas e 2 colunas
int[,] numbers = new int[5, 2];

// Criando um vetor tridimensional
int[,,] triNumbers = new int[5, 4, 3];

// Inicializando os valores do vetor
int[,] iniNumbers = new int[,]
{
    { 9, 15,-90,},
    { 19, 25,-91,},
    { 29, 35,-92,},
    { 49, 45,-93,},
    { 59, 55,-94 }
};

// Código para encontrar o maior e o menor número e suas posições
int maiorNumero = int.MinValue;
int menorNumero = int.MaxValue;
int linhaMaior = 0;
int colunaMaior = 0;
int linhaMenor = 0;
int colunaMenor = 0;

for (int i = 0; i < iniNumbers.GetLength(0); i++)
{
    for (int j = 0; j < iniNumbers.GetLength(1); j++)
    {
        if (iniNumbers[i, j] > maiorNumero)
        {
            maiorNumero = iniNumbers[i, j];
            linhaMaior = i;
            colunaMaior = j;
        }

        if (iniNumbers[i, j] < menorNumero)
        {
            menorNumero = iniNumbers[i, j];
            linhaMenor = i;
            colunaMenor = j;
        }
    }
}

Console.WriteLine($"O maior número é {maiorNumero} e está na posição [{linhaMaior}, {colunaMaior}]");
Console.WriteLine($"O menor número é {menorNumero} e está na posição [{linhaMenor}, {colunaMenor}]");