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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grbInventory = new System.Windows.Forms.GroupBox();
            this.grbStats = new System.Windows.Forms.GroupBox();
            this.lblDisplayPlayerClass = new System.Windows.Forms.Label();
            this.lblDisplayPlayerRace = new System.Windows.Forms.Label();
            this.lblDisplayPlayerName = new System.Windows.Forms.Label();
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
            this.rtbLocation = new System.Windows.Forms.RichTextBox();
            this.grbEnvironment = new System.Windows.Forms.GroupBox();
            this.rtbEnv = new System.Windows.Forms.RichTextBox();
            this.grpRoomControls = new System.Windows.Forms.GroupBox();
            this.btnScan = new System.Windows.Forms.Button();
            this.btnLook = new System.Windows.Forms.Button();
            this.btnSouth = new System.Windows.Forms.Button();
            this.btnEast = new System.Windows.Forms.Button();
            this.btnWest = new System.Windows.Forms.Button();
            this.btnNorth = new System.Windows.Forms.Button();
            this.grpEnvironmentItems = new System.Windows.Forms.GroupBox();
            this.btnInspectWeapon = new System.Windows.Forms.Button();
            this.btnAttack = new System.Windows.Forms.Button();
            this.cboWeapons = new System.Windows.Forms.ComboBox();
            this.lblWeapon = new System.Windows.Forms.Label();
            this.btnGet = new System.Windows.Forms.Button();
            this.cboItems = new System.Windows.Forms.ComboBox();
            this.lblItems = new System.Windows.Forms.Label();
            this.btnEnemyView = new System.Windows.Forms.Button();
            this.cboEnemies = new System.Windows.Forms.ComboBox();
            this.lblEnemies = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
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
            this.grbStats.Controls.Add(this.lblDisplayPlayerClass);
            this.grbStats.Controls.Add(this.lblDisplayPlayerRace);
            this.grbStats.Controls.Add(this.lblDisplayPlayerName);
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
            // 
            // lblDisplayPlayerClass
            // 
            this.lblDisplayPlayerClass.Location = new System.Drawing.Point(204, 29);
            this.lblDisplayPlayerClass.Name = "lblDisplayPlayerClass";
            this.lblDisplayPlayerClass.Size = new System.Drawing.Size(97, 23);
            this.lblDisplayPlayerClass.TabIndex = 15;
            this.lblDisplayPlayerClass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDisplayPlayerRace
            // 
            this.lblDisplayPlayerRace.Location = new System.Drawing.Point(107, 29);
            this.lblDisplayPlayerRace.Name = "lblDisplayPlayerRace";
            this.lblDisplayPlayerRace.Size = new System.Drawing.Size(79, 23);
            this.lblDisplayPlayerRace.TabIndex = 14;
            this.lblDisplayPlayerRace.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDisplayPlayerName
            // 
            this.lblDisplayPlayerName.Location = new System.Drawing.Point(6, 29);
            this.lblDisplayPlayerName.Name = "lblDisplayPlayerName";
            this.lblDisplayPlayerName.Size = new System.Drawing.Size(77, 23);
            this.lblDisplayPlayerName.TabIndex = 13;
            this.lblDisplayPlayerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.lblClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClass.Location = new System.Drawing.Point(233, 16);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(37, 13);
            this.lblClass.TabIndex = 2;
            this.lblClass.Text = "Class";
            // 
            // llblRace
            // 
            this.llblRace.AutoSize = true;
            this.llblRace.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblRace.Location = new System.Drawing.Point(128, 16);
            this.llblRace.Name = "llblRace";
            this.llblRace.Size = new System.Drawing.Size(37, 13);
            this.llblRace.TabIndex = 1;
            this.llblRace.Text = "Race";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(26, 16);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(39, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // grbRoom
            // 
            this.grbRoom.Controls.Add(this.rtbLocation);
            this.grbRoom.Location = new System.Drawing.Point(590, 12);
            this.grbRoom.Name = "grbRoom";
            this.grbRoom.Size = new System.Drawing.Size(404, 186);
            this.grbRoom.TabIndex = 3;
            this.grbRoom.TabStop = false;
            this.grbRoom.Text = "Room";
            // 
            // rtbLocation
            // 
            this.rtbLocation.Location = new System.Drawing.Point(6, 19);
            this.rtbLocation.Name = "rtbLocation";
            this.rtbLocation.Size = new System.Drawing.Size(392, 154);
            this.rtbLocation.TabIndex = 0;
            this.rtbLocation.Text = "";
            // 
            // grbEnvironment
            // 
            this.grbEnvironment.Controls.Add(this.rtbEnv);
            this.grbEnvironment.Location = new System.Drawing.Point(590, 204);
            this.grbEnvironment.Name = "grbEnvironment";
            this.grbEnvironment.Size = new System.Drawing.Size(404, 434);
            this.grbEnvironment.TabIndex = 4;
            this.grbEnvironment.TabStop = false;
            this.grbEnvironment.Text = "Environment";
            // 
            // rtbEnv
            // 
            this.rtbEnv.Location = new System.Drawing.Point(6, 19);
            this.rtbEnv.Name = "rtbEnv";
            this.rtbEnv.Size = new System.Drawing.Size(392, 320);
            this.rtbEnv.TabIndex = 0;
            this.rtbEnv.Text = "";
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
            this.btnSouth.Visible = false;
            //this.btnSouth.Click += new System.EventHandler(this.btnSouth_Click);
            // 
            // btnEast
            // 
            this.btnEast.Location = new System.Drawing.Point(178, 43);
            this.btnEast.Name = "btnEast";
            this.btnEast.Size = new System.Drawing.Size(75, 23);
            this.btnEast.TabIndex = 2;
            this.btnEast.Text = "East";
            this.btnEast.UseVisualStyleBackColor = true;
            this.btnEast.Visible = false;
            // 
            // btnWest
            // 
            this.btnWest.Location = new System.Drawing.Point(6, 43);
            this.btnWest.Name = "btnWest";
            this.btnWest.Size = new System.Drawing.Size(75, 23);
            this.btnWest.TabIndex = 1;
            this.btnWest.Text = "West";
            this.btnWest.UseVisualStyleBackColor = true;
            this.btnWest.Visible = false;
            // 
            // btnNorth
            // 
            this.btnNorth.Location = new System.Drawing.Point(93, 18);
            this.btnNorth.Name = "btnNorth";
            this.btnNorth.Size = new System.Drawing.Size(75, 23);
            this.btnNorth.TabIndex = 0;
            this.btnNorth.Text = "North";
            this.btnNorth.UseVisualStyleBackColor = true;
            //this.btnNorth.Click += new System.EventHandler(this.btnNorth_Click);
            // 
            // grpEnvironmentItems
            // 
            this.grpEnvironmentItems.Controls.Add(this.btnInspectWeapon);
            this.grpEnvironmentItems.Controls.Add(this.btnAttack);
            this.grpEnvironmentItems.Controls.Add(this.cboWeapons);
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
            // 
            // btnInspectWeapon
            // 
            this.btnInspectWeapon.Location = new System.Drawing.Point(143, 165);
            this.btnInspectWeapon.Name = "btnInspectWeapon";
            this.btnInspectWeapon.Size = new System.Drawing.Size(75, 23);
            this.btnInspectWeapon.TabIndex = 9;
            this.btnInspectWeapon.Text = "Inspect";
            this.btnInspectWeapon.UseVisualStyleBackColor = true;
            //this.btnInspectWeapon.Click += new System.EventHandler(this.btnInspectWeapon_Click);
            // 
            // btnAttack
            // 
            this.btnAttack.Location = new System.Drawing.Point(42, 165);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(75, 23);
            this.btnAttack.TabIndex = 8;
            this.btnAttack.Text = "Attack With";
            this.btnAttack.UseVisualStyleBackColor = true;
            //this.btnAttack.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // cboWeapons
            // 
            this.cboWeapons.FormattingEnabled = true;
            this.cboWeapons.Location = new System.Drawing.Point(69, 138);
            this.cboWeapons.Name = "cboWeapons";
            this.cboWeapons.Size = new System.Drawing.Size(121, 21);
            this.cboWeapons.TabIndex = 7;
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
            //this.btnEnemyView.Click += new System.EventHandler(this.btnEnemyView_Click);
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
            // timer1
            // 
            this.timer1.Enabled = true;
            //this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            this.KeyPreview = true;
            this.Name = "JoshorInterface";
            this.Text = "Joshor";
           // this.Load += new System.EventHandler(this.JoshorInterface_Load);
            //this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.JoshorInterface_KeyDown);
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
        private System.Windows.Forms.RichTextBox rtbLocation;
        private System.Windows.Forms.Label lblDisplayPlayerClass;
        private System.Windows.Forms.Label lblDisplayPlayerRace;
        private System.Windows.Forms.Label lblDisplayPlayerName;
        private System.Windows.Forms.Label lblDisplayAC;
        private System.Windows.Forms.Label lblDisplayLvl;
        private System.Windows.Forms.Label lblDisplayExp;
        private System.Windows.Forms.Label lblDisplayGold;
        private System.Windows.Forms.GroupBox grpRoomControls;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.Button btnLook;
        private System.Windows.Forms.Button btnSouth;
        private System.Windows.Forms.Button btnEast;
        private System.Windows.Forms.Button btnWest;
        private System.Windows.Forms.Label lblEnemies;
        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.Label lblWeapon;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.ComboBox cboItems;
        private System.Windows.Forms.Label lblItems;
        public System.Windows.Forms.ComboBox cboEnemies;
        public System.Windows.Forms.GroupBox grpEnvironmentItems;
        public System.Windows.Forms.Button btnEnemyView;
        public System.Windows.Forms.Button btnNorth;
        private System.Windows.Forms.Button btnInspectWeapon;
        public System.Windows.Forms.ComboBox cboWeapons;
        public System.Windows.Forms.RichTextBox rtbEnv;
        public System.Windows.Forms.Label lblDisplayHP;
        public System.Windows.Forms.Timer timer1;
    }
}

