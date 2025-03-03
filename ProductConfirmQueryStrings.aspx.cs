using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QueryString5834255
{
    public partial class ProductConfirmQueryStrings : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Retrieve the query string's parameters from the encoded URL.
            ddlCategory.SelectedValue = Request.QueryString["ddlCategory"];
            ddlSupplier.SelectedValue = Request.QueryString["ddlSupplier"];
            lblProduct.Text = Request.QueryString["strProduct"];
            txtDescription.Text = Request.QueryString["strDescription"];
            lblImage.Text = Request.QueryString["strImage"];
            decimal decPrice = Convert.ToDecimal(Request.QueryString["decPrice"]);
            lblPrice.Text = decPrice.ToString("c");
            lblNumberInStock.Text = Request.QueryString["bytNumberInStock"];
            lblNumberOnOrder.Text = Request.QueryString["bytNumberOnOrder"];
            lblReorderLevel.Text = Request.QueryString["bytReorderLevel"];
            //Compute and display the value in stock and the value on order
            byte bytNumberInStock = Convert.ToByte(Request.QueryString["bytNumberInStock"]);
            byte bytNumberOnOrder = Convert.ToByte(Request.QueryString["bytNumberOnOrder"]);
            decimal decValueInStock = decPrice * bytNumberInStock;
            decimal decValueOnOrder = decPrice * bytNumberOnOrder;
            lblValueInStock.Text = " (Value: " + decValueInStock.ToString("c") + ")";
            lblValueOnOrder.Text = " (Value: " + decValueInStock.ToString("c") + ")";
            if (!IsPostBack)
            {
                ddlCategory.Enabled = false;
                ddlSupplier.Enabled = false;
            }
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("ProductEnterQueryStrings.aspx");
        }
    }
}