using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Typeing_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Stats stats = new Stats();
        Random random = new Random();

        int endGame;
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

            private void timer1_Tick(object sender, EventArgs e)
            {
                listBox1.Items.Add((Keys)random.Next(65, 90));
                if (listBox1.Items.Count > 7)
                {
                    listBox1.Items.Clear();
                    listBox1.Items.Add("Game over");
                    timer1.Stop();
                    endGame = 1;
                }
            }
        

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (listBox1.Items.Contains(e.KeyCode))
            {
                listBox1.Items.Remove(e.KeyCode);
                listBox1.Refresh();
                timer1.Interval = timer1.Interval - 14;
                if(difficultyProgressBar.Value < 701)
                {
                    difficultyProgressBar.Value += 13;
                }
                stats.Update(true);
            }
            else
            {
                stats.Update(false);
            }
            //ステータスバーの再表示
            if (endGame != 1) {
            correctLabel.Text = "Correct: " + stats.Correct;
                missedLabel.Text = "Missed: " + stats.Missed;
                totallLabel.Text = "Total: " + stats.Total;
                accuracyLabel.Text = "Accuracy: " + stats.Accuracy + "%";
            }
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
