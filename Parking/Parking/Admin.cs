using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parking.Core;
namespace Parking
{
    public partial class Admin : Form
    {
        AdminService service;
        public Admin()
        {
            InitializeComponent();
            service = new AdminService();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if(adminUserName.Text=="admin" && adminPassword.Text=="admin")
            {
                loginPanel.Visible = false;
                splitContainer1.Visible = true;
            }
        }

        private void addFloor_Click(object sender, EventArgs e)
        {
            newFloorPanel.Visible = true;
            dataShowPanel.Visible = false;
        }

        private void seeFloors_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = service.getFloors();
            dataGridView1.Refresh();
            dataShowPanel.Visible = true;
            newFloorPanel.Visible = false;
        }

        private void addFloorsSubmitButton_Click(object sender, EventArgs e)
        {
            try
            {
                int row = int.Parse(rowTextField.Text);
                int column = int.Parse(columnTextField.Text);

                service.createNewFloor(row, column);
                MessageBox.Show("Successfully created");
            }
            catch (Exception ex) { MessageBox.Show("Empty Text Field or Wrong Value" + ex.ToString()); }

        }

        private void allUserDataButton_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = service.getFAllUser();
            dataGridView1.Refresh();
            dataShowPanel.Visible = true;
            newFloorPanel.Visible = false;
        }

        private void currentUserDataButton_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = service.getCurrentUser();
            dataGridView1.Refresh();
            dataShowPanel.Visible = true;
            newFloorPanel.Visible = false;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginBackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
