using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace Swigino_wix_billing
{

    // Diese Klasse soll vom CSVHelper verwendet werden, jedoch so, dass ich beim Lesen jeder Zeile den Inhalt
    // noch manipulieren kann, bevor der CSVHelper diese bekommt. Dient dazu, Schrott aus dem CSV zu entfernen
    // d.h. ein malformed CSV zu einem wellformed CSV umzuformen.
    class CustomStreamReader : StreamReader
    {
        private Hashtable htReplace;

        // Jeder benötigte Constructor aus Streamreader muss hier deklariert werden und auf den Konstruktor seiner
        // Basisklasse verweisen
        public CustomStreamReader(string csvPath, Stream stream)
            : base(stream)
        {
        }
        public CustomStreamReader(Stream stream, Encoding encoding)
            : base(stream, encoding)
        {
        }

        public CustomStreamReader(string path, Encoding encoding)
            : base(path, encoding)
        {
        }


        public override string ReadLine()
        {
            // 
            string s = base.ReadLine();

            // Just for test and fun, replace all n with X
            s = s.Replace('s', 'X');

            if (htReplace != null)
            {

                // Remove/ replace unwanted characters in CSV
                foreach (DictionaryEntry d in htReplace)
                {
                    s = s.Replace(d.Key as string, d.Value as string);
                }

            }

            return s;
        }

        public void addStrReplacementHash(Hashtable htReplacementHash)
        {
            htReplace = htReplacementHash;
        }
    }

}
