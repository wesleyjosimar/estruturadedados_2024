using System.Reflection.Metadata.Ecma335;
using ListaGenerica;

List<double> numbers = new List<double>();
do
{
    Console.WriteLine("Informe um numero:");
    string? numberStr = Console.ReadLine();
    //Validando a entrada do Usuario
    if(!double.TryParse(numberStr, out double number))
    {
        break;
    }
    numbers.Add(number);
    Console.WriteLine($"Amedia dos Valores é {numbers.Average()}");
}
while(true);

//-- Lista de Pessoas

List<Person> people= new List<Person>();
Person  p1 = new Person();
p1.Age = 12;
p1.Country = CountryEnum.PY;
people.Add(p1);

p1.Name = "Joaquim Jose da Silva Xavier";

people.Add(new Person(){
    Name = "Sharon Stone",
    Age = 60,
    Country = CountryEnum.PY,

});

Person p3  =new Person(){
    Name = "Arnold e suas nega",
    Age = 65,
    Country = CountryEnum.JP
};

people.Add(p3);

// formas de percorrer a lista generica
foreach(Person p in people)
{
    Console.WriteLine( p.Name);

}

//Modo for tradicional
for(int i = 0; i < people.Count; i++)
{
    Console.WriteLine(
        $"Nome: {people[i].Name}"
    );
}