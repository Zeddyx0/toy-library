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
    public partial class Members : Form
    {

        string name, image, description, type, location, repCost, cost, status;
        int mouseX = 0, mouseY = 0;
        bool mouseDown;

        public Members(string mID)
        {
            InitializeComponent();
            loginID.Text =  mID;
            //MessageBox.Show(mID);
            
        }
        

        private void Members_Load(object sender, EventArgs e)
        {
            displayToys();
            ToyCategoryItems();
        }

       
        private void pbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

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

        private void bSearch_Click(object sender, EventArgs e)
        {
            lvToys.Clear();
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void panelSearch_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        

        private void displayToys()
        {
            SQL.selectQuery("Select * from Toy");

            //string query = "select * from Toy where";
            //if (1.Text().equals("") )
            //{ query.}


            if(SQL.read.HasRows)
            {
                while(SQL.read.Read())
                {

                    //assigning values to the database values
                    name = SQL.read[1].ToString();
                    image = SQL.read[11].ToString();
                    description = SQL.read[2].ToString();
                    type = SQL.read[10].ToString();
                    location = SQL.read[6].ToString();
                    repCost = SQL.read[4].ToString();
                    cost = SQL.read[5].ToString();
                    status = SQL.read[9].ToString();



                    //adding data to the Listview
                    string[] row = { image, name, description };
                    ListViewItem lvi = new ListViewItem(image);
                    lvi.SubItems.Add(name);
                    lvi.SubItems.Add(description);
                    lvi.SubItems.Add(type);
                    lvi.SubItems.Add(cost);
                    lvi.SubItems.Add(repCost);
                    lvi.SubItems.Add(location);

                    lvToys.Items.Add(lvi);

                    
                    //lvToys.Items.Add(image, name, description);

                }
            }
        }

        private void ToyCategoryItems()
        {
            string title;
            SQL.selectQuery("select * from Category");
            if(SQL.read.HasRows)
            {
                while (SQL.read.Read())
                {
                    title = SQL.read[1].ToString();
                    cbToyCategory.Items.Add(title);
                }

            }

        }
    }
}
