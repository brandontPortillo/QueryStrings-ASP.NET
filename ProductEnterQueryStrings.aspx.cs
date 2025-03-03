using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QueryString5834255
{
    public partial class ProductEnterQueryStrings : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnConfirm_Click(object sender, EventArgs e)
        {
            //Go to the confirmation page with the encoded URL
            Response.Redirect
                (
                "ProductConfirmQueryStrings.aspx" +
                "?ddlCategory=" + ddlCategory.SelectedValue +
                "&ddlSupplier=" + ddlSupplier.SelectedValue +
                "&strProduct=" + txtProduct.Text +
                "&strDescription=" + txtDescription.Text +
                "&strImage=" + txtImage.Text +
                "&decPrice=" + txtPrice.Text +
                "&bytNumberInStock=" + txtNumberInStock.Text +
                "&bytNumberOnOrder=" + txtNumberOnOrder.Text +
                "&bytReorderLevel=" + txtReorderLevel.Text
                );
        }
    }
}