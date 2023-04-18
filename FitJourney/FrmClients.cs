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
    public partial class FrmClients : Form
    {
        bool alreadyOpen;
        public FrmClients()
        {
            InitializeComponent();
        }

        private void dgvClients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvClients.CurrentCell.ColumnIndex.Equals(0) && e.RowIndex != -1)
            {
                if (dgvClients.CurrentCell != null && dgvClients.CurrentCell.Value != null)
                {

                    // MessageBox.Show(dgvClients.CurrentCell.Value.ToString());
                    //Create mock client (Only for navigation testing)
                    FrmClient fClient = new FrmClient(new FitJourney.Client(dgvClients.CurrentCell.Value.ToString(),"Doe"));
                    fClient.MdiParent = this.MdiParent;
                    fClient.Show();
                    int posX = this.Width+130;
                    
                    foreach(Form f in Application.OpenForms)
                    {
                        if(f is FrmClient)
                        {
                            posX += fClient.Size.Width;
                        }
                    }
                    fClient.Location = new Point(this.Width + 130, 0);

                }
                    
            }
        }

        private void FrmClients_Load(object sender, EventArgs e)
        {
            this.dgvClients.Rows.Add("Diogo", "Diogo");
            this.dgvClients.Rows.Add("Thomas", "Thomas");
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            FrmAddClient frmAddClient = new FrmAddClient();
            frmAddClient.MdiParent = this.MdiParent;
            frmAddClient.Show();
            frmAddClient.Location = new Point(this.Location.X, this.Height);
        }
    }
}
