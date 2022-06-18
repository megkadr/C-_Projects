using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csvtohtmldobry
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = File.ReadAllLines(args[0]);
            var html= "<html>\n\t<style>\ntable, td{\nborder:2px solid black;\n}</style>\n<body>\n<table style=\"width:100%\">\n";
            int linia = 0;
            foreach (var line in lines)
            {
              var cols = line.Split(';');
               
                if (linia % 2 == 0)
                {
                    html += "<tr style=\"background-color: blue;\">";
                    linia++;
                }
                else
                {
                    html += "<tr style=\"background-color: red;\">";
                    linia++;
                }
              for (int i=0;i<cols.Length;i++)
              {
                
                        html += "<td>" + cols[i] + "</td>";
                    
               }
              html += "</tr>";
              
            }
            html += "</table>\n</body>\n</html>";
            File.WriteAllText(@"C:\Users\miniz\source\repos\csvtohtmldobry\csvtohtmldobry\plik.html", html);

        }
    }
}
