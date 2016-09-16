using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Engine;


namespace Joshor
{
    public partial class MobInterface : Form
    {
        JoshorInterface Form1Object = new JoshorInterface();

        public MobInterface()
        {
            InitializeComponent();
        }
        
        private void MobInterface_Load(object sender, EventArgs e)
        {
            lblCreatureName.Text = "";
            lblDisplayHP.Text = "";
            lblDisplayAC.Text = "";
            lblDisplayDamage.Text = "";

            foreach(Monster mob in World.Monsters)
            {
                if(mob.name == Form1Object.cboEnemies.Text)
                {
                    lblCreatureName.Text = mob.name;
                    lblDisplayHP.Text = mob.CurrentHitPoints.ToString();
                    lblDisplayAC.Text = mob.ac.ToString();
                    lblDisplayDamage.Text = mob.damage.ToString();


                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
