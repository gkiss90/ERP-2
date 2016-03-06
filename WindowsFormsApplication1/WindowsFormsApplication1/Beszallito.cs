using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Beszallito : Form
    {
        DatabaseConnection objConnect;
        string conString;

        DataSet ds;
        DataRow dRow;

        int MaxRows;
        int inc = 0;
        public Beszallito()
        {
            InitializeComponent();
        }
        
        private void NavigateRecords()
        {
            dRow = ds.Tables[0].Rows[inc];
            txtID.Text = dRow.ItemArray.GetValue(0).ToString();
            txtNev.Text = dRow.ItemArray.GetValue(1).ToString();
            string check = dRow.ItemArray.GetValue(2).ToString();
            if (check == "1")
                checkBox1.Checked = true;
            else
                checkBox1.Checked = false;

        }

        private void combofill()
        {
            comboBox1.Items.Clear();
            DataRow comboRow;

                for (int i = 0; i < MaxRows; i++)
                {
                    comboRow = ds.Tables[0].Rows[i];
                    comboBox1.Items.Add(comboRow.ItemArray.GetValue(1).ToString());

                }
        }

        private string aktiv()
        {
            if (checkBox1.Checked)
                return "1";
            else
                return "0";
        }

        private void Beszallito_Load(object sender, EventArgs e)
        {
            try
            {
                objConnect = new DatabaseConnection();
                conString = Properties.Settings.Default.DatabaseConnectionString;

                objConnect.connection_string = conString;
                objConnect.Sql = "select * from beszallito";

                ds = objConnect.GetConnection;

                MaxRows = ds.Tables[0].Rows.Count;

                combofill();
                
                NavigateRecords();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnMentes_Click(object sender, EventArgs e)
        {
            DataRow row = ds.Tables[0].NewRow();
            row[0] = txtID.Text;
            row[1] = txtNev.Text;
            row[2] = aktiv();

            ds.Tables[0].Rows.Add(row);

            try
            {
                objConnect.UpdateDatabase(ds);
                MaxRows++;
                inc = MaxRows - 1;
                MessageBox.Show("Új beszallító elmentve");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            btnUj.Enabled = true;
            //btnNext.Enabled = true;
            //btnPrev.Enabled = true;
            comboBox1.Enabled = true;
            btnTorles.Enabled = true;
            btnMod.Enabled = true;
            btnMegse.Enabled = false;
            btnMentes.Enabled = false;
            combofill();
        }

        private void btnUj_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtNev.Clear();
            txtID.Text = (MaxRows + 1).ToString();
            btnUj.Enabled = false;
            comboBox1.Enabled = false;
            //btnNext.Enabled = false;
            //btnPrev.Enabled = false;
            btnTorles.Enabled = false;
            btnMod.Enabled = false;
            btnMegse.Enabled = true;
            btnMentes.Enabled = true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (inc != MaxRows - 1)
            {
                inc++;
                NavigateRecords();
            }
            else
            {
                MessageBox.Show("Nincs több bolt");
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (inc > 0)
            {
                inc--;
                NavigateRecords();
            }
            else
            {
                MessageBox.Show("Első bolt");
            }
        }

        private void btnMegse_Click(object sender, EventArgs e)

  
        {
            NavigateRecords();
            btnUj.Enabled = true;
            comboBox1.Enabled = true;
            //btnNext.Enabled = true;
            //btnPrev.Enabled = true;
            btnTorles.Enabled = true;
            btnMod.Enabled = true;
            btnMegse.Enabled = false;
            btnMentes.Enabled = false;
            
        }

        private void btnTorles_Click(object sender, EventArgs e)
        {
            try
            {
                ds.Tables[0].Rows[inc].Delete();
                objConnect.UpdateDatabase(ds);

                MaxRows = ds.Tables[0].Rows.Count;
                inc--;
                NavigateRecords();

                MessageBox.Show("Törölve");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            combofill();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            inc = comboBox1.SelectedIndex;
            NavigateRecords();
            //DataRowView vrow = (DataRowView)comboBox1.SelectedItem;
            //DataRow row = vrow.Row;

        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            DataRow row = ds.Tables[0].Rows[inc];
            row[1] = txtNev.Text;
            row[2] = aktiv();

           

            try
            {
                objConnect.UpdateDatabase(ds);
                MessageBox.Show("Beszállító módosítva");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            combofill();
        }
    }
}
