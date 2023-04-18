namespace FitJourney
{
    partial class FrmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnHome = new System.Windows.Forms.Button();
            this.btnNextSession = new System.Windows.Forms.Button();
            this.btnClients = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(15, 152);
            this.btnHome.Margin = new System.Windows.Forms.Padding(6);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(228, 44);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            // 
            // btnNextSession
            // 
            this.btnNextSession.Location = new System.Drawing.Point(15, 237);
            this.btnNextSession.Margin = new System.Windows.Forms.Padding(6);
            this.btnNextSession.Name = "btnNextSession";
            this.btnNextSession.Size = new System.Drawing.Size(228, 44);
            this.btnNextSession.TabIndex = 1;
            this.btnNextSession.Text = "Next Session";
            this.btnNextSession.UseVisualStyleBackColor = true;
            this.btnNextSession.Click += new System.EventHandler(this.btnNextSession_Click);
            // 
            // btnClients
            // 
            this.btnClients.Location = new System.Drawing.Point(15, 312);
            this.btnClients.Margin = new System.Windows.Forms.Padding(6);
            this.btnClients.Name = "btnClients";
            this.btnClients.Size = new System.Drawing.Size(228, 44);
            this.btnClients.TabIndex = 2;
            this.btnClients.Text = "Clients";
            this.btnClients.UseVisualStyleBackColor = true;
            this.btnClients.Click += new System.EventHandler(this.btnClients_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(15, 725);
            this.btnClose.Margin = new System.Windows.Forms.Padding(6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(228, 44);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkViolet;
            this.ClientSize = new System.Drawing.Size(260, 802);
            this.ControlBox = false;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClients);
            this.Controls.Add(this.btnNextSession);
            this.Controls.Add(this.btnHome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmMenu";
            this.Text = "FrmMenu";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnNextSession;
        private System.Windows.Forms.Button btnClients;
        private System.Windows.Forms.Button btnClose;
    }
}