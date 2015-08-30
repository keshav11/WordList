using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordList.DataLayer
{
    public class Word
    {

        public string WordString { get; set; }

        public string MeaningString { get; set; }

        public Word(string word, string meaning)
        {
            WordString = word;
            MeaningString = meaning;
        }

    }
}
