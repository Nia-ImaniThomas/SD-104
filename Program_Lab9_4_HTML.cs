using System;

namespace Lab_9_4_HTML
{
    class Program_Lab9_4_HTML
    {
        static void Main(string[] args)
        {
            string filename = " C:\\Weblogs\\Lab 9 - 4_HTML\\Lab 9 - 4_HTML";

            Header header = new Header();
            UnorderedList list = new UnorderedList();
            StringBuilder sb = new StringBuilder();

            Console.WriteLine("Enter text for HTML header.");
            string headerElement = header.CreateHeader(Console.ReadLine());
            string[] listItems = new string[3];

            for (int i = 0; i < listItems.Length; i++)
            {
                Console.WriteLine("Add another item to the list.");
                listItems[i] = list.CreateListItem(Console.ReadLine());
            }

            StringBuilder listElement = list.CreateList(listItems);
            sb.Append(headerElement);
            sb.Append(listElement.ToString());

            File.AppendAllText(filename, sb.ToString());

        }
    }
}