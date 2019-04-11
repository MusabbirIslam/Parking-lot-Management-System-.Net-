namespace Parking
{
    partial class Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.loginPanel = new System.Windows.Forms.Panel();
            this.loginBackButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.adminPassword = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.adminUserName = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.backButton = new System.Windows.Forms.Button();
            this.currentUserDataButton = new System.Windows.Forms.Button();
            this.allUserDataButton = new System.Windows.Forms.Button();
            this.seeFloors = new System.Windows.Forms.Button();
            this.addFloor = new System.Windows.Forms.Button();
            this.newFloorPanel = new System.Windows.Forms.Panel();
            this.addFloorsSubmitButton = new System.Windows.Forms.Button();
            this.columnTextField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rowTextField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataShowPanel = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.loginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.newFloorPanel.SuspendLayout();
            this.dataShowPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // loginPanel
            // 
            this.loginPanel.Controls.Add(this.loginBackButton);
            this.loginPanel.Controls.Add(this.submitButton);
            this.loginPanel.Controls.Add(this.adminPassword);
            this.loginPanel.Controls.Add(this.label16);
            this.loginPanel.Controls.Add(this.adminUserName);
            this.loginPanel.Controls.Add(this.label15);
            this.loginPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginPanel.Location = new System.Drawing.Point(0, 0);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(736, 491);
            this.loginPanel.TabIndex = 0;
            // 
            // loginBackButton
            // 
            this.loginBackButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.loginBackButton.Location = new System.Drawing.Point(256, 317);
            this.loginBackButton.Name = "loginBackButton";
            this.loginBackButton.Size = new System.Drawing.Size(103, 52);
            this.loginBackButton.TabIndex = 10;
            this.loginBackButton.Text = "Back";
            this.loginBackButton.UseVisualStyleBackColor = true;
            this.loginBackButton.Click += new System.EventHandler(this.loginBackButton_Click);
            // 
            // submitButton
            // 
            this.submitButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.submitButton.Location = new System.Drawing.Point(365, 317);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(103, 52);
            this.submitButton.TabIndex = 9;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // adminPassword
            // 
            this.adminPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.adminPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminPassword.Location = new System.Drawing.Point(268, 252);
            this.adminPassword.Name = "adminPassword";
            this.adminPassword.PasswordChar = '*';
            this.adminPassword.Size = new System.Drawing.Size(200, 29);
            this.adminPassword.TabIndex = 8;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(315, 211);
            this.label16.Name = "label16";
            this.label16.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label16.Size = new System.Drawing.Size(102, 24);
            this.label16.TabIndex = 7;
            this.label16.Text = "Password :";
            this.label16.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // adminUserName
            // 
            this.adminUserName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.adminUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminUserName.Location = new System.Drawing.Point(268, 170);
            this.adminUserName.Name = "adminUserName";
            this.adminUserName.Size = new System.Drawing.Size(200, 29);
            this.adminUserName.TabIndex = 6;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(315, 130);
            this.label15.Name = "label15";
            this.label15.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label15.Size = new System.Drawing.Size(115, 24);
            this.label15.TabIndex = 5;
            this.label15.Text = "User Name :";
            this.label15.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.newFloorPanel);
            this.splitContainer1.Panel2.Controls.Add(this.dataShowPanel);
            this.splitContainer1.Size = new System.Drawing.Size(736, 491);
            this.splitContainer1.SplitterDistance = 193;
            this.splitContainer1.TabIndex = 10;
            this.splitContainer1.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.backButton, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.currentUserDataButton, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.allUserDataButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.seeFloors, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.addFloor, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(193, 491);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // backButton
            // 
            this.backButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backButton.Location = new System.Drawing.Point(3, 395);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(187, 93);
            this.backButton.TabIndex = 4;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // currentUserDataButton
            // 
            this.currentUserDataButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.currentUserDataButton.Location = new System.Drawing.Point(3, 297);
            this.currentUserDataButton.Name = "currentUserDataButton";
            this.currentUserDataButton.Size = new System.Drawing.Size(187, 92);
            this.currentUserDataButton.TabIndex = 3;
            this.currentUserDataButton.Text = "Current User List";
            this.currentUserDataButton.UseVisualStyleBackColor = true;
            this.currentUserDataButton.Click += new System.EventHandler(this.currentUserDataButton_Click);
            // 
            // allUserDataButton
            // 
            this.allUserDataButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allUserDataButton.Location = new System.Drawing.Point(3, 199);
            this.allUserDataButton.Name = "allUserDataButton";
            this.allUserDataButton.Size = new System.Drawing.Size(187, 92);
            this.allUserDataButton.TabIndex = 2;
            this.allUserDataButton.Text = "All Users List";
            this.allUserDataButton.UseVisualStyleBackColor = true;
            this.allUserDataButton.Click += new System.EventHandler(this.allUserDataButton_Click);
            // 
            // seeFloors
            // 
            this.seeFloors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.seeFloors.Location = new System.Drawing.Point(3, 101);
            this.seeFloors.Name = "seeFloors";
            this.seeFloors.Size = new System.Drawing.Size(187, 92);
            this.seeFloors.TabIndex = 1;
            this.seeFloors.Text = "All Floors";
            this.seeFloors.UseVisualStyleBackColor = true;
            this.seeFloors.Click += new System.EventHandler(this.seeFloors_Click);
            // 
            // addFloor
            // 
            this.addFloor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addFloor.Location = new System.Drawing.Point(3, 3);
            this.addFloor.Name = "addFloor";
            this.addFloor.Size = new System.Drawing.Size(187, 92);
            this.addFloor.TabIndex = 0;
            this.addFloor.Text = "Add New Floor";
            this.addFloor.UseVisualStyleBackColor = true;
            this.addFloor.Click += new System.EventHandler(this.addFloor_Click);
            // 
            // newFloorPanel
            // 
            this.newFloorPanel.Controls.Add(this.addFloorsSubmitButton);
            this.newFloorPanel.Controls.Add(this.columnTextField);
            this.newFloorPanel.Controls.Add(this.label2);
            this.newFloorPanel.Controls.Add(this.rowTextField);
            this.newFloorPanel.Controls.Add(this.label1);
            this.newFloorPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newFloorPanel.Location = new System.Drawing.Point(0, 0);
            this.newFloorPanel.Name = "newFloorPanel";
            this.newFloorPanel.Size = new System.Drawing.Size(539, 491);
            this.newFloorPanel.TabIndex = 0;
            // 
            // addFloorsSubmitButton
            // 
            this.addFloorsSubmitButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.addFloorsSubmitButton.Location = new System.Drawing.Point(232, 287);
            this.addFloorsSubmitButton.Name = "addFloorsSubmitButton";
            this.addFloorsSubmitButton.Size = new System.Drawing.Size(99, 41);
            this.addFloorsSubmitButton.TabIndex = 4;
            this.addFloorsSubmitButton.Text = "Submit";
            this.addFloorsSubmitButton.UseVisualStyleBackColor = true;
            this.addFloorsSubmitButton.Click += new System.EventHandler(this.addFloorsSubmitButton_Click);
            // 
            // columnTextField
            // 
            this.columnTextField.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.columnTextField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.columnTextField.Location = new System.Drawing.Point(322, 233);
            this.columnTextField.Name = "columnTextField";
            this.columnTextField.Size = new System.Drawing.Size(100, 26);
            this.columnTextField.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(135, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Number Of Colums";
            // 
            // rowTextField
            // 
            this.rowTextField.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rowTextField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rowTextField.Location = new System.Drawing.Point(322, 169);
            this.rowTextField.Name = "rowTextField";
            this.rowTextField.Size = new System.Drawing.Size(100, 26);
            this.rowTextField.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number Of Rows";
            // 
            // dataShowPanel
            // 
            this.dataShowPanel.Controls.Add(this.dataGridView1);
            this.dataShowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataShowPanel.Location = new System.Drawing.Point(0, 0);
            this.dataShowPanel.Name = "dataShowPanel";
            this.dataShowPanel.Size = new System.Drawing.Size(539, 491);
            this.dataShowPanel.TabIndex = 4;
            this.dataShowPanel.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(539, 491);
            this.dataGridView1.TabIndex = 0;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 491);
            this.Controls.Add(this.loginPanel);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Admin";
            this.Text = "Admin";
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.newFloorPanel.ResumeLayout(false);
            this.newFloorPanel.PerformLayout();
            this.dataShowPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TextBox adminPassword;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox adminUserName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button addFloor;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button currentUserDataButton;
        private System.Windows.Forms.Button allUserDataButton;
        private System.Windows.Forms.Button seeFloors;
        private System.Windows.Forms.Panel newFloorPanel;
        private System.Windows.Forms.TextBox rowTextField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox columnTextField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel dataShowPanel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button addFloorsSubmitButton;
        private System.Windows.Forms.Button loginBackButton;
    }
}