using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ISBN
{
    public partial class ISBN : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        //convert method
        private static string GetIsbn(string productID)
        {
            //Remove(978)
            string isbn9 = productID.Substring(3);
            char[] isbn = isbn9.ToCharArray();
            int j = 10;
            int sum = 0;
            for (int i = 0; i < isbn.Length; i++)
            {
                sum += Convert.ToInt32(isbn[i].ToString()) * j;
                j--;
            }
            int a = 11 - (sum % 11);
            //a<10 ->a 
            //a =10 -> x 
            //a =11 -> 0
            string isbn10 = (a < 10) ? a.ToString() : ((a == 10) ? "x" : "0");
            return isbn9 + isbn10;

        }
        //Validation
        private bool checkIDvalidation(string productID)
        {
            bool validate = true;
            if(!Int64.TryParse(productID,out long ID) || productID.Length != 12)
            // 
            {
                LabelError.Visible = true;
                validate = false;
            }
            return validate;
        }
        //Convert button
        protected void ButtonConvert_Click(object sender, EventArgs e)
        {
            if (checkIDvalidation(ProductIDTextBox.Text))
            {
                ISBNnum.Text = GetIsbn(ProductIDTextBox.Text);

                LabelError.Visible = false;
                LabelISBN.Visible = true;
                ISBNnum.Visible = true;
            }
            else
            {
                LabelISBN.Visible = false;
                ISBNnum.Visible = false;
            }
        }
        //Clear Button
        protected void ButtonClear_Click(object sender, EventArgs e)
        {
            ProductIDTextBox.Text = string.Empty;
            ISBNnum.Text = string.Empty;
            ISBNnum.Visible = false;
            LabelError.Visible = false;
            LabelISBN.Visible = false;
        }
    }
}