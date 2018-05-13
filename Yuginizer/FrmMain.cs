using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yuginizer.Properties;

namespace Yuginizer
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            lstFilter.SelectedItem = lstFilter.Items[0];
            lstYourCards.Items.AddRange(Settings.Default.Cards);
            tbxNewCardsSearch.AutoCompleteCustomSource.AddRange(Settings.Default.AutocompleteList);
            lstYourCards_ItemAdded();

            if (Settings.Default.Cards.Length > 0)
                lstYourCards.SelectedIndex = 0;
        }

        private async void FrmMain_Load(object sender, EventArgs e)
        {
            if (Settings.Default.AutocompleteList.Length == 0)
            {
                tabsMenu.Enabled = false;
				var autocompleteList = await FetchCardList();
                Text = "Yuginizer";
                tbxNewCardsSearch.AutoCompleteCustomSource.AddRange(autocompleteList.ToArray());
                Settings.Default.AutocompleteList = autocompleteList.ToArray();
                tabsMenu.Enabled = true;
            }
        }

        private async void btnNewCardsSearch_Click(object sender, EventArgs e)
        {
            if (tbxNewCardsSearch.Text == "") return;
            btnNewCardsSearch.Enabled = false;
            lstFilter.Enabled = false;
            Cursor = Cursors.WaitCursor;

            var query = tbxNewCardsSearch.Text;
            var filter = lstFilter.SelectedItem.ToString();
            var result = new List<Card>();

            if (chkSupportCards.Checked)
            {
                foreach (var cardName in await API.GetSupportCards(query))
                    result.AddRange(await API.GetCardVersions(cardName, filter));
            }
            else if (chkSets.Checked)
            {
                foreach (var cardName in await API.GetSetCards(query))
                    result.AddRange(await API.GetCardVersions(cardName, filter));
            }
            else if (chkCards.Checked)
            {
                result.AddRange(await API.GetCardVersions(query, filter));
            }

            lstSearchResults.Items.Clear();
            lstSearchResults.Items.AddRange(result.ToArray());
            lstSearchResults.Select();
            btnNewCardsSearch.Enabled = true;
            lstFilter.Enabled = true;
            lblResultsCount.Text = $"Results: {result.Count}";
            Cursor = Cursors.Arrow;

            if (result.Count > 0)
                lstSearchResults.SelectedIndex = 0;

            var totalValue = 0m;
            foreach (var card in result)
            {
                totalValue += await API.GetCardPrice(card);
                lblResultsValue.Text = "$" + totalValue;
            }
        }

        private void lstSearchResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstSearchResults.SelectedItem != null)
                SelectedCard = (Card)lstSearchResults.SelectedItem;
        }

        private void lstFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbxNewCardsSearch.Text != "" && btnNewCardsSearch.Enabled)
                btnNewCardsSearch_Click(this, EventArgs.Empty);
        }

        private void lstYourCards_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstYourCards.SelectedItem != null)
                SelectedCard = (Card)lstYourCards.SelectedItem;
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Settings.Default.Cards = lstYourCards.Items.Cast<Card>().ToArray();
            Settings.Default.Save();
        }

        private void btnAddCard_Click(object sender, EventArgs e)
        {

            lstYourCards.Items.Add(
                tabsMenu.SelectedTab == tabFind
                    ? lstSearchResults.SelectedItem
                    : SelectedCard);
            SelectedCard = SelectedCard;
            lstYourCards_ItemAdded();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            lstYourCards.Items.Remove(SelectedCard);
            SelectedCard = null;
            lstYourCards_ItemAdded();
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            lstYourCards.Items.Clear();
            lstYourCards.Items.AddRange(
                Settings.Default.Cards
                    .Where(
                        card =>
                            card.ToString().ToLower().Contains(tbxSearch.Text.ToLower()))
                    .ToArray());
        }

        private void lstYourCards_ItemAdded()
        {
			var totalValue = GetTotalCardValue();
            lblTotalValue.Text = $"Total Value: ${totalValue}";
            lblYourCardsTitle.Text = $"Your Cards ({lstYourCards.Items.Count})";
            Settings.Default.Cards = lstYourCards.Items.Cast<Card>().ToArray();
            Settings.Default.Save();
        }

        private async void btnRefreshTotalValue_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            btnRefreshTotalValue.Enabled = false;
            int index = 0;
			var items = lstYourCards.Items.Cast<Card>().ToArray();
			var originalValue = GetTotalCardValue();

			foreach (var card in items)
            {
                var cardInstance = card as Card;
                cardInstance.Price = await API.GetCardPrice(cardInstance);
                Text = $"Yuginizer - Updating Prices: {index++}/{lstYourCards.Items.Count}";
            }

			MessageBox.Show(
				$"Refresh complete!\nYour total card value went from ${originalValue} to ${GetTotalCardValue()}.", 
				"Refresh Complete", 
				MessageBoxButtons.OK, MessageBoxIcon.Information);

            lstYourCards_ItemAdded();
            btnRefreshTotalValue.Enabled = true;
            Text = "Yuginizer";
        }

        private void tbxNewCardsSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (btnNewCardsSearch.Enabled && (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return))
                btnNewCardsSearch_Click(this, EventArgs.Empty);
        }

        private void btnSellCard_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new FrmCreateListing(SelectedCard).ShowDialog();
        }

        private void lstSearchResults_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                tbxNewCardsSearch.SelectAll();
                tbxNewCardsSearch.Select();
            }

            if (e.KeyCode == Keys.OemMinus)
                btnRemove_Click(this, EventArgs.Empty);
            if (e.KeyCode == Keys.Oemplus)
                btnAddCard_Click(this, EventArgs.Empty);
        }

		private decimal GetTotalCardValue()
		{
			var totalValue = 0m;
			foreach (var card in lstYourCards.Items)
				totalValue += (card as Card).Price;
			return totalValue;
		}

		private async Task<List<string>> FetchCardList()
		{
			var autocompleteList = new List<string>();
			var sets = await API.GetCardSets();
			var index = 0;
			foreach (var set in sets)
			{
				autocompleteList.AddRange(await API.GetSetCards(set));
				Text = $"Yuginizer - Loading Complete Card List {index++}/{sets.Count()} (this might take a while)";
			}
			return autocompleteList;
		}

		private async void btnUpdateDB_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			tabsMenu.Enabled = false;
			var autocompleteList = await FetchCardList();
			Text = "Yuginizer";
			tbxNewCardsSearch.AutoCompleteCustomSource.Clear();
			tbxNewCardsSearch.AutoCompleteCustomSource.AddRange(autocompleteList.ToArray());
			Settings.Default.AutocompleteList = autocompleteList.ToArray();
			tabsMenu.Enabled = true;
		}
	}
}
