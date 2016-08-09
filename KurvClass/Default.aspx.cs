﻿using KurvClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button_submit_Click(object sender, EventArgs e)
    {
        List<CartProduct> cart = new List<CartProduct>();

        cart = GrabCart(cart);

        AddToCart(cart);

        ShowCart(cart);
    }

    private void ShowCart(List<CartProduct> cart)
    {
        GV_cart.DataSource = cart;
        GV_cart.DataBind();
    }

    private void AddToCart(List<CartProduct> cart)
    {

        bool newProduct = true;

        foreach(CartProduct product in cart){
            if (product.Id == Convert.ToInt32(TextBox_id.Text))
            {
                newProduct = false;
                product.Amount += Convert.ToInt32(TextBox_antal.Text);
                product.SamletPris = product.Amount * product.Price;
            }
        }

       
      
 if (newProduct)

        cart.Add(new CartProduct(Convert.ToInt32(TextBox_id.Text),
            TextBox_navn.Text,
            Convert.ToDecimal(TextBox_pris.Text),
            Convert.ToInt32(TextBox_antal.Text)
            ));
    }

    private List<CartProduct> GrabCart(List<CartProduct> cart)
    {
        if (Session["Cart"] == null)
        {
            Session.Add("Cart", cart);
        }

        cart = Session["Cart"] as List<CartProduct>;
        return cart;
    }

}