using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public static class SaveData
    {
        public static string PLAYER_DATA_FILE_NAME = (CapWord.FirstCharToUpper(Player._player.PlayerName) +".xml");

        public static void SaveGameData(Player _player)
        {
            File.WriteAllText(PLAYER_DATA_FILE_NAME, _player.ToXmlString());

            //PlayerDataMapper.SaveToDatabase(_player);
        }
    }
}
