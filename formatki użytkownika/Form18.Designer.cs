
namespace WypozyczalniaSamochodow
{
    partial class Form18
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
            this.buttonZostaję18 = new System.Windows.Forms.Button();
            this.buttonWyloguj18 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonZostaję18
            // 
            this.buttonZostaję18.Location = new System.Drawing.Point(30, 40);
            this.buttonZostaję18.Name = "buttonZostaję18";
            this.buttonZostaję18.Size = new System.Drawing.Size(149, 23);
            this.buttonZostaję18.TabIndex = 0;
            this.buttonZostaję18.Text = "Zostaje ";
            this.buttonZostaję18.UseVisualStyleBackColor = true;
            this.buttonZostaję18.Click += new System.EventHandler(this.buttonZostaję18_Click);
            // 
            // buttonWyloguj18
            // 
            this.buttonWyloguj18.Location = new System.Drawing.Point(211, 40);
            this.buttonWyloguj18.Name = "buttonWyloguj18";
            this.buttonWyloguj18.Size = new System.Drawing.Size(149, 23);
            this.buttonWyloguj18.TabIndex = 1;
            this.buttonWyloguj18.Text = "Wyloguj";
            this.buttonWyloguj18.UseVisualStyleBackColor = true;
            this.buttonWyloguj18.Click += new System.EventHandler(this.buttonWyloguj18_Click);
            // 
            // Form18
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(413, 77);
            this.Controls.Add(this.buttonWyloguj18);
            this.Controls.Add(this.buttonZostaję18);
            this.Name = "Form18";
            this.Text = "Form18";
            this.Load += new System.EventHandler(this.Form18_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonZostaję18;
        private System.Windows.Forms.Button buttonWyloguj18;
    }
}