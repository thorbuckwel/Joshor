namespace Engine
{
    partial class CreateMob
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
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtGold = new System.Windows.Forms.TextBox();
            this.txtAC = new System.Windows.Forms.TextBox();
            this.txtXP = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.cboFaction = new System.Windows.Forms.ComboBox();
            this.cboAttackable = new System.Windows.Forms.ComboBox();
            this.txtMaxHp = new System.Windows.Forms.TextBox();
            this.txtCurrentHp = new System.Windows.Forms.TextBox();
            this.lblFaction = new System.Windows.Forms.Label();
            this.lblCanBeAttacked = new System.Windows.Forms.Label();
            this.lblMaxHp = new System.Windows.Forms.Label();
            this.lblCurrentHp = new System.Windows.Forms.Label();
            this.lblGold = new System.Windows.Forms.Label();
            this.lblArmor = new System.Windows.Forms.Label();
            this.lblXP = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtDamage = new System.Windows.Forms.TextBox();
            this.lblDamage = new System.Windows.Forms.Label();
            this.txtBaseAttack = new System.Windows.Forms.TextBox();
            this.lblBaseAttack = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(185, 210);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 41;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(103, 211);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 40;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtGold
            // 
            this.txtGold.Location = new System.Drawing.Point(67, 149);
            this.txtGold.Name = "txtGold";
            this.txtGold.Size = new System.Drawing.Size(100, 20);
            this.txtGold.TabIndex = 39;
            // 
            // txtAC
            // 
            this.txtAC.Location = new System.Drawing.Point(67, 123);
            this.txtAC.Name = "txtAC";
            this.txtAC.Size = new System.Drawing.Size(100, 20);
            this.txtAC.TabIndex = 38;
            // 
            // txtXP
            // 
            this.txtXP.Location = new System.Drawing.Point(67, 96);
            this.txtXP.Name = "txtXP";
            this.txtXP.Size = new System.Drawing.Size(100, 20);
            this.txtXP.TabIndex = 37;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(67, 70);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 36;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(67, 47);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 35;
            // 
            // cboFaction
            // 
            this.cboFaction.FormattingEnabled = true;
            this.cboFaction.Location = new System.Drawing.Point(177, 178);
            this.cboFaction.Name = "cboFaction";
            this.cboFaction.Size = new System.Drawing.Size(105, 21);
            this.cboFaction.TabIndex = 34;
            // 
            // cboAttackable
            // 
            this.cboAttackable.FormattingEnabled = true;
            this.cboAttackable.Items.AddRange(new object[] {
            "True",
            "False"});
            this.cboAttackable.Location = new System.Drawing.Point(276, 146);
            this.cboAttackable.Name = "cboAttackable";
            this.cboAttackable.Size = new System.Drawing.Size(84, 21);
            this.cboAttackable.TabIndex = 33;
            // 
            // txtMaxHp
            // 
            this.txtMaxHp.Location = new System.Drawing.Point(276, 120);
            this.txtMaxHp.Name = "txtMaxHp";
            this.txtMaxHp.Size = new System.Drawing.Size(84, 20);
            this.txtMaxHp.TabIndex = 32;
            // 
            // txtCurrentHp
            // 
            this.txtCurrentHp.Location = new System.Drawing.Point(276, 97);
            this.txtCurrentHp.Name = "txtCurrentHp";
            this.txtCurrentHp.Size = new System.Drawing.Size(84, 20);
            this.txtCurrentHp.TabIndex = 31;
            // 
            // lblFaction
            // 
            this.lblFaction.AutoSize = true;
            this.lblFaction.Location = new System.Drawing.Point(95, 181);
            this.lblFaction.Name = "lblFaction";
            this.lblFaction.Size = new System.Drawing.Size(45, 13);
            this.lblFaction.TabIndex = 30;
            this.lblFaction.Text = "Faction:";
            // 
            // lblCanBeAttacked
            // 
            this.lblCanBeAttacked.AutoSize = true;
            this.lblCanBeAttacked.Location = new System.Drawing.Point(173, 150);
            this.lblCanBeAttacked.Name = "lblCanBeAttacked";
            this.lblCanBeAttacked.Size = new System.Drawing.Size(94, 13);
            this.lblCanBeAttacked.TabIndex = 29;
            this.lblCanBeAttacked.Text = "Can Be Attacked?";
            // 
            // lblMaxHp
            // 
            this.lblMaxHp.AutoSize = true;
            this.lblMaxHp.Location = new System.Drawing.Point(173, 123);
            this.lblMaxHp.Name = "lblMaxHp";
            this.lblMaxHp.Size = new System.Drawing.Size(47, 13);
            this.lblMaxHp.TabIndex = 28;
            this.lblMaxHp.Text = "Max Hp:";
            // 
            // lblCurrentHp
            // 
            this.lblCurrentHp.AutoSize = true;
            this.lblCurrentHp.Location = new System.Drawing.Point(173, 100);
            this.lblCurrentHp.Name = "lblCurrentHp";
            this.lblCurrentHp.Size = new System.Drawing.Size(61, 13);
            this.lblCurrentHp.TabIndex = 27;
            this.lblCurrentHp.Text = "Current Hp:";
            // 
            // lblGold
            // 
            this.lblGold.AutoSize = true;
            this.lblGold.Location = new System.Drawing.Point(15, 152);
            this.lblGold.Name = "lblGold";
            this.lblGold.Size = new System.Drawing.Size(32, 13);
            this.lblGold.TabIndex = 26;
            this.lblGold.Text = "Gold:";
            // 
            // lblArmor
            // 
            this.lblArmor.AutoSize = true;
            this.lblArmor.Location = new System.Drawing.Point(14, 126);
            this.lblArmor.Name = "lblArmor";
            this.lblArmor.Size = new System.Drawing.Size(24, 13);
            this.lblArmor.TabIndex = 25;
            this.lblArmor.Text = "AC:";
            // 
            // lblXP
            // 
            this.lblXP.AutoSize = true;
            this.lblXP.Location = new System.Drawing.Point(14, 100);
            this.lblXP.Name = "lblXP";
            this.lblXP.Size = new System.Drawing.Size(24, 13);
            this.lblXP.TabIndex = 24;
            this.lblXP.Text = "XP:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(14, 73);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 23;
            this.lblName.Text = "Name:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(14, 50);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 13);
            this.lblID.TabIndex = 22;
            this.lblID.Text = "ID:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(103, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(154, 31);
            this.lblTitle.TabIndex = 21;
            this.lblTitle.Text = "Create Mob";
            // 
            // txtDamage
            // 
            this.txtDamage.Location = new System.Drawing.Point(276, 43);
            this.txtDamage.Name = "txtDamage";
            this.txtDamage.Size = new System.Drawing.Size(84, 20);
            this.txtDamage.TabIndex = 43;
            // 
            // lblDamage
            // 
            this.lblDamage.AutoSize = true;
            this.lblDamage.Location = new System.Drawing.Point(173, 50);
            this.lblDamage.Name = "lblDamage";
            this.lblDamage.Size = new System.Drawing.Size(50, 13);
            this.lblDamage.TabIndex = 42;
            this.lblDamage.Text = "Damage:";
            // 
            // txtBaseAttack
            // 
            this.txtBaseAttack.Location = new System.Drawing.Point(276, 71);
            this.txtBaseAttack.Name = "txtBaseAttack";
            this.txtBaseAttack.Size = new System.Drawing.Size(84, 20);
            this.txtBaseAttack.TabIndex = 44;
            // 
            // lblBaseAttack
            // 
            this.lblBaseAttack.AutoSize = true;
            this.lblBaseAttack.Location = new System.Drawing.Point(173, 74);
            this.lblBaseAttack.Name = "lblBaseAttack";
            this.lblBaseAttack.Size = new System.Drawing.Size(68, 13);
            this.lblBaseAttack.TabIndex = 45;
            this.lblBaseAttack.Text = "Base Attack:";
            // 
            // CreateMob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Engine.Properties.Resources.Mob;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(377, 249);
            this.Controls.Add(this.lblBaseAttack);
            this.Controls.Add(this.txtBaseAttack);
            this.Controls.Add(this.txtDamage);
            this.Controls.Add(this.lblDamage);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtGold);
            this.Controls.Add(this.txtAC);
            this.Controls.Add(this.txtXP);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.cboFaction);
            this.Controls.Add(this.cboAttackable);
            this.Controls.Add(this.txtMaxHp);
            this.Controls.Add(this.txtCurrentHp);
            this.Controls.Add(this.lblFaction);
            this.Controls.Add(this.lblCanBeAttacked);
            this.Controls.Add(this.lblMaxHp);
            this.Controls.Add(this.lblCurrentHp);
            this.Controls.Add(this.lblGold);
            this.Controls.Add(this.lblArmor);
            this.Controls.Add(this.lblXP);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblTitle);
            this.Name = "CreateMob";
            this.Text = "CreateMob";
            this.Load += new System.EventHandler(this.CreateMob_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtGold;
        private System.Windows.Forms.TextBox txtAC;
        private System.Windows.Forms.TextBox txtXP;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.ComboBox cboFaction;
        private System.Windows.Forms.ComboBox cboAttackable;
        private System.Windows.Forms.TextBox txtMaxHp;
        private System.Windows.Forms.TextBox txtCurrentHp;
        private System.Windows.Forms.Label lblFaction;
        private System.Windows.Forms.Label lblCanBeAttacked;
        private System.Windows.Forms.Label lblMaxHp;
        private System.Windows.Forms.Label lblCurrentHp;
        private System.Windows.Forms.Label lblGold;
        private System.Windows.Forms.Label lblArmor;
        private System.Windows.Forms.Label lblXP;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtDamage;
        private System.Windows.Forms.Label lblDamage;
        private System.Windows.Forms.TextBox txtBaseAttack;
        private System.Windows.Forms.Label lblBaseAttack;
    }
}