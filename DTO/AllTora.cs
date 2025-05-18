using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class AllTora:Location
    {
        public string Chumash { get; set; }
        public string Perek {  get; set; }
        public string Pasuk {  get; set; }
        public string Melel { get; set; }
        public AllTora()
        {
            
        }
       public AllTora(string chumash, string perek, string pasuk, string melel)
        {
            Chumash = chumash;
            Perek = perek;
            Pasuk = pasuk;
            Melel = melel;
        }
    }

}
