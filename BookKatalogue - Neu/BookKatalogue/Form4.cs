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

        public bibForm()
        {
            InitializeComponent();

            _bookCollection = new Collection();
            //ColumnHeader header = new ColumnHeader();
            //header.Width = lvCollection.Width - 5;
            //header.Text = "";
            //header.Name = "col1";
            //header.Width = lvCollection.Width - 5;
            //lvCollection.Columns.Add(header);

            //lbCollection.DataSource = _bookCollection.GetCollection();
            //lbCollection.DisplayMember = "Name";
            //lbCollection.ValueMember = "BookCount";

        }

        private void suchLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {

        }

        private void hauptfensterToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
        private void button1_Click(object sender, EventArgs e)
        {
            CollectionItem item = new CollectionItem();
            _bookCollection.AddCollectionItem(item);
            
            CollectionItemControl cic = new CollectionItemControl();

            Label lblName = cic.Controls.Find("lblName", true)[0] as Label;
            lblName.Text = item.Name;
            Label lblBookCount = cic.Controls.Find("lblBookCount", true)[0] as Label;
            lblBookCount.Text = item.BookCount.ToString();

            int height = cic.Height;
            int heightGap = 3;
            int totalHeight = height + heightGap;

            int controlCount = pnlCollectionItem.Controls.Count;

            Point controlPosition;
            if (controlCount == 0)
                controlPosition = new Point(4, 4);
            else
                controlPosition = new Point(4, 4 + controlCount * totalHeight);

            cic.Location = controlPosition;
            cicList.Add(cic);

            pnlCollectionItem.Controls.Add(cic);
            ResizeCollectionItems();
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

        private void ResizeCollectionItems()
        {
            int scrollbarWidth = 0;
            if (pnlCollectionItem.VerticalScroll.Visible)
                scrollbarWidth = 15;


            foreach (CollectionItemControl cic in cicList)
            {
                cic.Width = pnlCollectionItem.Width - 10 - scrollbarWidth;
            }
        }

        private void dGVBuch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
