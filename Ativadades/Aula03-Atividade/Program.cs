int[] pares = new int[50];
int indicePar = 0;


for (int i = 1; i <= 100; i++)
{
    if (i % 2 == 0)
    {
        pares[indicePar] = i;
        indicePar++;
    }
}

Console.WriteLine("Números pares:");
for (int i = 0; i < pares.Length; i++)
{
    Console.Write(pares[i] + " ");
}