// Файл Program.cs
using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("------------------Колекції------------------");

            // Масив
            MyString[] array = new MyString[]
            {
                new MyString("apple", 3, true),
                new MyString("banana", 1, true),
                new MyString("cherry", 2, true)
            };

            Console.WriteLine("Масив:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            // Generic колекція
            List<MyString> list = new List<MyString>();
            list.Add(new MyString("dog", 4, true));
            list.Add(new MyString("cat", 2, true));
            list.Add(new MyString("elephant", 3, true));

            Console.WriteLine("\nGeneric List:");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            // Non-generic колекція
            ArrayList arrayList = new ArrayList();
            arrayList.Add(new MyString("red", 5, false));
            arrayList.Add(new MyString("green", 2, false));
            arrayList.Add(new MyString("blue", 3, false));

            Console.WriteLine("\nArrayList:");
            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[i]);
            }

            // Оновлення
            list[1] = new MyString("lion", 10, true);
            Console.WriteLine("\nПісля оновлення елемента у List:");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            // Видалення
            arrayList.RemoveAt(0);
            Console.WriteLine("\nПісля видалення елемента з ArrayList:");
            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[i]);
            }

            // Пошук
            bool found = false;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Value == "lion")
                {
                    found = true;
                }
            }

            if (found == true)
            {
                Console.WriteLine("\nЗнайдено елемент 'lion' у List.");
            }
            else
            {
                Console.WriteLine("\nЕлемент 'lion' не знайдено у List.");
            }

            Console.WriteLine("\n------------------Бінарне дерево------------------");

            // Бінарне дерево з об'єктів MyString
            BinaryTree<MyString> tree = new BinaryTree<MyString>();
            tree.Insert(new MyString("delta", 4, true));
            tree.Insert(new MyString("alpha", 1, true));
            tree.Insert(new MyString("epsilon", 5, true));
            tree.Insert(new MyString("beta", 2, true));
            tree.Insert(new MyString("gamma", 3, true));

            // Обхід дерева — у прямому порядку (pre-order)
            Console.WriteLine("Обхід дерева (pre-order):");
            foreach (MyString s in tree)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("\nПрограма завершена успішно.");
        }
    }
}
