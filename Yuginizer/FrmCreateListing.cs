/* By Alec Audet */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yuginizer
{
    public partial class FrmCreateListing : Form
    {
        private Card card;

        public FrmCreateListing(Card card)
        {
            InitializeComponent();
            this.card = card;
            chkMint.Checked = true;
        }

        public void UpdateText()
        {
            tbxTitle.Text =
                $"{card.Name} - {card.PrintTag} - {card.Rarity} - {card.Set}";
            tbxBody.Text =
                $"Card Name: {card.Name} [{card.Rarity}]\n" +
                $"Print Tag: {card.PrintTag}\n" +
                $"From Set: {card.Set}\n\n" +
                $"Card is in {GetCondition()}, sleeved, and ready to be shipped for free anywhere in the U.S. via First-Class Mail.";
            lblPrice.Text = "$" + card.Price;
        }

        public string GetCondition()
        {
            if (chkMint.Checked) return "Mint Condition";
            if (chkNearMint.Checked) return "Near Mint Condition";
            if (chkOther.Checked) return "[ADD CONDITION HERE]";
            return "";
        }

        private void Option_CheckedChange(object sender, EventArgs e)
        {
            UpdateText();
        }

        private void bntDone_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnViewSimilar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(
                "https://www.ebay.com/sch/i.html?_nkw=" +
                Uri.EscapeUriString($"{card.Name} - {card.PrintTag} - {card.Rarity}"));
        }
    }
}
