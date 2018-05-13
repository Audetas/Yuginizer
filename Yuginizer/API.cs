using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Yuginizer
{
    public class API
    {
        private static WebClient wc;
        private static WebClient wc2;

        static API()
        {
            wc = new WebClient();
            wc2 = new WebClient();
        }

        private static IEnumerable<JToken> AllChildren(JToken json)
        {
            foreach (var c in json.Children())
            {
                yield return c;
                foreach (var cc in AllChildren(c))
                {
                    yield return cc;
                }
            }
        }

        public static async Task<string[]> GetCardSets()
        {
            return await Task.Run(() =>
            {
                var response = wc.DownloadString(
                    "http://yugiohprices.com/api/card_sets");

                //if (JObject.Parse(response)["status"].ToString() == "fail")
                  //  return new string[0];

                var sets = response.Split('"');
                var resultSetNames = new List<string>();

                for (int i = 1; i < sets.Length; i += 2)
                    resultSetNames.Add(sets[i]);

                return resultSetNames.ToArray();
            });
        }

        public static async Task<string[]> GetSupportCards(string cardName)
        {
            return await Task.Run(() =>
            {
                var response = wc.DownloadString(
                "http://yugiohprices.com/api/card_support/" +
                Uri.EscapeUriString(cardName));

                if (JObject.Parse(response)["status"].ToString() == "fail")
                    return new string[0];

                var names = response.Split('"');
                var resultCardNames = new List<string>();

                for (int i = 1; i < names.Length; i += 2)
                    resultCardNames.Add(names[i]);

                return resultCardNames.ToArray();
            });
        }

        public static async Task<string[]> GetSetCards(string setName)
        {
            return await Task.Run(() =>
            {
                var response = wc.DownloadString(
                "http://yugiohprices.com/api/set_data/" +
                Uri.EscapeUriString(setName));

                if (JObject.Parse(response)["status"].ToString() == "fail")
                    return new string[0];

                var splits = response.Split(
                    new[] { "\"name\":\"" }, StringSplitOptions.RemoveEmptyEntries);

                var resultCardNames = new List<string>();

                foreach (var split in splits)
                {
                    if (!split.Contains("\"")) continue;
                    var name = split.Split('"')[0];
                    if (name.Contains("{") || name.Contains("}")) continue;
                    if (name == setName) continue;
                    resultCardNames.Add(name);
                }

                return resultCardNames.ToArray();
            });
        }

        public static async Task<Card[]> GetCardVersions(string cardName, string filter)
        {
            return await Task.Run(() =>
            {
                var response = wc.DownloadString(
                "http://yugiohprices.com/api/card_versions/" +
                Uri.EscapeUriString(cardName));

                var resultObject = JObject.Parse(response);

                if (resultObject["status"].ToString() == "fail")
                    return new Card[0];

                var resultObjects = AllChildren(resultObject)
                    .First(c => c.Type == JTokenType.Array && c.Path.Contains("data"))
                    .Children<JObject>();

                var resultCards = new List<Card>(resultObjects.Count());

                foreach (var version in resultObjects)
                {
                    var card = Card.FromData(
                        cardName,
                        version["name"].ToString(),
                        version["rarity"].ToString(),
                        version["print_tag"].ToString());

                    if (filter == "All Rarities" || filter == card.Rarity)
                    {
                        card.UpdateDetails();
                        resultCards.Add(card);
                    }
                }

                return resultCards.ToArray();
            });
        }

        public static async Task<decimal> GetCardPrice(Card card)
        {
            return await Task.Run(() =>
            {
                lock (wc2)
                {
                    try
                    {
                        var response = wc2.DownloadString(
                            "http://yugiohprices.com/api/price_history/" +
                            Uri.EscapeUriString(card.PrintTag) +
                            "?rarity=" +
                            Uri.EscapeUriString(card.Rarity));

                        if (JObject.Parse(response)["status"].ToString() == "fail")
                            return -1m;

                        card.LastUpdated = DateTime.Now;
                        return decimal.Parse(
                            response
                                .Split(new[] { "\"price_average\":" }, StringSplitOptions.None)[1]
                                .Split(new[] { "," }, StringSplitOptions.None)[0]);
                    }
                    catch
                    {
                        return -1m;
                    }
                }
            });
        }

        public static async Task UpdateCard(Card card)
        {
            await Task.Run(() =>
            {
                return;
                var response = wc.DownloadString(
                    "http://yugiohprices.com/api/card_data/" +
                    Uri.EscapeUriString(card.Name));
                dynamic parsed = JsonConvert.DeserializeObject<dynamic>(response);
                if (parsed.status != "success")
                    throw new InvalidOperationException("response was not a success.\n" + response);
                card.Name = parsed.data.name;
                //Text = parsed.data.text;
                //CardType = parsed.data.card_type;
                //Type = parsed.data.type;
                //Family = parsed.data.family;
                //Atk = parsed.data.atk;
                //Def = parsed.data.def;
                //Level = parsed.data.level;
                //Property = parsed.data.property;
            });
        }
    }
}
