using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordList.DataLayer
{
    public interface IPersistenceLayer
    {
        List<Word> GetAll();
        void Add(string word, string meaning);
    }
}
