using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_9_4_HTML
{
    class Header : Program_Lab9_4_HTML
    {
        public const string open = "<h1> " +
            "Cake Tasting Options";
        public const string close = "</h1>";

        public string CreateHeader(string text)
        {
            string header = String.Concat(open, text, close, "\n");
            return header;
        }
    }

    class UnorderedList
    {
        public const string open = "<ul>" +
            "Tasting for 2, " +
            "Tasting for 3, " +
            "Tasting for 4";
        public const string close = "</ul>";

        public string CreateListItem(string text)
        {
            string open = "<li>\n";
            string close = "</li>\n";

            string listItem = String.Concat(open, text, close, "\n");
            return listItem;
        }

        public StringBuilder CreateList(string[] listItems)
        {

            StringBuilder sb = new StringBuilder();
            sb.Append(open);
            foreach (string item in listItems)
            {
                sb.Append(item);
            }
            sb.Append(close);

            return sb;
        }

    }
}