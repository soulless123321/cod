using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR3
{
    public static class DictionaryPrinter
    {
        public static void PrintInColumn(Dictionary<string, double> dict, ListBox listBox)
        {
            foreach (var kvp in dict)
            {
                listBox.Items.Add($"{kvp.Key}: {kvp.Value}");
            }
        }
    }
}
