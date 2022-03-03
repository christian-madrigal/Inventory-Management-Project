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
        //intitial part of the program
        #region
        SneakerRepository repository;

        public void SetGridHeightWidth(DataGridView grd, int maxHeight)
        {
            var height = 40;
            foreach (DataGridViewRow row in grd.Rows)
            {
                if (row.Visible)
                    height += row.Height;
                continue;
            }

            if (height > maxHeight)
                height = maxHeight;

            grd.Height = height;
        }
        public Form2()
        {
            InitializeComponent();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            repository = new SneakerRepository();
            invenGrid.DataSource = repository.GetInventories();
            custgrid.DataSource = repository.GetCustomers();
            invenGrid.Visible = false;
            grpInventory.Visible = false;
            grpSearch.Visible = false;
            btnAddNew.Visible = false;
            btnSubNew.Visible = false;
            btnSelect.Visible = false;
            btnUpdSel.Visible = false;
            btnDelete.Visible = false;
            btnRefresh.Visible = false;
            custgrid.Visible = false;
            grpCustomer.Visible = false;
            btnAddNewCus.Visible = false;
            btnSubNewCus.Visible = false;
            btnSelectCus.Visible = false;
            btnUpdSelCus.Visible = false;
            btnDeleteCus.Visible = false;
            btnRefreshCus.Visible = false;
            cmbSize.SelectedIndex = -1;
            cmbCSize.SelectedIndex = -1;
            cmbSize.Items.AddRange(new string[] { "5", "5.5", "6", "6.5", "7", "7.5", "8", "8.5", "9", "9.5", "10", "10.5", "11", "11.5", "12", "12.5", "13" });
            cmbCSize.Items.AddRange(new string[] { "5", "5.5", "6", "6.5", "7", "7.5", "8", "8.5", "9", "9.5", "10", "10.5", "11", "11.5", "12", "12.5", "13" });
            this.invenGrid.Columns["Customer"].Visible = false;
            this.custgrid.Columns["Inventory"].Visible = false;
            SetGridHeightWidth(custgrid, custgrid.Height);
            SetGridHeightWidth(invenGrid, invenGrid.Height);
            for (int i = 0; i < invenGrid.Columns.Count; i++)
                if (invenGrid.Columns[i] is DataGridViewImageColumn)
                {
                    ((DataGridViewImageColumn)invenGrid.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Zoom;
                    break;
                }
            invenGrid.AllowUserToAddRows = false;

        }

        private void btnInv_Click(object sender, EventArgs e)
        {
            invenGrid.Visible = true;
            grpInventory.Visible = true;
            grpSearch.Visible = true;
            btnAddNew.Visible = true;
            btnSubNew.Visible = false;
            btnSelect.Visible = true;
            btnUpdSel.Visible = false;
            btnDelete.Visible = true;
            btnRefresh.Visible = true;
            btnSearchInv.Visible = true;
            custgrid.Visible = false;
            grpCustomer.Visible = false;
            btnAddNewCus.Visible = false;
            btnSubNewCus.Visible = false;
            btnSelectCus.Visible = false;
            btnUpdSelCus.Visible = false;
            btnDeleteCus.Visible = false;
            btnRefreshCus.Visible = false;
            btnSearchCus.Visible = false;
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            custgrid.Visible = true;
            grpCustomer.Visible = true;
            grpSearch.Visible = true;
            btnAddNewCus.Visible = true;
            btnSubNewCus.Visible = false;
            btnSelectCus.Visible = true;
            btnUpdSelCus.Visible = false;
            btnDeleteCus.Visible = true;
            btnRefreshCus.Visible = true;
            btnSearchCus.Visible = true;
            invenGrid.Visible = false;
            grpInventory.Visible = false;
            btnAddNew.Visible = false;
            btnSubNew.Visible = false;
            btnSelect.Visible = false;
            btnUpdSel.Visible = false;
            btnDelete.Visible = false;
            btnRefresh.Visible = false;
            btnSearchInv.Visible = false;

        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }
        #endregion
        //Button functions to add Inventory to Inventory Grid
        #region
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtID.Text = (repository.GetMaxID() + 1).ToString();
            txtID.ReadOnly = true;
            picBox.Image = null;
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
            if (txtShoeName.Text != string.Empty && txtColor.Text != string.Empty && cmbSize.Text != string.Empty && txtQty.Text != string.Empty && txtPrice.Text != string.Empty && txtSku.Text != string.Empty && picBox.Image != null)
            {
                var newshoe = new Inventory();
                newshoe.ItemID = Convert.ToInt32(txtID.Text);
                newshoe.Name = txtShoeName.Text;
                newshoe.Color = txtColor.Text;
                newshoe.Size = cmbSize.Text;
                newshoe.Qty = Convert.ToInt32(txtQty.Text);
                newshoe.Price = Convert.ToInt32(txtPrice.Text);
                newshoe.Sku = txtSku.Text;

                MemoryStream mmst = new MemoryStream();
                picBox.Image.Save(mmst, picBox.Image.RawFormat);
                byte[] img = mmst.ToArray();

                newshoe.ShoePicture = img;
                this.invenGrid.Columns["Customer"].Visible = false;
                repository.AddRecord(newshoe);
            }
            else
            {
                MessageBox.Show("Please ensure all fiels are filled out");
            }
            Clear();
            btnSubNew.Visible = false;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            var id = invenGrid.CurrentRow.Cells[0].Value;
            var invtoupdate = repository.FindInventory((int)id);
            txtID.Text = invtoupdate.ItemID.ToString();
            txtShoeName.Text = invtoupdate.Name.ToString();
            txtColor.Text = invtoupdate.Color.ToString();
            cmbSize.Text = invtoupdate.Size.ToString();
            txtQty.Text = invtoupdate.Qty.ToString();
            txtPrice.Text = invtoupdate.Price.ToString();
            txtSku.Text = invtoupdate.Sku.ToString();
            MemoryStream ms = new MemoryStream((byte[])invenGrid.CurrentRow.Cells[1].Value‌​);
            picBox.Image = Image.FromStream(ms);
            btnUpdSel.Visible = true;

        }

        private void btnUpdSel_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(txtID.Text);
            var invtoupdate = repository.FindInventory(id);
            invtoupdate.Name = txtShoeName.Text;
            invtoupdate.Color = txtColor.Text;
            invtoupdate.Size = cmbSize.Text;
            invtoupdate.Qty = Convert.ToInt32(txtQty.Text);
            invtoupdate.Price = Convert.ToDecimal(txtPrice.Text);
            invtoupdate.Sku = txtSku.Text;
            MemoryStream mmst = new MemoryStream();
            picBox.Image.Save(mmst, picBox.Image.RawFormat);
            byte[] img = mmst.ToArray();
            invtoupdate.ShoePicture = img;
            repository.UpdateRecord(id, invtoupdate);
            this.invenGrid.Columns["Customer"].Visible = false;
            Clear();
            btnUpdSel.Visible = false;

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            invenGrid.DataSource = null;
            invenGrid.DataSource = repository.GetInventories();
            SetGridHeightWidth(invenGrid, invenGrid.Height);
            for (int i = 0; i < invenGrid.Columns.Count; i++)
                if (invenGrid.Columns[i] is DataGridViewImageColumn)
                {
                    ((DataGridViewImageColumn)invenGrid.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Zoom;
                    break;
                }

            this.invenGrid.Columns["Customer"].Visible = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var id = invenGrid.CurrentRow.Cells[0].Value;
            var invtodel = repository.FindInventory((int)id);
            repository.DeleteRecord(invtodel);
            MessageBox.Show("Record is deleted");
        }


        #endregion
        //Button functions to add Customer to Customer Grid
        #region
        private void btnAddNewCus_Click(object sender, EventArgs e)
        {
            txtOrderID.Clear();
            txtOrderID.Text = (repository.GetMaxNum() + 1).ToString();
            txtOrderID.ReadOnly = true;
            txtFName.Clear();
            txtLName.Clear();
            txtAddy.Clear();
            txtCity.Clear();
            txtState.Clear();
            txtZip.Clear();
            txtCSku.Clear();
            btnSubNewCus.Visible = true;

        }

        private void btnSubNewCus_Click(object sender, EventArgs e)
        {
            if (txtFName.Text != string.Empty && txtLName.Text != string.Empty && cmbCSize.Text != string.Empty && txtAddy.Text != string.Empty && txtCity.Text != string.Empty && txtCity.Text != string.Empty && txtState.Text != string.Empty && txtZip.Text != string.Empty && txtCSku.Text != string.Empty)
            {
                var newcus = new Customer();
                newcus.OrderID = Convert.ToInt32(txtOrderID.Text);
                newcus.FirstName = txtFName.Text;
                newcus.LastName = txtLName.Text;
                newcus.StreetAddress = txtAddy.Text;
                newcus.City = txtCity.Text;
                newcus.State = txtState.Text;
                newcus.ZipCode = txtZip.Text;
                newcus.Sku = txtCSku.Text;
                newcus.Size = cmbCSize.Text;
                this.invenGrid.Columns["Customer"].Visible = false;
                repository.AddRecord(newcus);
            }
            else
            {
                MessageBox.Show("Please ensure all fiels are filled out");
            }
            this.custgrid.Columns["Inventory"].Visible = false;
            Clear();

            btnSubNewCus.Visible = false;
        }

        private void btnSelectCus_Click(object sender, EventArgs e)
        {
            var id = custgrid.CurrentRow.Cells[0].Value;
            var custoupdate = repository.FindCustomers((int)id);
            txtOrderID.Text = custoupdate.OrderID.ToString();
            txtFName.Text = custoupdate.FirstName.ToString();
            txtLName.Text = custoupdate.LastName.ToString();
            txtAddy.Text = custoupdate.StreetAddress.ToString();
            txtCity.Text = custoupdate.City.ToString();
            txtState.Text = custoupdate.State.ToString();
            txtZip.Text = custoupdate.ZipCode.ToString();
            txtCSku.Text = custoupdate.Sku.ToString();
            cmbCSize.Text = custoupdate.Size.ToString();
            btnUpdSelCus.Visible = true;
        }

        private void btnUpdSelCus_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(txtOrderID.Text);
            var custoupdate = repository.FindCustomers(id);
            custoupdate.OrderID = Convert.ToInt32(txtOrderID.Text);
            custoupdate.FirstName = txtFName.Text;
            custoupdate.LastName = txtLName.Text;
            custoupdate.StreetAddress = txtAddy.Text;
            custoupdate.City = txtCity.Text;
            custoupdate.State = txtState.Text;
            custoupdate.ZipCode = txtZip.Text;
            custoupdate.Sku = txtCSku.Text;
            custoupdate.Size = cmbCSize.Text;
            repository.UpdateRecord(id, custoupdate);
            this.custgrid.Columns["Inventory"].Visible = false;
            Clear();
            btnUpdSelCus.Visible = false;
        }

        private void btnRefreshCus_Click(object sender, EventArgs e)
        {
            custgrid.DataSource = null;
            custgrid.DataSource = repository.GetCustomers();
            SetGridHeightWidth(invenGrid, invenGrid.Height);
            this.custgrid.Columns["Inventory"].Visible = false;
        }

        private void btnDeleteCus_Click(object sender, EventArgs e)
        {
            var id = custgrid.CurrentRow.Cells[0].Value;
            var custodelete = repository.FindCustomers((int)id);
            repository.DeleteRecord(custodelete);
            MessageBox.Show("Record is deleted");
        }

        #endregion
        //Method for Clearing all items
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
            picBox.Image = null;

            txtOrderID.Clear();
            txtFName.Clear();
            txtLName.Clear();
            txtAddy.Clear();
            txtCity.Clear();
            txtState.Clear();
            txtZip.Clear();
            txtCSku.Clear();
            cmbCSize.SelectedIndex = -1;
            cmbCSize.DataSource = null;

        }
        #endregion
        //validation for Inventory
        #region

        private void txtShoeName_Leave(object sender, EventArgs e)
        {
            if (txtShoeName.Text == "")
            {
                string vin = string.Empty;
                MessageBox.Show("Dont forget to add the name of the shoe");
            }
            else if ((txtShoeName.Text.Length > 37))
            {
                txtShoeName.Clear();
                MessageBox.Show("Please check the name and that it doesnt exceed 37 charartcers");
                txtShoeName.Focus();
            }
            else
                return;
        }

        private void txtColor_Leave(object sender, EventArgs e)
        {
            if (txtColor.Text == "")
            {
                string vin = string.Empty;
                MessageBox.Show("You forgot the colorway");
            }
            else if ((txtColor.Text.Length > 37))
            {
                txtColor.Clear();
                MessageBox.Show("That's a long colorway, check it again");
                txtColor.Focus();
            }
            else
                return;
        }

        private void cmbSize_Leave(object sender, EventArgs e)
        {
            if (cmbSize.Text == "")
            {
                string size = string.Empty;
                MessageBox.Show("Ensure to input the size");
            }
        }

        private void txtQty_Leave(object sender, EventArgs e)
        {
            if (txtQty.Text == "")
            {
                string qty = string.Empty;
                MessageBox.Show("Did you cop any shoes this release, make sure to input the Qty");
            }
            else
                return;

        }

        private void txtPrice_Leave(object sender, EventArgs e)
        {
            if (txtPrice.Text == "")
            {
                string price = string.Empty;
                MessageBox.Show("Lets sell some shoes, input the price");

            }
        }

        private void txtSku_Leave(object sender, EventArgs e)
        {
            if (txtSku.Text == "")
            {
                string make = string.Empty;
                MessageBox.Show("Enter the sku!!!");
            }
            else
                return;
        }

        private void PicBox_Click(object sender, EventArgs e)
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


        #endregion
        //validation for Customer
        #region

        private void txtFName_Leave(object sender, EventArgs e)
        {
            if (txtFName.Text == "")
            {
                string vin = string.Empty;
                MessageBox.Show("Dont forget to add the First Name");
            }
            else if ((txtFName.Text.Length > 37))
            {
                txtFName.Clear();
                MessageBox.Show("Please check the name and that it doesnt exceed 37 charartcers");
                txtFName.Focus();
            }
            else
                return;
        }

        private void txtLName_Leave(object sender, EventArgs e)
        {
            if (txtLName.Text == "")
            {
                string vin = string.Empty;
                MessageBox.Show("Dont forget to add the Last Name");
            }
            else if ((txtColor.Text.Length > 37))
            {
                txtColor.Clear();
                MessageBox.Show("Please check the name and that it doesnt exceed 37 charartcers");
                txtColor.Focus();
            }
            else
                return;
        }

        private void txtAddy_Leave(object sender, EventArgs e)
        {
            if (txtAddy.Text == "")
            {
                string price = string.Empty;
                MessageBox.Show("Check that addy");

            }
        }

        private void txtCity_Leave(object sender, EventArgs e)
        {
            if (txtCity.Text == "")
            {
                string price = string.Empty;
                MessageBox.Show("What City are  you shipping too");

            }
        }

        private void txtState_Leave(object sender, EventArgs e)
        {
            if (txtState.Text == "")
            {
                string price = string.Empty;
                MessageBox.Show("Where is that state at");

            }
        }

        private void txtZip_Leave(object sender, EventArgs e)
        {
            if (txtZip.Text == "")
            {
                string price = string.Empty;
                MessageBox.Show("Check that zip code");

            }
        }

        private void txtCSku_Leave(object sender, EventArgs e)
        {
            if (txtCSku.Text == "")
            {
                string price = string.Empty;
                MessageBox.Show("Please check the Sku you entered");

            }
        }

        private void cmbCSize_Leave(object sender, EventArgs e)
        {
            if (cmbCSize.Text == "")
            {
                string size = string.Empty;
                MessageBox.Show("Ensure to input the size");
            }
        }


        #endregion
        //Search Function
        #region
        private void button1_Click(object sender, EventArgs e)
        {
            string searchValue = txtSearch.Text;

            invenGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            foreach (DataGridViewRow row in invenGrid.Rows)
            {
                if (row.Cells[7].Value.ToString().Contains(searchValue))
                {
                    invenGrid.Rows[row.Index].Visible = true;
                    int index = row.Index;
                    row.Visible = true;
                    invenGrid.FirstDisplayedScrollingRowIndex = index;

                }
                else if (row.Cells[2].Value.ToString().Contains(searchValue))
                {
                    invenGrid.Rows[row.Index].Visible = true;
                    int index = row.Index;
                    row.Visible = true;
                    invenGrid.FirstDisplayedScrollingRowIndex = index;
                }
                else
                {
                    int index = row.Index;
                    CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[invenGrid.DataSource];
                    currencyManager1.SuspendBinding();
                    invenGrid.Rows[row.Index].Visible = false;
                    currencyManager1.ResumeBinding();
                }
            }
        }

        private void btnSearchCus_Click(object sender, EventArgs e)
        {
            string searchValue = txtSearch.Text;

            custgrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            foreach (DataGridViewRow row in custgrid.Rows)
            {
                if (row.Cells[7].Value.ToString().Equals(searchValue))
                {
                    custgrid.Rows[row.Index].Visible = true;
                    int index = row.Index;
                    row.Visible = true;
                    invenGrid.FirstDisplayedScrollingRowIndex = index;

                }
                else if (row.Cells[0].Value.ToString().Equals(searchValue))
                {
                    custgrid.Rows[row.Index].Visible = true;
                    int index = row.Index;
                    row.Visible = true;
                    invenGrid.FirstDisplayedScrollingRowIndex = index;
                }
                else
                {

                    int index = row.Index;
                    CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[custgrid.DataSource];
                    currencyManager1.SuspendBinding();
                    custgrid.Rows[row.Index].Visible = false;
                    currencyManager1.ResumeBinding();
                }
            }
        }
        #endregion
    }
}
        
