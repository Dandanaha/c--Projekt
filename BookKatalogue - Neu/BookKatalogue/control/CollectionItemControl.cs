using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookKatalogue.model;

namespace BookKatalogue.controll
{
    public partial class CollectionItemControl : UserControl
    {
        private CollectionItem item = null;

        public CollectionItemControl(CollectionItem item)
        {
            this.item = item;        
            InitializeComponent();
        }


        private void tbName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                tbName.ReadOnly = true;                
                tbName.SelectionLength = 0;
                tbName.Enabled = false;
                item.Name = tbName.Text;
            }                
        }
    }
}
