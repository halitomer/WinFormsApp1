using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        public void ButtonSearch_Click(object sender, EventArgs e)
        {
            string searchText = textBoxSearch.Text.Trim();

            var books = new List<string>
    {
        "Harry Potter",
        "The Hobbit",
        "The Catcher in the Rye"
    };

            // نبحث عن الكتب التي تحتوي على النص
            var matchedBooks = books.Where(b => b.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0).ToList();

            // نفرغ محتوى الليست بوكس أولاً
            listBoxBooks.Items.Clear();

            if (matchedBooks.Any())
            {
                // نعرض النتائج بالليست بوكس
                foreach (var book in matchedBooks)
                {
                    listBoxBooks.Items.Add(book);
                }
            }
            else
            {
                MessageBox.Show("No matching books found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void listBoxBooks_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
