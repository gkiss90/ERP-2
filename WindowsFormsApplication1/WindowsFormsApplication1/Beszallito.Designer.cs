namespace WindowsFormsApplication1
{
    partial class Beszallito
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
            this.btnUj = new System.Windows.Forms.Button();
            this.btnMentes = new System.Windows.Forms.Button();
            this.btnMegse = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnTorles = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNev = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnMod = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUj
            // 
            this.btnUj.Location = new System.Drawing.Point(12, 174);
            this.btnUj.Name = "btnUj";
            this.btnUj.Size = new System.Drawing.Size(75, 23);
            this.btnUj.TabIndex = 0;
            this.btnUj.Text = "Új";
            this.btnUj.UseVisualStyleBackColor = true;
            this.btnUj.Click += new System.EventHandler(this.btnUj_Click);
            // 
            // btnMentes
            // 
            this.btnMentes.Enabled = false;
            this.btnMentes.Location = new System.Drawing.Point(102, 174);
            this.btnMentes.Name = "btnMentes";
            this.btnMentes.Size = new System.Drawing.Size(75, 23);
            this.btnMentes.TabIndex = 1;
            this.btnMentes.Text = "Mentés";
            this.btnMentes.UseVisualStyleBackColor = true;
            this.btnMentes.Click += new System.EventHandler(this.btnMentes_Click);
            // 
            // btnMegse
            // 
            this.btnMegse.Enabled = false;
            this.btnMegse.Location = new System.Drawing.Point(197, 174);
            this.btnMegse.Name = "btnMegse";
            this.btnMegse.Size = new System.Drawing.Size(75, 23);
            this.btnMegse.TabIndex = 2;
            this.btnMegse.Text = "Mégse";
            this.btnMegse.UseVisualStyleBackColor = true;
            this.btnMegse.Click += new System.EventHandler(this.btnMegse_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(197, 90);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Következő";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Visible = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnTorles
            // 
            this.btnTorles.Location = new System.Drawing.Point(12, 216);
            this.btnTorles.Name = "btnTorles";
            this.btnTorles.Size = new System.Drawing.Size(75, 23);
            this.btnTorles.TabIndex = 4;
            this.btnTorles.Text = "Törlés";
            this.btnTorles.UseVisualStyleBackColor = true;
            this.btnTorles.Click += new System.EventHandler(this.btnTorles_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(197, 53);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(75, 23);
            this.btnPrev.TabIndex = 5;
            this.btnPrev.Text = "Előző";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Visible = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(69, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(203, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Beszallito";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(69, 53);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Név";
            // 
            // txtNev
            // 
            this.txtNev.Location = new System.Drawing.Point(69, 95);
            this.txtNev.Name = "txtNev";
            this.txtNev.Size = new System.Drawing.Size(100, 20);
            this.txtNev.TabIndex = 11;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(69, 132);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Aktív";
            // 
            // btnMod
            // 
            this.btnMod.Location = new System.Drawing.Point(102, 216);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(75, 23);
            this.btnMod.TabIndex = 14;
            this.btnMod.Text = "Módosít";
            this.btnMod.UseVisualStyleBackColor = true;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // Beszallito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.txtNev);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnTorles);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnMegse);
            this.Controls.Add(this.btnMentes);
            this.Controls.Add(this.btnUj);
            this.Name = "Beszallito";
            this.Text = "Beszallito";
            this.Load += new System.EventHandler(this.Beszallito_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUj;
        private System.Windows.Forms.Button btnMentes;
        private System.Windows.Forms.Button btnMegse;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnTorles;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNev;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnMod;
    }
}