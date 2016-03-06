namespace WindowsFormsApplication1
{
    partial class Termek
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
            this.comboTermek = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBeszallito = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNev = new System.Windows.Forms.TextBox();
            this.Név = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEAN = new System.Windows.Forms.TextBox();
            this.btnUj = new System.Windows.Forms.Button();
            this.btnMentes = new System.Windows.Forms.Button();
            this.btnMegse = new System.Windows.Forms.Button();
            this.btnTorles = new System.Windows.Forms.Button();
            this.btnModosit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBoxArulhato = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBoxRendelheto = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboTermek
            // 
            this.comboTermek.FormattingEnabled = true;
            this.comboTermek.Location = new System.Drawing.Point(77, 13);
            this.comboTermek.Name = "comboTermek";
            this.comboTermek.Size = new System.Drawing.Size(121, 21);
            this.comboTermek.TabIndex = 0;
            this.comboTermek.SelectedIndexChanged += new System.EventHandler(this.comboTermek_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Termék:";
            // 
            // comboBeszallito
            // 
            this.comboBeszallito.FormattingEnabled = true;
            this.comboBeszallito.Location = new System.Drawing.Point(77, 128);
            this.comboBeszallito.Name = "comboBeszallito";
            this.comboBeszallito.Size = new System.Drawing.Size(121, 21);
            this.comboBeszallito.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Beszállító";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(77, 47);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 5;
            // 
            // txtNev
            // 
            this.txtNev.Location = new System.Drawing.Point(77, 74);
            this.txtNev.Name = "txtNev";
            this.txtNev.Size = new System.Drawing.Size(100, 20);
            this.txtNev.TabIndex = 6;
            // 
            // Név
            // 
            this.Név.AutoSize = true;
            this.Név.Location = new System.Drawing.Point(19, 74);
            this.Név.Name = "Név";
            this.Név.Size = new System.Drawing.Size(27, 13);
            this.Név.TabIndex = 7;
            this.Név.Text = "Név";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "EAN";
            // 
            // txtEAN
            // 
            this.txtEAN.Location = new System.Drawing.Point(77, 101);
            this.txtEAN.Name = "txtEAN";
            this.txtEAN.Size = new System.Drawing.Size(100, 20);
            this.txtEAN.TabIndex = 9;
            // 
            // btnUj
            // 
            this.btnUj.Location = new System.Drawing.Point(16, 257);
            this.btnUj.Name = "btnUj";
            this.btnUj.Size = new System.Drawing.Size(75, 23);
            this.btnUj.TabIndex = 10;
            this.btnUj.Text = "Új";
            this.btnUj.UseVisualStyleBackColor = true;
            this.btnUj.Click += new System.EventHandler(this.btnUj_Click);
            // 
            // btnMentes
            // 
            this.btnMentes.Location = new System.Drawing.Point(123, 257);
            this.btnMentes.Name = "btnMentes";
            this.btnMentes.Size = new System.Drawing.Size(75, 23);
            this.btnMentes.TabIndex = 11;
            this.btnMentes.Text = "Mentés";
            this.btnMentes.UseVisualStyleBackColor = true;
            this.btnMentes.Click += new System.EventHandler(this.btnMentes_Click);
            // 
            // btnMegse
            // 
            this.btnMegse.Location = new System.Drawing.Point(229, 257);
            this.btnMegse.Name = "btnMegse";
            this.btnMegse.Size = new System.Drawing.Size(75, 23);
            this.btnMegse.TabIndex = 12;
            this.btnMegse.Text = "Mégse";
            this.btnMegse.UseVisualStyleBackColor = true;
            this.btnMegse.Click += new System.EventHandler(this.btnMegse_Click);
            // 
            // btnTorles
            // 
            this.btnTorles.Location = new System.Drawing.Point(22, 310);
            this.btnTorles.Name = "btnTorles";
            this.btnTorles.Size = new System.Drawing.Size(75, 23);
            this.btnTorles.TabIndex = 13;
            this.btnTorles.Text = "Törlés";
            this.btnTorles.UseVisualStyleBackColor = true;
            this.btnTorles.Click += new System.EventHandler(this.btnTorles_Click);
            // 
            // btnModosit
            // 
            this.btnModosit.Location = new System.Drawing.Point(123, 310);
            this.btnModosit.Name = "btnModosit";
            this.btnModosit.Size = new System.Drawing.Size(75, 23);
            this.btnModosit.TabIndex = 14;
            this.btnModosit.Text = "Módosít";
            this.btnModosit.UseVisualStyleBackColor = true;
            this.btnModosit.Click += new System.EventHandler(this.btnModosit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Árulható";
            // 
            // checkBoxArulhato
            // 
            this.checkBoxArulhato.AutoSize = true;
            this.checkBoxArulhato.Location = new System.Drawing.Point(77, 178);
            this.checkBoxArulhato.Name = "checkBoxArulhato";
            this.checkBoxArulhato.Size = new System.Drawing.Size(15, 14);
            this.checkBoxArulhato.TabIndex = 16;
            this.checkBoxArulhato.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Rendelhető";
            // 
            // checkBoxRendelheto
            // 
            this.checkBoxRendelheto.AutoSize = true;
            this.checkBoxRendelheto.Location = new System.Drawing.Point(103, 203);
            this.checkBoxRendelheto.Name = "checkBoxRendelheto";
            this.checkBoxRendelheto.Size = new System.Drawing.Size(15, 14);
            this.checkBoxRendelheto.TabIndex = 18;
            this.checkBoxRendelheto.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(59, 396);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(225, 159);
            this.dataGridView1.TabIndex = 19;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Bolt";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Készlet";
            this.Column2.Name = "Column2";
            // 
            // Termek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 601);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.checkBoxRendelheto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.checkBoxArulhato);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnModosit);
            this.Controls.Add(this.btnTorles);
            this.Controls.Add(this.btnMegse);
            this.Controls.Add(this.btnMentes);
            this.Controls.Add(this.btnUj);
            this.Controls.Add(this.txtEAN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Név);
            this.Controls.Add(this.txtNev);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBeszallito);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboTermek);
            this.Name = "Termek";
            this.Text = "Termek";
            this.Load += new System.EventHandler(this.Termek_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboTermek;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBeszallito;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtNev;
        private System.Windows.Forms.Label Név;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEAN;
        private System.Windows.Forms.Button btnUj;
        private System.Windows.Forms.Button btnMentes;
        private System.Windows.Forms.Button btnMegse;
        private System.Windows.Forms.Button btnTorles;
        private System.Windows.Forms.Button btnModosit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBoxArulhato;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBoxRendelheto;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}