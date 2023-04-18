namespace FitJourney
{
    partial class FrmMenuClient
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnWorkout = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnDiet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(2, 645);
            this.btnClose.Margin = new System.Windows.Forms.Padding(6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(228, 44);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnWorkout
            // 
            this.btnWorkout.Location = new System.Drawing.Point(2, 230);
            this.btnWorkout.Margin = new System.Windows.Forms.Padding(6);
            this.btnWorkout.Name = "btnWorkout";
            this.btnWorkout.Size = new System.Drawing.Size(228, 44);
            this.btnWorkout.TabIndex = 6;
            this.btnWorkout.Text = "Workouts";
            this.btnWorkout.UseVisualStyleBackColor = true;
            this.btnWorkout.Click += new System.EventHandler(this.btnWorkout_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.Location = new System.Drawing.Point(2, 157);
            this.btnProfile.Margin = new System.Windows.Forms.Padding(6);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(228, 44);
            this.btnProfile.TabIndex = 5;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(2, 72);
            this.btnHome.Margin = new System.Windows.Forms.Padding(6);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(228, 44);
            this.btnHome.TabIndex = 4;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnDiet
            // 
            this.btnDiet.Location = new System.Drawing.Point(2, 299);
            this.btnDiet.Margin = new System.Windows.Forms.Padding(6);
            this.btnDiet.Name = "btnDiet";
            this.btnDiet.Size = new System.Drawing.Size(228, 44);
            this.btnDiet.TabIndex = 8;
            this.btnDiet.Text = "Diet";
            this.btnDiet.UseVisualStyleBackColor = true;
            this.btnDiet.Click += new System.EventHandler(this.btnDiet_Click);
            // 
            // FrmMenuClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(234, 731);
            this.Controls.Add(this.btnDiet);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnWorkout);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.btnHome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMenuClient";
            this.Text = "FrmMenuClient";
            this.Load += new System.EventHandler(this.FrmMenuClient_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnWorkout;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnDiet;
    }
}