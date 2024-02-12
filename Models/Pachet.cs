using System;
using System.Collections.Generic;
using System.Linq;
namespace AplicatieProiectMobil.Models
{
    public class Pachet
    {
        public int Id { get; set; }
        public string Nume { get; set; }
        public string Eveniment { get; set; }
        public string Locatie { get; set; }
        public string Pret { get; set; }
        public short CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string InformatiiSuplimentare { get; set; }
    }
}