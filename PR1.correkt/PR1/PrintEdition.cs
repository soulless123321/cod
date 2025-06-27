using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR1
{
    public class PrintEdition
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public string Publisher { get; set; }
        public int Pages { get; set; }

        public string GetInfo()
        {
            return $"Название: {Title}\nАвтор: {Author}\nГод: {Year}\nИздательство: {Publisher}\nСтраниц: {Pages}";
        }
    }
}
