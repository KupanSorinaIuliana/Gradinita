using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gradinita
{
    public class Child
    {
        public int ID { get; set; }

        public string Nume { get; set; }

        public string Simbol { get; set; }

        public int Total { get; set; }

        public int SarciniFacute { get; set; }

        public String Intrebari { get; set; }
    }
}
