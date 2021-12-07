using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Code_for_Education
{
    public partial class SearchItem : UserControl
    {
        public SearchItem()
        {
            InitializeComponent();
        }

        #region Properties
        private string _Autor;

        public  String Autor
        {
            get { return _Autor; }
            set { _Autor = value; lblAutor.Text = value; }
        }

        private String _Descri;

        public String Descri
        {
            get { return _Descri; }
            set { _Descri = value; lblDescri.Text = value; }
        }



        #endregion

        private void SearchItem_Click(object sender, EventArgs e)
        {

        }
    }
}
