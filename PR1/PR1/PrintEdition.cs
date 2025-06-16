using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR1
{
    class PrintEdition
    {
        // Свойства для хранения данных
        public string Title { get; set; }        // Название
        public string Author { get; set; }       // Автор
        public int Year { get; set; }            // Год издания
        public string Publisher { get; set; }    // Издательство
        public int Pages { get; set; }           // Количество страниц

        // Метод для получения информации о печатном издании
        public string GetInfo()
        {
            return $"Название: {Title}\nАвтор: {Author}\nГод: {Year}\nИздательство: {Publisher}\nСтраниц: {Pages}";
        }
    }
}
