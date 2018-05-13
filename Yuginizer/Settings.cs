using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Yuginizer
{
    [Serializable]
    public class Settings
    {
        private static string _path = "database.bin";
        private static Settings _default = null;
        public static Settings Default
        {
            get
            {
                if (_default == null)
                    ReadSettings();
                return _default;
            }
        }

        // These members are the settings and are serialized
        public string[] AutocompleteList = new string[0];
        public Card[] Cards = new Card[0];
        // ---

        public void Save()
        {
            lock (_path)
            {
                using (FileStream fs = File.OpenWrite(_path))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(fs, _default);
                }
            }
        }

        private static void ReadSettings()
        {
            if (File.Exists(_path))
            {
                using (FileStream fs = File.OpenRead(_path))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    _default = (Settings)bf.Deserialize(fs);
                }
            }
            else
            {
                _default = new Settings();
            }
        }
    }
}
