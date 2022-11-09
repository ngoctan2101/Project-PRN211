using MusicStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore
{
    public partial class ShoppingCart
    {
        MusicStoreContext context = new MusicStoreContext();

        string ShoppingCartId { get; set; }

        public static ShoppingCart GetCart()
        {
            var cart = new ShoppingCart();
            cart.ShoppingCartId = cart.GetCartId();
            return cart;
        }

        public string GetCartId()
        {
            if (Settings.CartId == null)
            {
                if (Settings.UserName != null)
                    Settings.CartId = Settings.UserName;
                else
                {
                    Guid tempCartId = Guid.NewGuid();
                    Settings.CartId = tempCartId.ToString();
                }
            }
            return Settings.CartId;
        }


    }
}
