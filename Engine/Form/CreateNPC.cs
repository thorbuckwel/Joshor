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
    public partial class CreateNPC : Form
    {
        private List<TextBox> npcTextBoxes;
        public CreateNPC()
        {
            InitializeComponent();
            BuildLists();
        }

        private void BuildLists()
        {
            npcTextBoxes = new List<TextBox>() { txtID, txtName, txtClass, txtRace, txtGold,
                                                txtCurrentHp, txtMaxHp};
        }

        private void CreateNPC_Load(object sender, EventArgs e)
        {
            cboFaction.DataSource = Enum.GetValues(typeof(Factions));
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);
            if (id > 600 && id <= 700)
            {
                foreach (Item item in World.Items.ToList())
                {
                    if (item.ID == id)
                    {
                        MessageBox.Show("That item already exist");
                    }
                }
                Factions factions;
                Enum.TryParse<Factions>(cboFaction.SelectedValue.ToString(), out factions);

                World.NPCs.Add(new NPC(id, txtName.Text, txtClass.Text, txtRace.Text, Convert.ToInt32(txtGold.Text),
                                        Convert.ToInt32(txtCurrentHp.Text), Convert.ToInt32(txtMaxHp.Text), false,
                                        bool.Parse(cboAttackable.Text), factions));
                MessageBox.Show("NPC created!");

                if (File.Exists(@"../../../Engine/Docs/NPCs.txt"))
                {
                    File.AppendAllText(@"../../../Engine/Docs/NPCs.txt", "" + Environment.NewLine);
                    File.AppendAllText(@"../../../Engine/Docs/NPCs.txt", id.ToString() + Environment.NewLine);
                    File.AppendAllText(@"../../../Engine/Docs/NPCs.txt", txtName.Text + Environment.NewLine);
                    File.AppendAllText(@"../../../Engine/Docs/NPCs.txt", txtClass.Text + Environment.NewLine);
                    File.AppendAllText(@"../../../Engine/Docs/NPCs.txt", txtRace.Text + Environment.NewLine);
                    File.AppendAllText(@"../../../Engine/Docs/NPCs.txt", txtGold.Text + Environment.NewLine);
                    File.AppendAllText(@"../../../Engine/Docs/NPCs.txt", txtCurrentHp.Text + Environment.NewLine);
                    File.AppendAllText(@"../../../Engine/Docs/NPCs.txt", txtMaxHp.Text + Environment.NewLine);
                    File.AppendAllText(@"../../../Engine/Docs/NPCs.txt", "false" + Environment.NewLine);
                    File.AppendAllText(@"../../../Engine/Docs/NPCs.txt", cboAttackable.Text + Environment.NewLine);
                    File.AppendAllText(@"../../../Engine/Docs/NPCs.txt", cboFaction.Text);
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
            txtClass.Text = "";
            txtRace.Text = "";
            txtGold.Text = "";
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
    }
}
