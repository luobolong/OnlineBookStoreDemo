using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerClient
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
            labelDate.Text = DateTime.Now.ToString("R");
            Timer timer = new Timer();
            timer.Tick += GetDateTimeClock;
            timer.Interval = 1000;
            timer.Start();

        }

        private void GetDateTimeClock(object sender, EventArgs e)
        {
            labelDate.Text = DateTime.Now.ToString("R");
        }
    }
}
