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
        JoshorInterface JoshorInterface;
        public MobInterface(JoshorInterface passed)
        {
            InitializeComponent();
            this.JoshorInterface = passed;
            
        }
        
        private void MobInterface_Load(object sender, EventArgs e)
        {
            lblCreatureName.Text = "";
            lblDisplayHP.Text = "";
            lblDisplayAC.Text = "";
            lblDisplayDamage.Text = "";

            Monster mobs = World.Monsters.FirstOrDefault(mob => mob.name == JoshorInterface.cboEnemies.Text);
            if (mobs != null)
            {
                lblCreatureName.Text = mobs.name;
                lblDisplayHP.Text = mobs.CurrentHitPoints.ToString();
                lblDisplayAC.Text = mobs.ac.ToString();
                lblDisplayDamage.Text = mobs.damage.ToString();
                picMonster.Image = Image.FromFile(@"../../../Engine/Image/" + mobs.image);


            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
