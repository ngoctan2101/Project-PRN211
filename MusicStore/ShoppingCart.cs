using Microsoft.EntityFrameworkCore;
using MusicStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.Models
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
        // cart empty
        public void CartEmpty()
        {
            var cartItems = context.Carts.Where(cart => cart.CartId == ShoppingCartId);
            foreach(var item in cartItems)
            {
                context.Carts.Remove(item);
            }
            context.SaveChanges();
        }

        // add to cart
        public void AddToCart(Album album)
        {
            var cartItem = context.Carts.SingleOrDefault(x=>x.CartId == ShoppingCartId && x.AlbumId == album.AlbumId);
            if(cartItem == null)
            {
                // tao 1 Item moi neu k ton tai trong cart
                cartItem = new Cart
                {
                    AlbumId = album.AlbumId,
                    CartId = ShoppingCartId,
                    Count = 1,
                    DateCreated = DateTime.Now
                };
                context.Carts.Add(cartItem);
            }
            else
            {
                // neu item ton tai trong cart
                cartItem.Count++;
            }
            context.SaveChanges();

        }

        // removecart
        public int RemoveCart(int id)
        {
            var cartItem = context.Carts.SingleOrDefault(
                c => c.CartId == ShoppingCartId
                && c.RecordId == id);

            int countItem = 0;
            if(cartItem != null)
            {
                // neu so luong > 1
                if(cartItem.Count > 1)
                {
                    cartItem.Count--;
                    countItem = cartItem.Count;
                }
                else
                {
                    context.Carts.Remove(cartItem);
                }
                context.SaveChanges();
            }
            return countItem;
        }
        // lay list cart
        public List<Cart> GetCartsItems()
        {             
            return context.Carts.Where(x=>x.CartId == ShoppingCartId).Include(x=>x.Album).ToList();
        }

        // count
        public int GetCount()
        {
            // Get the count of each item in the cart and sum them up
            int? count = (from cartItems in context.Carts
                          where cartItems.CartId == ShoppingCartId
                          select (int?)cartItems.Count).Sum();
            // Return 0 if all entries are null
            return count ?? 0;
        }

        // total
        public decimal GetTotal()
        {
            decimal? total = (from cartItems in context.Carts
                              where cartItems.CartId == ShoppingCartId
                              select (int?)cartItems.Count * cartItems.Album.Price).Sum();
            return total ?? 0;
        }

        // create oder
        public int CreateOrder(Order order)
        {
            var cartItem = GetCartsItems();

            try
            {
                //save order
                context.Orders.Add(order);
                context.SaveChanges();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return -1;
            }
            // lay id max
            int OrderID = context.Orders.Select(x => x.OrderId).Max();
            foreach (var item in cartItem)
            {
                var oderDetail = new OrderDetail
                {
                    AlbumId = item.AlbumId,
                    OrderId = OrderID,
                    UnitPrice = item.Album.Price,
                    Quantity = item.Count
                };
                try
                {

                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return -1;
                }
            }
            CartEmpty();
            return OrderID;
        }


        // lay id cua cart
        public string GetCartId()
        {
            if (Check.CartId == null)
            {
                // dung thi cartid lay ten thanh username 
                // k thi radom
                if (Check.UserName != null)
                    Check.CartId = Check.UserName;
                else
                {
                    Guid tempCartId = Guid.NewGuid();
                    Check.CartId = tempCartId.ToString();
                }
            }
            return Check.CartId;
        }
        // change cartid thanh username
        public void ChangeName()
        {
            var shoopingca = context.Carts.Where(x => x.CartId == ShoppingCartId);
            foreach (Cart item in shoopingca)
            {
                item.CartId = Check.UserName;
            }
            context.SaveChanges();
            Check.CartId = null;
        }

    }
}
