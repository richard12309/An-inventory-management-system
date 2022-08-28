using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class LoginForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\JNR\Desktop\IA\InventoryManagementSystem\InventoryManagementSystem\dbms.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void checkBoxPass_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtPass.Clear();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_MouseHover(object sender, EventArgs e)
        {
            txtName.Text = "";
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = true;

            pictureBox2.Visible = false;
            pictureBox3.Location = new Point(254, 322);
            
            txtPass.UseSystemPasswordChar = true;

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
            pictureBox2.Visible = true;
            pictureBox3.Location = new Point(284, 322);
            pictureBox2.Location = new Point(254, 322);
            txtPass.UseSystemPasswordChar = false;




        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtPass.Clear();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {

            try
            {

                MainForm main = new MainForm();
                main.ShowDialog();

                //cm = new SqlCommand("SELECT * FROM tbUser WHERE username=@username AND password=@password", con);
                //cm.Parameters.AddWithValue("@username", txtName.Text);
                //cm.Parameters.AddWithValue("@password", txtPass.Text);
                //con.Open();
                //dr = cm.ExecuteReader();
                //dr.Read();
                //if (dr.HasRows)
                //{
                //    MessageBox.Show("Welcome " + dr["fullname"].ToString() + " | ", "ACCESS GRANTED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    this.Hide();
                //    MainForm main = new MainForm();
                //    main.ShowDialog();


                //}
                //else
                //{
                //    MessageBox.Show("Invalid username or password!", "ACCESS DENITED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }

}