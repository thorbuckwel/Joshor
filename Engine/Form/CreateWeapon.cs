using Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace Engine
{
    public partial class CreateWeapon : Form
    {
        private List<TextBox> itemTextBoxes;
        public CreateWeapon()
        {
            InitializeComponent();
            BuildLists();
        }

        private void BuildLists()
        {
            itemTextBoxes = new List<TextBox>() { txtWeaponID, txtWeaponName, txtWeaponNamePlural, txtWeaponPrice, txtWeaponDamage, txtWeaponDescription };
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (CreateFormInputValidation.ItemTextBoxesHaveErrors(itemTextBoxes) == false)
            {
                //There are no errors with your text box,
                //create your item
                int id = Convert.ToInt32(txtWeaponID.Text);
                if (id > 100 && id <= 200)
                {
                    foreach (Weapon weapon in World.Weapons.ToList())
                    {
                        if (weapon.ID == id)
                        {
                            MessageBox.Show("That item already exist");
                        }
                    }
                    //World.Weapons.Add(new Weapon(id, txtWeaponName.Text, txtWeaponNamePlural.Text, txtWeaponDescription.Text, Convert.ToInt32(txtWeaponPrice.Text),
                                        //txtWeaponDamage.Text, cboWeaponDamageType.Text, bool.Parse(cboWeaponEquiptable.Text, int.Parse(cbo)));
                    MessageBox.Show("Weapon created!");

                    if (File.Exists(@"../../../Engine/Docs/Weapon.txt"))
                    {
                        File.AppendAllText(@"../../../Engine/Docs/Weapon.txt", "" + Environment.NewLine);
                        File.AppendAllText(@"../../../Engine/Docs/Weapon.txt", id.ToString() + Environment.NewLine);
                        File.AppendAllText(@"../../../Engine/Docs/Weapon.txt", txtWeaponName.Text + Environment.NewLine);
                        File.AppendAllText(@"../../../Engine/Docs/Weapon.txt", txtWeaponNamePlural.Text + Environment.NewLine);
                        File.AppendAllText(@"../../../Engine/Docs/Weapon.txt", txtWeaponDescription.Text + Environment.NewLine);
                        File.AppendAllText(@"../../../Engine/Docs/Weapon.txt", txtWeaponPrice.Text + Environment.NewLine);
                        File.AppendAllText(@"../../../Engine/Docs/Weapon.txt", txtWeaponDamage.Text + Environment.NewLine);
                        File.AppendAllText(@"../../../Engine/Docs/Weapon.txt", cboWeaponDamageType.Text + Environment.NewLine);
                        File.AppendAllText(@"../../../Engine/Docs/Weapon.txt", cboWeaponEquiptable.Text);
                    }

                    ClearAll();
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        public void ClearAll()
        {
            txtWeaponID.Text = "";
            txtWeaponName.Text = "";
            txtWeaponNamePlural.Text = "";
            txtWeaponDescription.Text = "";
            txtWeaponDamage.Text = "";
            cboWeaponDamageType.Text = "";
            txtWeaponPrice.Text = "";
            cboWeaponEquiptable.SelectedText = "";

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
