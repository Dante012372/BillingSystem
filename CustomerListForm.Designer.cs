namespace BillingSystem
{
    partial class CustomerListForm
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
            lblTitle = new Label();
            dgvCustomers = new DataGridView();
            btnAdd = new Button();
            btnDelete = new Button();
            btnLogout = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            CustomerID = new DataGridViewTextBoxColumn();
            FullName = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            ContactNumber = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Balance = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(38, 39);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(133, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Customer List";
            // 
            // dgvCustomers
            // 
            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomers.Columns.AddRange(new DataGridViewColumn[] { CustomerID, FullName, Address, ContactNumber, Email, Balance });
            dgvCustomers.Location = new Point(41, 100);
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomers.Size = new Size(692, 145);
            dgvCustomers.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(38, 276);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 33);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(332, 276);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(117, 33);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(604, 276);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(129, 31);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "LOGOUT";
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(217, 48);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(131, 26);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "SEARCH";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(370, 45);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(265, 23);
            txtSearch.TabIndex = 6;
            // 
            // CustomerID
            // 
            CustomerID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CustomerID.HeaderText = "ID";
            CustomerID.Name = "CustomerID";
            CustomerID.ReadOnly = true;
            // 
            // FullName
            // 
            FullName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            FullName.HeaderText = "Full Name";
            FullName.Name = "FullName";
            FullName.ReadOnly = true;
            // 
            // Address
            // 
            Address.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Address.HeaderText = "Address";
            Address.Name = "Address";
            Address.ReadOnly = true;
            // 
            // ContactNumber
            // 
            ContactNumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ContactNumber.HeaderText = "Contact Number";
            ContactNumber.Name = "ContactNumber";
            ContactNumber.ReadOnly = true;
            // 
            // Email
            // 
            Email.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Email.HeaderText = "Email";
            Email.Name = "Email";
            Email.ReadOnly = true;
            // 
            // Balance
            // 
            Balance.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Balance.HeaderText = "Balance";
            Balance.Name = "Balance";
            Balance.ReadOnly = true;
            // 
            // CustomerListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(btnLogout);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(dgvCustomers);
            Controls.Add(lblTitle);
            Name = "CustomerListForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Billing System - Customer List";
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private DataGridView dgvCustomers;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnLogout;
        private Button btnSearch;
        private TextBox txtSearch;
        private DataGridViewTextBoxColumn CustomerID;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn ContactNumber;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Balance;
    }
}