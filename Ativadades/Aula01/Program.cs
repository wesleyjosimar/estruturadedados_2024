using Aula01;
// Comentário de uma linha

/*
    Comentário de
    Múltiplas linhas
*/

// Declarando variável
int number;

// Atribuindo valor
number = 10;

// Declarando contante
const int DAYS_IN_WEEK = 7;

// Imprimindo String concatenada
Console.WriteLine($"A semana tem {DAYS_IN_WEEK} dias.");
// new tipoenumerador() -> Invoca o metodo contrutor de objeto
//Toda Classe tem o seu contrutor padrao implicito sem argumento
//E possivel subescrever este metodo especificando em argumentos
//Todavia, se o fizermos , perdemos o original implicito
//precisaremos definilo explisadamente
TipoEnumerador TipEnum = new TipoEnumerador();
TipoEnumerador.Language enumenglish = TipEnum.GetLanguageEnum("inglês");
Console.WriteLine($"O enum de inglês é {enumenglish}");