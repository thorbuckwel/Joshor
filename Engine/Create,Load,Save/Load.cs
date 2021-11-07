using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.Threading.Tasks;

namespace Engine
{
    class Load
    { 
        public static void LoadGameData(string name)
        {
                if (!File.Exists(name + ".xml"))
                {
                    World.message.SetMessage("Player does not exist.");
                    IsNewPlayer.NewPlayer();
                }
                else
                {
                    Player._player = null;
                    Player._player = CreatePlayerFromXmlString(File.ReadAllText(name + ".xml"));
                }
            
        }

        public static Player CreatePlayerFromXmlString(string PLAYER_DATA_FILE_NAME)
        {
            try
            {
                XmlDocument playerData = new XmlDocument();

                playerData.LoadXml(PLAYER_DATA_FILE_NAME);
                string playerName = playerData.SelectSingleNode("/Player/Stats/Name").InnerText;
               // World.message.SetMessage("Got name: " + playerName);
                string PC = playerData.SelectSingleNode("/Player/Stats/Class").InnerText;
               // World.message.SetMessage("Got class: " + PC);
                string PR = playerData.SelectSingleNode("/Player/Stats/Race").InnerText;
                //World.message.SetMessage("Got race: " + PR);
                int currentHitPoints = Convert.ToInt32(playerData.SelectSingleNode("/Player/Stats/CurrentHitPoints").InnerText);
               // World.message.SetMessage("Got current hit points: " + currentHitPoints.ToString());
                int maximumHitPoints = Convert.ToInt32(playerData.SelectSingleNode("/Player/Stats/MaximumHitPoints").InnerText);
               // World.message.SetMessage("Got max hit points: " + maximumHitPoints.ToString());
                int gold = Convert.ToInt32(playerData.SelectSingleNode("/Player/Stats/Gold").InnerText);
               // World.message.SetMessage("Got gold: " + gold.ToString());
                int experiencePoints = Convert.ToInt32(playerData.SelectSingleNode("/Player/Stats/ExperiencePoints").InnerText);
                //World.message.SetMessage("Got experience: " + experiencePoints.ToString());
                Factions factionString = (Factions)Enum.Parse(typeof(Factions), (playerData.SelectSingleNode("/Player/Stats/Faction").InnerText), true);
                //World.message.SetMessage("Got Faction: " + factionString.ToString());
                int alignment = Convert.ToInt32(playerData.SelectSingleNode("/Player/Stats/Alignment").InnerText);
                //World.message.SetMessage("Got Alignment: " + alignment.ToString());
                int equiptString = Convert.ToInt32(playerData.SelectSingleNode("/Player/Stats/CurrentWeapon").InnerText);
                IWeapon equipt = World.WeaponByID(equiptString);
               // World.message.SetMessage("Got equipt weapon: " + equipt.Name.ToString());

                Player player = new Player(playerName, PC, PR, gold, currentHitPoints, maximumHitPoints, (Weapon)equipt, false, true, factionString, alignment);

                int currentLocationID = Convert.ToInt32(playerData.SelectSingleNode("/Player/Stats/CurrentLocation").InnerText);
                Player.CurrentLocation = World.LocationByID(currentLocationID);

                if (playerData.SelectSingleNode("/Player/Stats/CurrentWeapon") != null)
                {
                    int currentWeaponID = Convert.ToInt32(playerData.SelectSingleNode("/Player/Stats/CurrentWeapon").InnerText);
                    player.Equipt = (Weapon)World.WeaponByID(currentWeaponID);
                }

                foreach (XmlNode node in playerData.SelectNodes("/Player/InventoryItems/InventoryItem"))
                {
                    int id = Convert.ToInt32(node.Attributes["ID"].Value);
                    int quantity = Convert.ToInt32(node.Attributes["Quantity"].Value);

                    if (id > 100 && id <= 200)
                    {
                        for (int i = 0; i < quantity; i++)
                        {
                            player.AddItemToInventory((Weapon)World.WeaponByID(id));
                        }
                    }
                    else
                    {
                        for (int i = 0; i < quantity; i++)
                        {
                            player.AddItemToInventory(World.ItemByID(id));
                        }
                    }
                }

                return player;
            }
            catch (Exception ex)
            {
                // If there was an error with the XML data, return a default player object
                World.message.SetMessage(ex.ToString());
                //return CreateDefaultPlayer();
                return null;
            }
        }
    }
}
