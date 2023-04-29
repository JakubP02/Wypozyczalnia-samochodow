
namespace WypozyczalniaSamochodow
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.buttonPowrot7 = new System.Windows.Forms.Button();
            this.labelRegulamin7 = new System.Windows.Forms.Label();
            this.labelRegulaminSzczegoly7 = new System.Windows.Forms.Label();
            this.buttonRejestracjaZmianaJezyk7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pictureBox2.Enabled = false;
            this.pictureBox2.Location = new System.Drawing.Point(50, 60);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(512, 578);
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // buttonPowrot7
            // 
            this.buttonPowrot7.BackColor = System.Drawing.Color.White;
            this.buttonPowrot7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonPowrot7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonPowrot7.FlatAppearance.BorderSize = 0;
            this.buttonPowrot7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPowrot7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F);
            this.buttonPowrot7.ForeColor = System.Drawing.Color.Black;
            this.buttonPowrot7.Location = new System.Drawing.Point(12, 669);
            this.buttonPowrot7.Name = "buttonPowrot7";
            this.buttonPowrot7.Size = new System.Drawing.Size(176, 53);
            this.buttonPowrot7.TabIndex = 29;
            this.buttonPowrot7.Text = "POWROT";
            this.buttonPowrot7.UseVisualStyleBackColor = false;
            this.buttonPowrot7.Click += new System.EventHandler(this.buttonPowrot7_Click);
            // 
            // labelRegulamin7
            // 
            this.labelRegulamin7.AutoSize = true;
            this.labelRegulamin7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F);
            this.labelRegulamin7.ForeColor = System.Drawing.Color.White;
            this.labelRegulamin7.Location = new System.Drawing.Point(213, 22);
            this.labelRegulamin7.Name = "labelRegulamin7";
            this.labelRegulamin7.Size = new System.Drawing.Size(201, 34);
            this.labelRegulamin7.TabIndex = 33;
            this.labelRegulamin7.Text = "REGULAMIN";
            // 
            // labelRegulaminSzczegoly7
            // 
            this.labelRegulaminSzczegoly7.AutoSize = true;
            this.labelRegulaminSzczegoly7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labelRegulaminSzczegoly7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegulaminSzczegoly7.ForeColor = System.Drawing.Color.White;
            this.labelRegulaminSzczegoly7.Location = new System.Drawing.Point(66, 74);
            this.labelRegulaminSzczegoly7.Name = "labelRegulaminSzczegoly7";
            this.labelRegulaminSzczegoly7.Size = new System.Drawing.Size(75, 224);
            this.labelRegulaminSzczegoly7.TabIndex = 34;
            this.labelRegulaminSzczegoly7.Text = "1. ...\r\n2. ...\r\n3. ...\r\n4. ...\r\n5. ...\r\n6. ...\r\n7. ...";
            // 
            // buttonRejestracjaZmianaJezyk7
            // 
            this.buttonRejestracjaZmianaJezyk7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonRejestracjaZmianaJezyk7.Image = ((System.Drawing.Image)(resources.GetObject("buttonRejestracjaZmianaJezyk7.Image")));
            this.buttonRejestracjaZmianaJezyk7.Location = new System.Drawing.Point(551, 5);
            this.buttonRejestracjaZmianaJezyk7.Name = "buttonRejestracjaZmianaJezyk7";
            this.buttonRejestracjaZmianaJezyk7.Size = new System.Drawing.Size(85, 46);
            this.buttonRejestracjaZmianaJezyk7.TabIndex = 35;
            this.buttonRejestracjaZmianaJezyk7.UseVisualStyleBackColor = true;
            this.buttonRejestracjaZmianaJezyk7.Click += new System.EventHandler(this.buttonRejestracjaZmianaJezyk7_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(640, 734);
            this.Controls.Add(this.buttonRejestracjaZmianaJezyk7);
            this.Controls.Add(this.labelRegulaminSzczegoly7);
            this.Controls.Add(this.labelRegulamin7);
            this.Controls.Add(this.buttonPowrot7);
            this.Controls.Add(this.pictureBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form7";
            this.Text = "REGULAMIN";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button buttonPowrot7;
        private System.Windows.Forms.Label labelRegulamin7;
        private System.Windows.Forms.Label labelRegulaminSzczegoly7;
        private System.Windows.Forms.Button buttonRejestracjaZmianaJezyk7;
    }
}