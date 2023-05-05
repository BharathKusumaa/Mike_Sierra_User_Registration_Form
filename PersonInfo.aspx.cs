using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.BussinessLogic;

namespace WebApplication1
{
    public partial class PersonInfo1 : System.Web.UI.Page
    {
        UserRegistrationEntities registrationEntities = new UserRegistrationEntities();
        PersonInfoBL personInfoBL = new PersonInfoBL();
        GenderBL genderBL = new GenderBL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                Loaddata();
            }

        }

        protected void SqlDataSource1_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }

        private void Loaddata()
        {
            gridviewInfo.DataSource = personInfoBL.GetPersonInformation();
            gridviewInfo.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            PersonInfo personInfo = new PersonInfo();


            personInfo.FirstName = TextBox1.Text.ToString();
            personInfo.LastName = TextBox6.Text.ToString();
            personInfo.Email = TextBox3.Text.ToString();
            personInfo.Password = TextBox4.Text.ToString();
            personInfo.Mobile = Convert.ToInt64(TextBox5.Text);
            //if (RadioButton1.Checked)
            //{
            //    personInfo.Gender
            //}
            personInfo.Gender = Convert.ToInt32(RadioButtonList1.SelectedValue);

            // personInfo.Gender = Convert.ToInt32(RadioButton1.Text);
            personInfo.Hobbies = Convert.ToInt32(CheckBoxList1.SelectedValue);
            bool result = personInfoBL.SavePersonInfo(personInfo);
            if(result==true)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Saved Successfully')", true);
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Data Not Saved Successfully')", true);
            }
            



            var context = new ValidationContext(personInfo, serviceProvider: null, items: null);
            var results = new List<ValidationResult>();
            var isValid = Validator.TryValidateObject(personInfo, context, results, true);

            if (!isValid)
            {
                foreach (var validationResult in results)
                {
                    Response.Write(validationResult.ErrorMessage.ToString());
                }

                return;
            }



            //genderId.Text = "";
            //if (RadioButton1.Checked)
            //{
            //    genderId.Text = "Your gender is " + RadioButton1.Text;
            //}
            //else if (RadioButton2.Checked)
            //{
            //    genderId.Text = "Your gender is " + RadioButton2.Text;
            //}

            //else genderId.Text = "Your gender is " + RadioButton3.Text;
            Loaddata();
            clearData();

        }

        protected void clearData()
        {
            TextBox1.Text = "";
            TextBox6.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            ResetFormValues(this.CheckBoxList1);
            ResetFormValues(this.RadioButtonList1);
            //RadioButtonList1.SelectedValue = "";
            //CheckBoxList1.SelectedValue = "";
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            clearData();
        }

       

        protected void gridviewInfo_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gridviewInfo.PageIndex = e.NewPageIndex;
            Loaddata();
        }

        private void ResetFormValues(Control c)
        {
            switch (c.GetType().ToString())
            {
                case "System.Web.UI.WebControls.TextBox":
                    ((TextBox)c).Text = "";
                    //birthdate.Text = "mm/dd/yyyy";  
                    break;
                case "System.Web.UI.WebControls.CheckBoxList":
                    CheckBoxList check = (CheckBoxList)c;
                    for (var i = 0; i < check.Items.Count; i++)
                    {
                        check.Items[i].Selected = false;
                    }
                    break;
                case "System.Web.UI.WebControls.RadioButtonList":
                    RadioButtonList radio = (RadioButtonList)c;
                    for (var i = 0; i < radio.Items.Count; i++)
                    {
                        radio.Items[i].Selected = false;
                    }
                    break;
            }
        }
    }
}
