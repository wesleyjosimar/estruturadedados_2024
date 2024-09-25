// Uma Fila é a estrutura de dados que 
//Pode ser aplicada para representar
//a fila de atendimento da cantina 
//As pessoas que chegam entra no final da fila
//e as primeiras que chegaram sao as primeiras a serem atendidas

//A função ENQUEUE e responsavel por adicionar novos elementos a fila
//a Funçao de DEQUEUE remove elesmentos da fila

// Desta forma, obedece o principio do FIFO
//First In, First oUT -> Primeiro que entra
// e o primeiro que sai

using Filas;

Random random = new Random();

CallCenter center = new ();
center.Call(1234);
center.Call(1369);
center.Call(2468);
center.Call(1478);

while (center.AreWattingCalls())
{
    Thread.Sleep(3000);
    IncomingCall call = center.Answer("Thiago");
    Console.WriteLine(
        @$"{DateTime.Now:HH:mm:ss}
        Chamado: #{call.Id}
        De: {call.ClientId}
        Atendimento por: {call.Consultant}" 
    );
    Thread.Sleep(random.Next(1000, 10000));
    center.End(call);
    Console.WriteLine(
        @$"Chamado: {call.Id}
            Encerrado as: {call.EndTime}"
    );
}
