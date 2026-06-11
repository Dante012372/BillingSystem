namespace BillingSystem
{
    partial class AddCustomerForm
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
            lblFullName = new Label();
            txtFullName = new TextBox();
            lblAddress = new Label();
            txtAddress = new TextBox();
            lblContact = new Label();
            lblEmail = new Label();
            lblBalance = new Label();
            txtContact = new TextBox();
            txtEmail = new TextBox();
            txtBalance = new TextBox();
            btnSave = new Button();
            btnClear = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitle.Location = new Point(137, 24);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(157, 21);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Add New Cusotmer";
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Location = new Point(29, 71);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(64, 15);
            lblFullName.TabIndex = 1;
            lblFullName.Text = "Full Name:";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(132, 69);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(245, 23);
            txtFullName.TabIndex = 2;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(29, 107);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(52, 15);
            lblAddress.TabIndex = 3;
            lblAddress.Text = "Address:";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(132, 99);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(245, 23);
            txtAddress.TabIndex = 4;
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.Location = new Point(29, 143);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(99, 15);
            lblContact.TabIndex = 5;
            lblContact.Text = "Contact Number:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(29, 178);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "Email:";
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Location = new Point(29, 215);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(83, 15);
            lblBalance.TabIndex = 7;
            lblBalance.Text = "Initial Balance:";
            // 
            // txtContact
            // 
            txtContact.Location = new Point(132, 135);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(245, 23);
            txtContact.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(132, 170);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(244, 23);
            txtEmail.TabIndex = 9;
            // 
            // txtBalance
            // 
            txtBalance.Location = new Point(132, 207);
            txtBalance.Name = "txtBalance";
            txtBalance.Size = new Size(244, 23);
            txtBalance.TabIndex = 10;
            txtBalance.Text = "0.00";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(40, 266);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 11;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(163, 266);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 12;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(301, 266);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 13;
            btnBack.Text = "BACK";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // AddCustomerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 381);
            Controls.Add(btnBack);
            Controls.Add(btnClear);
            Controls.Add(btnSave);
            Controls.Add(txtBalance);
            Controls.Add(txtEmail);
            Controls.Add(txtContact);
            Controls.Add(lblBalance);
            Controls.Add(lblEmail);
            Controls.Add(lblContact);
            Controls.Add(txtAddress);
            Controls.Add(lblAddress);
            Controls.Add(txtFullName);
            Controls.Add(lblFullName);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AddCustomerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Billing System - Add Customer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblFullName;
        private TextBox txtFullName;
        private Label lblAddress;
        private TextBox txtAddress;
        private Label lblContact;
        private Label lblEmail;
        private Label lblBalance;
        private TextBox txtContact;
        private TextBox txtEmail;
        private TextBox txtBalance;
        private Button btnSave;
        private Button btnClear;
        private Button btnBack;
    }
}