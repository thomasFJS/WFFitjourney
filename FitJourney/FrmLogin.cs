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
    public partial class FrmLogin : Form
    {
        static FrmLogin instance;
        private FrmLogin()
        {
            InitializeComponent();
        }

        static public FrmLogin getInstance()
        {
            if (instance is null || instance.IsDisposed)
            {
                instance = new FrmLogin();
            }
            return instance;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            FrmRegister.getInstance().ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtLogin.Text == "admin")
            {
                FrmHome.getInstance().loadView(true);
                
            }
            else
            {
                FrmHome.getInstance().loadView(false);
            }
            this.Close();
        }
    }
}
