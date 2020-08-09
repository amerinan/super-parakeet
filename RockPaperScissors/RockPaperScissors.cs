using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissors
{
    public partial class RockPaperScissors : Form
    {
        private string playerChoice;
        private string computerChoice;
        private int[] score = new int[3];
        private string resultTxt;

        public RockPaperScissors()
        {
            InitializeComponent();
        }

        private void btnRock_Click(object sender, EventArgs e)
        {
            playerChoice = "rock";
            pcChoice();
            results();
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            playerChoice = "paper";
            pcChoice();
            results();
        }

        private void btnScissors_Click(object sender, EventArgs e)
        {
            playerChoice = "scissors";
            pcChoice();
            results();
        }

        private void pcChoice()
        {
            List<string> temp = new List<string> { "rock", "paper", "scissors" };
            var random = new Random();
            int index = random.Next(temp.Count);
            computerChoice = (temp[index]);
        }

        private void results()
        {
            switch (playerChoice)
            {
                case "rock":
                    {
                        switch (computerChoice)
                        {
                            case "rock":
                                youTie();
                                break;

                            case "paper":
                                youLose();
                                break;

                            case "scissors":
                                youWin();
                                break;

                            default:
                                break;
                        }
                        break;
                    }
                case "paper":
                    {
                        switch (computerChoice)
                        {
                            case "rock":
                                youWin();
                                break;

                            case "paper":
                                youTie();
                                break;

                            case "scissors":
                                youLose();
                                break;

                            default:
                                break;
                        }
                        break;
                    }

                case "scissors":
                    {
                        switch (computerChoice)
                        {
                            case "rock":
                                youLose();
                                break;

                            case "paper":
                                youWin();
                                break;

                            case "scissors":
                                youTie();
                                break;

                            default:
                                break;
                        }
                        break;
                    }

                default:
                    MessageBox.Show("Please select a valid option", "Entry Error");
                    break;

            }
        }

        private void youWin()
        {
            resultTxt = "You Win!";
            score[0]++;
            updateTxtBox();
        }

        private void youLose()
        {
            resultTxt = "You Lose!";
            score[1]++; 
            updateTxtBox();
        }

        private void youTie()
        {
            resultTxt = "Tie Game";
            score[2]++;
            updateTxtBox();
        }

        private void updateTxtBox()
        {
            txtResults.Text = resultTxt;
            string sep = " - ";
            txtScore.Text = Convert.ToString(score[0]) + sep + Convert.ToString(score[1]) + sep + Convert.ToString(score[2]);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
