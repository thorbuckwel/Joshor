using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Engine
{
    public partial class Spawning : Form
    {
        public Spawning()
        {
            InitializeComponent();            
        }

        private void Spawning_Load(object sender, EventArgs e)
        {
            #region Load Item List
            foreach (Item item in World.Items)
            {
                cboItemList.Items.Add(item.Name);
                cboItemList.Sorted = true;                
            }
            #endregion

            #region Load Weapon List
            foreach (Weapon weapon in World.Weapons)
            {
                cboWeaponList.Items.Add(weapon.Name);
                cboWeaponList.Sorted = true;
            }
            #endregion

            #region Load Mob List
            foreach (Monster mob in World.Monsters)
            {
                cboMobList.Items.Add(mob.Name);
                cboMobList.Sorted = true;
            }
            #endregion

            #region Load NPC List
            foreach (NPC npc in World.NPCs)
            {
                cboNPCList.Items.Add(npc.NPCName);
                cboNPCList.Sorted = true;
            }
            #endregion
        }

        private void btnItemSpawn_Click(object sender, EventArgs e)
        {
            foreach (Item item in World.Items)
            {
                if (item.Name == cboItemList.Text)
                {
                    Player.CurrentLocation.RoomLoot.Add(new Item(item.ID, item.Name, item.NamePlural, item.Desc, item.Price, item.Equiptable));
                    MessageBox.Show("Item has been spawned!");
                    break;
                }                
            }           
        }

        private void btnWeaponSpawn_Click(object sender, EventArgs e)
        {
            foreach (Weapon weapon in World.Weapons)
            {
                if (weapon.Name == cboWeaponList.Text)
                {
                    Player.CurrentLocation.RoomLoot.Add(new Weapon(weapon.ID, weapon.Name, weapon.NamePlural, weapon.Desc, weapon.Price, weapon.Damage,
                                                        weapon.DamageType, weapon.Equiptable, weapon.WearLocation));
                    MessageBox.Show("Weapon has been spawned!");
                    break;
                }
            }
        }

        private void btnMobSpawn_Click(object sender, EventArgs e)
        {
            foreach (Monster mob in World.Monsters)
            {
                if (mob.Name == cboMobList.Text)
                {
                    Player.CurrentLocation.RoomMob.Add(new Monster(mob.ID, mob.Name, mob.Experiance, mob.Gold, mob.AC, mob.Damage,
                                                    mob.BaseAttack, mob.CurrentHitPoints, mob.MaxHitPoints, mob.Image, mob.IsDead, mob.CanBeAttacked, mob.Factions));
                    MessageBox.Show("Mob has been spawned!");
                    break;
                }
            }
        }

        private void btnNPCSpawn_Click(object sender, EventArgs e)
        {
            foreach (NPC npc in World.NPCs)
            {
                if (npc.NPCName == cboNPCList.Text)
                {
                    Player.CurrentLocation.RmNPC.Add(new NPC(npc.ID, npc.NPCName, npc.NPCClass, npc.NPCRace, npc.Gold, npc.CurrentHitPoints,
                                                    npc.MaximumHitPoints, npc.IsDead, npc.CanBeAttacked, npc.Factions));
                    
                    MessageBox.Show("NPC has been spawned!");
                    break;
                }
            }
        }
    }
}
