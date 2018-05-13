/* By Alec Audet */

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yuginizer.Properties;

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
				var result = MessageBox.Show(
					"No database detected!\nClick 'YES' to build a new copy (may take a few minutes).\nClick 'NO' to use a cached copy (may be out of date).",
					"Yuginizer",
					MessageBoxButtons.YesNo, MessageBoxIcon.Information);

				if (result == DialogResult.Yes)
					_default = new Settings();
				else
				{
					File.WriteAllBytes(_path, Resources.databasedefault);
					ReadSettings();
					MessageBox.Show(
						"You are using a card database from 5/13/18. You may want to rebuild the database if new sets have been released since said date.",
						"Yuginizer");
				}
            }
        }
    }
}
