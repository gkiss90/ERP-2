namespace WindowsFormsApplication1
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
            this.btnTermek = new System.Windows.Forms.Button();
            this.btnBolt = new System.Windows.Forms.Button();
            this.btnBeszallitok = new System.Windows.Forms.Button();
            this.btnRendeles = new System.Windows.Forms.Button();
            this.btnEladas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTermek
            // 
            this.btnTermek.Location = new System.Drawing.Point(27, 29);
            this.btnTermek.Name = "btnTermek";
            this.btnTermek.Size = new System.Drawing.Size(75, 23);
            this.btnTermek.TabIndex = 0;
            this.btnTermek.Text = "Termekek";
            this.btnTermek.UseVisualStyleBackColor = true;
            this.btnTermek.Click += new System.EventHandler(this.btnTermek_Click);
            // 
            // btnBolt
            // 
            this.btnBolt.Location = new System.Drawing.Point(27, 58);
            this.btnBolt.Name = "btnBolt";
            this.btnBolt.Size = new System.Drawing.Size(75, 23);
            this.btnBolt.TabIndex = 1;
            this.btnBolt.Text = "Boltok";
            this.btnBolt.UseVisualStyleBackColor = true;
            this.btnBolt.Click += new System.EventHandler(this.btnBolt_Click);
            // 
            // btnBeszallitok
            // 
            this.btnBeszallitok.Location = new System.Drawing.Point(27, 87);
            this.btnBeszallitok.Name = "btnBeszallitok";
            this.btnBeszallitok.Size = new System.Drawing.Size(75, 23);
            this.btnBeszallitok.TabIndex = 2;
            this.btnBeszallitok.Text = "Beszállítók";
            this.btnBeszallitok.UseVisualStyleBackColor = true;
            this.btnBeszallitok.Click += new System.EventHandler(this.btnBeszallitok_Click);
            // 
            // btnRendeles
            // 
            this.btnRendeles.Location = new System.Drawing.Point(27, 116);
            this.btnRendeles.Name = "btnRendeles";
            this.btnRendeles.Size = new System.Drawing.Size(75, 23);
            this.btnRendeles.TabIndex = 3;
            this.btnRendeles.Text = "Rendelés";
            this.btnRendeles.UseVisualStyleBackColor = true;
            // 
            // btnEladas
            // 
            this.btnEladas.Location = new System.Drawing.Point(27, 146);
            this.btnEladas.Name = "btnEladas";
            this.btnEladas.Size = new System.Drawing.Size(75, 23);
            this.btnEladas.TabIndex = 4;
            this.btnEladas.Text = "Eladás";
            this.btnEladas.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 261);
            this.Controls.Add(this.btnEladas);
            this.Controls.Add(this.btnRendeles);
            this.Controls.Add(this.btnBeszallitok);
            this.Controls.Add(this.btnBolt);
            this.Controls.Add(this.btnTermek);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTermek;
        private System.Windows.Forms.Button btnBolt;
        private System.Windows.Forms.Button btnBeszallitok;
        private System.Windows.Forms.Button btnRendeles;
        private System.Windows.Forms.Button btnEladas;
    }
}

