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

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (CreateFormInputValidation.ItemTextBoxesHaveErrors(itemTextBoxes) == false)
            {
                //There are no errors with your text box,
                //create your item
                // World.Items.Add(new Engine.Item())
            }
       
        }
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
