using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateCalculator
{
    public partial class CALCULATOR : Form
    {
        public CALCULATOR()
        {
            InitializeComponent();
        }

        private void CALCULATOR_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string date1 = dateTimePicker1.Text;
            string date2 = dateTimePicker2.Text;
            int counter = 0, month1 = 0, day1 = 0, year1 = 0, month2 = 0, day2 = 0, year2 = 0;
            DateTime result1 = dateTimePicker1.Value;
            DateTime result2 = dateTimePicker2.Value;
            
            foreach(string date in result1.ToString().Split(' ', ',', '/'))
            {
                if (counter == 3)
                    break;
                else if (counter == 0)
                    month1 = int.Parse(date);
                else if (counter == 1)
                    day1 = int.Parse(date);
                else if (counter == 2)
                    year1 = int.Parse(date);
                counter++;
            }

            counter = 0;
            foreach (string date in result2.ToString().Split(' ', ',', '/'))
            {
                if (counter == 3)
                    break;
                else if (counter == 0)
                    month2 = int.Parse(date);
                else if (counter == 1)
                    day2 = int.Parse(date);
                else if (counter == 2)
                    year2 = int.Parse(date);
                counter++;
            }
            
            try
            {
                DateTime oldDate = new DateTime(year1, month1, day1);
                DateTime newDate = new DateTime(year2, month2, day2);
                TimeSpan ts = newDate - oldDate;

                double seconds = ts.TotalSeconds;
                double minutes = seconds / 60;
                double hours = minutes / 60;
                double days = hours / 24;
                int years = (int) days / 365;
                int months = years * 12;

                MessageBox.Show("\nYears: " + years.ToString() +
                                "\nMonths: " + months.ToString() +
                                "\nDays: " + days.ToString() +
                                "\nHours: " + hours.ToString() +
                                "\nMinutes: " + minutes.ToString() +
                                "\nSeconds: " + seconds.ToString());
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }
    }
}