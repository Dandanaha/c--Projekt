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
    public partial class BookReaderForm : Form
    {
        string _bookPath = "";

        public BookReaderForm(string bookPath)
        {
            this._bookPath = bookPath;
            InitializeComponent();

            Console.WriteLine(
                _bookPath
            );

            axAcroPDF1.LoadFile(_bookPath);
        }
    }
}
