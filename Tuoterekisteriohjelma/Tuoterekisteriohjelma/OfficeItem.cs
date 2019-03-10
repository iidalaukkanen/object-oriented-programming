using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Tuoterekisteriohjelma
{
    class OfficeItem
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string GroupName { get; set; }
        public double Price { get; set; }
        public int Amount { get; set; }
        public string Comment { get; set; }

        public override string ToString()
        {
            return $"Tuote: {Name}\nTuotenumero: {Id}\nTuoteryhmä: {GroupName}\n" +
                $"Hinta: {Price.ToString("c", CultureInfo.CurrentCulture)}\n" +
                $"Määrä: {Amount}\nKommentit: {Comment}";
        }
    }
}
