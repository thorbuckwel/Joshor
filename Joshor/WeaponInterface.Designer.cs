namespace Joshor
{
    partial class WeaponInterface
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblWepName = new System.Windows.Forms.Label();
            this.lblWepCost = new System.Windows.Forms.Label();
            this.lblDamageValue = new System.Windows.Forms.Label();
            this.lblDamageType = new System.Windows.Forms.Label();
            this.btnDamageTypes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Weapon Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Weapon Cost:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Damage:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Damage Type:";
            // 
            // lblWepName
            // 
            this.lblWepName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblWepName.Location = new System.Drawing.Point(111, 11);
            this.lblWepName.Name = "lblWepName";
            this.lblWepName.Size = new System.Drawing.Size(100, 23);
            this.lblWepName.TabIndex = 4;
            this.lblWepName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWepCost
            // 
            this.lblWepCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblWepCost.Location = new System.Drawing.Point(111, 40);
            this.lblWepCost.Name = "lblWepCost";
            this.lblWepCost.Size = new System.Drawing.Size(100, 23);
            this.lblWepCost.TabIndex = 5;
            this.lblWepCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDamageValue
            // 
            this.lblDamageValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDamageValue.Location = new System.Drawing.Point(111, 69);
            this.lblDamageValue.Name = "lblDamageValue";
            this.lblDamageValue.Size = new System.Drawing.Size(100, 23);
            this.lblDamageValue.TabIndex = 6;
            this.lblDamageValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDamageType
            // 
            this.lblDamageType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDamageType.Location = new System.Drawing.Point(111, 101);
            this.lblDamageType.Name = "lblDamageType";
            this.lblDamageType.Size = new System.Drawing.Size(100, 23);
            this.lblDamageType.TabIndex = 7;
            this.lblDamageType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDamageTypes
            // 
            this.btnDamageTypes.Location = new System.Drawing.Point(217, 101);
            this.btnDamageTypes.Name = "btnDamageTypes";
            this.btnDamageTypes.Size = new System.Drawing.Size(27, 23);
            this.btnDamageTypes.TabIndex = 8;
            this.btnDamageTypes.Text = "?";
            this.btnDamageTypes.UseVisualStyleBackColor = true;
            this.btnDamageTypes.Click += new System.EventHandler(this.btnDamageTypes_Click);
            // 
            // WeaponInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 131);
            this.Controls.Add(this.btnDamageTypes);
            this.Controls.Add(this.lblDamageType);
            this.Controls.Add(this.lblDamageValue);
            this.Controls.Add(this.lblWepCost);
            this.Controls.Add(this.lblWepName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "WeaponInterface";
            this.Text = "WeaponInterface";
            this.Load += new System.EventHandler(this.WeaponInterface_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblWepName;
        private System.Windows.Forms.Label lblWepCost;
        private System.Windows.Forms.Label lblDamageValue;
        private System.Windows.Forms.Label lblDamageType;
        private System.Windows.Forms.Button btnDamageTypes;
    }
}