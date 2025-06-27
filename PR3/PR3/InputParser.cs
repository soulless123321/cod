using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR3
{
    public class InputParser
    {
        public Dictionary<string, double> Parse(string input)
        {
            var dict = new Dictionary<string, double>();
            var pairs = input.Split(',');
            // Обрабатываем каждый элемент массива
            foreach (var pair in pairs)
            {
                var trimmedPair = pair.Trim();
                if (string.IsNullOrEmpty(trimmedPair))
                    continue;

                var parts = trimmedPair.Split(':');
                if (parts.Length != 2)
                    throw new FormatException("Некорректный формат: " + pair);

                string key = parts[0].Trim();

                double value;
                if (!double.TryParse(parts[1].Trim(), out value))
                    throw new FormatException("Некорректное число: " + parts[1].Trim());

                dict[key] = value;
            }
            return dict;
        }
    }
}
