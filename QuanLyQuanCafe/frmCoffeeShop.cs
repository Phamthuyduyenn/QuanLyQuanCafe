using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using System.Data.SqlClient;

namespace QuanLyQuanCafe
{
    public partial class frmCoffeeShop : Form
    {
        public frmCoffeeShop()
        {
            InitializeComponent();
        }

        TableBUS tabBUS = new TableBUS();
        void LoadCombobox()
        {
            var cmd = new SqlCommand("select name from Product", cn);
            //var dr = cmd.ExecuteReader();
            var dt = new DataTable();
            dt.Load(dr);
            dr.Dispose();
            cbShowFood.DataSource = dt;
        }

        private void frmCoffeeShop_Load(object sender, EventArgs e)
        {
            this.Show();
            this.Enabled = false;

            frmLogin frm = new frmLogin();
            DialogResult result = frm.ShowDialog();

            if (result == DialogResult.OK)
                this.Enabled = true;
            else Application.Exit();
            LoadCombobox();

            DataTable tables = tabBUS.Get();
            foreach (DataRow table in tables.Rows)
            {
                Button btn = new Button();
                btn.Size = new Size(100, 100);
                btn.BackgroundImageLayout = ImageLayout.Zoom;
                btn.Text = table[1].ToString() + Environment.NewLine + Environment.NewLine + table[2].ToString();
                btn.Click += Btn_Click;
                btn.Tag = table;

                switch (table[2].ToString())
                {
                    case "Có người":
                        btn.BackgroundImage = QuanLyQuanCafe.Properties.Resources.coffeeColor;
                        break;
                    default:
                        btn.BackgroundImage = QuanLyQuanCafe.Properties.Resources.coffeeBlack;
                        break;
                }
                flpTable.Controls.Add(btn);

            }
        }

        ItemBUS itemBUS = new ItemBUS();
        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            DataRow table = (DataRow)btn.Tag;

            int tableID = Int32.Parse(table[0].ToString());

            DataTable dt = itemBUS.Get(tableID);
            dgvItem.DataSource = dt;

            float total = 0;
            if (table[2].ToString() == "Có người")
            {
                foreach (DataRow row in dt.Rows)
                {
                    total += float.Parse(row["TTien"].ToString());
                }
                txtTTien.Text = total.ToString();
            }
            else txtTTien.Text = total.ToString("0");
        }



        public SqlConnection cn { get; set; }
    }
}
