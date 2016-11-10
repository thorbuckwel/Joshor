namespace Engine
{
    partial class CreateWeapon
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
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.cboWeaponDamageType = new System.Windows.Forms.ComboBox();
            this.txtWeaponDescription = new System.Windows.Forms.TextBox();
            this.txtWeaponDamage = new System.Windows.Forms.TextBox();
            this.txtWeaponPrice = new System.Windows.Forms.TextBox();
            this.txtWeaponNamePlural = new System.Windows.Forms.TextBox();
            this.txtWeaponName = new System.Windows.Forms.TextBox();
            this.txtWeaponID = new System.Windows.Forms.TextBox();
            this.gboWeaponEquiptable = new System.Windows.Forms.GroupBox();
            this.cboWeaponEquiptable = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDamageType = new System.Windows.Forms.Label();
            this.lblDamage = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblNamePlural = new System.Windows.Forms.Label();
            this.lblWeaponName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.gboWeaponEquiptable.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(98, 23);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(197, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Create Weapon";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(204, 303);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(115, 303);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 15;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // cboWeaponDamageType
            // 
            this.cboWeaponDamageType.FormattingEnabled = true;
            this.cboWeaponDamageType.Items.AddRange(new object[] {
            "Slash",
            "Blunt",
            "Pierce"});
            this.cboWeaponDamageType.Location = new System.Drawing.Point(144, 193);
            this.cboWeaponDamageType.Name = "cboWeaponDamageType";
            this.cboWeaponDamageType.Size = new System.Drawing.Size(100, 21);
            this.cboWeaponDamageType.TabIndex = 14;
            // 
            // txtWeaponDescription
            // 
            this.txtWeaponDescription.Location = new System.Drawing.Point(13, 244);
            this.txtWeaponDescription.Multiline = true;
            this.txtWeaponDescription.Name = "txtWeaponDescription";
            this.txtWeaponDescription.Size = new System.Drawing.Size(369, 42);
            this.txtWeaponDescription.TabIndex = 13;
            // 
            // txtWeaponDamage
            // 
            this.txtWeaponDamage.Location = new System.Drawing.Point(144, 169);
            this.txtWeaponDamage.Name = "txtWeaponDamage";
            this.txtWeaponDamage.Size = new System.Drawing.Size(100, 20);
            this.txtWeaponDamage.TabIndex = 12;
            // 
            // txtWeaponPrice
            // 
            this.txtWeaponPrice.Location = new System.Drawing.Point(144, 145);
            this.txtWeaponPrice.Name = "txtWeaponPrice";
            this.txtWeaponPrice.Size = new System.Drawing.Size(100, 20);
            this.txtWeaponPrice.TabIndex = 11;
            // 
            // txtWeaponNamePlural
            // 
            this.txtWeaponNamePlural.Location = new System.Drawing.Point(144, 119);
            this.txtWeaponNamePlural.Name = "txtWeaponNamePlural";
            this.txtWeaponNamePlural.Size = new System.Drawing.Size(100, 20);
            this.txtWeaponNamePlural.TabIndex = 10;
            // 
            // txtWeaponName
            // 
            this.txtWeaponName.Location = new System.Drawing.Point(144, 96);
            this.txtWeaponName.Name = "txtWeaponName";
            this.txtWeaponName.Size = new System.Drawing.Size(100, 20);
            this.txtWeaponName.TabIndex = 9;
            // 
            // txtWeaponID
            // 
            this.txtWeaponID.Location = new System.Drawing.Point(144, 73);
            this.txtWeaponID.Name = "txtWeaponID";
            this.txtWeaponID.Size = new System.Drawing.Size(100, 20);
            this.txtWeaponID.TabIndex = 8;
            // 
            // gboWeaponEquiptable
            // 
            this.gboWeaponEquiptable.Controls.Add(this.cboWeaponEquiptable);
            this.gboWeaponEquiptable.Location = new System.Drawing.Point(279, 70);
            this.gboWeaponEquiptable.Name = "gboWeaponEquiptable";
            this.gboWeaponEquiptable.Size = new System.Drawing.Size(88, 72);
            this.gboWeaponEquiptable.TabIndex = 7;
            this.gboWeaponEquiptable.TabStop = false;
            this.gboWeaponEquiptable.Text = "Equiptable";
            // 
            // cboWeaponEquiptable
            // 
            this.cboWeaponEquiptable.FormattingEnabled = true;
            this.cboWeaponEquiptable.Items.AddRange(new object[] {
            "True",
            "False"});
            this.cboWeaponEquiptable.Location = new System.Drawing.Point(18, 26);
            this.cboWeaponEquiptable.Name = "cboWeaponEquiptable";
            this.cboWeaponEquiptable.Size = new System.Drawing.Size(60, 21);
            this.cboWeaponEquiptable.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Description";
            // 
            // lblDamageType
            // 
            this.lblDamageType.AutoSize = true;
            this.lblDamageType.Location = new System.Drawing.Point(23, 196);
            this.lblDamageType.Name = "lblDamageType";
            this.lblDamageType.Size = new System.Drawing.Size(77, 13);
            this.lblDamageType.TabIndex = 5;
            this.lblDamageType.Text = "Damage Type:";
            // 
            // lblDamage
            // 
            this.lblDamage.AutoSize = true;
            this.lblDamage.Location = new System.Drawing.Point(23, 172);
            this.lblDamage.Name = "lblDamage";
            this.lblDamage.Size = new System.Drawing.Size(50, 13);
            this.lblDamage.TabIndex = 4;
            this.lblDamage.Text = "Damage:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(23, 148);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(34, 13);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "Price:";
            // 
            // lblNamePlural
            // 
            this.lblNamePlural.AutoSize = true;
            this.lblNamePlural.Location = new System.Drawing.Point(23, 124);
            this.lblNamePlural.Name = "lblNamePlural";
            this.lblNamePlural.Size = new System.Drawing.Size(67, 13);
            this.lblNamePlural.TabIndex = 2;
            this.lblNamePlural.Text = "Plural Name:";
            // 
            // lblWeaponName
            // 
            this.lblWeaponName.AutoSize = true;
            this.lblWeaponName.Location = new System.Drawing.Point(23, 100);
            this.lblWeaponName.Name = "lblWeaponName";
            this.lblWeaponName.Size = new System.Drawing.Size(38, 13);
            this.lblWeaponName.TabIndex = 1;
            this.lblWeaponName.Text = "Name:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(23, 76);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 13);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID:";
            // 
            // CreateWeapon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Engine.Properties.Resources.Weapons;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(400, 370);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.cboWeaponDamageType);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtWeaponDescription);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtWeaponDamage);
            this.Controls.Add(this.lblWeaponName);
            this.Controls.Add(this.txtWeaponPrice);
            this.Controls.Add(this.lblNamePlural);
            this.Controls.Add(this.txtWeaponNamePlural);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtWeaponName);
            this.Controls.Add(this.lblDamage);
            this.Controls.Add(this.txtWeaponID);
            this.Controls.Add(this.lblDamageType);
            this.Controls.Add(this.gboWeaponEquiptable);
            this.Controls.Add(this.label1);
            this.Name = "CreateWeapon";
            this.Text = "CreateWeapon";
            this.gboWeaponEquiptable.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblWeaponName;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblNamePlural;
        private System.Windows.Forms.Label lblDamage;
        private System.Windows.Forms.Label lblDamageType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.ComboBox cboWeaponDamageType;
        private System.Windows.Forms.TextBox txtWeaponDescription;
        private System.Windows.Forms.TextBox txtWeaponDamage;
        private System.Windows.Forms.TextBox txtWeaponPrice;
        private System.Windows.Forms.TextBox txtWeaponNamePlural;
        private System.Windows.Forms.TextBox txtWeaponName;
        private System.Windows.Forms.TextBox txtWeaponID;
        private System.Windows.Forms.GroupBox gboWeaponEquiptable;
        private System.Windows.Forms.ComboBox cboWeaponEquiptable;
    }
}