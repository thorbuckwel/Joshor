namespace Engine
{
    partial class CreateNPC
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
            this.lblID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblRace = new System.Windows.Forms.Label();
            this.lblGold = new System.Windows.Forms.Label();
            this.lblCurrentHp = new System.Windows.Forms.Label();
            this.lblMaxHp = new System.Windows.Forms.Label();
            this.lblCanBeAttacked = new System.Windows.Forms.Label();
            this.lblFaction = new System.Windows.Forms.Label();
            this.txtCurrentHp = new System.Windows.Forms.TextBox();
            this.txtMaxHp = new System.Windows.Forms.TextBox();
            this.cboAttackable = new System.Windows.Forms.ComboBox();
            this.cboFaction = new System.Windows.Forms.ComboBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.txtRace = new System.Windows.Forms.TextBox();
            this.txtGold = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(112, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(157, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Create NPC";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(23, 50);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 13);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "ID:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(23, 73);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name:";
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(23, 100);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(35, 13);
            this.lblClass.TabIndex = 3;
            this.lblClass.Text = "Class:";
            // 
            // lblRace
            // 
            this.lblRace.AutoSize = true;
            this.lblRace.Location = new System.Drawing.Point(23, 126);
            this.lblRace.Name = "lblRace";
            this.lblRace.Size = new System.Drawing.Size(36, 13);
            this.lblRace.TabIndex = 4;
            this.lblRace.Text = "Race:";
            // 
            // lblGold
            // 
            this.lblGold.AutoSize = true;
            this.lblGold.Location = new System.Drawing.Point(24, 152);
            this.lblGold.Name = "lblGold";
            this.lblGold.Size = new System.Drawing.Size(32, 13);
            this.lblGold.TabIndex = 5;
            this.lblGold.Text = "Gold:";
            // 
            // lblCurrentHp
            // 
            this.lblCurrentHp.AutoSize = true;
            this.lblCurrentHp.Location = new System.Drawing.Point(182, 50);
            this.lblCurrentHp.Name = "lblCurrentHp";
            this.lblCurrentHp.Size = new System.Drawing.Size(61, 13);
            this.lblCurrentHp.TabIndex = 6;
            this.lblCurrentHp.Text = "Current Hp:";
            // 
            // lblMaxHp
            // 
            this.lblMaxHp.AutoSize = true;
            this.lblMaxHp.Location = new System.Drawing.Point(182, 73);
            this.lblMaxHp.Name = "lblMaxHp";
            this.lblMaxHp.Size = new System.Drawing.Size(47, 13);
            this.lblMaxHp.TabIndex = 7;
            this.lblMaxHp.Text = "Max Hp:";
            // 
            // lblCanBeAttacked
            // 
            this.lblCanBeAttacked.AutoSize = true;
            this.lblCanBeAttacked.Location = new System.Drawing.Point(182, 100);
            this.lblCanBeAttacked.Name = "lblCanBeAttacked";
            this.lblCanBeAttacked.Size = new System.Drawing.Size(94, 13);
            this.lblCanBeAttacked.TabIndex = 8;
            this.lblCanBeAttacked.Text = "Can Be Attacked?";
            // 
            // lblFaction
            // 
            this.lblFaction.AutoSize = true;
            this.lblFaction.Location = new System.Drawing.Point(182, 126);
            this.lblFaction.Name = "lblFaction";
            this.lblFaction.Size = new System.Drawing.Size(45, 13);
            this.lblFaction.TabIndex = 9;
            this.lblFaction.Text = "Faction:";
            // 
            // txtCurrentHp
            // 
            this.txtCurrentHp.Location = new System.Drawing.Point(285, 47);
            this.txtCurrentHp.Name = "txtCurrentHp";
            this.txtCurrentHp.Size = new System.Drawing.Size(84, 20);
            this.txtCurrentHp.TabIndex = 10;
            // 
            // txtMaxHp
            // 
            this.txtMaxHp.Location = new System.Drawing.Point(285, 70);
            this.txtMaxHp.Name = "txtMaxHp";
            this.txtMaxHp.Size = new System.Drawing.Size(84, 20);
            this.txtMaxHp.TabIndex = 11;
            // 
            // cboAttackable
            // 
            this.cboAttackable.FormattingEnabled = true;
            this.cboAttackable.Items.AddRange(new object[] {
            "True",
            "False"});
            this.cboAttackable.Location = new System.Drawing.Point(285, 96);
            this.cboAttackable.Name = "cboAttackable";
            this.cboAttackable.Size = new System.Drawing.Size(84, 21);
            this.cboAttackable.TabIndex = 12;
            // 
            // cboFaction
            // 
            this.cboFaction.FormattingEnabled = true;
            this.cboFaction.Location = new System.Drawing.Point(264, 123);
            this.cboFaction.Name = "cboFaction";
            this.cboFaction.Size = new System.Drawing.Size(105, 21);
            this.cboFaction.TabIndex = 13;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(76, 47);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 14;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(76, 70);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 15;
            // 
            // txtClass
            // 
            this.txtClass.Location = new System.Drawing.Point(76, 96);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(100, 20);
            this.txtClass.TabIndex = 16;
            // 
            // txtRace
            // 
            this.txtRace.Location = new System.Drawing.Point(76, 123);
            this.txtRace.Name = "txtRace";
            this.txtRace.Size = new System.Drawing.Size(100, 20);
            this.txtRace.TabIndex = 17;
            // 
            // txtGold
            // 
            this.txtGold.Location = new System.Drawing.Point(76, 149);
            this.txtGold.Name = "txtGold";
            this.txtGold.Size = new System.Drawing.Size(100, 20);
            this.txtGold.TabIndex = 18;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(112, 190);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 19;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(194, 189);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 20;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // CreateNPC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Engine.Properties.Resources.Npc;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(381, 234);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtGold);
            this.Controls.Add(this.txtRace);
            this.Controls.Add(this.txtClass);
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
            this.Controls.Add(this.lblRace);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblTitle);
            this.Name = "CreateNPC";
            this.Text = "CreateNPC";
            this.Load += new System.EventHandler(this.CreateNPC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblRace;
        private System.Windows.Forms.Label lblGold;
        private System.Windows.Forms.Label lblCurrentHp;
        private System.Windows.Forms.Label lblMaxHp;
        private System.Windows.Forms.Label lblCanBeAttacked;
        private System.Windows.Forms.Label lblFaction;
        private System.Windows.Forms.TextBox txtCurrentHp;
        private System.Windows.Forms.TextBox txtMaxHp;
        private System.Windows.Forms.ComboBox cboAttackable;
        private System.Windows.Forms.ComboBox cboFaction;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.TextBox txtRace;
        private System.Windows.Forms.TextBox txtGold;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnClear;
    }
}