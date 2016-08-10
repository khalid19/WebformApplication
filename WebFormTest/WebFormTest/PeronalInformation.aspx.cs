using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormTest
{
    public partial class PeronalInformation : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {

            Label6.Visible = false;
        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            var connectionString = ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString);
            Person person = new Person();

            person.FirstName = firstNameTextBox.Text;
            person.LastName = lastNameTextBox.Text;
            person.Contact = contactTextBox.Text;
            person.Address = addressTextBox.Text;

            if (FileUpload1.HasFile)
            {
                string strname = FileUpload1.FileName.ToString();

                FileUpload1.PostedFile.SaveAs(Server.MapPath("~/upload/") + strname);
                connection.Open();

                string query = "insert into Person values('" + person.FirstName + "','" + person.LastName + "','" +
                               person.Contact + "','" + person.Address + "','" + strname + "')";

                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                connection.Close();
                Label6.Visible = true;
                firstNameTextBox.Text = "";
                lastNameTextBox.Text = "";
                contactTextBox.Text = "";
                addressTextBox.Text = "";
                Label6.Text = "Data And Image Saved Succesfuylly ";

            }
            else
            {
                Label6.Visible = true;
                Label6.Text = "Not Working properly";
            }
        }

        private static string ConnectionString()
        {
            string connectionString = "server=DESKTOP-30ONMO9; initial catalog=Test2; integrated security=sspi";
            return connectionString;
        }

        protected void searchButton_Click(object sender, EventArgs e)
        {

            var connectionString = ConnectionString();
            string strname = null;

            Person person = new Person();

            person.PersonId = Convert.ToInt32(idTextBox.Text);
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = "select * from Person where PersonId='" + person.PersonId + "'";

                SqlCommand command = new SqlCommand(query, connection);


                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    person.FirstName = reader[1].ToString();
                    person.LastName = reader[2].ToString();
                    person.Contact = reader[3].ToString();
                    person.Address = reader[4].ToString();
                    strname = (reader[5]).ToString();



                }



                FileUpload1.PostedFile.SaveAs(Server.MapPath("~/upload/") + strname);

                firstNameTextBox.Text = person.FirstName;
                lastNameTextBox.Text = person.LastName;
                contactTextBox.Text = person.Contact;
                addressTextBox.Text = person.Address;


            }
            catch (Exception exception)
            {

                Label6.Text = "Not working properly" + exception.Message;
            }
        }

        protected void updateButton_Click(object sender, EventArgs e)
        {
            var connectionString = ConnectionString();


            SqlConnection connection = new SqlConnection(connectionString);

            Person person = new Person();
            person.PersonId = Convert.ToInt32(idTextBox.Text);
            person.FirstName = firstNameTextBox.Text;
            person.LastName = lastNameTextBox.Text;
            person.Contact = contactTextBox.Text;
            person.Address = addressTextBox.Text;
            if (FileUpload1.HasFile)
            {
                string strname = FileUpload1.FileName.ToString();

                FileUpload1.PostedFile.SaveAs(Server.MapPath("~/upload/") + strname);


                connection.Open();
                //string query = "insert into Person values('" + person.FirstName + "','" + person.LastName + "','" + person.Contact + "','" + person.LastName + "','" + pathTextBox.Text + "')";
                string query = "update Person set FirstName='" + person.FirstName + "',LastName='" + person.LastName +
                               "',Contact='" + person.Contact + "',Address='" + person.Address + "',Image='" +
                               strname + "' where PersonId='" + person.PersonId + "' ";
                SqlCommand command = new SqlCommand(query, connection);

                command.ExecuteNonQuery();

                connection.Close();

                firstNameTextBox.Text = "";
                lastNameTextBox.Text = "";
                contactTextBox.Text = "";
                addressTextBox.Text = "";

                Label6.Visible = true;
                Label6.Text = "Data And Image Updated Succesfuylly ";

            }
            else
            {
                Label6.Visible = true;
                Label6.Text = "NotWorking properly";
            }
        }

        protected void deleteButton_Click(object sender, EventArgs e)
        {
            var connectionString = ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString);

            Person person = new Person();
            person.PersonId = Convert.ToInt32(idTextBox.Text);


            try
            {
                connection.Open();
                //string query = "insert into Person values('" + person.FirstName + "','" + person.LastName + "','" + person.Contact + "','" + person.LastName + "','" + pathTextBox.Text + "')";
                string query = "delete from Person  where PersonId='" + person.PersonId + "' ";
                SqlCommand command = new SqlCommand(query, connection);

                int affectedRow = command.ExecuteNonQuery();

                connection.Close();

                firstNameTextBox.Text = "";
                lastNameTextBox.Text = "";
                contactTextBox.Text = "";
                addressTextBox.Text = "";
                Label6.Visible = true;

                Label6.Text = "Data deleted Successfully";



            }
            catch (Exception exception)
            {
                Label6.Visible = true;
                Label6.Text = exception.Message + "Data deleted Successfully";

            }


        }

        protected void showButton_Click(object sender, EventArgs e)
        {

            var connectionString = ConnectionString();



            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();
            string query = "select * from Person ";

            List<Person> persons = new List<Person>();

            SqlCommand command = new SqlCommand(query, connection);


            SqlDataReader reader = command.ExecuteReader();


            while (reader.Read())
            {
                Person person = new Person();
                person.PersonId = Convert.ToInt32(reader[0]);
                person.FirstName = reader[1].ToString();
                person.LastName = reader[2].ToString();
                person.Contact = reader[3].ToString();
                person.Address = reader[4].ToString();
                person.Image = (reader[5]).ToString();

                persons.Add(person);

            }
            GridView1.DataSource = persons;
            GridView1.DataBind();
        }

      
              
        }

        }


 

