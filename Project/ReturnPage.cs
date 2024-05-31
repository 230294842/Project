using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class ReturnPage : Form
    {
        public ReturnPage()
        {
            InitializeComponent();
            timer1.Interval = 1000; // Set the interval to 1 second
            timer1.Tick += new EventHandler(timer1_Tick); // Ensure the Tick event is connected
            timer1.Start(); // Start the timer
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dateTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss tt"); // Set the initial text of the label
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dateTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss tt"); // Update the label's text with the current date and time
        }

        private void showPersonalInfoButton_Click(object sender, EventArgs e)
        {

        }

        private void editPersonalInfoButton_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) // Clicks "Next page"
        {

        }
    }
}
