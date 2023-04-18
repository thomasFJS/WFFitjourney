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
    public partial class FrmHome : Form
    {
        public Client user;
        static FrmHome instance;
        private FrmHome()
        {
            InitializeComponent();
        }


        static public FrmHome getInstance()
        {
            if (instance is null || instance.IsDisposed)
            {
                instance = new FrmHome();

            }
            return instance;
        }
        private void frmHome_Load(object sender, EventArgs e)
        {
            // FrmClients frmClients = new FrmClients();
            // frmClients.MdiParent = this;
            // FrmNextSession frmNextSession = new FrmNextSession();
            // frmNextSession.MdiParent = this;
            // frmClients.Show();
            // frmNextSession.Show();
            // FrmMenu fMenu = new FrmMenu();
            // fMenu.MdiParent = this;
            // fMenu.Show(
            instance.Size = new Size(1400, 800);
            instance.CenterToScreen();
 
           FrmLogin fLogin = FrmLogin.getInstance();
           fLogin.ShowDialog();
        }

        public void loadView(bool isAdmin)
        {
            if(isAdmin)
            {         
                FrmMenu fMenu = new FrmMenu();    
                fMenu.MdiParent = this;
                fMenu.Show();
                user = new Client("Test", "test", true);
            }
            else
            {
              FrmMenuClient fMenu = new FrmMenuClient();
                fMenu.MdiParent = this;
                fMenu.Show();
                user = new Client("Test", "test", false);
            }
        }
        private void btnAddClient_Click(object sender, EventArgs e)
        {

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMenu fMenu = new FrmMenu();
            fMenu.MdiParent = this;
     
            fMenu.Show();
        }
    }
}
