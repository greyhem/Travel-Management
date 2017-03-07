using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class Admin_Feedback : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["UserID"] == null)
        {
            Response.Redirect("~/Login.aspx");
        }

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        
        try
        {
            if (ValidateFields())
            {
                int intResult = 0;
                FeedbackBO ObjFeedbackBO = new FeedbackBO();
                ObjFeedbackBO.UserName = txtName.Text.Trim();
                ObjFeedbackBO.Email= txtEmail.Text.Trim();
                ObjFeedbackBO.Comments= txtComments.Text.Trim();
               
                if (txtPhCountry1.Text.Trim() != "" && txtPhSTD1.Text.Trim() != "" && txtPhone1.Text.Trim() != "")
                {
                    ObjFeedbackBO.Phone = txtPhCountry1.Text.Trim() + "~" + txtPhSTD1.Text.Trim() + "~" + txtPhone1.Text.Trim();
                }

                if (txtMobileCountry.Text.Trim() != "" && txtMobile.Text.Trim() != "")
                {
                    ObjFeedbackBO.Mobile = txtMobileCountry.Text.Trim() + "~" + txtMobile.Text.Trim();
                }

                if (ddlRating.SelectedIndex != 0)
                {
                    ObjFeedbackBO.RatingOfSite = ddlRating.SelectedItem.Text;
                }
                intResult = ObjFeedbackBO.InsertIntotblFeedback();
                if (intResult > 0)
                {
                    Wizard1.ActiveStepIndex = 1;
                }
                else
                {

                }
            }
        }
        catch
        {
            throw;
        }
        Wizard1.ActiveStepIndex = 1;

    }
    private bool ValidateFields()
    {
        try
        {
            if (txtName.Text.Trim() == "")
            {
                lblError.Text = "Enter Name";
                return false;
            }
            if (txtEmail.Text.Trim() == "")
            {
                lblError.Text = "Enter Email";
                return false;
            }

            if (txtPhone1.Text.Trim() == "" && txtPhCountry1.Text.Trim() == "" && txtPhSTD1.Text.Trim() == "" && txtMobile.Text.Trim() == "" && txtMobileCountry.Text.Trim() == "")
            {
                lblError.Text = "Enter atleast one contact number";
                return false;

            }

            else
            {
                if (txtPhone1.Text.Trim() == "" && txtPhCountry1.Text.Trim() == "" && txtPhSTD1.Text.Trim() == "")
                {
                    if (txtMobile.Text.Trim() == "" && txtMobileCountry.Text.Trim() == "")
                    {
                        lblError.Text = "Enter atleast one contact number";
                        return false;
                    }


                    if (txtMobileCountry.Text.Trim() == "")
                    {
                        lblError.Text = "Enter Mobile Country Code";
                        return false;
                    }
                    if (txtMobile.Text.Trim() == "")
                    {
                        lblError.Text = "Enter Mobile Number";
                        return false;
                    }



                }
                if (txtMobile.Text.Trim() == "" && txtMobileCountry.Text.Trim() == "")
                {
                    if (txtPhone1.Text.Trim() == "" && txtPhCountry1.Text.Trim() == "" && txtPhSTD1.Text.Trim() == "")
                    {

                        lblError.Text = "Enter atleast one contact number";
                    }



                    if (txtPhCountry1.Text.Trim() == "")
                    {
                        lblError.Text = "Enter Phone Country Code";
                        return false;
                    }
                    if (txtPhSTD1.Text.Trim() == "")
                    {
                        lblError.Text = "Enter Phone STD";
                        return false;
                    }

                    if (txtPhone1.Text.Trim() == "")
                    {
                        lblError.Text = "Enter Phone Number";
                        return false;
                    }
                }
            }
            if (ddlRating.SelectedIndex == 0)
            {
                lblError.Text = "Give Rating";
                return false;
            }

            return true;
        }
        catch
        {
            return false;
        }
    }

}
