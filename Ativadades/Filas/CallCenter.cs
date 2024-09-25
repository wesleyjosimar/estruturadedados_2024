using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Filas
{
    public class CallCenter
    {
        private int _counter = 0;
        public Queue<IncomingCall>? Calls { get; set; }

        public CallCenter()
        {
            Calls = new Queue<IncomingCall>();
        }
        //Metodo para abertura de chamados
        public void Call(int clientId)
        {
            IncomingCall call = new IncomingCall()
            {
                Id = ++ _counter,
                ClientId = clientId,
                CallTime = DateTime.Now
            };
            Calls!.Enqueue(call);
        }
        public IncomingCall Answer(string consultant)
        {
            //validacao: Verificar se tem atentimentos na fila
            if(Calls!.Count > 0)
            {
                IncomingCall call = Calls.Dequeue();
                call.Consultant = consultant;
                call.StartTiem = DateTime.Now;

                return call;
            }
            return null!;
        
        }

        public void End(IncomingCall call)
        {
            call.EndTime = DateTime.Now;
        }
        public bool AreWattingCalls()
        {
            return (Calls!.Count > 0);
        }
    }
}