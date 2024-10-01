using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Dictionary
{
    public class Pessoa
    {
       public int Id {get; set;} 
       public string? Nome {get; set;}
       public DataTime BirthDate {get; set;}
    }
}