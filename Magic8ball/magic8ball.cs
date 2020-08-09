using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magic8ball
{
    public partial class magic8ball : Form
    {
        private List<string> answers = new List<string>()
        {
            "As I see it, yes.",
            "Ask again later.",
            "Better not tell you now.",
            "Cannot predict now.",
            "Concentrate and ask again.",
            "Don’t count on it.",
            "It is certain.",
            "It is decidedly so.",
            "Most likely.",
            "My reply is no.",
            "My sources say no.",
            "Outlook not so good.",
            "Outlook good.",
            "Reply hazy, try again.",
            "Signs point to yes.",
            "Very doubtful.",
            "ithout a doubt.",
            "Yes.",
            "Yes – definitely.",
            "You may rely on it."

        };
        public magic8ball()
        {
            InitializeComponent();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtQuestion.Clear();
            
        }

        private void btnAsk_Click(object sender, EventArgs e)
        {
            if(txtQuestion.Text != "")
            {
                txtResponse.Clear();
                response();
            }
            else
            {
                MessageBox.Show("Please ask a question.");
                txtQuestion.Focus();
                txtResponse.Clear();
            }
        }

        private void response()
        {
            var random = new Random();
            int index = random.Next(answers.Count);
            txtResponse.Text = answers[index];
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            txtQuestion.Clear();
            txtResponse.Clear();
        }
    }
}
