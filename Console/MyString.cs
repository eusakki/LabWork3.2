using System;

namespace ConsoleApp
{
    public class MyString : IComparable<MyString>
    {
        private string value;      // Рядкове значення, яке зберігається в об’єкті
        private int key;           // Числовий ключ, за яким об’єкт вставляється в дерево
        private bool direction;    // Напрямок обходу дерева (true - прямий, false - обернений)

        public string Value
        {
            get { return value; }
            set { this.value = value; }
        }

        public int Key
        {
            get { return key; }
            set { key = value; }
        }

        public bool Direction
        {
            get { return direction; }
            set { direction = value; }
        }

        public MyString(string value, int key, bool direction)
        {
            this.value = value;
            this.key = key;
            this.direction = direction;
        }

        public int CompareTo(MyString other)
        {
            if (other == null)
            {
                return 1;
            }

            if (direction == true)
            {
                if (key > other.key)
                {
                    return 1;
                }
                else if (key < other.key)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                if (key < other.key)
                {
                    return 1;
                }
                else if (key > other.key)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
        }

        public override string ToString()
        {
            return "Value: " + value + ", Key: " + key + ", Direction: " + direction;
        }
    }
}
