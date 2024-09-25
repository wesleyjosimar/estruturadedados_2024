using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Threading.Tasks;

namespace Filas
{
//Esta classe representa a fila de chamados em um call center
    public class IncomingCall
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public DateTime CallTime { get; set; }
        public DateTime StartTiem { get; set; }
        public DateTime EndTime { get; set; }
        public string? Consultant { get; set; }


    }
}