﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KurvClass
{
    public class Cart
    {
        public List<CartProduct> items;

        public Cart()
        {

            this.items = GrabCart();
        }
        public List<CartProduct> Items { get { return this.items; } }

        private List<CartProduct> GrabCart()
        {
            List<CartProduct> cart = new List<CartProduct>();
            if (HttpContext.Current.Session["Cart"] == null)
            {
                HttpContext.Current.Session.Add("Cart", cart);
            }

            cart = HttpContext.Current.Session["Cart"] as List<CartProduct>;
            return cart;
        }

        public void AddToCart(int id, string name, decimal price, int amount)
        {

            bool newProduct = true;

            foreach (CartProduct product in this.items)
            {

                if (product.Id == id)
                {
                    newProduct = false;
                    product.Amount += amount;
                }
            }



            if (newProduct)

                this.items.Add(new CartProduct(id, name, price, amount ));
                   
                   
        }
    }
}