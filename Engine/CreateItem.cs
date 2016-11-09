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

namespace JosherConsole
{
    public partial class CreateScreen : Form
    {
        private List<TextBox> itemTextBoxes;
        public CreateScreen()
        {
            InitializeComponent();
            BuildLists();            
        }

        private void BuildLists()
        {
            itemTextBoxes = new List<TextBox>() { txtID, txtName, txtNamePlural, txtPrice, txtDescription };
        }

       

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }


        public void ClearAll()
        {
            txtID.Text = "";
            txtName.Text = "";
            txtNamePlural.Text = "";
            txtDescription.Text = "";
            txtPrice.Text = "";
            cboItemEquiptable.SelectedText = ""; 

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

        private void btnCreate_Click_1(object sender, EventArgs e)
        {
            if (CreateFormInputValidation.ItemTextBoxesHaveErrors(itemTextBoxes) == false)
            {
                //There are no errors with your text box,
                //create your item
                int id = Convert.ToInt32(txtID.Text);
                if (id > 200 && id <= 300)
                {
                    foreach (Item item in World.Items.ToList())
                    {
                        if (item.ID == id)
                        {
                            MessageBox.Show("That item already exist");
                        }
                    }
                    World.Items.Add(new Item(id, txtName.Text, txtNamePlural.Text, txtDescription.Text,
                                        Convert.ToInt32(txtPrice.Text), bool.Parse(cboItemEquiptable.Text)));
                    MessageBox.Show("Item created!");

                    if (File.Exists(@"../../../Engine/Docs/Items.txt"))
                    {
                        File.AppendAllText(@"../../../Engine/Docs/Items.txt", "" + Environment.NewLine);
                        File.AppendAllText(@"../../../Engine/Docs/Items.txt", id.ToString() + Environment.NewLine);
                        File.AppendAllText(@"../../../Engine/Docs/Items.txt", txtName.Text + Environment.NewLine);
                        File.AppendAllText(@"../../../Engine/Docs/Items.txt", txtNamePlural.Text + Environment.NewLine);
                        File.AppendAllText(@"../../../Engine/Docs/Items.txt", txtDescription.Text + Environment.NewLine);
                        File.AppendAllText(@"../../../Engine/Docs/Items.txt", txtPrice.Text + Environment.NewLine);
                        File.AppendAllText(@"../../../Engine/Docs/Items.txt", cboItemEquiptable.Text);
                    }

                    ClearAll();
                }
            }
        }
    }
}