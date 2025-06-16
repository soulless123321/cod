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
    public partial class MainForm: Form
    {
       
        public MainForm()
        {
            Label lblTitle = new Label() { Text = "Название", Top = 10, Left = 10, Width = 100 };
            txtTitle = new TextBox() { Top = 30, Left = 10, Width = 360 };

            Label lblAuthor = new Label() { Text = "Автор", Top = 60, Left = 10, Width = 100 };
            txtAuthor = new TextBox() { Top = 80, Left = 10, Width = 360 };

            Label lblYear = new Label() { Text = "Год", Top = 110, Left = 10, Width = 100 };
            txtYear = new TextBox() { Top = 130, Left = 10, Width = 360 };

            Label lblPublisher = new Label() { Text = "Издательство", Top = 160, Left = 10, Width = 100 };
            txtPublisher = new TextBox() { Top = 180, Left = 10, Width = 360 };

            Label lblPages = new Label() { Text = "Страниц", Top = 210, Left = 10, Width = 100 };
            txtPages = new TextBox() { Top = 230, Left = 10, Width = 360 };

            Button btnShow = new Button() { Text = "Показать", Top = 270, Left = 10, Width = 100 };
            btnShow.Click += BtnShow_Click;

            // Добавление контролов на форму
            this.Controls.Add(lblTitle);
            this.Controls.Add(txtTitle);
            this.Controls.Add(lblAuthor);
            this.Controls.Add(txtAuthor);
            this.Controls.Add(lblYear);
            this.Controls.Add(txtYear);
            this.Controls.Add(lblPublisher);
            this.Controls.Add(txtPublisher);
            this.Controls.Add(lblPages);
            this.Controls.Add(txtPages);
            this.Controls.Add(btnShow);
        }
        private void BtnShow_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            string author = txtAuthor.Text;
            string publisher = txtPublisher.Text;

            if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(author) ||
                string.IsNullOrWhiteSpace(publisher) || string.IsNullOrWhiteSpace(txtYear.Text) ||
                string.IsNullOrWhiteSpace(txtPages.Text))
            {
                MessageBox.Show("Заполните все поля!", "Внимание");
                return;
            }

            if (!int.TryParse(txtYear.Text, out int year))
            {
                MessageBox.Show("Год должен быть числом", "Ошибка");
                return;
            }
            if (year < 0)
            {
                MessageBox.Show("Год не может быть отрицательным", "Ошибка");
                return;
            }

            if (!int.TryParse(txtPages.Text, out int pages))
            {
                MessageBox.Show("Страниц должно быть числом", "Ошибка");
                return;
            }
            if (pages < 0)
            {
                MessageBox.Show("Количество страниц не может быть отрицательным", "Ошибка");
                return;
            }

            PrintEdition edition = new PrintEdition()
            {
                Title = title,
                Author = author,
                Year = year,
                Publisher = publisher,
                Pages = pages
            };

            MessageBox.Show(edition.GetInfo(), "Информация");
        }

        private void lblYear_Click(object sender, EventArgs e)
        {

        }
    }
}
