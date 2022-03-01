using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Sneakers_mngmt
{
    public partial class Form2 : Form
    {
        #region
        SneakerRepository repository;


        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            repository = new SneakerRepository();
            invenGrid.DataSource = repository.GetInventories();
            btnSubNew.Visible = false;
            btnUpdSel.Visible = false;
            cmbSize.SelectedIndex = -1;
            cmbSize.Items.AddRange(new string[] {"5","5.5","6","6.5","7","7.5","8","8.5","9","9.5","10","10.5","11","11.5","12","12.5","13"});
            this.invenGrid.Columns["Customer"].Visible=false;
            DataGridViewImageColumn imgcol = new DataGridViewImageColumn();
            imgcol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            invenGrid.RowTemplate.Height = 100;
            invenGrid.AllowUserToAddRows = false;

        }
        private void invenGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }
        #endregion
        #region
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtID.Text = (repository.GetMaxID() + 1).ToString();
            txtID.ReadOnly = true;
            //picBox();
            txtShoeName.Clear();
            txtColor.Clear();
            txtQty.Clear();
            txtPrice.Clear();
            txtSku.Clear();
            btnSubNew.Visible = true;
            picBox.Enabled = true;
        }

        private void btnSubNew_Click(object sender, EventArgs e)
        {
            if (txtShoeName.Text != string.Empty && txtColor.Text != string.Empty && cmbSize.Text != string.Empty && txtQty.Text != string.Empty && txtPrice.Text != string.Empty && txtSku.Text != string.Empty)
            {
                var newshoe = new Inventory();
                newshoe.ItemID = Convert.ToInt32(txtID.Text);
                newshoe.Name= txtShoeName.Text;
                newshoe.Color= txtColor.Text;
                newshoe.Size=Convert.ToDecimal(cmbSize.Text);
                newshoe.Qty=Convert.ToInt32(txtQty.Text);
                newshoe.Price= Convert.ToInt32(txtPrice.Text);
                newshoe.Sku= txtSku.Text;
                
                MemoryStream mmst = new MemoryStream();
                picBox.Image.Save(mmst, picBox.Image.RawFormat);
                byte[] img = mmst.ToArray();
                newshoe.ShoePic = img;
                this.invenGrid.Columns["Customer"].Visible = false;
                repository.AddRecord(newshoe);
                picBox.Image = null;

            }
            else
            {
                MessageBox.Show("Please ensure all fiels are filled out");
            }
            Clear();
        }

        

        private void btnSelect_Click(object sender, EventArgs e)
        {
            var id = invenGrid.CurrentRow.Cells[7].Value;
            var invtoupdate = repository.FindInventory((string)id);
            txtID.Text=invtoupdate.ItemID.ToString();
            txtShoeName.Text=invtoupdate.Name.ToString();
            txtColor.Text=invtoupdate.Color.ToString();
            cmbSize.Text=invtoupdate.Size.ToString();
            txtQty.Text=invtoupdate.Qty.ToString();
            txtPrice.Text=invtoupdate.Price.ToString();
            txtSku.Text=invtoupdate.Sku.ToString();
            //MemoryStream mmst = new MemoryStream();
            //picBox.Image.Save(mmst, picBox.Image.RawFormat);
            //byte[] img = mmst.ToArray();
            //picBox.Image = invtoupdate.ShoePic.Length > 0 ? img : null;
            //invtoupdate.ShoePic = img;
            ////picBox.Image=invtoupdate.ShoePic.Any() ? picBox.Image : null;
            btnUpdSel.Visible=true;

        }

        private void btnUpdSel_Click(object sender, EventArgs e)
        {
            var id = txtSku.Text;
            var invtoupdate = repository.FindInventory(id);
            invtoupdate.Name = txtShoeName.Text;
            invtoupdate.Color = txtColor.Text;
            invtoupdate.Size=Convert.ToDecimal(cmbSize.Text);
            invtoupdate.Qty=Convert.ToInt32(txtQty.Text);
            invtoupdate.Price=Convert.ToDecimal(txtPrice.Text);
            invtoupdate.Sku=txtSku.Text;
            MemoryStream mmst = new MemoryStream();
            picBox.Image.Save(mmst, picBox.Image.RawFormat);
            byte[] img = mmst.ToArray();
            invtoupdate.ShoePic = img;
            repository.UpdateRecord(id, invtoupdate);
            this.invenGrid.Columns["Customer"].Visible = false;
            Clear();


        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            invenGrid.DataSource = null;
            invenGrid.DataSource=repository.GetInventories();
            btnSubNew.Enabled = false;
            btnUpdSel.Enabled=false;
            this.invenGrid.Columns["Customer"].Visible = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var id= invenGrid.CurrentRow.Cells[7].Value;
            var invtodel=repository.FindInventory((string)id);
            repository.DeleteRecord(invtodel);
            MessageBox.Show("Record is deleted");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }
        #endregion
        #region
        private void Clear()
        {
            txtID.Clear();
            txtShoeName.Clear();
            txtColor.Clear();
            cmbSize.SelectedIndex = -1;
            cmbSize.DataSource = null;
            txtQty.Clear();
            txtPrice.Clear();
            txtSku.Clear();
            picBox.Enabled = false;
            
        }
        #endregion

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtShoeName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtColor_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbSize_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSku_TextChanged(object sender, EventArgs e)
        {

        }

        private void picBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfld = new OpenFileDialog();
            {
                opnfld.Filter = "Image Files (*.jpg;*.jpeg;*.gif;)|*.jpg;*.jpeg;*.gif";
                if (opnfld.ShowDialog() == DialogResult.OK)
                {
                    picBox.Image = new Bitmap(opnfld.FileName);
                }
            }
        }

        
    }

}
