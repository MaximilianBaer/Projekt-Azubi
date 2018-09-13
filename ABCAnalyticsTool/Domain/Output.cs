using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Output
    {
        public int ID { get; set; }
        public string Bezeichnung { get; set; }
        public int Menge { get; set; }
        public double MengeProzent { get; set; }
        public string AnteilMenge { get; set; }
        public int Wert { get; set; }
        public double WertProzent { get; set; }
        public string AnteilWert { get; set; }
        public ABC Kategorie { get; set; }

    }
}
