using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordCounter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void wordCountButton_Click(object sender, EventArgs e)
        {
            try
            {
                string phrase = phraseTextBox.Text;
                resultlabel.Text = GetWordCount(phrase.TrimEnd()).ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private int GetWordCount(string phrase)
        {
            int wordCount = 0;
            
            //Create Array or List
            List<string> words = new List<string>();
            words = phrase.Split(null).ToList();

          foreach (string word in words)
            {
                wordCount++;
            }    

            return wordCount;
        }
    }
}
