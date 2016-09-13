namespace Joshor
{
    partial class JoshorInterface
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grbInventory = new System.Windows.Forms.GroupBox();
            this.grbStats = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDisplayAC = new System.Windows.Forms.Label();
            this.lblDisplayLvl = new System.Windows.Forms.Label();
            this.lblDisplayExp = new System.Windows.Forms.Label();
            this.lblDisplayGold = new System.Windows.Forms.Label();
            this.lblDisplayHP = new System.Windows.Forms.Label();
            this.lblAC = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblExperience = new System.Windows.Forms.Label();
            this.lblGold = new System.Windows.Forms.Label();
            this.lblHP = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.llblRace = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.grbRoom = new System.Windows.Forms.GroupBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.grbEnvironment = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.grpRoomControls = new System.Windows.Forms.GroupBox();
            this.btnScan = new System.Windows.Forms.Button();
            this.btnLook = new System.Windows.Forms.Button();
            this.btnSouth = new System.Windows.Forms.Button();
            this.btnEast = new System.Windows.Forms.Button();
            this.btnWest = new System.Windows.Forms.Button();
            this.btnNorth = new System.Windows.Forms.Button();
            this.grpEnvironmentItems = new System.Windows.Forms.GroupBox();
            this.btnAttack = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblWeapon = new System.Windows.Forms.Label();
            this.btnGet = new System.Windows.Forms.Button();
            this.cboItems = new System.Windows.Forms.ComboBox();
            this.lblItems = new System.Windows.Forms.Label();
            this.btnEnemyView = new System.Windows.Forms.Button();
            this.cboEnemies = new System.Windows.Forms.ComboBox();
            this.lblEnemies = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grbInventory.SuspendLayout();
            this.grbStats.SuspendLayout();
            this.grbRoom.SuspendLayout();
            this.grbEnvironment.SuspendLayout();
            this.grpRoomControls.SuspendLayout();
            this.grpEnvironmentItems.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(301, 201);
            this.dataGridView1.TabIndex = 0;
            // 
            // grbInventory
            // 
            this.grbInventory.Controls.Add(this.dataGridView1);
            this.grbInventory.Location = new System.Drawing.Point(12, 412);
            this.grbInventory.Name = "grbInventory";
            this.grbInventory.Size = new System.Drawing.Size(307, 226);
            this.grbInventory.TabIndex = 1;
            this.grbInventory.TabStop = false;
            this.grbInventory.Text = "Inventory";
            // 
            // grbStats
            // 
            this.grbStats.Controls.Add(this.label3);
            this.grbStats.Controls.Add(this.label2);
            this.grbStats.Controls.Add(this.label1);
            this.grbStats.Controls.Add(this.lblDisplayAC);
            this.grbStats.Controls.Add(this.lblDisplayLvl);
            this.grbStats.Controls.Add(this.lblDisplayExp);
            this.grbStats.Controls.Add(this.lblDisplayGold);
            this.grbStats.Controls.Add(this.lblDisplayHP);
            this.grbStats.Controls.Add(this.lblAC);
            this.grbStats.Controls.Add(this.lblLevel);
            this.grbStats.Controls.Add(this.lblExperience);
            this.grbStats.Controls.Add(this.lblGold);
            this.grbStats.Controls.Add(this.lblHP);
            this.grbStats.Controls.Add(this.lblClass);
            this.grbStats.Controls.Add(this.llblRace);
            this.grbStats.Controls.Add(this.lblName);
            this.grbStats.Location = new System.Drawing.Point(12, 12);
            this.grbStats.Name = "grbStats";
            this.grbStats.Size = new System.Drawing.Size(307, 186);
            this.grbStats.TabIndex = 2;
            this.grbStats.TabStop = false;
            this.grbStats.Text = "Stats";
            this.grbStats.Enter += new System.EventHandler(this.grbStats_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(233, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 13;
            // 
            // lblDisplayAC
            // 
            this.lblDisplayAC.AutoSize = true;
            this.lblDisplayAC.Location = new System.Drawing.Point(92, 160);
            this.lblDisplayAC.Name = "lblDisplayAC";
            this.lblDisplayAC.Size = new System.Drawing.Size(0, 13);
            this.lblDisplayAC.TabIndex = 12;
            // 
            // lblDisplayLvl
            // 
            this.lblDisplayLvl.AutoSize = true;
            this.lblDisplayLvl.Location = new System.Drawing.Point(92, 136);
            this.lblDisplayLvl.Name = "lblDisplayLvl";
            this.lblDisplayLvl.Size = new System.Drawing.Size(0, 13);
            this.lblDisplayLvl.TabIndex = 11;
            // 
            // lblDisplayExp
            // 
            this.lblDisplayExp.AutoSize = true;
            this.lblDisplayExp.Location = new System.Drawing.Point(92, 112);
            this.lblDisplayExp.Name = "lblDisplayExp";
            this.lblDisplayExp.Size = new System.Drawing.Size(0, 13);
            this.lblDisplayExp.TabIndex = 10;
            // 
            // lblDisplayGold
            // 
            this.lblDisplayGold.AutoSize = true;
            this.lblDisplayGold.Location = new System.Drawing.Point(92, 88);
            this.lblDisplayGold.Name = "lblDisplayGold";
            this.lblDisplayGold.Size = new System.Drawing.Size(0, 13);
            this.lblDisplayGold.TabIndex = 9;
            // 
            // lblDisplayHP
            // 
            this.lblDisplayHP.AutoSize = true;
            this.lblDisplayHP.Location = new System.Drawing.Point(92, 64);
            this.lblDisplayHP.Name = "lblDisplayHP";
            this.lblDisplayHP.Size = new System.Drawing.Size(0, 13);
            this.lblDisplayHP.TabIndex = 8;
            // 
            // lblAC
            // 
            this.lblAC.AutoSize = true;
            this.lblAC.Location = new System.Drawing.Point(6, 160);
            this.lblAC.Name = "lblAC";
            this.lblAC.Size = new System.Drawing.Size(24, 13);
            this.lblAC.TabIndex = 7;
            this.lblAC.Text = "AC:";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(6, 136);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(36, 13);
            this.lblLevel.TabIndex = 6;
            this.lblLevel.Text = "Level:";
            // 
            // lblExperience
            // 
            this.lblExperience.AutoSize = true;
            this.lblExperience.Location = new System.Drawing.Point(6, 112);
            this.lblExperience.Name = "lblExperience";
            this.lblExperience.Size = new System.Drawing.Size(63, 13);
            this.lblExperience.TabIndex = 5;
            this.lblExperience.Text = "Experience:";
            this.lblExperience.Click += new System.EventHandler(this.lblExperience_Click);
            // 
            // lblGold
            // 
            this.lblGold.AutoSize = true;
            this.lblGold.Location = new System.Drawing.Point(6, 88);
            this.lblGold.Name = "lblGold";
            this.lblGold.Size = new System.Drawing.Size(32, 13);
            this.lblGold.TabIndex = 4;
            this.lblGold.Text = "Gold:";
            // 
            // lblHP
            // 
            this.lblHP.AutoSize = true;
            this.lblHP.Location = new System.Drawing.Point(6, 64);
            this.lblHP.Name = "lblHP";
            this.lblHP.Size = new System.Drawing.Size(55, 13);
            this.lblHP.TabIndex = 3;
            this.lblHP.Text = "Hit Points:";
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(233, 16);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(32, 13);
            this.lblClass.TabIndex = 2;
            this.lblClass.Text = "Class";
            // 
            // llblRace
            // 
            this.llblRace.AutoSize = true;
            this.llblRace.Location = new System.Drawing.Point(128, 16);
            this.llblRace.Name = "llblRace";
            this.llblRace.Size = new System.Drawing.Size(33, 13);
            this.llblRace.TabIndex = 1;
            this.llblRace.Text = "Race";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(26, 16);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // grbRoom
            // 
            this.grbRoom.Controls.Add(this.richTextBox2);
            this.grbRoom.Location = new System.Drawing.Point(590, 12);
            this.grbRoom.Name = "grbRoom";
            this.grbRoom.Size = new System.Drawing.Size(404, 275);
            this.grbRoom.TabIndex = 3;
            this.grbRoom.TabStop = false;
            this.grbRoom.Text = "Room";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(6, 19);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(392, 250);
            this.richTextBox2.TabIndex = 0;
            this.richTextBox2.Text = "";
            // 
            // grbEnvironment
            // 
            this.grbEnvironment.Controls.Add(this.richTextBox1);
            this.grbEnvironment.Location = new System.Drawing.Point(590, 293);
            this.grbEnvironment.Name = "grbEnvironment";
            this.grbEnvironment.Size = new System.Drawing.Size(404, 345);
            this.grbEnvironment.TabIndex = 4;
            this.grbEnvironment.TabStop = false;
            this.grbEnvironment.Text = "Environment";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(6, 19);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(392, 320);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // grpRoomControls
            // 
            this.grpRoomControls.Controls.Add(this.btnScan);
            this.grpRoomControls.Controls.Add(this.btnLook);
            this.grpRoomControls.Controls.Add(this.btnSouth);
            this.grpRoomControls.Controls.Add(this.btnEast);
            this.grpRoomControls.Controls.Add(this.btnWest);
            this.grpRoomControls.Controls.Add(this.btnNorth);
            this.grpRoomControls.Location = new System.Drawing.Point(325, 13);
            this.grpRoomControls.Name = "grpRoomControls";
            this.grpRoomControls.Size = new System.Drawing.Size(259, 274);
            this.grpRoomControls.TabIndex = 5;
            this.grpRoomControls.TabStop = false;
            this.grpRoomControls.Text = "Room Controls";
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(7, 245);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(75, 23);
            this.btnScan.TabIndex = 5;
            this.btnScan.Text = "Scan";
            this.btnScan.UseVisualStyleBackColor = true;
            // 
            // btnLook
            // 
            this.btnLook.Location = new System.Drawing.Point(178, 245);
            this.btnLook.Name = "btnLook";
            this.btnLook.Size = new System.Drawing.Size(75, 23);
            this.btnLook.TabIndex = 4;
            this.btnLook.Text = "Look";
            this.btnLook.UseVisualStyleBackColor = true;
            // 
            // btnSouth
            // 
            this.btnSouth.Location = new System.Drawing.Point(93, 68);
            this.btnSouth.Name = "btnSouth";
            this.btnSouth.Size = new System.Drawing.Size(75, 23);
            this.btnSouth.TabIndex = 3;
            this.btnSouth.Text = "South";
            this.btnSouth.UseVisualStyleBackColor = true;
            // 
            // btnEast
            // 
            this.btnEast.Location = new System.Drawing.Point(178, 43);
            this.btnEast.Name = "btnEast";
            this.btnEast.Size = new System.Drawing.Size(75, 23);
            this.btnEast.TabIndex = 2;
            this.btnEast.Text = "East";
            this.btnEast.UseVisualStyleBackColor = true;
            this.btnEast.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnWest
            // 
            this.btnWest.Location = new System.Drawing.Point(6, 43);
            this.btnWest.Name = "btnWest";
            this.btnWest.Size = new System.Drawing.Size(75, 23);
            this.btnWest.TabIndex = 1;
            this.btnWest.Text = "West";
            this.btnWest.UseVisualStyleBackColor = true;
            // 
            // btnNorth
            // 
            this.btnNorth.Location = new System.Drawing.Point(93, 18);
            this.btnNorth.Name = "btnNorth";
            this.btnNorth.Size = new System.Drawing.Size(75, 23);
            this.btnNorth.TabIndex = 0;
            this.btnNorth.Text = "North";
            this.btnNorth.UseVisualStyleBackColor = true;
            // 
            // grpEnvironmentItems
            // 
            this.grpEnvironmentItems.Controls.Add(this.btnAttack);
            this.grpEnvironmentItems.Controls.Add(this.comboBox1);
            this.grpEnvironmentItems.Controls.Add(this.lblWeapon);
            this.grpEnvironmentItems.Controls.Add(this.btnGet);
            this.grpEnvironmentItems.Controls.Add(this.cboItems);
            this.grpEnvironmentItems.Controls.Add(this.lblItems);
            this.grpEnvironmentItems.Controls.Add(this.btnEnemyView);
            this.grpEnvironmentItems.Controls.Add(this.cboEnemies);
            this.grpEnvironmentItems.Controls.Add(this.lblEnemies);
            this.grpEnvironmentItems.Location = new System.Drawing.Point(325, 293);
            this.grpEnvironmentItems.Name = "grpEnvironmentItems";
            this.grpEnvironmentItems.Size = new System.Drawing.Size(253, 345);
            this.grpEnvironmentItems.TabIndex = 6;
            this.grpEnvironmentItems.TabStop = false;
            this.grpEnvironmentItems.Text = "Environment Items";
            this.grpEnvironmentItems.Enter += new System.EventHandler(this.grpEnvironmentItems_Enter);
            // 
            // btnAttack
            // 
            this.btnAttack.Location = new System.Drawing.Point(93, 165);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(75, 23);
            this.btnAttack.TabIndex = 8;
            this.btnAttack.Text = "Attack With";
            this.btnAttack.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(69, 138);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // lblWeapon
            // 
            this.lblWeapon.AutoSize = true;
            this.lblWeapon.Location = new System.Drawing.Point(103, 122);
            this.lblWeapon.Name = "lblWeapon";
            this.lblWeapon.Size = new System.Drawing.Size(48, 13);
            this.lblWeapon.TabIndex = 6;
            this.lblWeapon.Text = "Weapon";
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(93, 265);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(75, 23);
            this.btnGet.TabIndex = 5;
            this.btnGet.Text = "Get";
            this.btnGet.UseVisualStyleBackColor = true;
            // 
            // cboItems
            // 
            this.cboItems.FormattingEnabled = true;
            this.cboItems.Location = new System.Drawing.Point(69, 238);
            this.cboItems.Name = "cboItems";
            this.cboItems.Size = new System.Drawing.Size(121, 21);
            this.cboItems.TabIndex = 4;
            // 
            // lblItems
            // 
            this.lblItems.AutoSize = true;
            this.lblItems.Location = new System.Drawing.Point(115, 222);
            this.lblItems.Name = "lblItems";
            this.lblItems.Size = new System.Drawing.Size(32, 13);
            this.lblItems.TabIndex = 3;
            this.lblItems.Text = "Items";
            // 
            // btnEnemyView
            // 
            this.btnEnemyView.Location = new System.Drawing.Point(93, 65);
            this.btnEnemyView.Name = "btnEnemyView";
            this.btnEnemyView.Size = new System.Drawing.Size(75, 23);
            this.btnEnemyView.TabIndex = 2;
            this.btnEnemyView.Text = "View";
            this.btnEnemyView.UseVisualStyleBackColor = true;
            // 
            // cboEnemies
            // 
            this.cboEnemies.FormattingEnabled = true;
            this.cboEnemies.Location = new System.Drawing.Point(69, 38);
            this.cboEnemies.Name = "cboEnemies";
            this.cboEnemies.Size = new System.Drawing.Size(121, 21);
            this.cboEnemies.TabIndex = 1;
            // 
            // lblEnemies
            // 
            this.lblEnemies.AutoSize = true;
            this.lblEnemies.Location = new System.Drawing.Point(103, 22);
            this.lblEnemies.Name = "lblEnemies";
            this.lblEnemies.Size = new System.Drawing.Size(47, 13);
            this.lblEnemies.TabIndex = 0;
            this.lblEnemies.Text = "Enemies";
            // 
            // JoshorInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 650);
            this.Controls.Add(this.grpEnvironmentItems);
            this.Controls.Add(this.grpRoomControls);
            this.Controls.Add(this.grbEnvironment);
            this.Controls.Add(this.grbRoom);
            this.Controls.Add(this.grbStats);
            this.Controls.Add(this.grbInventory);
            this.Name = "JoshorInterface";
            this.Text = "Joshor";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grbInventory.ResumeLayout(false);
            this.grbStats.ResumeLayout(false);
            this.grbStats.PerformLayout();
            this.grbRoom.ResumeLayout(false);
            this.grbEnvironment.ResumeLayout(false);
            this.grpRoomControls.ResumeLayout(false);
            this.grpEnvironmentItems.ResumeLayout(false);
            this.grpEnvironmentItems.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox grbInventory;
        private System.Windows.Forms.GroupBox grbStats;
        private System.Windows.Forms.GroupBox grbRoom;
        private System.Windows.Forms.GroupBox grbEnvironment;
        private System.Windows.Forms.Label lblAC;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblExperience;
        private System.Windows.Forms.Label lblGold;
        private System.Windows.Forms.Label lblHP;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label llblRace;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDisplayAC;
        private System.Windows.Forms.Label lblDisplayLvl;
        private System.Windows.Forms.Label lblDisplayExp;
        private System.Windows.Forms.Label lblDisplayGold;
        private System.Windows.Forms.Label lblDisplayHP;
        private System.Windows.Forms.GroupBox grpRoomControls;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.Button btnLook;
        private System.Windows.Forms.Button btnSouth;
        private System.Windows.Forms.Button btnEast;
        private System.Windows.Forms.Button btnWest;
        private System.Windows.Forms.Button btnNorth;
        private System.Windows.Forms.GroupBox grpEnvironmentItems;
        private System.Windows.Forms.Button btnEnemyView;
        private System.Windows.Forms.ComboBox cboEnemies;
        private System.Windows.Forms.Label lblEnemies;
        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblWeapon;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.ComboBox cboItems;
        private System.Windows.Forms.Label lblItems;
    }
}

