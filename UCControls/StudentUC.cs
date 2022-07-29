using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UCControls
{
    public partial class StudentUC : UserControl
    {
        private string no;

        public string No
        {
            get { return noLbl.Text; }
            set { noLbl.Text=value; }
        }

        private string fullname;

        public string Fullname
        {
            get { return fullnameLbl.Text; }
            set { fullnameLbl.Text = value; }
        }

        private string age;

        public string Age
        {
            get { return ageLbl.Text; }
            set { ageLbl.Text = value; }
        }

        public StudentUC()
        {
            InitializeComponent();

            this.Click += StudentUC_Click;
        }

        private void StudentUC_Click(object sender, EventArgs e)
        {
             var uc=sender as StudentUC;
            MessageBox.Show(uc.Fullname);
        }
    }
}
