namespace wypożyczalnia_pracownik
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.buttonLewo4 = new System.Windows.Forms.Button();
            this.buttonPrawo4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxListaSamochdów4 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonLewo4
            // 
            this.buttonLewo4.Location = new System.Drawing.Point(261, 206);
            this.buttonLewo4.Name = "buttonLewo4";
            this.buttonLewo4.Size = new System.Drawing.Size(106, 52);
            this.buttonLewo4.TabIndex = 45;
            this.buttonLewo4.Text = "<";
            this.buttonLewo4.UseVisualStyleBackColor = true;
            // 
            // buttonPrawo4
            // 
            this.buttonPrawo4.Location = new System.Drawing.Point(368, 206);
            this.buttonPrawo4.Name = "buttonPrawo4";
            this.buttonPrawo4.Size = new System.Drawing.Size(106, 52);
            this.buttonPrawo4.TabIndex = 44;
            this.buttonPrawo4.Text = ">";
            this.buttonPrawo4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(265, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "Numer Garażu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "lokalizacja";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "Lista samochodów";
            // 
            // listBoxListaSamochdów4
            // 
            this.listBoxListaSamochdów4.FormattingEnabled = true;
            this.listBoxListaSamochdów4.Location = new System.Drawing.Point(368, 100);
            this.listBoxListaSamochdów4.Name = "listBoxListaSamochdów4";
            this.listBoxListaSamochdów4.Size = new System.Drawing.Size(120, 95);
            this.listBoxListaSamochdów4.TabIndex = 49;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(760, 313);
            this.Controls.Add(this.listBoxListaSamochdów4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonLewo4);
            this.Controls.Add(this.buttonPrawo4);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLewo4;
        private System.Windows.Forms.Button buttonPrawo4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxListaSamochdów4;
    }
}