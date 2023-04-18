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
    public partial class FrmClient : Form
    {
        Client client;
        public FrmClient(Client c)
        {
            InitializeComponent();
            client = c;
        }

        private void FrmClient_Load(object sender, EventArgs e)
        {
            txtName.Text = client.Name;
            txtSurname.Text = client.Surname;
            if (FrmHome.getInstance().user.IsAdmin)
            {
                btnAddDiet.Enabled = true;
                btnAddDiet.Visible = true;
                btnAddWorkout.Enabled = true;
                btnAddWorkout.Visible = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Save new info in database
            MessageBox.Show("Infos saved");
        }

        private void btnAddWorkout_Click(object sender, EventArgs e)
        {
            //Add pdf 
            if (ofdProgram.ShowDialog() == DialogResult.OK)
            {
                string fileName = this.ofdProgram.FileName;

                MessageBox.Show(fileName);
            }


        }

        private void btnAddDiet_Click(object sender, EventArgs e)
        {
            //Add pdf 
            if (ofdProgram.ShowDialog() == DialogResult.OK)
            {
                string fileName = this.ofdProgram.FileName;

                MessageBox.Show(fileName);
            }
        }
    }
}
