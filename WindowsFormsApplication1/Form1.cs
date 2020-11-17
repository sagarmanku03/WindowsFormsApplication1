using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Race
{
    public partial class Form1 : Form
    {
        Person[] Bettings;
        hound[] Pet;
        Person CurrentBetting;

        public Form1()
        {
            InitializeComponent();
            Random RandomPicker = new Random();
            
            Bettings = new Person[3];
            Pet = new hound[4];

            Bettings[0] = new Person();
            Bettings[0].Name = "Joe";
            Bettings[0].RadioBTN = JoeButton;
            Bettings[0].Labeling = JoeBLabel;
            Bettings[0].Money = 50;
            Bettings[0].UpdateLBL();

            Bettings[1] = new Person();
            Bettings[1].Name = "Bob";
            Bettings[1].RadioBTN = bobRadioButton;
            Bettings[1].Labeling = BobBLabel;
            Bettings[1].Money = 75;
            Bettings[1].UpdateLBL();

            Bettings[2] = new Person();
            Bettings[2].Name = "Al";
            Bettings[2].RadioBTN = alRadioButton;
            Bettings[2].Labeling = alBetLabel;
            Bettings[2].Money = 45;
            Bettings[2].UpdateLBL();


            int StartPosition = Pet1.Location.X;
            int distance = Photo.Width;
            for (int i = 0; i < 4; i++)
            {
                Pet[i] = new hound();
                Pet[i].RandomPicker = RandomPicker;
                Pet[i].TrackSize = distance;
                Pet[i].Location = Pet[i].FromPosition = StartPosition;
            }

            Pet[0].MyPictureBox = Pet1;
            Pet[1].MyPictureBox = Pet2;
            Pet[2].MyPictureBox = Pet3;
            Pet[3].MyPictureBox = Pet4;

            CurrentBetting = Bettings[0];
        }

        private void GoRace_Click(object sender, EventArgs e)
        {
            int win = 0;
            int num_wins = 0;

            while (num_wins == 0)
            {
                for (int i = 0; i < Pet.Length; i++)
                {
                    if (Pet[i].Running())
                    {
                        num_wins++;
                        win = i + 1;
                    }
                }
                Application.DoEvents();
                System.Threading.Thread.Sleep(3);
            }



            for (int i = 0; i < Pet.Length; i++)
            {
                Pet[i].TFPosition();
            }
            string messageContent = "Congratulations \n";
            bool anyoneWins = false;
            for (int i = 0; i < Bettings.Length; i++)
            {
                if (Bettings[i].OurBet.Pet == win)
                {
                    anyoneWins = true;
                    messageContent += Bettings[i].Name + "\n";
                }
                Bettings[i].Collect(win);
                Bettings[i].ClearBet();
                Bettings[i].UpdateLBL();
            }
            if (anyoneWins)
            {
                MessageBox.Show(" Pet Number" + win + "wins!\n" + messageContent);
            }

            if (num_wins > 1)
                MessageBox.Show("We have " + num_wins + " wins");
            else if (!anyoneWins)
            {
                MessageBox.Show(" Pet Number" + win + "wins!");
            }
            numericUpDownBet.Value = numericUpDownBet.Minimum;
            numericUpDownPet.Value = numericUpDownPet.Minimum;
            ResetGame();
        }

        private void ResetGame()
        {
            Pet1.Location = new Point(61, 32);
            Pet2.Location = new Point(61, 84);
            Pet3.Location = new Point(61, 131);
            Pet4.Location = new Point(61, 181);
        }

        private void JoeButton_CheckedChanged(object sender, EventArgs e)
        {
            SetBetting(0);
        }

        private void bobRadioButton_CheckedChanged_1(object sender, EventArgs e)
        {
            SetBetting(1);
        }

        private void alRadioButton_CheckedChanged_1(object sender, EventArgs e)
        {
            SetBetting(2);
        }

        private void BetsButton_Click(object sender, EventArgs e)
        {
            CurrentBetting.SetBet((int)numericUpDownBet.Value, (int)numericUpDownPet.Value);
            CurrentBetting.UpdateLBL();
        }
        private void SetBetting(int index)
        {
            CurrentBetting = Bettings[index];
            NameLabel.Text = CurrentBetting.Name;
            if (CurrentBetting.OurBet != null)
            {
                numericUpDownBet.Value = CurrentBetting.OurBet.Price;
                numericUpDownPet.Value = CurrentBetting.OurBet.Pet;
            }
            else
            {
                numericUpDownBet.Value = numericUpDownBet.Minimum;
                numericUpDownPet.Value = 1;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MinBLabel.Text = "Minimum Bet $5.00";
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            ResetGame();
        }
        private void Pet1_Click(object sender, EventArgs e)
        {

        }
        private void formButtonRace_Click(object sender, EventArgs e)
        {
            int win = 0;
            int winpet = 0;
            int count = 0;
            for (int i = 0; i < Bettings.Length; i++)
            {
                if (Bettings[1].OurBet != null)
                {
                    count++;
                }
            }

            if (count == Bettings.Length)
            {
                while (win == 0)
                {
                    for (int i = 0; i < Pet.Length; i++)
                    {
                        if (Pet[i].Running())
                        {
                            win++;
                            winpet = i + 1;
                            for (int i2 = 0; i2 < Bettings.Length; i2++)
                            {
                                Bettings[i2].Collect(i + 1);
                            }
                        }
                        Application.DoEvents();
                        System.Threading.Thread.Sleep(3);
                    }
                }
                if (win > 1)
                {
                    MessageBox.Show("Multiple wins!", "WOW");
                }
                else
                {
                    MessageBox.Show("The win was Pet Number" + winpet);
                }
                for (int i = 0; i < Bettings.Length; i++)
                {
                    Bettings[i].ClearBet(true);
                }
                for (int i = 0; i < Pet.Length; i++)
                {
                    Pet[i].TFPosition();
                }
            }
            else
            {
                MessageBox.Show("Not all players have placed their bets!", "Wait wait!");
            }
        }
        private void Photo_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
