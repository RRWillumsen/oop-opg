using KurvClass;
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
 

        AddToCart(cart);

        ShowCart(cart);
    }

    private void ShowCart(List<CartProduct> cart)
    {
        GV_cart.DataSource = cart;
        GV_cart.DataBind();
    }

   
}
   
