﻿using BookKatalogue.controll;
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
    public partial class bibForm : Form
    {

        Collection _bookCollection;

        public bibForm()
        {
            InitializeComponent();
            _bookCollection = new Collection();
            AddNewCollectionItemControlToList("Alle", false);
        }

        private void öffnenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            string filepath;

            od.Filter = "PDF Files (*.pdf)|*.pdf|All Files (*.*)|*.*";
            od.Title = "Select a PDF File";

            if (od.ShowDialog() == DialogResult.OK)
            {

                filepath = od.FileName.ToString();
            }
        }

        private void speichernToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sd = new SaveFileDialog();
            sd.ShowDialog();
        }

        private void aktuellistToolStrip_Click(object sender, EventArgs e)
        {
            aktuellistToolStrip.Enabled = aktuellistToolStrip.Checked;
        }

       /* private void Do_Checked()
        {
            aktuellistToolStrip.Enabled = aktuellistToolStrip.Checked;
            autorToolStripMenuItem.Enabled = autorToolStripMenuItem.Checked;
        } */

        private void autorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            autorToolStripMenuItem.Enabled = autorToolStripMenuItem.Checked;

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void SortiComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
         

            if (rbtnBücherInf.Checked)
            {
                rbtnBücherInf.BackColor = Color.Red;
            }
            else
            {
                rbtnBücherInf.BackColor = Color.White;
            }

            
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains("Suche ..."))
            {
                textBox1.Text = "";
            }
        }


        List<CollectionItemControl> cicList = new List<CollectionItemControl>();
        private void btnAddCollection_Click(object sender, EventArgs e)
        {
            //Remove Focus
            RemoveFocusOnAllCollectionItemControls();
            AddNewCollectionItemControlToList("New Collection", true);
        }

        private void AddNewCollectionItemControlToList(string collectionName, bool isFocusOnItem = false)
        {
            CollectionItem item = new CollectionItem();
            item.Name = collectionName;
            _bookCollection.AddCollectionItem(item);
            CollectionItemControl cic = new CollectionItemControl(item);
            TextBox tbName = cic.Controls.Find("tbName", true)[0] as TextBox;
            tbName.Text = item.Name;
            Label lblBookCount = cic.Controls.Find("lblBookCount", true)[0] as Label;
            lblBookCount.Text = item.BookCount.ToString();
            cic.Location = new Point(4, 4);            
            cicList.Add(cic);

            RepositionAllCollectionItemControls(cic);
            pnlCollectionItem.Controls.Add(cic);
            ResizeCollectionItems();
            btnAddCollection.Text = "Sammlung hinzufügen (" + cicList.Count + ")";

            //Set Focus 
            if (isFocusOnItem)
                SetFocusOnAllCollectionItemControls(tbName);
            else
                tbName.Enabled = false;
        }

        private void RepositionAllCollectionItemControls(CollectionItemControl cic)
        {
            int height = cic.Height;
            int heightGap = 3;
            int totalHeight = height + heightGap;
            
            int y = cicList[0].Location.Y;
            for (int i = 1; i < cicList.Count; i++)
            {
                Point controlPosition = new Point(4, 4 + y + totalHeight);
                cicList[i].Location = controlPosition;
                y += 4 + totalHeight;
            }            
        }

        private void SetFocusOnAllCollectionItemControls(TextBox tbName)
        {
            tbName.Focus();
            tbName.ReadOnly = false;
            tbName.SelectAll();
        }

        private void RemoveFocusOnAllCollectionItemControls()
        {
            foreach (CollectionItemControl ele in cicList)
            {
                TextBox eleTextBox = ele.Controls.Find("tbName", true)[0] as TextBox;
                eleTextBox.ReadOnly = true;
                eleTextBox.SelectionLength = 0;
                eleTextBox.Enabled = false;
            }
        }

        private void tsmiBeenden_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Möchten Sie wirklich das Programm verlassen?", "Warning",  MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dialog == DialogResult.Yes)
            {
                this.Close();
            }        
        }

        private void pnlCollectionItem_SizeChanged(object sender, EventArgs e)
        {
            ResizeCollectionItems();
        }

        public void ResizeCollectionItems()
        {
            int scrollbarWidth = 0;
            if (pnlCollectionItem.VerticalScroll.Visible)
                scrollbarWidth = 15;

            foreach (CollectionItemControl cic in cicList)
            {
                //blablubb
                cic.Width = pnlCollectionItem.Width - 10 - scrollbarWidth;
                cic.RefreshBookCount();
            }

            dgvBooks.Refresh();            
        }


        private void btnAddBook_Click(object sender, EventArgs e)
        {
            //AddBookForm abf = new AddBookForm();
            //abf.SetNewBookData(this, _bookCollection);
            //abf.Show();


            //############Test###########
            Book book = new Book();
            book.Title = "Test";
            book.Author = "Dan";
            book.Isbn = "1234.5678.9098.7654";
            _bookCollection.GetCollection("Alle").AddBook(book);

            UpdateBookDataSource();
            //###########################

            ResizeCollectionItems();
        }

        private void bibForm_Load(object sender, EventArgs e)
        {
            UpdateBookDataSource();
        }

        private void UpdateBookDataSource()
        {
            BindingList<Book> bindingList = new BindingList<Book>(_bookCollection.GetCollection("Alle").BookList);
            BindingSource bsBook = new BindingSource(bindingList, null);
            dgvBooks.DataSource = bsBook;
        }

        private void btnEditBooks_Click(object sender, EventArgs e)
        {
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.HeaderText = "";
            checkBoxColumn.Width = 30;
            checkBoxColumn.Name = "checkBoxColumn";

            dgvBooks.Columns.Insert(0, checkBoxColumn);
            dgvBooks.Columns[0].Width = 18;

            //dgvBooks.ReadOnly = false;
            btnDeleteBook.Visible = true;

            foreach (DataGridViewColumn row in dgvBooks.Columns)
            {
                if (row.GetType() == typeof(DataGridViewCheckBoxColumn))
                    row.ReadOnly = false;
                else
                    row.ReadOnly = true;

            }

            dgvBooks.ReadOnly = false;
            UpdateBookDataSource();                 
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            CollectionItem ci = _bookCollection.GetCollection("Alle");

            foreach (DataGridViewRow row in dgvBooks.Rows)
            {
                bool isSelected = Convert.ToBoolean(row.Cells["checkBoxColumn"].Value);
                if (isSelected)
                {
                    // einige Zellen sind null...warum das?!?!?!?! --> meist die Hälfte der selektierten Items
                    //if(row.Cells["Title"].Value != null)
                    {
                        // Buch löschen                        
                        string bookTitle = row.Cells["Title"].Value.ToString();
                        ci.RemoveBook(bookTitle);               
                    }
                }
            }
            UpdateBookDataSource();
            ResizeCollectionItems();
        }
    }
}
