using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            // Получение данных из полей
            string title = txtTitle.Text.Trim();
            string author = txtAuthor.Text.Trim();
            string publisher = txtPublisher.Text.Trim();
            string yearText = txtYear.Text.Trim();
            string pagesText = txtPages.Text.Trim();

            // Проверка заполненности всех полей
            if (IsAnyFieldEmpty(title, author, publisher, yearText, pagesText))
            {
                MessageBox.Show("Заполните все поля!", "Внимание");
                return;
            }

            // Проверка и преобразование года
            if (!TryParseNonNegativeInt(yearText, out int year))
            {
                MessageBox.Show("Год должен быть числом и не отрицательным", "Ошибка");
                return;
            }

            // Проверка и преобразование количества страниц
            if (!TryParseNonNegativeInt(pagesText, out int pages))
            {
                MessageBox.Show("Количество страниц должно быть числом и не отрицательным", "Ошибка");
                return;
            }

            // Создаем объект книги
            PrintEdition edition = new PrintEdition
            {
                Title = title,
                Author = author,
                Publisher = publisher,
                Year = year,
                Pages = pages
            };

            // Вывод информации
            MessageBox.Show(edition.GetInfo(), "Информация");
        }

        // Проверяет, есть ли хотя бы одно пустое поле
        private bool IsAnyFieldEmpty(params string[] fields)
        {
            foreach (var field in fields)
            {
                if (string.IsNullOrWhiteSpace(field))
                    return true;
            }
            return false;
        }

        // Пытается преобразовать строку в неотрицательное целое число
        private bool TryParseNonNegativeInt(string text, out int result)
        {
            if (int.TryParse(text, out result))
            {
                if (result >= 0)
                    return true;
            }
            result = 0;
            return false;
        }

        // Класс книги (если еще не создан)
        public class PrintEdition
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public string Publisher { get; set; }
            public int Year { get; set; }
            public int Pages { get; set; }

            public string GetInfo()
            {
                return $"Книга: {Title}\nАвтор: {Author}\nИздательство: {Publisher}\nГод: {Year}\nСтраниц: {Pages}";
            }
        }
    }
}