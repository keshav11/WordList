using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WordList.DataLayer;

namespace WordList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Word> data = new ObservableCollection<Word>();
        public WordListManager wordManager = new WordListManager();
        public MainWindow()
        {
            InitializeComponent();
            foreach (Word w in wordManager.GetAll())
                data.Add(new Word(w.WordString, w.MeaningString));
            wordList.DataContext = data;
        }

        private void wordList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void textBox_Copy_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void addWord_Click(object sender, RoutedEventArgs e)
        {
            wordManager.Add(this.textWord.Text, this.textMeaning.Text);
            data.Add(new Word(this.textWord.Text, this.textMeaning.Text));
        }
    }
}
