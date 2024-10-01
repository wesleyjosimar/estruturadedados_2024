//Diferente da TalelaHash o Dictionary nos permite
//especificar o tipo de dado que sera utilizado em pares
//key -> Value
//Isso nos fornece uma estrutura fortemente tipada

Dictionary<string, string> dictionary =
new Dictionary<string, string>() 
{
    {"Chaves 1", "Valor 1"},
    {"Chaves 2", "Valor 2"},
};

//obeter valor do dictionary
string val = dictionary["Chave 1"];

try
{
    val = dictionary["Chave 3"];
}
catch (Exception ex)
{
    Console.WriteLine("Erro ao obter valor de Chave");
    Console.WriteLine(ex.Message);
}
//Verificando se a chave existe antes de acessar
//para evitar erros e perjuizo na execução

if(dictionary.ContainsKey("Chave 2"))
{
    Console.WriteLine($"Chave 2: `{dictionary["Chave 2"]}`");
}

// Outra maneira de obter o valor e evitar erro
dictionary.TryGetValue("Chave 4", out string? valor);
if(valor is not null)
Console.WriteLine($"Chave 4: {valor}");

//Podemos adicionar da mesma forma plea chave inexistente
dictionary["Chave 0"] = "Valor 0";

//Percorrer o dicionario
foreach(KeyValuePair<string, string> kvp in dictionary)
{
    Console.WriteLine($"{kvp.Key}:{kvp.Value}");
}

//Ulizando tipos abstratos de daods do dicionario
Dictionary<int, Pessoa> dicPessoa = 
new Dictionary<int, Pessoa>();

dicPessoa.Add(
    1,
    new Pessoa(){
        Id = 0,
        BirthDate = new DateTime(1984, 7, 5,)
        Name = "Mauricio Roberto Gonzato",
    }
)

dicPessoa.Add(
    1,
    new Pessoa(){
        Id = 0,
        BirthDate = new DateTime(1997, 9, 2,)
        Name = "Wesley Lima",
    }
)

reach(KeyValuePair<int, Pessoa> kvp in dicPessoa)
{
    Console.WriteLine(kvp.key);
    Console.WriteLine(kvp.value.Id);
    Console.WriteLine(kvp.value.BirthDate);
    Console.WriteLine(kvp.value.Name);
}
