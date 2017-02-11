using BookKatalogue.controll;
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
        public string _currentCollectionName = "Alle";

        public bibForm()
        {
            InitializeComponent();
            Collection bookCollection = new Collection();
            _bookCollection = bookCollection;
            AddNewCollectionItemControlToList("Alle", false);

            rbShowDataGridView.Checked = true;
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
                this.dgvBooks.Visible = false;
                this.listView.Visible = true;
                UpdateBookDataSource(_currentCollectionName);
            }

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
            cic.Click += new EventHandler(collectionItemControl_Click);
            cicList.Add(cic);

            RepositionAllCollectionItemControls(cic);
            pnlCollectionItem.Controls.Add(cic);
            ResizeCollectionItems();
            int collectionCounter = cicList.Count - 1;
            btnAddCollection.Text = "Sammlung hinzufügen (" + collectionCounter + ")";

            //Set Focus 
            if (isFocusOnItem)
                SetFocusOnAllCollectionItemControls(tbName);
            else
                tbName.Enabled = false;
        }

        private void collectionItemControl_Click(object sender, EventArgs e)
        {
            CollectionItemControl cic = sender as CollectionItemControl;
            CollectionItem ci = cic.CollectionItem;
            string collectionName = ci.Name;

            _currentCollectionName = collectionName;
            Console.WriteLine("Ich bin: " + collectionName);
            UpdateBookDataSource(_currentCollectionName); // TEEEEEEEST
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
            DialogResult dialog = MessageBox.Show("Möchten Sie wirklich das Programm verlassen?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
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
            listView.Refresh();
        }


        private void btnAddBook_Click(object sender, EventArgs e)
        {
            AddBookForm abf = new AddBookForm();
            abf.SetNewBookData(this, _bookCollection);
            abf.Show();

            //############Test###########
            //Book book = new Book();
            //book.Title = "Test";
            //book.Author = "Dan";
            //book.Isbn = "1234.5678.9098.7654";
            //_selectedColelction.GetCollection("Alle").AddBook(book);

            //UpdateBookDataSource();
            //###########################

            //UpdateBookDataSource("Alle");
            ResizeCollectionItems();
        }

        public void AddAddedBooksToLibrary()
        {
            for (int i = 0; i < _bookCollection.CollectionList.Count; i++)
            {
                if (_bookCollection.CollectionList[i].Name == "Alle")
                    continue;

                //Collection i - Bücherliste                
                // List<Book> bookList = _bookCollection.GetCollection("Alle").BookList;
                List<Book> bookList = _bookCollection.CollectionList[i].BookList;
                for (int j = 0; j < bookList.Count; j++)
                {
                    if (!_bookCollection.CollectionList[0].BookList.Contains(bookList[j]))
                    {
                        _bookCollection.GetCollection("Alle").AddBook(bookList[j]);
                    }
                }
            }
        }

        // sollte nur dann aufgerufen werden, wenn ein Buch aus der "Library" aka "Alle" gelöscht wird!!
        public void RemoveDeletedBooksFromCollections()
        {

        }

        private void bibForm_Load(object sender, EventArgs e)
        {
            //ein paar bücher hinzufügen
            //for (int i = 0; i < 5; i++)
            //{
            //    Book book = new Book();
            //    book.Title = "Test " + i;
            //    book.Author = "Dan";
            //    book.Isbn = "1234.5678.9098.7654";
            //    book.Path = "C:\\Users\\Christopher\\SkyDrive\\Dokumente\\Christian_Shop_DB_Model.pdf";
            //    book.CoverPath = "C:\\Users\\Christopher\\Pictures\\motorrad inventar 3.png";
            //    _bookCollection.GetCollection("Alle").AddBook(book);
            //}

            UpdateBookDataSource(_currentCollectionName);
            ResizeCollectionItems();
        }

        public void UpdateBookDataSource(string collectionName)
        {
            BindingList<Book> bindingList = new BindingList<Book>(_bookCollection.GetCollection(collectionName).BookList);
            BindingSource bsBook = new BindingSource(bindingList, null);
            dgvBooks.DataSource = bsBook;
            // Spalte mit "Path" ausblenden! ... das sollte später aber via Column-Name implementiert werden.. sonst fällt einem das ewt. mal auf die Füße!
            dgvBooks.Columns[dgvBooks.ColumnCount - 1].Visible = false;


            #region ListView - LargeIcon
            listView.TileSize = new Size(160, 240);
            
            ImageList myImageList = new ImageList();
            
            foreach (Book book in bsBook)
            {
                if (book.CoverPath == null || book.CoverPath == "")
                    continue;

                Bitmap bookPicture = new Bitmap((book).CoverPath);
                myImageList.Images.Add(bookPicture);
            }
            myImageList.ImageSize = new Size(160, listView.TileSize.Height);           
            listView.LargeImageList = myImageList;
            
            // Add column headers so the subitems will appear.
            //ColumnHeader header = new ColumnHeader();            
            //listView.Columns.Add(header);

            listView.Items.Clear();
            List<ListViewItem> listViewItems = new List<ListViewItem>();            
                        
            var items = listView.Items;            
            for(int i = 0; i < bsBook.Count; i++)
            {                
                ListViewItem item = new ListViewItem(new string[]
                {((Book)bsBook[i]).Title}, i);
                

                listViewItems.Add(item);
            }

            listView.Items.AddRange(listViewItems.ToArray());
            #endregion
        }

        private void cbBookEdit_CheckedChanged(object sender, EventArgs e)
        {
            //TODO:
            if(dgvBooks.SelectedRows.Count > 0)
                dgvBooks.SelectedRows[0].Selected = false;
            //foreach (DataGridViewRow row in dgvBooks.SelectedRows)
            //{
            //    row.Selected = false;
            //}

            if (cbBookEdit.Checked)
            {
                cbBookEdit.Text = "Fertig";

                DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
                checkBoxColumn.HeaderText = "";
                checkBoxColumn.Width = 30;
                checkBoxColumn.Name = "checkBoxColumn";

                dgvBooks.Columns.Insert(0, checkBoxColumn);
                dgvBooks.Columns[0].Width = 18;

                dgvBooks.ReadOnly = false;
                btnDeleteBook.Visible = true;
                btnMoveBook.Visible = true;
                dgvBooks.MultiSelect = true;

                foreach (DataGridViewColumn row in dgvBooks.Columns)
                {
                    if (row.GetType() == typeof(DataGridViewCheckBoxColumn))
                        row.ReadOnly = false;
                    else
                        row.ReadOnly = true;
                }

                dgvBooks.ReadOnly = false;
                UpdateBookDataSource(_currentCollectionName);
            }
            else
            {
                cbBookEdit.Text = "editieren";

                if (dgvBooks.Columns[0].Name == "checkBoxColumn")
                {
                    dgvBooks.Columns.Remove("checkBoxColumn");
                }

                btnDeleteBook.Visible = false;
                btnMoveBook.Visible = false;
                dgvBooks.MultiSelect = false;
            }
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            string message = string.Empty;
            CollectionItem ci = _bookCollection.GetCollection(_currentCollectionName);

            List<string> deleteList = new List<string>();
            foreach (DataGridViewRow row in dgvBooks.Rows)
            {
                bool isSelected = Convert.ToBoolean(row.Cells["checkBoxColumn"].Value);
                if (isSelected)
                {
                    // einige Zellen sind null...warum das?!?!?!?! --> meist die Hälfte der selektierten Items
                    // Iterator Problem vermutlích! (wobei ich es auch mit ner for schleife probiert hatte)...nuja
                    // jetzt hab ich ne löschliste verwendet!
                    if (row.Cells["Title"].Value != null)
                    {
                        deleteList.Add(row.Cells["Title"].Value.ToString());
                    }
                }
            }

            foreach (string bookName in deleteList)
            {
                ci.RemoveBook(bookName/*, _currentCollectionName*/);
            }

            UpdateBookDataSource(_currentCollectionName);
            ResizeCollectionItems();
        }

        private void btnMoveBook_Click(object sender, EventArgs e)
        {
            //TODO: schiebe die ausgewählten Bücher in eine "Collection"

        }

        private void dgvBooks_SelectionChanged(object sender, EventArgs e)
        {
            // "Bücher editieren"-Modus
            if (cbBookEdit.Checked)
            {
                if (dgvBooks.SelectedRows.Count < 2)
                    return;

                foreach (DataGridViewRow row in dgvBooks.SelectedRows)
                {
                    if (Convert.ToBoolean(row.Cells["checkBoxColumn"].Value) == false)
                        row.Cells["checkBoxColumn"].Value = true;
                }
            }
        }

        private void dgvBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // "Bücher editieren"-Modus
            if (cbBookEdit.Checked)
            {
                if (dgvBooks.SelectedRows.Count > 1)
                    return;

                int i = e.RowIndex;
                if (i == -1)
                    return;
                DataGridViewRow row = dgvBooks.Rows[i];
                row.Cells["checkBoxColumn"].Value = !Convert.ToBoolean(row.Cells["checkBoxColumn"].Value);
            }
        }

        private void dgvBooks_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!cbBookEdit.Checked)
            {
                //if (dgvBooks.SelectedRows.Count == 1)
                //    return;

                int i = e.RowIndex;
                if (i == -1)
                    return;

                ReadBook(i);
            }           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {            
            CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dgvBooks.DataSource];
            currencyManager1.SuspendBinding();

            bool foundBooks = false;


            foreach (DataGridViewRow r in dgvBooks.Rows)
            {
                if ((String)cbSearchColumn.SelectedItem == "Titel")
                {
                    if ((r.DataBoundItem as Book).Title.Contains(textBox1.Text))
                        foundBooks = true;
                }
                else if ((String)cbSearchColumn.SelectedItem == "Autor")
                {
                    if ((r.DataBoundItem as Book).Author.Contains(textBox1.Text))
                        foundBooks = true;
                }
                else if ((String)cbSearchColumn.SelectedItem == "ISBN")
                {
                    if ((r.DataBoundItem as Book).Isbn.Contains(textBox1.Text))
                        foundBooks = true;
                }

                if (foundBooks == true)
                {
                    dgvBooks.Rows[r.Index].Visible = true;
                    foundBooks = false;
                }
                else
                {
                    dgvBooks.Rows[r.Index].Visible = false;
                }
            }           

            currencyManager1.ResumeBinding();          
        }

        private void rbShowDataGridView_CheckedChanged(object sender, EventArgs e)
        {
            if(rbShowDataGridView.Checked)
            {
                this.listView.Visible = false;
                this.dgvBooks.Visible = true;
            }
        }

        private void listView_DoubleClick(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count < 1)
                return;

            ListViewItem selectedItem = listView.SelectedItems[0];
            string itemName = selectedItem.ToString();
            int itemIndex = selectedItem.Index;

            ReadBook(itemIndex);
        }

        private void ReadBook(int itemIndex)
        {
            if (itemIndex == -1)
                return;
            CollectionItem collection = _bookCollection.GetCollection(_currentCollectionName);
            Book selectedBook = collection.BookList[itemIndex];
            string bookPath = selectedBook.Path;

            if (bookPath.Length == 0)
                return;

            BookReaderForm brf = new BookReaderForm(bookPath);
            brf.Show();
        }

        private void speichernToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            String savePath = "";
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XML files (*.xml)|*.xml";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                savePath = saveFileDialog.FileName;
            }

            if(savePath != "")
                _bookCollection.SaveCollection(savePath);
        }

        private void ladenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String loadPath = "";
            OpenFileDialog openFileDialoge = new OpenFileDialog();
            openFileDialoge.Filter = "XML files (*.xml)|*.xml";
            if (openFileDialoge.ShowDialog() == DialogResult.OK)
            {
                loadPath = openFileDialoge.FileName;
            }

            if (loadPath != "")
            {
                _bookCollection.LoadCollection(loadPath);
                UpdateBookDataSource(_currentCollectionName);
            }   
        }
    }
}
