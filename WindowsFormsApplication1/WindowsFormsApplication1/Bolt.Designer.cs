namespace WindowsFormsApplication1
{
    partial class Bolt
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
            this.btnTorles = new System.Windows.Forms.Button();
            this.btnMentes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNev = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnMegse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUj
            // 
            this.btnUj.Location = new System.Drawing.Point(12, 181);
            this.btnUj.Name = "btnUj";
            this.btnUj.Size = new System.Drawing.Size(75, 23);
            this.btnUj.TabIndex = 0;
            this.btnUj.Text = "Új";
            this.btnUj.UseVisualStyleBackColor = true;
            this.btnUj.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTorles
            // 
            this.btnTorles.Location = new System.Drawing.Point(102, 226);
            this.btnTorles.Name = "btnTorles";
            this.btnTorles.Size = new System.Drawing.Size(75, 23);
            this.btnTorles.TabIndex = 1;
            this.btnTorles.Text = "Törlés";
            this.btnTorles.UseVisualStyleBackColor = true;
            this.btnTorles.Click += new System.EventHandler(this.btnTorles_Click);
            // 
            // btnMentes
            // 
            this.btnMentes.Enabled = false;
            this.btnMentes.Location = new System.Drawing.Point(102, 181);
            this.btnMentes.Name = "btnMentes";
            this.btnMentes.Size = new System.Drawing.Size(75, 23);
            this.btnMentes.TabIndex = 2;
            this.btnMentes.Text = "Mentés";
            this.btnMentes.UseVisualStyleBackColor = true;
            this.btnMentes.Click += new System.EventHandler(this.btnMentes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bolt:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(48, 13);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Név";
            // 
            // txtNev
            // 
            this.txtNev.Location = new System.Drawing.Point(48, 42);
            this.txtNev.Name = "txtNev";
            this.txtNev.Size = new System.Drawing.Size(100, 20);
            this.txtNev.TabIndex = 6;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(12, 226);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 7;
            this.btnNext.Text = "Következő";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(183, 226);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(75, 23);
            this.btnPrev.TabIndex = 8;
            this.btnPrev.Text = "Előző";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnMegse
            // 
            this.btnMegse.Enabled = false;
            this.btnMegse.Location = new System.Drawing.Point(197, 181);
            this.btnMegse.Name = "btnMegse";
            this.btnMegse.Size = new System.Drawing.Size(75, 23);
            this.btnMegse.TabIndex = 9;
            this.btnMegse.Text = "Mégse";
            this.btnMegse.UseVisualStyleBackColor = true;
            this.btnMegse.Click += new System.EventHandler(this.btnMegse_Click);
            // 
            // Bolt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnMegse);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.txtNev);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMentes);
            this.Controls.Add(this.btnTorles);
            this.Controls.Add(this.btnUj);
            this.Name = "Bolt";
            this.Text = "Bolt";
            this.Load += new System.EventHandler(this.Bolt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUj;
        private System.Windows.Forms.Button btnTorles;
        private System.Windows.Forms.Button btnMentes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnMegse;
    }
}