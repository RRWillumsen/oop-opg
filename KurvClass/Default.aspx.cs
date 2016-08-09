using KurvClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    private Cart cart;
    protected void Page_Load(object sender, EventArgs e)
    {
        cart = new Cart();

    }
    protected void Button_submit_Click(object sender, EventArgs e)
    {
        cart.AddToCart(
            Convert.ToInt32(TextBox_id.Text),
            TextBox_navn.Text,
            Convert.ToDecimal(TextBox_pris.Text),
            Convert.ToInt32(TextBox_antal.Text)
            );
        ShowCart(cart.Items);
    }

    private void ShowCart(List<CartProduct> cart)
    {
        GV_cart.DataSource = cart;
        GV_cart.DataBind();
    }


}

