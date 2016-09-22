namespace Joshor
{
    partial class MonsterInfoWindow
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
            this.picMonster = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCreatureName = new System.Windows.Forms.Label();
            this.lblHP = new System.Windows.Forms.Label();
            this.lblDisplayMobHP = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDisplayAC = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDisplayDamage = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picMonster)).BeginInit();
            this.SuspendLayout();
            // 
            // picMonster
            // 
            this.picMonster.Location = new System.Drawing.Point(24, 23);
            this.picMonster.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.picMonster.Name = "picMonster";
            this.picMonster.Size = new System.Drawing.Size(446, 400);
            this.picMonster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMonster.TabIndex = 0;
            this.picMonster.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(508, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Creature:";
            // 
            // lblCreatureName
            // 
            this.lblCreatureName.AutoSize = true;
            this.lblCreatureName.Location = new System.Drawing.Point(670, 48);
            this.lblCreatureName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCreatureName.Name = "lblCreatureName";
            this.lblCreatureName.Size = new System.Drawing.Size(228, 25);
            this.lblCreatureName.TabIndex = 2;
            this.lblCreatureName.Text = "888888888888888888";
            // 
            // lblHP
            // 
            this.lblHP.AutoSize = true;
            this.lblHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHP.Location = new System.Drawing.Point(514, 98);
            this.lblHP.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblHP.Name = "lblHP";
            this.lblHP.Size = new System.Drawing.Size(132, 29);
            this.lblHP.TabIndex = 3;
            this.lblHP.Text = "Hit Points:";
            // 
            // lblDisplayMobHP
            // 
            this.lblDisplayMobHP.AutoSize = true;
            this.lblDisplayMobHP.Location = new System.Drawing.Point(670, 102);
            this.lblDisplayMobHP.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDisplayMobHP.Name = "lblDisplayMobHP";
            this.lblDisplayMobHP.Size = new System.Drawing.Size(204, 25);
            this.lblDisplayMobHP.TabIndex = 4;
            this.lblDisplayMobHP.Text = "8888888888888888";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(514, 152);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "AC:";
            // 
            // lblDisplayAC
            // 
            this.lblDisplayAC.AutoSize = true;
            this.lblDisplayAC.Location = new System.Drawing.Point(670, 156);
            this.lblDisplayAC.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDisplayAC.Name = "lblDisplayAC";
            this.lblDisplayAC.Size = new System.Drawing.Size(192, 25);
            this.lblDisplayAC.TabIndex = 6;
            this.lblDisplayAC.Text = "888888888888888";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(514, 206);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 29);
            this.label6.TabIndex = 7;
            this.label6.Text = "Damage:";
            // 
            // lblDisplayDamage
            // 
            this.lblDisplayDamage.AutoSize = true;
            this.lblDisplayDamage.Location = new System.Drawing.Point(670, 210);
            this.lblDisplayDamage.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDisplayDamage.Name = "lblDisplayDamage";
            this.lblDisplayDamage.Size = new System.Drawing.Size(180, 25);
            this.lblDisplayDamage.TabIndex = 8;
            this.lblDisplayDamage.Text = "88888888888888";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(640, 317);
            this.closeButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(150, 44);
            this.closeButton.TabIndex = 9;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // MobInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 446);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.lblDisplayDamage);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblDisplayAC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblDisplayMobHP);
            this.Controls.Add(this.lblHP);
            this.Controls.Add(this.lblCreatureName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picMonster);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "MobInterface";
            this.Text = "MobInterface";
            this.Load += new System.EventHandler(this.MobInterface_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picMonster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picMonster;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCreatureName;
        private System.Windows.Forms.Label lblHP;
        private System.Windows.Forms.Label lblDisplayMobHP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDisplayAC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblDisplayDamage;
        private System.Windows.Forms.Button closeButton;
    }
}