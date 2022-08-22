using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milestone_4
{
    /*
     * Enrique Sanchezmurillo
     * CST-150, Milestone 4 & 5
     * 21 AUG 2022
     */
    public partial class Form2 : Form
    {
        //Initialized all variables used throughout the class
        List<string> userList = new List<string>();

       static int xboxQuant = 0;
       static string xboxName = " ";
        static int userXInv = 0;
       static string xboxDescription = " ";
       static decimal xboxPrice = 0;


       static int psQuant = 0;
        static int userPSInv = 0;
       static string psName = " ";
       static string psDescription = " ";
       static decimal psPrice = 0;

        public Form2()
        {
            InitializeComponent();
        }
        //We used the load even to create our objects to a default state
        private void Form2_Load(object sender, EventArgs e)
        {
            xboxProduct("create", 5);
            PSProduct("create", 4);
        }

        
         public void xboxProduct(string action, int quant)
            {
            //We use the action string to determine what we are going to do with our inventory
                if (action.Equals("create"))
                {
                    //Creating our product
                    xboxName = "Xbox";
                    xboxDescription = "Video Game Console";
                    xboxPrice = 400.00m;
                    xboxQuant = quant;
                }
                if (action.Equals("add") || action.Equals("restock"))
                {
                //IF there is enough items to return
                if (userXInv - quant >= 0) 
                {
                    xboxQuant += quant;//updates current quant for xbox store inventory
                    
                    if (action.Equals("add")) {
                        MessageBox.Show(quant + " Item(s) Returned");
                        //Search and remove items from list
                        int itemIndex = 0;
                        for(int i = 0; i < quant; i++)
                        {
                            itemIndex = userList.IndexOf(xboxName);
                            userList.RemoveAt(itemIndex);
                            
                        }
                    }
                }
                else if (action.Equals("restock"))
                {
                    xboxQuant += quant;
                    MessageBox.Show(quant + " Xbox Item(s) Restocked");
                }
                else
                {
                    MessageBox.Show("Not enough items in inventory to return.");
                }
                   
                }
                if (action.Equals("remove"))
                {
                    if (xboxQuant-quant >= 0)
                    {
                    xboxQuant -= quant;
                    MessageBox.Show(quant + " Item(s) Purchased");
                    //Add items to list
                    for (int i = 0; i < quant; i++)
                    {
                        userList.Add("Xbox");
                    }
                    }
                    else
                    {
                        MessageBox.Show("Not enough shop inventory to make transaction.");
                    }
                }
            //Here we assign the information to the label
            ShopXboxLabel.Text = "Name: " + xboxName + " \n\n" +
            "Description: " + xboxDescription + "\n\n" +
            "Price: $" + xboxPrice + "\n\n" +
            "Quantity: " + xboxQuant + "\n\n" +
            "Price for All: " + String.Format("{0:C}",xboxQuant * xboxPrice); //MILESTONE 5 CHANGE
            int count = 0;
            //Search to count how many elements are in list, if there is nothing, we display empty
            foreach(string product in userList)
            {
                if (product.Equals("Xbox"))
                {
                    count++;
                }
            }
            if (count == 0)
            {
                InvXboxLabel.Text = "Empty";
            }
            else
            {
                //Here we update the label as we add/remove from the list (user's inventory)
                userXInv += count;
                InvXboxLabel.Text = "Name: " + xboxName + " \n\n" +
                "Description: " + xboxDescription + "\n\n" +
                "Price: $" + xboxPrice + "\n\n" +
                "Quantity: " + userXInv;
            }
        }
          public void PSProduct(string action, int quant)
            {
            if (action.Equals("create"))
                {
                    psName = "PlayStation";
                    psDescription = "Video Game Console";
                    psPrice = 500.00m;
                    psQuant = quant;
                }
            if (action.Equals("add") || action.Equals("restock"))
            {
                //IF there is enough items to return
                if (userPSInv - quant >= 0)
                {
                    psQuant += quant;//updates current quant for xbox store inventory

                    if (action.Equals("add"))
                    {
                        MessageBox.Show(quant + " Item(s) Returned");
                        //Search and remove items from list
                        int itemIndex = 0;
                        for (int i = 0; i < quant; i++)
                        {
                            itemIndex = userList.IndexOf(psName);
                            userList.RemoveAt(itemIndex);

                        }
                    }
                }
                else if (action.Equals("restock"))
                {
                    psQuant += quant;
                    MessageBox.Show(quant + " Playstation Item(s) Restocked");
                }
                else
                {
                    MessageBox.Show("Not enough items in inventory to return.");
                }

            }
            if (action.Equals("remove"))
                {
                    if (psQuant - quant >= 0)
                    {
                    psQuant -= quant;
                    MessageBox.Show(quant + " Item(s) Purchased");
                    for (int i = 0; i < quant; i++)
                    {
                        userList.Add("Playstation");
                    }
                }
                else
                {
                    MessageBox.Show("Not enough inventory to make transaction.");
                }
                    
             }
                //Label Description
                ShowPSLabel.Text = "Name: " + psName + " \n\n" +
                   "Description: " + psDescription + "\n\n" +
                   "Price: $" + psPrice + "\n\n" +
                   "Quantity: " + psQuant + "\n\n" + 
                   "Price for All: " + String.Format("{0:C}", psQuant * psPrice); //MILESTONE 5 CHANGE
            int count = 0;
            foreach (string product in userList)
            {
                if (product.Equals("Playstation"))
                {
                    count++;
                }
            }
            if (count == 0)
            {
                invPSLabel.Text = "Empty";
            }
            else
            {
                userPSInv += count;
                invPSLabel.Text = "Name: " + psName + " \n\n" +
                "Description: " + psDescription + "\n\n" +
                "Price: $" + psPrice + "\n\n" +
                "Quantity: " + userPSInv;
            }

        }

        private void XboxPurBut_Click(object sender, EventArgs e)
        {
            try
            {
                int userQuant = int.Parse(shopTextInp.Text);
                xboxProduct("remove", userQuant);
                //add to user inventory
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid input, submit integer");
            }
        }
        private void PSPurBut_Click(object sender, EventArgs e)
        {
            try
            {
                int userQuant = int.Parse(shopTextInp.Text);
                PSProduct("remove", userQuant);
                //add to user inventory
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid input, submit integer");
            }
        }
        //Exact same functions as the purchase buttons but isntead we are sending the "add" string
        private void XboxRetBut_Click(object sender, EventArgs e)
        {
            try
            {
                int userQuant = int.Parse(InvTextBox.Text);
                xboxProduct("add", userQuant);
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid input, submit integer");
            }
        }
        private void ReturnPSBut_Click(object sender, EventArgs e)
        {
            try
            {
                int userQuant = int.Parse(InvTextBox.Text);
                PSProduct("add", userQuant);
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid input, submit integer");
            }
        }
        //Closing Form
        private void ExitButtonShop_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Restock button
        private void RestockButton_Click(object sender, EventArgs e)
        {
            try
            {
                int userQuant = int.Parse(shopTextInp.Text);
                xboxProduct("restock", userQuant);
                PSProduct("restock", userQuant);
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Input, submit integer");
            }
        }
    }


    }

