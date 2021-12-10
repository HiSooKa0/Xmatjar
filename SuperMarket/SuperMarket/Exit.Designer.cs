
namespace SuperMarket
{
    partial class Exit
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.Close = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Stay = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.guna2CustomGradientPanel1);
            this.panel1.Controls.Add(this.Close);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Stay);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(586, 191);
            this.panel1.TabIndex = 6;
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BackColor = System.Drawing.Color.Black;
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.SystemColors.Highlight;
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.SystemColors.Highlight;
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.SystemColors.Highlight;
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.SystemColors.Highlight;
            this.guna2CustomGradientPanel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, 162);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.ShadowDecoration.Parent = this.guna2CustomGradientPanel1;
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(585, 28);
            this.guna2CustomGradientPanel1.TabIndex = 9;
            // 
            // Close
            // 
            this.Close.BorderRadius = 3;
            this.Close.BorderThickness = 1;
            this.Close.CheckedState.Parent = this.Close;
            this.Close.CustomImages.Parent = this.Close;
            this.Close.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Close.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Close.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Close.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Close.DisabledState.Parent = this.Close;
            this.Close.FillColor = System.Drawing.Color.White;
            this.Close.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F);
            this.Close.ForeColor = System.Drawing.Color.Black;
            this.Close.HoverState.Parent = this.Close;
            this.Close.Location = new System.Drawing.Point(192, 85);
            this.Close.Name = "Close";
            this.Close.ShadowDecoration.Parent = this.Close;
            this.Close.Size = new System.Drawing.Size(81, 37);
            this.Close.TabIndex = 8;
            this.Close.Text = "Yes";
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(150, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Are you sure you want to exit ?";
            // 
            // Stay
            // 
            this.Stay.BorderRadius = 3;
            this.Stay.BorderThickness = 1;
            this.Stay.CheckedState.Parent = this.Stay;
            this.Stay.CustomImages.Parent = this.Stay;
            this.Stay.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Stay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Stay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Stay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Stay.DisabledState.Parent = this.Stay;
            this.Stay.FillColor = System.Drawing.Color.Silver;
            this.Stay.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stay.ForeColor = System.Drawing.Color.Black;
            this.Stay.HoverState.Parent = this.Stay;
            this.Stay.Location = new System.Drawing.Point(303, 85);
            this.Stay.Name = "Stay";
            this.Stay.ShadowDecoration.Parent = this.Stay;
            this.Stay.Size = new System.Drawing.Size(82, 37);
            this.Stay.TabIndex = 6;
            this.Stay.Text = "No";
            this.Stay.Click += new System.EventHandler(this.Stay_Click);
            // 
            // Exit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(587, 192);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Exit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exit";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2Button Close;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button Stay;
    }
}