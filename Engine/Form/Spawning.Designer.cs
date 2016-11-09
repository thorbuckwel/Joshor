namespace Engine
{
    partial class Spawning
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
            this.grbSpawnItem = new System.Windows.Forms.GroupBox();
            this.btnItemSpawn = new System.Windows.Forms.Button();
            this.cboItemList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grbSpawnWeapon = new System.Windows.Forms.GroupBox();
            this.btnWeaponSpawn = new System.Windows.Forms.Button();
            this.cboWeaponList = new System.Windows.Forms.ComboBox();
            this.grbMob = new System.Windows.Forms.GroupBox();
            this.btnMobSpawn = new System.Windows.Forms.Button();
            this.cboMobList = new System.Windows.Forms.ComboBox();
            this.grbNPC = new System.Windows.Forms.GroupBox();
            this.btnNPCSpawn = new System.Windows.Forms.Button();
            this.cboNPCList = new System.Windows.Forms.ComboBox();
            this.grbSpawnItem.SuspendLayout();
            this.grbSpawnWeapon.SuspendLayout();
            this.grbMob.SuspendLayout();
            this.grbNPC.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbSpawnItem
            // 
            this.grbSpawnItem.Controls.Add(this.btnItemSpawn);
            this.grbSpawnItem.Controls.Add(this.cboItemList);
            this.grbSpawnItem.Location = new System.Drawing.Point(12, 49);
            this.grbSpawnItem.Name = "grbSpawnItem";
            this.grbSpawnItem.Size = new System.Drawing.Size(357, 51);
            this.grbSpawnItem.TabIndex = 0;
            this.grbSpawnItem.TabStop = false;
            this.grbSpawnItem.Text = "Item";
            // 
            // btnItemSpawn
            // 
            this.btnItemSpawn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItemSpawn.Location = new System.Drawing.Point(246, 17);
            this.btnItemSpawn.Name = "btnItemSpawn";
            this.btnItemSpawn.Size = new System.Drawing.Size(105, 23);
            this.btnItemSpawn.TabIndex = 1;
            this.btnItemSpawn.Text = "Spawn";
            this.btnItemSpawn.UseVisualStyleBackColor = true;
            this.btnItemSpawn.Click += new System.EventHandler(this.btnItemSpawn_Click);
            // 
            // cboItemList
            // 
            this.cboItemList.FormattingEnabled = true;
            this.cboItemList.Location = new System.Drawing.Point(6, 19);
            this.cboItemList.Name = "cboItemList";
            this.cboItemList.Size = new System.Drawing.Size(220, 21);
            this.cboItemList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Spawning";
            // 
            // grbSpawnWeapon
            // 
            this.grbSpawnWeapon.Controls.Add(this.btnWeaponSpawn);
            this.grbSpawnWeapon.Controls.Add(this.cboWeaponList);
            this.grbSpawnWeapon.Location = new System.Drawing.Point(12, 106);
            this.grbSpawnWeapon.Name = "grbSpawnWeapon";
            this.grbSpawnWeapon.Size = new System.Drawing.Size(357, 48);
            this.grbSpawnWeapon.TabIndex = 2;
            this.grbSpawnWeapon.TabStop = false;
            this.grbSpawnWeapon.Text = "Weapon";
            // 
            // btnWeaponSpawn
            // 
            this.btnWeaponSpawn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWeaponSpawn.Location = new System.Drawing.Point(246, 15);
            this.btnWeaponSpawn.Name = "btnWeaponSpawn";
            this.btnWeaponSpawn.Size = new System.Drawing.Size(105, 23);
            this.btnWeaponSpawn.TabIndex = 1;
            this.btnWeaponSpawn.Text = "Spawn";
            this.btnWeaponSpawn.UseVisualStyleBackColor = true;
            this.btnWeaponSpawn.Click += new System.EventHandler(this.btnWeaponSpawn_Click);
            // 
            // cboWeaponList
            // 
            this.cboWeaponList.FormattingEnabled = true;
            this.cboWeaponList.Location = new System.Drawing.Point(6, 17);
            this.cboWeaponList.Name = "cboWeaponList";
            this.cboWeaponList.Size = new System.Drawing.Size(220, 21);
            this.cboWeaponList.TabIndex = 0;
            // 
            // grbMob
            // 
            this.grbMob.Controls.Add(this.btnMobSpawn);
            this.grbMob.Controls.Add(this.cboMobList);
            this.grbMob.Location = new System.Drawing.Point(12, 160);
            this.grbMob.Name = "grbMob";
            this.grbMob.Size = new System.Drawing.Size(357, 53);
            this.grbMob.TabIndex = 3;
            this.grbMob.TabStop = false;
            this.grbMob.Text = "Mob";
            // 
            // btnMobSpawn
            // 
            this.btnMobSpawn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMobSpawn.Location = new System.Drawing.Point(246, 18);
            this.btnMobSpawn.Name = "btnMobSpawn";
            this.btnMobSpawn.Size = new System.Drawing.Size(105, 23);
            this.btnMobSpawn.TabIndex = 1;
            this.btnMobSpawn.Text = "Spawn";
            this.btnMobSpawn.UseVisualStyleBackColor = true;
            this.btnMobSpawn.Click += new System.EventHandler(this.btnMobSpawn_Click);
            // 
            // cboMobList
            // 
            this.cboMobList.FormattingEnabled = true;
            this.cboMobList.Location = new System.Drawing.Point(6, 20);
            this.cboMobList.Name = "cboMobList";
            this.cboMobList.Size = new System.Drawing.Size(220, 21);
            this.cboMobList.TabIndex = 0;
            // 
            // grbNPC
            // 
            this.grbNPC.Controls.Add(this.btnNPCSpawn);
            this.grbNPC.Controls.Add(this.cboNPCList);
            this.grbNPC.Location = new System.Drawing.Point(12, 219);
            this.grbNPC.Name = "grbNPC";
            this.grbNPC.Size = new System.Drawing.Size(357, 50);
            this.grbNPC.TabIndex = 4;
            this.grbNPC.TabStop = false;
            this.grbNPC.Text = "NPC";
            // 
            // btnNPCSpawn
            // 
            this.btnNPCSpawn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNPCSpawn.Location = new System.Drawing.Point(246, 17);
            this.btnNPCSpawn.Name = "btnNPCSpawn";
            this.btnNPCSpawn.Size = new System.Drawing.Size(105, 23);
            this.btnNPCSpawn.TabIndex = 1;
            this.btnNPCSpawn.Text = "Spawn";
            this.btnNPCSpawn.UseVisualStyleBackColor = true;
            this.btnNPCSpawn.Click += new System.EventHandler(this.btnNPCSpawn_Click);
            // 
            // cboNPCList
            // 
            this.cboNPCList.FormattingEnabled = true;
            this.cboNPCList.Location = new System.Drawing.Point(6, 19);
            this.cboNPCList.Name = "cboNPCList";
            this.cboNPCList.Size = new System.Drawing.Size(220, 21);
            this.cboNPCList.TabIndex = 0;
            // 
            // Spawning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 294);
            this.Controls.Add(this.grbNPC);
            this.Controls.Add(this.grbMob);
            this.Controls.Add(this.grbSpawnWeapon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grbSpawnItem);
            this.Name = "Spawning";
            this.Text = "Spawning";
            this.Load += new System.EventHandler(this.Spawning_Load);
            this.grbSpawnItem.ResumeLayout(false);
            this.grbSpawnWeapon.ResumeLayout(false);
            this.grbMob.ResumeLayout(false);
            this.grbNPC.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbSpawnItem;
        private System.Windows.Forms.Button btnItemSpawn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbSpawnWeapon;
        private System.Windows.Forms.Button btnWeaponSpawn;
        private System.Windows.Forms.GroupBox grbMob;
        private System.Windows.Forms.ComboBox cboMobList;
        private System.Windows.Forms.GroupBox grbNPC;
        private System.Windows.Forms.Button btnMobSpawn;
        private System.Windows.Forms.Button btnNPCSpawn;
        private System.Windows.Forms.ComboBox cboNPCList;
        public System.Windows.Forms.ComboBox cboItemList;
        public System.Windows.Forms.ComboBox cboWeaponList;
    }
}