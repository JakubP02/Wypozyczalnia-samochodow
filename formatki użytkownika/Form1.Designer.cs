namespace WypozyczalniaSamochodow
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ButtonZaloguj1 = new System.Windows.Forms.Button();
            this.ButtonZarejestruj1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonRejestracjaZmianaJezyk1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.buttonWyjdź1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonZaloguj1
            // 
            this.ButtonZaloguj1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ButtonZaloguj1.Location = new System.Drawing.Point(123, 292);
            this.ButtonZaloguj1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonZaloguj1.Name = "ButtonZaloguj1";
            this.ButtonZaloguj1.Size = new System.Drawing.Size(411, 80);
            this.ButtonZaloguj1.TabIndex = 7;
            this.ButtonZaloguj1.Text = "Zaloguj się";
            this.ButtonZaloguj1.UseVisualStyleBackColor = true;
            this.ButtonZaloguj1.Click += new System.EventHandler(this.ButtonZaloguj1_Click);
            // 
            // ButtonZarejestruj1
            // 
            this.ButtonZarejestruj1.Location = new System.Drawing.Point(123, 414);
            this.ButtonZarejestruj1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonZarejestruj1.Name = "ButtonZarejestruj1";
            this.ButtonZarejestruj1.Size = new System.Drawing.Size(411, 76);
            this.ButtonZarejestruj1.TabIndex = 6;
            this.ButtonZarejestruj1.Text = "k";
            this.ButtonZarejestruj1.UseVisualStyleBackColor = true;
            this.ButtonZarejestruj1.Click += new System.EventHandler(this.ButtonZarejestruj1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Location = new System.Drawing.Point(-92, 254);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(799, 279);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // buttonRejestracjaZmianaJezyk1
            // 
            this.buttonRejestracjaZmianaJezyk1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonRejestracjaZmianaJezyk1.Image = ((System.Drawing.Image)(resources.GetObject("buttonRejestracjaZmianaJezyk1.Image")));
            this.buttonRejestracjaZmianaJezyk1.Location = new System.Drawing.Point(549, 7);
            this.buttonRejestracjaZmianaJezyk1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRejestracjaZmianaJezyk1.Name = "buttonRejestracjaZmianaJezyk1";
            this.buttonRejestracjaZmianaJezyk1.Size = new System.Drawing.Size(85, 46);
            this.buttonRejestracjaZmianaJezyk1.TabIndex = 21;
            this.buttonRejestracjaZmianaJezyk1.Tag = "Ang";
            this.buttonRejestracjaZmianaJezyk1.UseVisualStyleBackColor = true;
            this.buttonRejestracjaZmianaJezyk1.Click += new System.EventHandler(this.buttonRejestracjaZmianaJezyk1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(121, 33);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(412, 214);
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // buttonWyjdź1
            // 
            this.buttonWyjdź1.Location = new System.Drawing.Point(48, 674);
            this.buttonWyjdź1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonWyjdź1.Name = "buttonWyjdź1";
            this.buttonWyjdź1.Size = new System.Drawing.Size(537, 28);
            this.buttonWyjdź1.TabIndex = 23;
            this.buttonWyjdź1.Text = "Wyjdź";
            this.buttonWyjdź1.UseVisualStyleBackColor = true;
            this.buttonWyjdź1.Click += new System.EventHandler(this.buttonWyjdź1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(640, 734);
            this.Controls.Add(this.buttonWyjdź1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.buttonRejestracjaZmianaJezyk1);
            this.Controls.Add(this.ButtonZaloguj1);
            this.Controls.Add(this.ButtonZarejestruj1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "EKRAN STARTOWY";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ButtonZaloguj1;
        private System.Windows.Forms.Button ButtonZarejestruj1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonRejestracjaZmianaJezyk1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button buttonWyjdź1;
    }
}