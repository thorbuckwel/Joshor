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
    public partial class MonsterInfoWindow : Form
    {
        DungeonUI mainDungeonUI;                        // To give this form access to JoshorInterface
        public MonsterInfoWindow(DungeonUI passed)
        {
            InitializeComponent();
            this.mainDungeonUI = passed;
            
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
            Monster monster = World.Monsters.FirstOrDefault(mob => mob.Name == mainDungeonUI.cboEnemies.Text);
            if (monster != null)
            {
                lblCreatureName.Text = monster.Name;
                lblDisplayMobHP.Text = monster.CurrentHitPoints.ToString();
                lblDisplayAC.Text = monster.ArmorClass.ToString();
                lblDisplayDamage.Text = "1d" + monster.DamageDice.NumberOfSides.ToString();
                picMonster.Image = Image.FromFile(@"../../../Engine/Image/" + monster.ImagePath);
            }

            
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
