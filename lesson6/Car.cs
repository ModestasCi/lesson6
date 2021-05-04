using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson6
{
    class Car
    {
        private Dictionary<int, char> MyDictionary { get; set; }
        public string Color { get; private set; }
        public int RatuSkaicius { get; private set; }

        public Car()
        {
            MyDictionary = new Dictionary<int, char>();
        }

        public char GetRecordFromDictionary(int key)
        {
            if (MyDictionary.ContainsKey(key))
            {
                return MyDictionary[key];
            }

            return 'a';
        }

        public void AddRecordToDictionary(int param1, char param2)
        {
            if (MyDictionary.ContainsKey(param1))
            {
                MyDictionary[param1] = param2;
            }
            else
            {
                MyDictionary.Add(param1, param2);
            }
        }

        public void SetColor(string color)
        {
            if (color == "red" || color == "blue" || color == "green")
            {
                this.Color = color;
            }
        }

        public void SetRatuSkaicius(int ratuSkaicius)
        {
            if (ratuSkaicius >= 4)
            {
                RatuSkaicius = ratuSkaicius;
            }
        }
    }
}
