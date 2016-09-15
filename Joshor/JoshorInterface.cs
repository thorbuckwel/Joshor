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
using Engine;



namespace Joshor
{
    public partial class JoshorInterface : Form
    {
        public JoshorInterface()
        {
            InitializeComponent();
        }

        private void JoshorInterface_Load(object sender, EventArgs e)
        {
            var list = new List<Monster>();
            using (StreamReader reader = File.OpenText(@"C:\Users\thorb_000\Desktop\Monsters.txt"))
            {
                while (!reader.EndOfStream)
                {
                    MessageBox.Show("Hello!");

                    int id = int.Parse(reader.ReadLine());
                    String name = reader.ReadLine();
                    int xp = int.Parse(reader.ReadLine());
                    int gold = int.Parse(reader.ReadLine());
                    int armor = int.Parse(reader.ReadLine());
                    int damage = int.Parse(reader.ReadLine());
                    int baseAttack = int.Parse(reader.ReadLine());
                    list.Add(new Monster(id, name, xp, gold, armor, damage, baseAttack));
                }
            }

        }
    }
}