﻿namespace JosherConsole
{
    partial class CreateScreen
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.gboItem = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtNamePlural = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.gboEquiptable = new System.Windows.Forms.GroupBox();
            this.cboItemEquiptable = new System.Windows.Forms.ComboBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblNamePlural = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblItemName = new System.Windows.Forms.Label();
            this.gboItem.SuspendLayout();
            this.gboEquiptable.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(99, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(153, 31);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Create Item";
            // 
            // gboItem
            // 
            this.gboItem.Controls.Add(this.btnClear);
            this.gboItem.Controls.Add(this.btnCreate);
            this.gboItem.Controls.Add(this.txtDescription);
            this.gboItem.Controls.Add(this.lblDescription);
            this.gboItem.Controls.Add(this.txtPrice);
            this.gboItem.Controls.Add(this.txtNamePlural);
            this.gboItem.Controls.Add(this.txtName);
            this.gboItem.Controls.Add(this.txtID);
            this.gboItem.Controls.Add(this.gboEquiptable);
            this.gboItem.Controls.Add(this.lblCost);
            this.gboItem.Controls.Add(this.lblNamePlural);
            this.gboItem.Controls.Add(this.lblID);
            this.gboItem.Controls.Add(this.lblItemName);
            this.gboItem.Location = new System.Drawing.Point(12, 43);
            this.gboItem.Name = "gboItem";
            this.gboItem.Size = new System.Drawing.Size(325, 337);
            this.gboItem.TabIndex = 2;
            this.gboItem.TabStop = false;
            this.gboItem.Text = "Items";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(170, 297);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(79, 297);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 11;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click_1);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(9, 153);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(292, 130);
            this.txtDescription.TabIndex = 10;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(117, 133);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(63, 13);
            this.lblDescription.TabIndex = 9;
            this.lblDescription.Text = "Description:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(107, 94);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 8;
            // 
            // txtNamePlural
            // 
            this.txtNamePlural.Location = new System.Drawing.Point(107, 68);
            this.txtNamePlural.Name = "txtNamePlural";
            this.txtNamePlural.Size = new System.Drawing.Size(100, 20);
            this.txtNamePlural.TabIndex = 7;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(107, 42);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 6;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(107, 16);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 5;
            // 
            // gboEquiptable
            // 
            this.gboEquiptable.Controls.Add(this.cboItemEquiptable);
            this.gboEquiptable.Location = new System.Drawing.Point(213, 19);
            this.gboEquiptable.Name = "gboEquiptable";
            this.gboEquiptable.Size = new System.Drawing.Size(88, 72);
            this.gboEquiptable.TabIndex = 4;
            this.gboEquiptable.TabStop = false;
            this.gboEquiptable.Text = "Equiptable";
            // 
            // cboItemEquiptable
            // 
            this.cboItemEquiptable.FormattingEnabled = true;
            this.cboItemEquiptable.Items.AddRange(new object[] {
            "True",
            "False"});
            this.cboItemEquiptable.Location = new System.Drawing.Point(18, 26);
            this.cboItemEquiptable.Name = "cboItemEquiptable";
            this.cboItemEquiptable.Size = new System.Drawing.Size(60, 21);
            this.cboItemEquiptable.TabIndex = 0;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(6, 97);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(34, 13);
            this.lblCost.TabIndex = 3;
            this.lblCost.Text = "Price:";
            // 
            // lblNamePlural
            // 
            this.lblNamePlural.AutoSize = true;
            this.lblNamePlural.Location = new System.Drawing.Point(6, 71);
            this.lblNamePlural.Name = "lblNamePlural";
            this.lblNamePlural.Size = new System.Drawing.Size(67, 13);
            this.lblNamePlural.TabIndex = 2;
            this.lblNamePlural.Text = "Plural Name:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(10, 19);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 13);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "ID:";
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Location = new System.Drawing.Point(6, 45);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(38, 13);
            this.lblItemName.TabIndex = 0;
            this.lblItemName.Text = "Name:";
            // 
            // CreateScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 400);
            this.Controls.Add(this.gboItem);
            this.Controls.Add(this.lblTitle);
            this.Name = "CreateScreen";
            this.Text = "CreateItem";
            this.gboItem.ResumeLayout(false);
            this.gboItem.PerformLayout();
            this.gboEquiptable.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gboItem;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtNamePlural;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.GroupBox gboEquiptable;
        private System.Windows.Forms.ComboBox cboItemEquiptable;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblNamePlural;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblItemName;
    }
}