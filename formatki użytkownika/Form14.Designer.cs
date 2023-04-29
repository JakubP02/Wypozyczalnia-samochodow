
namespace WypozyczalniaSamochodow
{
    partial class Form14
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form14));
            this.labelPotwierdzenie14 = new System.Windows.Forms.Label();
            this.labelDziekujemy14 = new System.Windows.Forms.Label();
            this.buttonOk14 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelPotwierdzenie14
            // 
            this.labelPotwierdzenie14.AutoSize = true;
            this.labelPotwierdzenie14.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F);
            this.labelPotwierdzenie14.ForeColor = System.Drawing.Color.White;
            this.labelPotwierdzenie14.Location = new System.Drawing.Point(14, 94);
            this.labelPotwierdzenie14.Name = "labelPotwierdzenie14";
            this.labelPotwierdzenie14.Size = new System.Drawing.Size(301, 102);
            this.labelPotwierdzenie14.TabIndex = 40;
            this.labelPotwierdzenie14.Text = "TWOJA PLATNOSC\r\nZOSTALA\r\nZATWIERDZONA";
            this.labelPotwierdzenie14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDziekujemy14
            // 
            this.labelDziekujemy14.AutoSize = true;
            this.labelDziekujemy14.Font = new System.Drawing.Font("Arial Rounded MT Bold", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDziekujemy14.ForeColor = System.Drawing.Color.White;
            this.labelDziekujemy14.Location = new System.Drawing.Point(32, 9);
            this.labelDziekujemy14.Name = "labelDziekujemy14";
            this.labelDziekujemy14.Size = new System.Drawing.Size(283, 44);
            this.labelDziekujemy14.TabIndex = 41;
            this.labelDziekujemy14.Text = "DZIEKUJEMY!";
            this.labelDziekujemy14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonOk14
            // 
            this.buttonOk14.BackColor = System.Drawing.Color.White;
            this.buttonOk14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonOk14.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonOk14.FlatAppearance.BorderSize = 0;
            this.buttonOk14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOk14.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOk14.ForeColor = System.Drawing.Color.Black;
            this.buttonOk14.Location = new System.Drawing.Point(105, 224);
            this.buttonOk14.Name = "buttonOk14";
            this.buttonOk14.Size = new System.Drawing.Size(102, 55);
            this.buttonOk14.TabIndex = 45;
            this.buttonOk14.Text = "OK";
            this.buttonOk14.UseVisualStyleBackColor = false;
            this.buttonOk14.Click += new System.EventHandler(this.buttonOk14_Click);
            // 
            // Form14
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(326, 307);
            this.Controls.Add(this.buttonOk14);
            this.Controls.Add(this.labelDziekujemy14);
            this.Controls.Add(this.labelPotwierdzenie14);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form14";
            this.Text = "DZIĘKUJEMY";
            this.Load += new System.EventHandler(this.Form14_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPotwierdzenie14;
        private System.Windows.Forms.Label labelDziekujemy14;
        private System.Windows.Forms.Button buttonOk14;
    }
}