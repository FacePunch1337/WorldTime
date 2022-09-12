using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorldTime
{
    public partial class Form1 : Form
    {
        private DateTime dateTime;
        private string worldTime;
    
        public Form1()
        {
            InitializeComponent();
           
            listBox1.Items.Add("New-York");
            listBox1.Items.Add("London");
            listBox1.Items.Add("California");
            listBox1.Items.Add("Tokyo");
            listBox1.Items.Add("Kiyiv");
            timer1.Start();
        }

       
        private void timer1_Tick(object sender, EventArgs e)
        {

            dateTime = DateTime.Now;
            textBox1.Text = worldTime;

            switch (listBox1.SelectedItem)
            {
                case "New-York":
                    worldTime = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(dateTime, "Eastern Standard Time").ToString(new CultureInfo("en-US").DateTimeFormat);
                    break;

                case "London":
                    worldTime = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(dateTime, "GMT Standard Time").ToString(new CultureInfo("en-GB").DateTimeFormat);
                    break;

                case "California":
                    worldTime = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(dateTime, "Pacific Standard Time").ToString(new CultureInfo("en-US").DateTimeFormat);
                    break;

                case "Tokyo":
                    worldTime = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(dateTime, "Tokyo Standard Time").ToString(new CultureInfo("ja-JP").DateTimeFormat);
                    break;

                case "Kiyiv":
                    worldTime = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(dateTime, "FLE Standard Time").ToString(new CultureInfo("uk-UA").DateTimeFormat);
                    break;
            }
        }
    }
}
