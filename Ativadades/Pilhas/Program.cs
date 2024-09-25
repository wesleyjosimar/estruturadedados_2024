// as pilhas trabalham com
//uma estrutura LIFO ->  Last In First Out
//tres metodos importantes:
//Push() -> Insere um elemento no topo da Pilha
//Pop() -> Remove um elemento do topo e o retorna
//Peek() -> Retorna o elemento do topo sem remove-lo


//Invertendo as bolas
Stack<char> caracteres = new Stack<char> ();
foreach(char c in "DARCY DA MONTANHA")
{
    caracteres.Push(c);
}

//Desempilhando
string invertido = string.Empty;
while(caracteres.Count > 0)
{
    invertido += caracteres.Pop ();
}
Console.WriteLine (invertido);


