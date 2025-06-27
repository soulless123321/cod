using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR2
{
    public partial class Form1 : Form
    {
        private PR2Processor processor;

        public Form1()
        {
            InitializeComponent();
            processor = new PR2Processor();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            processor.GenerateRandomList();
            UpdateListBox();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            processor.InsertLastEvenAfterOdds();
            UpdateListBox();
        }

        private void UpdateListBox()
        {
            listBoxNumbers.DataSource = null;
            listBoxNumbers.DataSource = processor.Numbers;
        }
    }
}
