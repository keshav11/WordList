using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordList.DataLayer
{
    public class WordListManager
    {
        public List<Word> wordList;
        public IPersistenceLayer persistenceLayer;
        public WordListManager()
        {
            wordList = new List<Word>();
            persistenceLayer = new WordListPersistenceLayer();
        }

        public void Add(string word, string meaning)
        {
            persistenceLayer.Add(word, meaning);
        }

        public List<Word> GetAll()
        {
            return persistenceLayer.GetAll();
        }
    }
}
