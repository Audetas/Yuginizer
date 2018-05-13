/* By Alec Audet */

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yuginizer
{
    [Serializable]
    public class Card
    {
        public string Name { get; set; }
        public string Rarity { get; set; }
        public string PrintTag { get; set; }
        public string Set { get; set; }

        //public string Text { get; set; }
        //public string CardType { get; set; }
        //public string Type { get; set; }
        //public string Family { get; set; }
        //public string Atk { get; set; }
        //public string Def { get; set; }
        //public string Level { get; set; }
        //public string Property { get; set; }

        public DateTime LastUpdated { get; set; }
        public string ImagePath { get; set; }
        public decimal Price { get; set; }

        [field: NonSerialized]
        public event EventHandler<Card> PriceUpdated;

        public static Card FromData(string name, string set, string rarity, string printTag)
        {
            return new Card()
            {
                Name = name,
                Set = set,
                Rarity = rarity,
                PrintTag = printTag,
                ImagePath = "http://yugiohprices.com/api/card_image/" + name
            };
        }

        public async void UpdateDetails()
        {
            await API.UpdateCard(this);
        }

        public async void UpdatePrice()
        {
            Price = await API.GetCardPrice(this);
            PriceUpdated?.Invoke(this, this);
        }

        public override string ToString()
        {
            return $"{Name} [{Rarity}]";
        }
    }
}
