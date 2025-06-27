using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnProcess_Click(object sender, EventArgs e)
        {
            lstOutput.Items.Clear();
            double sum = 0;

            string input = txtInput.Text; 

            string[] values = input.Split(',');

            for (int i = 0; i < values.Length; i++)
            {
                string valueStr = values[i].Trim();
                if (double.TryParse(valueStr, out double value))
                {
                    // Успешно преобразовалось в число
                    string key = $"ключ{i + 1}";
                    lstOutput.Items.Add($"{key}: {value}");
                    sum += value;
                }
                else
                {
                    lstOutput.Items.Add($"Значение {valueStr} некорректное");
                }
            }
            lblSum.Text = $"Сумма: {sum}";
        }
        // Обработчик пункта меню "Помощь"
        private void помощьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Это ссылка на меня:\nilasemonaev@gmail.com", "Помощь");
        }
    }
}