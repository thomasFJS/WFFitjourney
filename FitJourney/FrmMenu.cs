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
    public partial class FrmMenu : Form
    {
        Form actualForm;
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            if(actualForm != null)
            {
                actualForm.Close();
            }
            FrmClients frmClients = new FrmClients();
            
            frmClients.MdiParent = this.MdiParent;
           
            frmClients.Show();
            frmClients.Location = new Point(this.Size.Width , 0);
            actualForm = frmClients;
        }

        private void btnNextSession_Click(object sender, EventArgs e)
        {
            if (actualForm != null)
            {
                actualForm.Close();
            }
            FrmNextSession frmNextSession = new FrmNextSession();
            frmNextSession.MdiParent = this.MdiParent;
            frmNextSession.Show();
            frmNextSession.Location = new Point(this.Size.Width, 0);
            actualForm = frmNextSession;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.MdiParent.Close();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            this.Size = new Size(this.Size.Width, 800);
        }
    }
}
