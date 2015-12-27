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
        bibForm _parentForm;
        Collection _bookCollection;

        public AddBookForm()
        {           
            InitializeComponent();
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void SetNewBookData(bibForm parentForm, Collection bookCollection)
        {
            //this.tbPath.Text = pathName;
            this._parentForm = parentForm;
            this._bookCollection = bookCollection;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if(this.tbPath.Text.Length == 0)
            {
                MessageBox.Show("Bitte wähle ein PDF aus!");
                return;
            }

            Book book = new Book();
            book.Title = tbTitel.Text;
            book.Author = tbAuthor.Text;
            book.Isbn = tbIsbn.Text;
            CollectionItem all = _bookCollection.GetCollection("Alle");
            all.AddBook(book);
            _parentForm.ResizeCollectionItems();
            _parentForm.UpdateBookDataSource();
            
            this.Close();
        }

        private void btnSelectPdf_Click(object sender, EventArgs e)
        {
            //TODO: Warum dauert das oft so extrem lang? (mehrere Sekunden...)      
            //--> ich denke, das passiert nur beim Doppelklick auf das gewünschte Item!
            OpenFileDialog openFileDialog1 = new OpenFileDialog();            
            openFileDialog1.Filter = "pdf files (*.pdf)|*.pdf";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.tbPath.Text = openFileDialog1.FileName;
            }
        }
    }
}
