using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace TracNghiem2
{
    public partial class FormDangNhap : DevExpress.XtraEditors.XtraForm
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void cOSOBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cOSOBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tRACNGHIEMDataSet);

        }

        private void FromDangNhap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tRACNGHIEMDataSet.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.tRACNGHIEMDataSet.V_DS_PHANMANH);
            // TODO: This line of code loads data into the 'tRACNGHIEMDataSet.COSO' table. You can move, or remove it, as needed.
            this.cOSOTableAdapter.Fill(this.tRACNGHIEMDataSet.COSO);
            tENCNComboBox.SelectedIndex = 1;
            tENCNComboBox.SelectedIndex = 0;
        }

        private void cOSOBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void tENCNLabel_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        private void tENCNComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.servername = tENCNComboBox.SelectedText.ToString();

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            FormDangNhap.ActiveForm.Close();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text.Trim() == "")
            {
                MessageBox.Show("Tài khoản đăng nhập không được rỗng", "Báo lỗi đăng nhập", MessageBoxButtons.OK);
                txtUserName.Focus();
                return;
            }
            Program.mlogin = txtUserName.Text;
            Program.password = txtPassword.Text;
            if (Program.KetNoi() == 0)
            {
                return;
            }
            MessageBox.Show("Đăng nhập thành công", "Đăng nhập", MessageBoxButtons.OK);
        }
    }
}