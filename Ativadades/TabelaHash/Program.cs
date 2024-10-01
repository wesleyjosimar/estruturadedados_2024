// Exemplo de uma agenda telefonica

using System.Collections;

Hashtable phoneBook = new Hashtable()
{
   // { "Chave", "Valor" },
    { "Thomazzi", "49-99961-0150" },
    { "Mauricio Gonzatto", "49-99975-8575" },
    {"Gabriel Bianchi", "49-999105-8904" },
};

//E possivel adicionar elementos de diversas formas

//Pelo proprio indice chave inexistente
phoneBook["Thiago Padilha"] = "49-99176-8255";

//ou pelo metodo Add()
phoneBook.Add("Marcos Henrique", "49-99202-6169");

//Entretando, na TabelaHash verifica se há duplicidade
//de chave e pode lançar uma
//Exception

try
{
    phoneBook.Add("Mauricio Gonzatto", "49-99975-8575");
}catch(Exception ex)
{
    Console.WriteLine($"Erro ao tentar excluir valor repetido");
    Console.WriteLine(ex.Message);
}

//Percorrendo Itens da HashTable
Console.WriteLine("Agenda telefonica:");
if(phoneBook.Count ==0)
    Console.WriteLine("A agenda esta vazia");
else
    foreach(DictionaryEntry entry in phoneBook)
        Console.WriteLine($"{entry.Key}:{entry.Value}");