using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Graph_Generator_Konsolenanwendung.Graph;

namespace Graph_Generator_Konsolenanwendung
{
    public static class Argumentverarbeiter
    {
        public static Graph_Eigenschaften Get_Graph_Eigenschaften(string[] args)
        {
            Graph_Eigenschaften b = new Graph_Eigenschaften();
            b.Standart_Graph();

            throw new NotImplementedException();
        }
    }
}
