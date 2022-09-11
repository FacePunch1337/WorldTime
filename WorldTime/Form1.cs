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
        public Form1()
        {
            InitializeComponent();
            listBox1.Items.Add("New-Yorke");
            listBox1.Items.Add("London");
            listBox1.Items.Add("California");
            listBox1.Items.Add("Tokyo");
            listBox1.Items.Add("Kiyiv");
        }

        

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem.ToString() == "Kiyiv")
            {
                CultureInfo cultureInfo = new CultureInfo("ua-UA");
                //TimeZoneInfo timeZoneInfo = new TimeZoneInfo();
                 
                
                var uaTime = DateTime.Now.ToString() + ':' + DateTime.Now.Minute.ToString() + ':' + DateTime.Now.Second.ToString();
                textBox1.Text = uaTime;
            }
            if (listBox1.SelectedItem.ToString() == "Tokyo")
            {
                CultureInfo cultureInfo = new CultureInfo("jp-JP");
                textBox1.Text = cultureInfo.Name;
            }

        }
    }
}
