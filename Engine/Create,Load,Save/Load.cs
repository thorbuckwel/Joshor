using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    class Load
    {
        public const string PLAYER_DATA_FILE_NAME = "PlayerData.xml";

        public static void LoadGameData()
        {
            Player _player;

            if (File.Exists(PLAYER_DATA_FILE_NAME))
            {
                _player = null;
                _player = Player.CreatePlayerFromXmlString(File.ReadAllText(PLAYER_DATA_FILE_NAME));
                CreatePlayer.CreateFromLoad(_player);
            }
            else
            {
                // _player = Player.CreateDefaultPlayer();
            }            
        }
    }
}
