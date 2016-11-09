using Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Engine
{
    public partial class CreateMob : Form
    {
        private List<TextBox> MobTextBoxes;
        public CreateMob()
        {
            InitializeComponent();
            BuildLists();
        }

        private void BuildLists()
        {
            MobTextBoxes = new List<TextBox>() { txtID, txtName, txtXP , txtAC, txtGold, txtDamage, txtBaseAttack,
                                                txtCurrentHp, txtMaxHp};
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);
            if (id > 0 && id <= 100)
            {
                foreach (Item item in World.Items.ToList())
                {
                    if (item.ID == id)
                    {
                        MessageBox.Show("That Mob already exist");
                    }
                }
                Factions factions;
                Enum.TryParse<Factions>(cboFaction.SelectedValue.ToString(), out factions);

                World.Monsters.Add(new Monster(id, txtName.Text, Convert.ToInt32(txtXP.Text), Convert.ToInt32(txtGold.Text), Convert.ToInt32(txtAC.Text),
                                    txtDamage.Text, Convert.ToInt32(txtBaseAttack.Text), Convert.ToInt32(txtCurrentHp.Text), Convert.ToInt32(txtMaxHp.Text),
                                    "", false, bool.Parse(cboAttackable.Text), factions));
                MessageBox.Show("NPC created!");
                ClearAll();

                if (File.Exists(@"../../../Engine/Docs/Monsters.txt"))
                {
                    File.AppendAllText(@"../../../Engine/Docs/Monsters.txt", "" + Environment.NewLine);
                    File.AppendAllText(@"../../../Engine/Docs/Monsters.txt", "ID: " + id.ToString() + Environment.NewLine);
                    File.AppendAllText(@"../../../Engine/Docs/Monsters.txt", "Name: " + txtName.Text + Environment.NewLine);
                    File.AppendAllText(@"../../../Engine/Docs/Monsters.txt", "XP: " + txtXP.Text + Environment.NewLine);
                    File.AppendAllText(@"../../../Engine/Docs/Monsters.txt", "Gold: " + txtGold.Text + Environment.NewLine);
                    File.AppendAllText(@"../../../Engine/Docs/Monsters.txt", "Armor: " + txtAC.Text + Environment.NewLine);
                    File.AppendAllText(@"../../../Engine/Docs/Monsters.txt", "Damage: " + txtDamage.Text + Environment.NewLine);
                    File.AppendAllText(@"../../../Engine/Docs/Monsters.txt", "BaseAttack: " + txtBaseAttack.Text + Environment.NewLine);
                    File.AppendAllText(@"../../../Engine/Docs/Monsters.txt", "CurrentHp: " + txtCurrentHp.Text + Environment.NewLine);
                    File.AppendAllText(@"../../../Engine/Docs/Monsters.txt", "MaxHp: " + txtMaxHp.Text + Environment.NewLine);
                    File.AppendAllText(@"../../../Engine/Docs/Monsters.txt", "Image: " + "" + Environment.NewLine);
                    File.AppendAllText(@"../../../Engine/Docs/Monsters.txt", "IsDead: " + "false" + Environment.NewLine);
                    File.AppendAllText(@"../../../Engine/Docs/Monsters.txt", "CanBeAttacked: " + cboAttackable.Text + Environment.NewLine);
                    File.AppendAllText(@"../../../Engine/Docs/Monsters.txt", "Faction: " + cboFaction.Text);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }


        public void ClearAll()
        {
            txtID.Text = "";
            txtName.Text = "";
            txtXP.Text = "";
            txtAC.Text = "";
            txtGold.Text = "";
            txtDamage.Text = "";
            txtBaseAttack.Text = "";
            txtCurrentHp.Text = "";
            txtMaxHp.Text = "";
            cboAttackable.SelectedItem = "";
            cboFaction.SelectedText = "";

        }

        public static class CreateFormInputValidation
        {
            public static bool CanParseStringToInt(string text)
            {
                try
                {
                    int answer = int.Parse(text);
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }

            public static bool StringIsEmpty(string text)
            {
                if (string.IsNullOrWhiteSpace(text) || string.Empty.Equals(text))
                    return true;

                return false;
            }

            public static bool ItemTextBoxesHaveErrors(List<TextBox> textboxes)
            {
                foreach (TextBox itemTxtBox in textboxes)
                {
                    if (CreateFormInputValidation.StringIsEmpty(itemTxtBox.Text))
                    {
                        // a text box was empty / null / or just whitespace
                        return true;
                    }

                }

                if (CanParseStringToInt(textboxes[0].Text) == false) // ID
                    return true;

                if (CanParseStringToInt(textboxes[3].Text) == false) //Price
                    return true;

                //If you get to here, there have been no errors
                return false;
            }
        }

        private void CreateMob_Load(object sender, EventArgs e)
        {
            cboFaction.DataSource = Enum.GetValues(typeof(Factions));
        }        
    }    
}
