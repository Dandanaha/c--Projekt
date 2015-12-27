using BookKatalogue.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookKatalogue
{
    public partial class AddBookForm : Form
    {
        Collection _bookCollection;

        public AddBookForm()
        {           
            InitializeComponent();
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void SetNewBookData(string pathName, Collection bookCollection)
        {
            this.tbPath.Text = pathName;
            this._bookCollection = bookCollection;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            book.Title = tbTitel.Text;
            book.Author = tbAuthor.Text;
            book.Isbn = tbIsbn.Text;
            CollectionItem all = _bookCollection.GetCollection("Alle");
            all.AddBook(book);
            this.Close();
        }
    }
}
