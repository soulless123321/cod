using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR2
{
    public class PR2Processor
    {
        public List<int> Numbers { get; private set; }

        public PR2Processor()
        {
            Numbers = new List<int>();
        }

        public void GenerateRandomList(int size = 10, int min = 1, int max = 100)
        {
            Random rand = new Random();
            Numbers.Clear();
            for (int i = 0; i < size; i++)
            {
                Numbers.Add(rand.Next(min, max));
            }
        }

        public void InsertLastEvenAfterOdds()
        {
            int lastEven = -1;
            // Находим последний четный элемент
            for (int i = Numbers.Count - 1; i >= 0; i--)
            {
                if (Numbers[i] % 2 == 0)
                {
                    lastEven = Numbers[i];
                    break;
                }
            }

            if (lastEven == -1)
                return; // Нет четных чисел

            // Вставляем после каждого нечетного
            for (int i = 0; i < Numbers.Count; i++)
            {
                if (Numbers[i] % 2 != 0)
                {
                    Numbers.Insert(i + 1, lastEven);
                    i++; // пропускаем вставленный элемент
                }
            }
        }
    }
}
