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
    public partial class FrmMenuClient : Form
    {
        Form actualForm;
        public FrmMenuClient()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.MdiParent.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (actualForm != null)
            {
                actualForm.Close();
            }
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            if(actualForm != null) { 
            actualForm.Close();
            }
            //Use client connected (mock client until database is implemented)
            FrmClient fClient = new FrmClient(new Client("Fujise","Thomas"));
            fClient.MdiParent = this.MdiParent;
            fClient.Show();
            fClient.Location = new Point(this.Width, 0);
            actualForm = fClient;
        }

        private void btnWorkout_Click(object sender, EventArgs e)
        {
            //Download pdf or display it 
            MessageBox.Show("Workout program downloaded");
        }

        private void btnDiet_Click(object sender, EventArgs e)
        {
            //Download pdf or display it 
            MessageBox.Show("Diet program downloaded");
        }

        private void FrmMenuClient_Load(object sender, EventArgs e)
        {
            this.Size = new Size(this.Size.Width, 800);
        }
    }
}
