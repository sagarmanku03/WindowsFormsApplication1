using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Race
{
    public class Person
    {
        public RadioButton RadioBTN;
        public Label Labeling;
        public string Name; 
        public Bet OurBet = null;
        public int Money;
       

        public void UpdateLBL()
        {
        if (OurBet == null)
        Labeling.Text = Name + " You Have Not bet Anything";
        else
        Labeling.Text = OurBet.GetDescription();
        RadioBTN.Text = Name + " Having " + Money + " Money";
        }


        public void ClearBet(bool OverRace)
        {
            if (OverRace)
            {
                OurBet = null;
            }
            else
            {
                if (this.OurBet != null)
                {
                    Money += this.OurBet.Price;
                    this.OurBet = null;
                }
                else
                {
                    this.OurBet = null;
                }
            }
            UpdateLBL();
        }

        public bool SetBet(int Price, int Pet)
        {
        if (Price > Money)
        {
        MessageBox.Show("I Have no money now for Bet", Name + " saying");
        return false;
        }
        else
        {
        if (this.OurBet == null)
        {
        this.OurBet = new Bet() { Price = Price, Betting = this, Pet = Pet };
        this.Money -= Price;
        this.UpdateLBL();
        return true;
        }
        else
        {
        this.Money += this.OurBet.Price;
        this.OurBet = null;
        this.OurBet = new Bet() { Price = Price, Betting = this, Pet = Pet };
        this.Money -= Price;
        this.UpdateLBL();
        return true;
        }
        }
        }

        static void Main()
        {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new Form1());
        }

        internal void Collect(int win)
        {

        //throw new NotImplementedException();
        }

        internal void ClearBet()
        {
       // throw new NotImplementedException();
        }
    }
}
