/* By Alec Audet */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yuginizer
{
    public partial class FrmMain
    {
        private Card _selectedCard;
        public Card SelectedCard
        {
            get => _selectedCard;
            set
            {
                if (_selectedCard != null)
                    _selectedCard.PriceUpdated -= _selectedCard_PriceUpdated;
                _selectedCard = value;
                if (_selectedCard != null)
                    _selectedCard.PriceUpdated += _selectedCard_PriceUpdated;
                pnlCardHeader.Visible = _selectedCard != null;
                pbxCardImage.Visible = _selectedCard != null;
                btnAddCard.Visible =
                    _selectedCard != null/* &&
                    !lstYourCards.Items.Contains(_selectedCard)*/;
                btnRemoveCard.Visible =
                    _selectedCard != null &&
                    lstYourCards.Items.Contains(_selectedCard);

                if (_selectedCard?.Price == 0)
                    _selectedCard?.UpdatePrice();

                pbxCardImage.ImageLocation = _selectedCard?.ImagePath;
                lblCardValue.Text = "$" + (_selectedCard?.Price ?? 0m).ToString();
                lblCardRarity.Text = _selectedCard?.Rarity;
                lblCardSet.Text = _selectedCard?.Set;
                lblPrintTag.Text = _selectedCard?.PrintTag;
            }
        }

        private void _selectedCard_PriceUpdated(object sender, Card e)
        {
            lblCardValue.Text = "$" + (_selectedCard?.Price ?? 0m).ToString();
        }
    }
}
