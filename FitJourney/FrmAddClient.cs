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
    public partial class FrmAddClient : Form
    {
        public FrmAddClient()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtSurname.Text != null && txtName.Text != null && txtEmail.Text != null && txtDateOfBirth.Text != null) 
            {
                //Add client to database

                MessageBox.Show("Client added");
                this.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
