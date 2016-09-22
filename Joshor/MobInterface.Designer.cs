namespace Joshor
{
    partial class MobInterface
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
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picMonster)).BeginInit();
            this.SuspendLayout();
            // 
            // picMonster
            // 
            this.picMonster.Location = new System.Drawing.Point(12, 12);
            this.picMonster.Name = "picMonster";
            this.picMonster.Size = new System.Drawing.Size(223, 208);
            this.picMonster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMonster.TabIndex = 0;
            this.picMonster.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(254, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Creature:";
            // 
            // lblCreatureName
            // 
            this.lblCreatureName.AutoSize = true;
            this.lblCreatureName.Location = new System.Drawing.Point(335, 25);
            this.lblCreatureName.Name = "lblCreatureName";
            this.lblCreatureName.Size = new System.Drawing.Size(115, 13);
            this.lblCreatureName.TabIndex = 2;
            this.lblCreatureName.Text = "888888888888888888";
            // 
            // lblHP
            // 
            this.lblHP.AutoSize = true;
            this.lblHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHP.Location = new System.Drawing.Point(257, 51);
            this.lblHP.Name = "lblHP";
            this.lblHP.Size = new System.Drawing.Size(73, 15);
            this.lblHP.TabIndex = 3;
            this.lblHP.Text = "Hit Points:";
            // 
            // lblDisplayMobHP
            // 
            this.lblDisplayMobHP.AutoSize = true;
            this.lblDisplayMobHP.Location = new System.Drawing.Point(335, 53);
            this.lblDisplayMobHP.Name = "lblDisplayMobHP";
            this.lblDisplayMobHP.Size = new System.Drawing.Size(103, 13);
            this.lblDisplayMobHP.TabIndex = 4;
            this.lblDisplayMobHP.Text = "8888888888888888";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(257, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "AC:";
            // 
            // lblDisplayAC
            // 
            this.lblDisplayAC.AutoSize = true;
            this.lblDisplayAC.Location = new System.Drawing.Point(335, 81);
            this.lblDisplayAC.Name = "lblDisplayAC";
            this.lblDisplayAC.Size = new System.Drawing.Size(97, 13);
            this.lblDisplayAC.TabIndex = 6;
            this.lblDisplayAC.Text = "888888888888888";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(257, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Damage:";
            // 
            // lblDisplayDamage
            // 
            this.lblDisplayDamage.AutoSize = true;
            this.lblDisplayDamage.Location = new System.Drawing.Point(335, 109);
            this.lblDisplayDamage.Name = "lblDisplayDamage";
            this.lblDisplayDamage.Size = new System.Drawing.Size(91, 13);
            this.lblDisplayDamage.TabIndex = 8;
            this.lblDisplayDamage.Text = "88888888888888";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(320, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MobInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 232);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblDisplayDamage);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblDisplayAC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblDisplayMobHP);
            this.Controls.Add(this.lblHP);
            this.Controls.Add(this.lblCreatureName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picMonster);
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
        private System.Windows.Forms.Button button1;
    }
}