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
    public partial class Termek : Form
    {

        DatabaseConnection objConnect;
        string conTermek;

        DataSet ds;
        DataRow dRow;

        int MaxRows;
        int inc = 0;

        private void NavigateRecords()
        {
            dRow = ds.Tables[0].Rows[inc];
            txtID.Text = dRow.ItemArray.GetValue(0).ToString();
            txtEAN.Text = dRow.ItemArray.GetValue(1).ToString();
            txtNev.Text = dRow.ItemArray.GetValue(2).ToString();

            string checkArulhato = dRow.ItemArray.GetValue(3).ToString();
            if (checkArulhato == "1")
                checkBoxArulhato.Checked = true;
            else
                checkBoxArulhato.Checked = false;


            string checkrendelheto = dRow.ItemArray.GetValue(4).ToString();
            if (checkrendelheto == "1")
                checkBoxRendelheto.Checked = true;
            else
                checkBoxRendelheto.Checked = false;

            string beszallito = dRow.ItemArray.GetValue(5).ToString();

            comboBeszallito.SelectedIndex = comboBeszallito.FindString(beszallito);

            ListFill(dRow.ItemArray.GetValue(0).ToString());
        }

        private void combofill()
        {
            comboTermek.Items.Clear();
            DataRow comboRow;

            for (int i = 0; i < MaxRows; i++)
            {
                comboRow = ds.Tables[0].Rows[i];
                comboTermek.Items.Add(comboRow.ItemArray.GetValue(1).ToString());

            }
        }

        private void comboBeszallitoFill()
        {
            comboBeszallito.Items.Clear();
            DatabaseConnection objConnectBeszallito = new DatabaseConnection();
            string conBeszallito = Properties.Settings.Default.DatabaseConnectionString;

            objConnectBeszallito.connection_string = conBeszallito;
            objConnectBeszallito.Sql = "select * from beszallito";

            DataSet dsBeszallito = objConnectBeszallito.GetConnection;

            DataRow comboRowBeszallito;

            int MaxRowsBeszallito = dsBeszallito.Tables[0].Rows.Count;

            for (int i = 0; i < MaxRowsBeszallito; i++)
            {
                comboRowBeszallito = dsBeszallito.Tables[0].Rows[i];
                comboBeszallito.Items.Add(comboRowBeszallito.ItemArray.GetValue(0).ToString());



            }
        }

        private string Rendelhetoe()
        {
            if (checkBoxRendelheto.Checked)
                return "1";
            else
                return "0";
        }

        private string Arulhatoe()
        {
            if (checkBoxArulhato.Checked)
                return "1";
            else
                return "0";
        }



        public Termek()
        {
            InitializeComponent();
        }

        private void Termek_Load(object sender, EventArgs e)
        {
            try
            {
                objConnect = new DatabaseConnection();
                conTermek = Properties.Settings.Default.DatabaseConnectionString;

                objConnect.connection_string = conTermek;
                objConnect.Sql = "select * from aru";

                ds = objConnect.GetConnection;
                /*
               
                objConnect.Sql = "select * from beszallito";
                DataSet dsBeszallito = objConnect.GetConnection;

                DataRow comboRowBeszallito;

                int MaxRowsBeszallito = dsBeszallito.Tables[0].Rows.Count;

                for (int i = 0; i < MaxRowsBeszallito; i++)
                {
                    comboRowBeszallito = dsBeszallito.Tables[0].Rows[i];
                    comboTermek.Items.Add(comboRowBeszallito.ItemArray.GetValue(0).ToString());
                }
 */



                MaxRows = ds.Tables[0].Rows.Count;
                comboBeszallitoFill();
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
            row[1] = txtEAN.Text;
            row[2] = txtNev.Text;

            row[3] = Arulhatoe();
            row[4] = Rendelhetoe();

            row[5] = comboBeszallito.SelectedItem.ToString();

            ds.Tables[0].Rows.Add(row);

            try
            {
                objConnect.UpdateDatabase(ds);
                MaxRows++;
                inc = MaxRows - 1;
                MessageBox.Show("Új termék elmentve");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

            BoltKapcsolat();

            btnUj.Enabled = true;

            comboTermek.Enabled = true;
            btnTorles.Enabled = true;
            btnModosit.Enabled = true;
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
            comboTermek.Enabled = false;
            btnTorles.Enabled = false;
            btnModosit.Enabled = false;
            btnMegse.Enabled = true;
            btnMentes.Enabled = true;
        }

        private void btnMegse_Click(object sender, EventArgs e)
        {
            NavigateRecords();
            btnUj.Enabled = true;
            comboTermek.Enabled = true;
            btnTorles.Enabled = true;
            btnModosit.Enabled = true;
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

        private void comboTermek_SelectedIndexChanged(object sender, EventArgs e)
        {
            inc = comboTermek.SelectedIndex;
            NavigateRecords();
        }

        private void btnModosit_Click(object sender, EventArgs e)
        {
            DataRow row = ds.Tables[0].Rows[inc];
            row[1] = txtEAN.Text;
            row[2] = txtNev.Text;
            row[3] = Arulhatoe();
            row[4] = Rendelhetoe();
            row[5] = comboBeszallito.SelectedItem.ToString();

            try
            {
                objConnect.UpdateDatabase(ds);
                MessageBox.Show("Termék módosítva");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            combofill();
        }



        private void BoltKapcsolat()
        {
            try
            {
                DatabaseConnection objBoltok = new DatabaseConnection();
                conTermek = Properties.Settings.Default.DatabaseConnectionString;

                objBoltok.connection_string = conTermek;
                objBoltok.Sql = "select * from bolt";

                DataSet dsBoltok = objBoltok.GetConnection;

                int MaxRowsBoltok = dsBoltok.Tables[0].Rows.Count;


                objBoltok.Sql = "select * from bolt_termek";
                DataSet dsKapcsolat = objBoltok.GetConnection;

                for (int i = 0; i < MaxRowsBoltok; i++)
                {
                    DataRow boltRow = dsBoltok.Tables[0].Rows[i];
                    DataRow row = dsKapcsolat.Tables[0].NewRow();
                    row[0] = boltRow.ItemArray.GetValue(0).ToString();
                    row[1] = txtID.Text;
                    row[2] = 0;
                    dsKapcsolat.Tables[0].Rows.Add(row);
                }
                objBoltok.UpdateDatabase(dsKapcsolat);

                MessageBox.Show("Új termék hozzáadva a boltokhoz");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);

            }
        }

        private void ListFill(string IDtermek)
        {
            try
            {
                //listView1.Clear();
                dataGridView1.Rows.Clear();
            DatabaseConnection objKapcsolat = new DatabaseConnection();
            conTermek = Properties.Settings.Default.DatabaseConnectionString;

            objKapcsolat.connection_string = conTermek;
                objKapcsolat.Sql = "select * from bolt_termek where termek_id = '" + IDtermek + "'";
            DataSet dsKapcsolat = objKapcsolat.GetConnection;

            int MaxRowsKapcsolat = dsKapcsolat.Tables[0].Rows.Count;
            


            for (int i = 0; i < MaxRowsKapcsolat; i++)
            {
                DataRow boltRow = dsKapcsolat.Tables[0].Rows[i];
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dataGridView1);
                    row.Cells[0].Value = boltRow.ItemArray.GetValue(0).ToString();
                    row.Cells[1].Value = boltRow.ItemArray.GetValue(2).ToString();
                    dataGridView1.Rows.Add(row);

                    /**
                    ListViewItem item = new ListViewItem(boltRow.ItemArray.GetValue(0).ToString());
                item.SubItems.Add(boltRow.ItemArray.GetValue(1).ToString());
                    item.SubItems.Add(boltRow.ItemArray.GetValue(2).ToString());
    ˛*/
                    //listView1.Items.Add(item);
            }
            }
        catch(Exception err)
            {
            MessageBox.Show(err.Message);
            }
        }

    }
}
