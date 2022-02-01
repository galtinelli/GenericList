
namespace GenericList
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
            this.btnElemanEkle = new System.Windows.Forms.Button();
            this.btnDongu = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnContains = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnElemanEkle
            // 
            this.btnElemanEkle.Location = new System.Drawing.Point(69, 12);
            this.btnElemanEkle.Name = "btnElemanEkle";
            this.btnElemanEkle.Size = new System.Drawing.Size(332, 45);
            this.btnElemanEkle.TabIndex = 0;
            this.btnElemanEkle.Text = "Eleman Ekle";
            this.btnElemanEkle.UseVisualStyleBackColor = true;
            this.btnElemanEkle.Click += new System.EventHandler(this.btnElemanEkle_Click);
            // 
            // btnDongu
            // 
            this.btnDongu.Location = new System.Drawing.Point(69, 63);
            this.btnDongu.Name = "btnDongu";
            this.btnDongu.Size = new System.Drawing.Size(332, 45);
            this.btnDongu.TabIndex = 1;
            this.btnDongu.Text = "Döngü İle Kullanımı";
            this.btnDongu.UseVisualStyleBackColor = true;
            this.btnDongu.Click += new System.EventHandler(this.btnDongu_Click);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(69, 114);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(332, 45);
            this.btnSort.TabIndex = 2;
            this.btnSort.Text = "Sort Metodu";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnContains
            // 
            this.btnContains.Location = new System.Drawing.Point(69, 165);
            this.btnContains.Name = "btnContains";
            this.btnContains.Size = new System.Drawing.Size(332, 45);
            this.btnContains.TabIndex = 3;
            this.btnContains.Text = "Contains Metodu";
            this.btnContains.UseVisualStyleBackColor = true;
            this.btnContains.Click += new System.EventHandler(this.btnContains_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 239);
            this.Controls.Add(this.btnContains);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnDongu);
            this.Controls.Add(this.btnElemanEkle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnElemanEkle;
        private System.Windows.Forms.Button btnDongu;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnContains;
    }
}

