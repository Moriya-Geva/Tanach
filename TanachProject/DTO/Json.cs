using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Json
    {
        public string FindName { get; set; }
        public List<string> ListFindName { get; set; }
        public List<AllTora> ListFoundPsukim { get; set; }
        public Json()
        {
            
        }
        public Json(string findName, List<string> listFindName, List<AllTora> listFoundPsukim)
        {
            FindName = findName;
            ListFindName = listFindName;
            ListFoundPsukim = listFoundPsukim;
        }
    }
    
}
