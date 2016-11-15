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
    public partial class PlayerCreate : Form
    {
        public PlayerCreate()
        {
            InitializeComponent();
        }

        int str = 10;
        int dex = 10;
        int con = 10;
        int wis = 10;
        int cha = 10;
        int intel = 10;
        int avaPoints = 15;

        private void PlayerCreate_Load(object sender, EventArgs e)
        {
            cboRace.DataSource = Enum.GetValues(typeof(Races));
            cboClass.DataSource = Enum.GetValues(typeof(Classes));
            cboFaction.DataSource = Enum.GetValues(typeof(Factions));            
            lblPointAva.Text = avaPoints.ToString();
            lblStr.Text = str.ToString();
            lblDex.Text = dex.ToString();
            lblCon.Text = con.ToString();
            lblWis.Text = wis.ToString();
            lblChar.Text = cha.ToString();
            lblInt.Text = intel.ToString();

        }

        #region Strength
        private void btnMinStr_Click(object sender, EventArgs e)
        {
            str = minusAbility(str, avaPoints);
            lblStr.Text = str.ToString();
            lblPointAva.Text = avaPoints.ToString();
        }

        private void bnPlusStr_Click(object sender, EventArgs e)
        {
            str = plusAbility(str, avaPoints);
            lblStr.Text = str.ToString();
            lblPointAva.Text = avaPoints.ToString();
        }
        #endregion

        #region Dexterity
        private void btnMinDex_Click(object sender, EventArgs e)
        {
            dex = minusAbility(dex, avaPoints);
            lblDex.Text = dex.ToString();
            lblPointAva.Text = avaPoints.ToString();
        }

        private void btnPlusDex_Click(object sender, EventArgs e)
        {
            dex = plusAbility(dex, avaPoints);
            lblDex.Text = dex.ToString();
            lblPointAva.Text = avaPoints.ToString();
        }
        #endregion

        #region Constitution
        private void btnMinCon_Click(object sender, EventArgs e)
        {
            con = minusAbility(con, avaPoints);
            lblCon.Text = con.ToString();
            lblPointAva.Text = avaPoints.ToString();
        }

        private void btnPlusCon_Click(object sender, EventArgs e)
        {
            con = plusAbility(con, avaPoints);
            lblCon.Text = con.ToString();
            lblPointAva.Text = avaPoints.ToString();
        }
        #endregion

        #region Wisdom
        private void btnMinWis_Click(object sender, EventArgs e)
        {
            wis = minusAbility(wis, avaPoints);
            lblWis.Text = wis.ToString();
            lblPointAva.Text = avaPoints.ToString();
        }

        private void btnPlusWis_Click(object sender, EventArgs e)
        {
            wis = plusAbility(wis, avaPoints);
            lblWis.Text = wis.ToString();
            lblPointAva.Text = avaPoints.ToString();
        }
        #endregion

        #region Charisma
        private void btnMinChar_Click(object sender, EventArgs e)
        {
            cha = minusAbility(cha, avaPoints);
            lblChar.Text = cha.ToString();
            lblPointAva.Text = avaPoints.ToString();
        }

        private void btnPlusChar_Click(object sender, EventArgs e)
        {
            cha = plusAbility(cha, avaPoints);
            lblChar.Text = cha.ToString();
            lblPointAva.Text = avaPoints.ToString();
        }
        #endregion

        #region Intelligence
        private void btnMinInt_Click(object sender, EventArgs e)
        {
            intel = minusAbility(intel, avaPoints);
            lblInt.Text = intel.ToString();
            lblPointAva.Text = avaPoints.ToString();
        }

        private void btnPlusInt_Click(object sender, EventArgs e)
        {
            intel = plusAbility(intel, avaPoints);
            lblInt.Text = intel.ToString();
            lblPointAva.Text = avaPoints.ToString();
        }
        #endregion

        public int minusAbility(int ability, int pointsPool)
        {
            if (ability == 7)
            {
                MessageBox.Show("Can not drop below 7!");
            }
            else
            {
                if (ability == 8)
                {
                    ability -= 1;
                    pointsPool += 4;
                }
                else if (ability <= 9)
                {
                    ability -= 1;
                    pointsPool += 2;
                }
                else if (ability < 10)
                {
                    ability -= 1;
                    pointsPool += 1;
                }
                else if (ability <= 13)
                {
                    ability -= 1;
                    pointsPool += 1;
                }
                else if (ability <= 15)
                {
                    ability -= 1;
                    pointsPool += 2;
                }
                else if (ability <= 17)
                {
                    ability -= 1;
                    pointsPool += 3;
                }
                else if (ability <= 18)
                {
                    ability -= 1;
                    pointsPool += 4;
                }
            }

            avaPoints = pointsPool;
            return ability;
        }

        public int plusAbility(int ability, int pointsPool)
        {
            if (pointsPool > 0)
            {
                if (ability == 18)
                {
                    MessageBox.Show("Can not go above 18!");
                }
                else
                {
                    if (ability == 7)
                    {
                        if (pointsPool > 4)
                        {
                            ability += 1;
                            pointsPool -= 4;
                        }
                        else
                        {
                            MessageBox.Show("Not enough points");
                        }
                    }
                    else if (ability < 9)
                    {
                        if (pointsPool > 2)
                        {
                            ability += 1;
                            pointsPool -= 2;
                        }
                        else
                        {
                            MessageBox.Show("Not enough points");
                        }
                    }
                    else if (ability <= 12)
                    {
                        if (pointsPool > 1)
                        {
                            ability += 1;
                            pointsPool -= 1;
                        }
                        else
                        {
                            MessageBox.Show("Not enough points");
                        }
                    }
                    else if (ability <= 13)
                    {
                        if (pointsPool > 2)
                        {
                            ability += 1;
                            pointsPool -= 2;
                        }
                        else
                        {
                            MessageBox.Show("Not enough points");
                        }
                    }
                    else if (ability < 15)
                    {
                        if (pointsPool > 2)
                        {
                            ability += 1;
                            pointsPool -= 2;
                        }
                        else
                        {
                            MessageBox.Show("Not enough points");
                        }
                    }
                    else if (ability < 17)
                    {
                        if (pointsPool > 3)
                        {
                            ability += 1;
                            pointsPool -= 3;
                        }
                        else
                        {
                            MessageBox.Show("Not enough points");
                        }
                    }
                    else if (ability < 18)
                    {
                        if (pointsPool > 4)
                        {
                            ability += 1;
                            pointsPool -= 4;
                        }
                        else
                        {
                            MessageBox.Show("Not enough points");
                        }
                    }
                }
            }

            avaPoints = pointsPool;
            return ability;
        }
    }
}
