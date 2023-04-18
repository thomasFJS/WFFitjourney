using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitJourney
{
    public partial class FrmRegister : Form
    {
        static FrmRegister instance;
        private FrmRegister()
        {
            InitializeComponent();
        }

        static public FrmRegister getInstance()
        {
            if(instance is null || instance.IsDisposed)
            {
                instance = new FrmRegister();

            }
            return instance;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FrmLogin.getInstance().Focus();
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

        }
    }
}
