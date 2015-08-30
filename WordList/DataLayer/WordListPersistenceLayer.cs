using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace WordList.DataLayer
{
    public class WordListPersistenceLayer : IPersistenceLayer
    {

        string xmlFile;
        XmlDocument doc;

        public WordListPersistenceLayer()
        {
            xmlFile = @"../../DataLayer/WordList.xml";
            doc = new XmlDocument();
            doc.Load(xmlFile);
        }
        public void Add(string word, string meaning)
        {
            XmlNode parentNode = doc.SelectSingleNode("WordList");
            var element = doc.CreateElement("Word");
            parentNode.AppendChild(element);
            element.SetAttribute("word", word);
            element.SetAttribute("meaning", meaning);
            doc.Save(xmlFile);
        }


        public List<Word> GetAll()
        {
            var words = doc.SelectNodes("WordList/Word");
            var wordList = new List<Word>();
            foreach (XmlNode word in words)
            {
                try
                {
                    wordList.Add(new Word(word.Attributes["word"].Value, word.Attributes["meaning"].Value));
                }
                catch
                {

                }
            }
            return wordList;
        }
    }
}
