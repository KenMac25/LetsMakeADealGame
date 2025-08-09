using System;
using System.Collections.Generic;
using System.Media;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Form1 : Form
    {
        private List<string> highValuePrizes;
        private List<string> mediumValuePrizes;
        private List<string> lowValuePrizes;
        private string prizeBehindDoor1;
        private string prizeBehindDoor2;
        private string prizeBehindDoor3;
        private Random random;
        private bool isGameFinished;
        private FileStream stream;

        public Form1()
        {
            InitializeComponent();
            InitializePrizes();
            random = new Random();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetupGame();
        }

        private void InitializePrizes()
        {
            highValuePrizes = new List<string> { "Lamborghini Aventador", "Range Rover", "6 Month Private Yacht Rental", "World Tour Vacation", "$10,000,000", "Porsche 911", "Rolls Royce", "LifeTime SeasonPass to a Sport of your Choice", "Private Performance of your Favorite Artist or Band", "Beach House in the Bahammas"};
            mediumValuePrizes = new List<string> { "Gym Equipment", "Washer and Dryer", "60 Inch Smart TV", "Apple MacBook", "Electric Bike", "Smart Phone", "Smart Watch", "2 Week Paid Vacation", "Unlimited Chipotle for 1 Year", "Home Renovation" };
            lowValuePrizes = new List<string> { "Bicycle", "Antique Rotary Phone", "$25 Visa Gift Card", "Kids Cartoon Watch", "1 Month Gym Membership", "Movie Tickets for 2", "Lottery Ticket", "Coupons", "Football", "Shoes" };
        }

        private void SetupGame()
        {
            lblMessage.Text = "Choose a door if you dare...";
            isGameFinished = false;

            prizePictureBox.Image = null;
            prizePictureBox.Visible = false;

            prizeBehindDoor1 = AssignPrize();
            prizeBehindDoor2 = AssignPrize();
            prizeBehindDoor3 = AssignPrize();

            btnDoor1.Enabled = true;
            btnDoor2.Enabled = true;
            btnDoor3.Enabled = true;
        }

        private string AssignPrize()
        {
            int category = random.Next(3);
            switch (category)
            {
                case 0: return highValuePrizes[random.Next(highValuePrizes.Count)];
                case 1: return mediumValuePrizes[random.Next(mediumValuePrizes.Count)];
                case 2: return lowValuePrizes[random.Next(lowValuePrizes.Count)];
                default: return "Error";
            }
        }

        private void btnDoor1_Click(object sender, EventArgs e)
        {
            ShowPrize(prizeBehindDoor1, btnDoor1);
        }

        private void btnDoor2_Click(object sender, EventArgs e)
        {
            ShowPrize(prizeBehindDoor2, btnDoor2);
        }

        private void btnDoor3_Click(object sender, EventArgs e)
        {
            ShowPrize(prizeBehindDoor3, btnDoor3);
        }

        private void ShowPrize(string prize, Button selectedButton)
        {
            if (isGameFinished) return;

            lblMessage.Text = $"You won: {prize}!\n";
            isGameFinished = true;

            btnDoor1.Enabled = false;
            btnDoor2.Enabled = false;
            btnDoor3.Enabled = false;

            if (highValuePrizes.Contains(prize))
            {
                ShowPrizeImage(prize);
                PlayWinSound();
                lblMessage.Text += " Jackpot!";
            }
            else if (mediumValuePrizes.Contains(prize))
            {
                ShowPrizeImage(prize);
                PlayNeutralSound();
                lblMessage.Text += " That's Decent!";
            }
            else if (lowValuePrizes.Contains(prize))
            {
                ShowPrizeImage(prize);
                PlayLoseSound();
                lblMessage.Text += " Not Bad.";
            }
        }

        private void ShowPrizeImage(string prizeType)
        {
            string imagePath = "";

            switch (prizeType)
            {
                case "Lamborghini Aventador":
                    imagePath = "Lambo.jpg";
                    break;
                case "Range Rover":
                    imagePath = "Rover.jpg";
                    break;
                case "6 Month Private Yacht Rental":
                    imagePath = "Yacht.jpg";
                    break;
                case "World Tour Vacation":
                    imagePath = "World.jpg";
                    break;
                case "$10,000,000":
                    imagePath = "Money.jpg";
                    break;
                case "Porsche 911":
                    imagePath = "Porsche.jpg";
                    break;
                case "Rolls Royce":
                    imagePath = "Royce.jpg";
                    break;
                case "LifeTime SeasonPass to a Sport of your Choice":
                    imagePath = "Sport.jpg";
                    break;
                case "Private Performance of your Favorite Artist or Band":
                    imagePath = "U2.jpg";
                    break;
                case "Beach House in the Bahammas":
                    imagePath = "Beach";
                    break;

                case "Gym Equipment":
                    imagePath = "Equipment.jpg";
                    break;
                case "Washer and Dryer":
                    imagePath = "Washer.jpg";
                    break;
                case "60 Inch Smart TV":
                    imagePath = "TV.jpg";
                    break;
                case "Apple MacBook":
                    imagePath = "Apple.jpg";
                    break;
                case "Electric Bike":
                    imagePath = "Bike.jpg";
                    break;
                case "Smart Phone":
                    imagePath = "SmartPhone.jpg";
                    break;
                case "Smart Watch":
                    imagePath = "SmartWatch.jpg";
                    break;
                case "2 Week Paid Vacation":
                    imagePath = "PaidVacation.jpg";
                    break;
                case "Unlimited Chipotle for 1 Year":
                    imagePath = "Chipotle.jpg";
                    break;
                case "Home Renovation":
                    imagePath = "Renovation.jpg";
                    break;

                case "Bicycle":
                    imagePath = "Bicycle.jpg";
                    break;
                case "Antique Rotary Phone":
                    imagePath = "Phone.jpg";
                    break;
                case "$25 Visa Gift Card":
                    imagePath = "Card.jpg";
                    break;
                case "Kids Cartoon Watch":
                    imagePath = "Watch.jpg";
                    break;
                case "1 Month Gym Membership":
                    imagePath = "Membership.jpg";
                    break;
                case "Movie Tickets for 2":
                    imagePath = "Ticket.jpg";
                    break;
                case "Lottery Ticket":
                    imagePath = "Lottery.jpg";
                    break;
                case "Coupons":
                    imagePath = "Coupon.jpg";
                    break;
                case "Football":
                    imagePath = "Football.jpg";
                    break;
                case "Shoes":
                    imagePath = "Shoes.jpg";
                    break;
            }

            if (!string.IsNullOrEmpty(imagePath))
            {
                prizePictureBox.Image = Image.FromFile(imagePath);
                prizePictureBox.Visible = true;
            }
        }

        private void PlayWinSound()
        {
            stream = File.OpenRead("winSound.wav");
            SoundPlayer winSound = new SoundPlayer(stream);
            winSound.Play();
        }

        private void PlayLoseSound()
        {

            stream = File.OpenRead("loseSound.wav");
            SoundPlayer loseSound = new SoundPlayer(stream);
            loseSound.Play();
        }

        private void PlayNeutralSound()
        {
                stream = File.OpenRead("neutralSound.wav");
                SoundPlayer neutralSound = new SoundPlayer(stream);
                neutralSound.Play();
        }
        private void btnRestart_Click(object sender, EventArgs e)
        {
            SetupGame();
        }

        private void lblMessage_Click(object sender, EventArgs e)
        {

        }
    }
}
