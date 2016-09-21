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
    public partial class WeaponInterface : Form
    {
        JoshorInterface JoshorInterface; //Allows this form to interact with the parent form
        public WeaponInterface(JoshorInterface passed)
        {
            InitializeComponent();
            this.JoshorInterface = passed;
        }

        private void btnDamageTypes_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<DamageTypesExplanation>().Count() == 1)
            {

            }
            else
            {
                DamageTypesExplanation frm = new DamageTypesExplanation();
                frm.Show();
            }
        }

        private void WeaponInterface_Load(object sender, EventArgs e)
        {
            lblWepName.Text = string.Empty;
            lblWepCost.Text = string.Empty;
            lblDamageValue.Text = string.Empty;
            lblDamageType.Text = string.Empty;

            Weapon weapons = World.Weapons.FirstOrDefault(weapon => weapon.name == JoshorInterface.cboWeapons.Text);
            if(weapons != null)
            {
                lblWepName.Text = weapons.name.ToString();
                lblWepCost.Text = weapons.cost.ToString();
                lblDamageValue.Text = weapons.damage.ToString();
                lblDamageType.Text = weapons.damageType.ToString();
            }
        }
    }
}
