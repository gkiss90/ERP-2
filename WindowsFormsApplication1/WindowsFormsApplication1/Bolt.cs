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
    public partial class Bolt : Form
    {
        DatabaseConnection objConnect;
        string conString;

        DataSet ds;
        DataRow dRow;

        int MaxRows;
        int inc = 0;

        public Bolt()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtNev.Clear();
            txtID.Text = (MaxRows + 1).ToString();
            btnUj.Enabled = false;
            btnNext.Enabled = false;
            btnPrev.Enabled = false;
            btnTorles.Enabled = false;
            btnMegse.Enabled = true;
            btnMentes.Enabled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Bolt_Load(object sender, EventArgs e)
        {
            try
            {
                objConnect = new DatabaseConnection();
                conString = Properties.Settings.Default.DatabaseConnectionString;

                objConnect.connection_string = conString;
                objConnect.Sql = "select * from bolt";

                ds = objConnect.GetConnection;
                MaxRows = ds.Tables[0].Rows.Count;

                NavigateRecords();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

        }

        private void NavigateRecords()
        {
            dRow = ds.Tables[0].Rows[inc];
            txtID.Text = dRow.ItemArray.GetValue(0).ToString();
            txtNev.Text = dRow.ItemArray.GetValue(1).ToString();

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
            btnNext.Enabled = true;
            btnPrev.Enabled = true;
            btnTorles.Enabled = true;
            btnMegse.Enabled = false;
            btnMentes.Enabled = false;
        }

        private void btnMentes_Click(object sender, EventArgs e)
        {
            DataRow row = ds.Tables[0].NewRow();
            row[0] = txtID.Text;
            row[1] = txtNev.Text;
            
            ds.Tables[0].Rows.Add(row);

            try
            {
                objConnect.UpdateDatabase(ds);
                MaxRows++;
                inc = MaxRows - 1;
                MessageBox.Show("Új bolt elmentve");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

            btnUj.Enabled = true;
            btnNext.Enabled = true;
            btnPrev.Enabled = true;
            btnTorles.Enabled = true;
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
        }
    }
}
