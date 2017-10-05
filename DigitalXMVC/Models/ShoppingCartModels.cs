using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using DigitalXData;


namespace DigitalXMVC.Models
{
    public class ShoppingCartModels
    {
        DigitalXDBEntities storeDB = new DigitalXDBEntities();
        HttpSessionStateBase session;


        public static ShoppingCartModels GetCart(HttpContextBase context)
        {
            var cart = new ShoppingCartModels();
            cart.session = context.Session;
            if (cart.session["OrderItems"] == null)
            {
                cart.session["OrderItems"] = new List<CartItemModels>();
            }
            return cart;
        }

        // Helper method to simplify shopping cart calls
        public static ShoppingCartModels GetCart(Controller controller)
        {
            return GetCart(controller.HttpContext);
        }

        public int AddToCart(Product product, int quant)
        {
            int q = quant;
            List<CartItemModels> cartItems = session["OrderItems"] as List<CartItemModels>;
            // Get the matching cart and product instances

            // Create a new cart item if no cart item exists

            bool itemInCart = false;

            foreach (CartItemModels ci in cartItems)
            {
                if (ci.ProductID == product.ProductID)
                {
                    ci.Quantity += quant;
                    q = ci.Quantity;
                    itemInCart = true;
                    break;
                }
            }
            if (!itemInCart)
            {
                CartItemModels newCI = new CartItemModels
                {
                    ProductID = product.ProductID,
                    Quantity = quant
                };
                cartItems.Add(newCI);
            }
            session["OrderItems"] = cartItems;
            return q;
        }

        public int RemoveFromCart(int id)
        {
            int q = 0;
            List<CartItemModels> orderItems = session["OrderItems"] as List<CartItemModels>;
            // Get the matching cart and product instances
            // Create a new cart item if no cart item exists


            foreach (CartItemModels od in orderItems)
            {
                if (od.ProductID == id)
                {
                    if (od.Quantity > 1)
                    {
                        od.Quantity--;
                        q = od.Quantity;
                    }
                    else
                    {
                        orderItems.Remove(od);
                    }
                }
            }
            session["OrderItems"] = orderItems;
            return q;
        }

        public void EmptyCart()
        {
            session["OrderItems"] = new List<CartItemModels>();
        }

        public List<OrderDetail> GetCartItems()
        {
            List<OrderDetail> ods = new List<OrderDetail>();
            foreach (CartItemModels ci in session["OrderItems"] as List<CartItemModels>)
            {
                var od = new OrderDetail
                {
                    ProductID = ci.ProductID,
                    Quantity = ci.Quantity,
                    Product = storeDB.Products.Find(ci.ProductID)
                };
                ods.Add(od);
            }
            return ods;
        }

        //public decimal GetTotal()
        //{
        //    // Multiply Product price by count of that Product to get 
        //    // the current price for each of those Products in the cart
        //    // sum all Product price totals to get the cart total
        //    decimal total = decimal.Zero;
        //    List<CartItem> orderItems = session["OrderItems"] as List<CartItem>;
        //    // Get the matching cart and product instances
        //    // Create a new cart item if no cart item exists

        //    foreach (CartItem od in orderItems)
        //    {
        //        total += od.Quantity * od.Product.Price;
        //    }
        //    return total;
        //}

        public int CheckOut(Order order)
        {
            var cartItems = this.GetCartItems();
            // Iterate over the items in the cart, 
            // adding the order details for each
            foreach (OrderDetail od in cartItems)
            {
                od.Packaged = true;
                od.OrderID = order.OrderID;
                od.PackagedBy = 1;

                storeDB.OrderDetails.Add(od);
            }

            // Save the order
            storeDB.SaveChanges();
            // Empty the shopping cart
            EmptyCart();
            // Return the OrderId as the confirmation number
            return order.OrderID;
        }

    }
}