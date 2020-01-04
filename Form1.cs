using System;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;
using System.Windows.Controls.Ribbon;
using DAM_ORMFramework;
using DAM_ORMFramework.Attribute;
using DAM_ORMFramework.Query;
using DAM_ORMFramework.Mapping;
using System.Data.SqlClient;
namespace DemoDAMFramework
{
    public partial class Form1 : Form
    {
        
        List<CellPhone> cellphones = null;
        List<Maker> makers = null;
        List<Color> colors = null;
        static string conn = ConfigurationManager.ConnectionStrings["DemoDAMFramework.Properties.Settings.Setting"].ConnectionString;
        SqlServerConnection connection = new SqlServerConnection(conn);
        public Form1()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                //cellphones = connection.ExecuteQuery<CellPhone>("Select * From CellPhone");
                //BindingGrigViewCellPhone(cellphones);
                MessageBox.Show("abc");
                connection.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void BindingGrigViewCellPhone(List<CellPhone> cellphones)
        {
            grvCellphone.Rows.Clear();
            foreach(CellPhone cellphone in cellphones)
            {
                MessageBox.Show(cellphone.Price.ToString());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMa.Text) || string.IsNullOrEmpty(txtTen.Text)
                || string.IsNullOrEmpty(txtGiatien.Text) || cbColor.SelectedIndex<=0 || cbHangSX.SelectedIndex<=0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
            else
            {
                CellPhone cp = new CellPhone();
                cp.ID = txtMa.Text;
                cp.Name = txtMa.Text;
                cp.MakerID = cbHangSX.SelectedIndex + 1;
                Price pr = new Price();
                pr.CellPhoneID = txtMa.Text;
                pr.Prices = (float.Parse(txtGiatien.Text.ToString()));
                
                try
                {
                    connection.Open();
                    connection.Insert(pr);
                    connection.Insert(cp);
                    connection.Close();
                    Form1_Load(sender, e);
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMa.Text) || string.IsNullOrEmpty(txtTen.Text)
                || string.IsNullOrEmpty(txtGiatien.Text) || cbColor.SelectedIndex <= 0 || cbHangSX.SelectedIndex <= 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
            else
            {
                CellPhone cp = new CellPhone();
                cp.ID = txtMa.Text;
                cp.Name = txtTen.Text;
                cp.MakerID = cbHangSX.SelectedIndex + 1;

                try
                {
                    connection.Open();
                    connection.Update(cp);
                    connection.Close();
                    Form1_Load(sender, e);
                }
                catch(Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int indexRowSelected = grvCellphone.CurrentCell.RowIndex;
            try
            {
                connection.Open();
                connection.Delete(cellphones[indexRowSelected]);
                connection.Close();
                Form1_Load(sender, e);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        
        private void AddDataToComboBox(List<Maker> makers)
        {
            cbHangSX.DisplayMember = "Text";
            cbHangSX.ValueMember = "Value";
            cbHangSX.Items.Clear();

            //foreach(Maker maker in makers)
            //{
            //    cbHangSX.Items.Add(new ComboBoxItem)
            //}
        }
    }
}
