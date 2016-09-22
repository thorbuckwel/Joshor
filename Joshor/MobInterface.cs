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
        JoshorInterface JoshorInterface;                        // To give this form access to JoshorInterface
        public MobInterface(JoshorInterface passed)
        {
            InitializeComponent();
            this.JoshorInterface = passed;
            
        }
        
        private void MobInterface_Load(object sender, EventArgs e)
        {
            /**
             * Clear the lbls at load time
             */
            lblCreatureName.Text = "";
            lblDisplayMobHP.Text = "";
            lblDisplayAC.Text = "";
            lblDisplayDamage.Text = "";

            /**
             * This will access cboEnemies and get the current value in it. We then search the Monsters List
             * to match the name in the combobox to a Monster's name in the list and fill in the lbls with values
             * from that Monster object.
             */
            Monster mobs = World.Monsters.FirstOrDefault(mob => mob.Name == JoshorInterface.cboEnemies.Text);
            if (mobs != null)
            {
                lblCreatureName.Text = mobs.Name;
                lblDisplayMobHP.Text = mobs.CurrentHitPoints.ToString();
                lblDisplayAC.Text = mobs.AC.ToString();
                lblDisplayDamage.Text = mobs.Damage.ToString();
                picMonster.Image = Image.FromFile(@"../../../Engine/Image/" + mobs.Image);


            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
