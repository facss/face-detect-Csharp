using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FaceDetect
{
    public partial class Subwindows : Form
    {
        public Subwindows()
        {
            InitializeComponent();
        }
        public  int size = 3;

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtSize.Text !="")
            {
                size =int.Parse( txtSize.Text);
            }
            this.Close();
        }
    }
}
