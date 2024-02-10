using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AplicatieProiectMobil.Enums;

namespace AplicatieProiectMobil.Models
{
    public  class Rezervare
    {
        public long Id { get; set; }
        public IEnumerable<Pachet> Pachets { get; set; } = Enumerable.Empty<Pachet>();
        public DateTime  Data { get; set; }
        public RezervareStatus Status { get; set; } = RezervareStatus.Trimisa;

        public Color Color => _rezervareStatusColorsMap[Status];

        private static readonly IReadOnlyDictionary<RezervareStatus, Color> _rezervareStatusColorsMap =
                new Dictionary<RezervareStatus, Color>
                {
                    [RezervareStatus.Trimisa] = Colors.LightGoldenrodYellow,
                    [RezervareStatus.Confirmata] = Colors.LightGreen,
                    [RezervareStatus.Trimisa] = Colors.DarkRed,

                };
            }
}
