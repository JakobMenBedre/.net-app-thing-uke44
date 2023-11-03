namespace app3
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
            this.addisjon = new System.Windows.Forms.Button();
            this.subtraksjon = new System.Windows.Forms.Button();
            this.multiplikasjon = new System.Windows.Forms.Button();
            this.divisjon = new System.Windows.Forms.Button();
            this.resultat = new System.Windows.Forms.Label();
            this.input1 = new System.Windows.Forms.TextBox();
            this.input2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.desimalerlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addisjon
            // 
            this.addisjon.Location = new System.Drawing.Point(538, 83);
            this.addisjon.Name = "addisjon";
            this.addisjon.Size = new System.Drawing.Size(126, 42);
            this.addisjon.TabIndex = 0;
            this.addisjon.Text = "+";
            this.addisjon.UseVisualStyleBackColor = true;
            this.addisjon.Click += new System.EventHandler(this.addisjon_Click);
            // 
            // subtraksjon
            // 
            this.subtraksjon.Location = new System.Drawing.Point(538, 131);
            this.subtraksjon.Name = "subtraksjon";
            this.subtraksjon.Size = new System.Drawing.Size(126, 42);
            this.subtraksjon.TabIndex = 1;
            this.subtraksjon.Text = "-";
            this.subtraksjon.UseVisualStyleBackColor = true;
            this.subtraksjon.Click += new System.EventHandler(this.subtraksjon_Click);
            // 
            // multiplikasjon
            // 
            this.multiplikasjon.Location = new System.Drawing.Point(538, 179);
            this.multiplikasjon.Name = "multiplikasjon";
            this.multiplikasjon.Size = new System.Drawing.Size(126, 42);
            this.multiplikasjon.TabIndex = 2;
            this.multiplikasjon.Text = "*";
            this.multiplikasjon.UseVisualStyleBackColor = true;
            this.multiplikasjon.Click += new System.EventHandler(this.multiplikasjon_Click);
            // 
            // divisjon
            // 
            this.divisjon.Location = new System.Drawing.Point(538, 227);
            this.divisjon.Name = "divisjon";
            this.divisjon.Size = new System.Drawing.Size(126, 42);
            this.divisjon.TabIndex = 3;
            this.divisjon.Text = "/";
            this.divisjon.UseVisualStyleBackColor = true;
            this.divisjon.Click += new System.EventHandler(this.divisjon_Click);
            // 
            // resultat
            // 
            this.resultat.AutoSize = true;
            this.resultat.Location = new System.Drawing.Point(50, 227);
            this.resultat.Name = "resultat";
            this.resultat.Size = new System.Drawing.Size(13, 13);
            this.resultat.TabIndex = 4;
            this.resultat.Text = "0";
            // 
            // input1
            // 
            this.input1.Location = new System.Drawing.Point(53, 83);
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(100, 20);
            this.input1.TabIndex = 5;
            // 
            // input2
            // 
            this.input2.Location = new System.Drawing.Point(53, 131);
            this.input2.Name = "input2";
            this.input2.Size = new System.Drawing.Size(100, 20);
            this.input2.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "0",
            "1",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.comboBox1.Location = new System.Drawing.Point(538, 294);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.Sorted = true;
            this.comboBox1.TabIndex = 7;
            // 
            // desimalerlabel
            // 
            this.desimalerlabel.AutoSize = true;
            this.desimalerlabel.Location = new System.Drawing.Point(339, 294);
            this.desimalerlabel.Name = "desimalerlabel";
            this.desimalerlabel.Size = new System.Drawing.Size(80, 13);
            this.desimalerlabel.TabIndex = 8;
            this.desimalerlabel.Text = "Antall desimaler";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.desimalerlabel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.input2);
            this.Controls.Add(this.input1);
            this.Controls.Add(this.resultat);
            this.Controls.Add(this.divisjon);
            this.Controls.Add(this.multiplikasjon);
            this.Controls.Add(this.subtraksjon);
            this.Controls.Add(this.addisjon);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addisjon;
        private System.Windows.Forms.Button subtraksjon;
        private System.Windows.Forms.Button multiplikasjon;
        private System.Windows.Forms.Button divisjon;
        private System.Windows.Forms.Label resultat;
        private System.Windows.Forms.TextBox input1;
        private System.Windows.Forms.TextBox input2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label desimalerlabel;
    }
}

