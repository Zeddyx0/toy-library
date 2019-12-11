using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INTRO_USERS
{
    //Name: Abdulaziz Andijani
    //Student ID: 1250753

    public partial class LoginPage : Form
    {
       public string lID = "", mID = "";
       public string fname = "", lname = "", iwi = "", DOB = "", gender = "", note = "", childLanguage = "";
        
        /// <summary>
        /// This is the first method called when the program form loads.
        /// </summary>
        public LoginPage()
        {
            InitializeComponent();
            //This line of code allows us to obscure the password visually and limit the max chars in textbox
            // textBoxPassword.PasswordChar = '*';     //password character to hide password characters
            // textBoxPassword.MaxLength = 20;         //max textbox character count
        }

        int mouseX = 0, mouseY = 0;
        bool mouseDown;


        private void bLibrarian_Click(object sender, EventArgs e)
        {
            panelLogin.Visible = false;
            panelLibrarian.Visible = true;
        }

        private void bMember_Click(object sender, EventArgs e)
        {
            panelLogin.Visible = false;
            panelMember.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lMBack_Click(object sender, EventArgs e)
        {
            panelLogin.Visible = true;
            panelMember.Visible = false;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            panelLogin.Visible = true;
            panelLibrarian.Visible = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X - 527;
                mouseY = MousePosition.Y - 20;

                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

      

        private void label8_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bLLogin_Click(object sender, EventArgs e)
        {

            //Variables to be used: 1x bool, 4x string
            bool loggedIn = false;
            string lUsername = "", lPassword = "";

            //check if boxes are empty, the Trim removes white space in text from either side
            if ("".Equals(tbLUserName.Text.Trim()) || "".Equals(tbLPassword.Text.Trim()))
            {
                MessageBox.Show("Please make sure you enter a Username and Password");
                return;
            }


            //Get	the	username	and	password	and	store	as	string
            lUsername = tbLUserName.Text.Trim();
            lPassword = tbLPassword.Text.Trim();

            //Use	a	select	query	on	the	users	table
            SQL.selectQuery("SELECT	*	from	Librarian");

            //If	there	exists	at	least	one	User
            if (SQL.read.HasRows)
            {
                //cycle	through	all	users	checking	if	the	username	exists	and	if	the	password	matches
                while (SQL.read.Read())
                {
                    //SQL.read[i]:	i=0	is	UserName	...	i=4	is	Password
                    if (lUsername.Equals(SQL.read[4].ToString()) && lPassword.Equals(SQL.read[5].ToString()))
                    {
                        //Username	and	Password	correct,	get	fname,	lname	to	display
                        loggedIn = true;
                        lID = SQL.read[0].ToString();


                        break; //stops	the	while	loop	since	they	have	logged	in
                    }
                }
            }
            else
            {
                //Error	message	to	show	that	no	users	have	been	registered
                MessageBox.Show("No	users	have	been	registered 1.");
                return;
            }

            //if logged in display a success message
            if (loggedIn)
            {
                //message stating we logged in good
                MessageBox.Show("hurray");

            }
            else
            {
                //message stating we couldn't log in
                MessageBox.Show("Login attempt unsuccessful! Please check details");
                tbMUserName.Focus();
                return;
            }
        }

        private void panelAllLoginElements_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tbMPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbMUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panelMember_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelLibrarian_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tbLUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void tbLPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void bLCLear_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panelLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }


        /// <summary>
        /// Clicked when user decides they are ready to log in, 
        /// Will get username and password, use that to query database and check that username and password are correct.
        /// A message box will be used to state whether or not we logged in successfully
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            //Variables to be used: 1x bool, 4x string
            bool loggedIn = false;
            string username = "", password = "";

            //check if boxes are empty, the Trim removes white space in text from either side
            if ("".Equals(tbMUserName.Text.Trim()) || "".Equals(tbMPassword.Text.Trim()))
            {
                MessageBox.Show("Please make sure you enter a Username and Password");
                return;
            }


            //Get	the	username	and	password	and	store	as	string
            username = tbMUserName.Text.Trim();
            password = tbMPassword.Text.Trim();

            //Use	a	select	query	on	the	users	table
            SQL.selectQuery("SELECT	*	from	Membership");

            //If	there	exists	at	least	one	User
            if (SQL.read.HasRows)
            {
                //cycle	through	all	users	checking	if	the	username	exists	and	if	the	password	matches
                while (SQL.read.Read())
                {
                    //SQL.read[i]:	i=0	is	UserName	...	i=4	is	Password
                    if (username.Equals(SQL.read[1].ToString()) && password.Equals(SQL.read[0].ToString()))
                    {
                        //Username	and	Password	correct,	get	fname,	lname	to	display
                        
                        mID = SQL.read[3].ToString();
                        //MessageBox.Show(mID);
                        loggedIn = true;
                        break; //stops	the	while	loop	since	they	have	logged	in
                    }
                }
            }
            else
            {
                //Error	message	to	show	that	no	users	have	been	registered
                MessageBox.Show("No	users	have	been	registered 1.");
                return;
            }

            //if logged in display a success message
            if (loggedIn)
            {
                //MessageBox.Show("Cool");
                Members membersLogin = new Members(mID);
                this.Hide();
                membersLogin.ShowDialog();
                this.Close();
                //message stating we logged in good
                //listBox1.Visible = true;
                //label1.Visible = false;
                //LoginAs.Visible = true;
                //setVariables();
                //string a = "First name:", b = "Last name:", c = "iwi?", d = "Birthday:", l = "Gender:", f = "Note:", g = "Language:";

                //listBox1.Items.Add(a);
                //listBox1.Items.Add(fname);
                //listBox1.Items.Add(b);
                //listBox1.Items.Add(lname);
                //listBox1.Items.Add(c);
                //listBox1.Items.Add(iwi);
                //listBox1.Items.Add(d);
                //listBox1.Items.Add(DOB);
                //listBox1.Items.Add(l);
                //listBox1.Items.Add(gender);
                //listBox1.Items.Add(f);
                //listBox1.Items.Add(note);
                //listBox1.Items.Add(g);
                //listBox1.Items.Add(childLanguage);


            }
            else
            {
                //message stating we couldn't log in
                MessageBox.Show("Login attempt unsuccessful! Please check details");
                tbMUserName.Focus();
                return;
            }

        }


        /// <summary>
        /// When clicked on switch page to the register page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
 

        /// <summary>
        /// Clears the text boxes on the page focuses on top one
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClearAll_Click(object sender, EventArgs e)
        {
            initialiseTextBoxes();
        }

        /// <summary>
        /// Initialises all textboxes to blank text
        /// Re focus to first text box
        /// </summary>
        public void initialiseTextBoxes()
        {
            //goes through and clears all of the textboxes
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    (c as TextBox).Clear();
                }
            }
            //makes next place user types the text box
            tbMUserName.Focus();
        }

        /// <summary>
        /// When the mouse hovers over the top of the register button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
    

        /// <summary>
        /// Takes us to the browse session page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        public void setVariables()
        {
            SQL.selectQuery("SELECT	*	from	Child");
            //If	there	exists	at	least	one	User
            if (SQL.read.HasRows)
            {
                
                    while (SQL.read.Read())
                    {
                    //cycle	through	all	users	checking	if	the	username	exists	and	if	the	password	matches
                    if (mID.Equals(SQL.read[0].ToString()))
                    {
                        fname = SQL.read[1].ToString();
                        lname = SQL.read[2].ToString();
                        iwi = SQL.read[3].ToString();
                        DOB = SQL.read[4].ToString();
                        gender = SQL.read[5].ToString();
                        note = SQL.read[6].ToString();
                        childLanguage = SQL.read[7].ToString();
                        return;
                    }

                }
            }

            else
            {
                //Error	message	to	show	that	no	users	have	been	registered
                MessageBox.Show("No	users	have	been	registered 3.");
                return;
            }
        }
    }

}

