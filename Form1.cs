using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DAM_ORMFramework.Mapping;
using System.Configuration;
namespace DemoDAMFramework
{
    public partial class Form1 : Form
    {
        
        List<CellPhone> cellphones = new List<CellPhone>();
        List<Maker> makers = new List<Maker>();
        List<Color> colors = new List<Color>();
        List<Color> colorscurrent = new List<Color>();
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
                txtMa.Enabled = false;
                connection.Open();
                cellphones = connection.ExecuteQuery<CellPhone>("Select * From CellPhone");
                makers = connection.Select<Maker>().Rows().Execute();
                colors = connection.Select<Color>().Rows().Execute();
                BindingGrigViewCellPhone(cellphones);
                AddDataMakerToComboBox(makers);
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
                if(cellphone.Price != null && cellphone.CellPhone_Colors!= null && cellphone.Maker!=null)
                {
                    grvCellphone.Rows.Add(cellphone.ID, cellphone.Name, cellphone.Maker.Name,cellphone.CellPhone_Colors.Count,cellphone.Price.Price);
                }
                else
                {
                    grvCellphone.Rows.Add(cellphone.ID, cellphone.Name, cellphone.Maker.Name,0,0);
                }

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtMa.Enabled = true;
            txtMa.Text = null;
            txtTen.Text = null;
            txtGiatien.Text = null;
            cbHangSX.SelectedItem = 0;
            if (string.IsNullOrEmpty(txtMa.Text) || string.IsNullOrEmpty(txtTen.Text)
                || string.IsNullOrEmpty(txtGiatien.Text) || cbHangSX.SelectedIndex<=0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
            else
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn thêm mới dữ liệu?", "Hộp thoại thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    CellPhone cp = new CellPhone();
                    cp.ID = txtMa.Text;
                    cp.Name = txtTen.Text;
                    cp.MakerID = ((ItemComboBox)cbHangSX.SelectedItem).Value;
                    cp.Price.Price = (double.Parse(txtGiatien.Text.ToString()));
                    Phone_Price pr = new Phone_Price();
                    pr.CellPhoneID = txtMa.Text;
                    pr.Price = (double.Parse(txtGiatien.Text.ToString()));

                    try
                    {
                        connection.Open();
                        connection.Insert(cp);
                        connection.Insert(pr);
                        connection.Close();
                        Form1_Load(sender, e);
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message);
                    }
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMa.Text) || string.IsNullOrEmpty(txtTen.Text)
                || string.IsNullOrEmpty(txtGiatien.Text) || cbHangSX.SelectedIndex <= 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
            else
            {
                if (MessageBox.Show("Thay đổi dữ liệu sẽ ảnh hưởng đến các bảng khác. Bạn có chắc chắn muốn thay đổi dữ liệu?", "Hộp thoại thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                { 
                    CellPhone cp = new CellPhone();
                    cp.ID = txtMa.Text;
                    cp.Name = txtTen.Text;
                    cp.MakerID = ((ItemComboBox)cbHangSX.SelectedItem).Value;
                    cp.Price.Price = (double.Parse(txtGiatien.Text.ToString()));
                    Phone_Price pr = new Phone_Price();
                   // pr.CellPhoneID = txtMa.Te;
                    try
                    {
                        connection.Open();
                        connection.Update(cp);
                        connection.Close();
                        Form1_Load(sender, e);
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message);
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int indexRowSelected = grvCellphone.CurrentCell.RowIndex;
            if (MessageBox.Show("Dữ liệu xóa sẽ ảnh hưởng đến các bảng khác và không thể phục hồi. Bạn có chắc chắn muốn xóa dữ liệu?", "Hộp thoại thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    connection.Open();
                    connection.Delete(cellphones[indexRowSelected]);
                    connection.Close();
                    Form1_Load(sender, e);
                }
                catch (Exception err)
                {
                    MessageBox.Show("Dữ liệu có liên quan đến bảng khác không thể xóa được");
                }
            }
        }
        
        private void AddDataMakerToComboBox(List<Maker> makers)
        {
            cbHangSX.DisplayMember = "Text";
            cbHangSX.ValueMember = "Value";
            cbHangSX.Items.Clear();
            cbHangSX.Items.Add(new ItemComboBox("Chọn",0));
            foreach (Maker maker in makers)
            {
                cbHangSX.Items.Add(new ItemComboBox(maker.Name, maker.ID));
            }
            cbHangSX.SelectedIndex = 0;
        }
      
        private void grvCellPhone_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMa.Enabled = false;
            int selectedRowIndex = grvCellphone.CurrentCell.RowIndex;
            txtMa.Text = cellphones[selectedRowIndex].ID;
            txtTen.Text = cellphones[selectedRowIndex].Name;
            txtGiatien.Text = cellphones[selectedRowIndex].Price.Price.ToString();
            for (int i = 0; i < cbHangSX.Items.Count; i++)
                if (((ItemComboBox)cbHangSX.Items[i]).Value == cellphones[selectedRowIndex].Maker.ID)
                    cbHangSX.SelectedIndex = i;

           
        }
    }
    public class ItemComboBox
    {
        public string Text { get; set; }
        public int Value { get; set; }

        public ItemComboBox(string text, int value)
        {
            Text = text;
            Value = value;
        }
    }
}
