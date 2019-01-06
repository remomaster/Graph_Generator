using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph_Generator_Konsolenanwendung.Graph
{
   public struct Graph_Eigenschaften
   {
        // Groesse
        public int Knoten;
        public int Kanten;
        public int Gewichtmax;
        public int Gewichtmin;
        public int Gradmax;
        public int Gradmin;

        // Eigenschaften
        public bool Multiedge;
        public bool Selfloop;
        public bool Gewichtet;
        public Zyklisch zyklisch;
        public bool Gerichtet;
        public bool Zusammenhaengend;
        public bool Tree;

        // Format
        public Format format;

        public void Standart_Graph()
        {
            Knoten = new Random().Next(5,201);
            Kanten = new Random().Next(0,Knoten*(Knoten-1)/2+1);
            Gewichtmax = 0;
            Gewichtmin = 0;
            Gradmax = Knoten-1;
            Gradmin = 0;
            Multiedge = false;
            Selfloop = false;
            Gewichtet = false;
            zyklisch = Zyklisch.Egal;
            Gerichtet = false;
            Zusammenhaengend = false;
            Tree = false;
            format = Format.SOI_Format;
        }
    }
}