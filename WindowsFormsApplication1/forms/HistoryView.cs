using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientApp.forms
{
    public partial class HistoryView : Form
    {
        List<Tuple<int, int, int, int, int, int, int>> values = new List<Tuple<int, int, int, int, int, int, int>>();

        public HistoryView(List<Tuple<int, int, int, int, int, int, int>> list)
        {
            InitializeComponent();
            values = list;
        }

        private void Pulse_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.Pulse_checkBox.Checked)
            {
                int index = 0;
                foreach (Tuple<int, int, int, int, int, int, int> tuple in values)
                {   
                    chart1.Series["Pulse"].Points.AddXY(index, tuple.Item1);
                    index++;
                }  
            }
            else
            {
                int index = 0;
                foreach (Tuple<int, int, int, int, int, int, int> tuple in values)
                {
                    chart1.Series["Pulse"].Points.Clear();
                    index++;
                }
            }
        }

        private void Rpm_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.Rpm_checkBox.Checked)
            {
                int index = 0;
                foreach (Tuple<int, int, int, int, int, int, int> tuple in values)
                {
                    chart1.Series["Rpm"].Points.AddXY(index, tuple.Item2);
                    index++;
                }    
            }
            else
            {
                int index = 0;
                foreach (Tuple<int, int, int, int, int, int, int> tuple in values)
                {
                    chart1.Series["Rpm"].Points.Clear();
                    index++;
                }
            }
        }

        private void Speed_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.Speed_checkBox.Checked)
            {
                int index = 0;
                foreach (Tuple<int, int, int, int, int, int, int> tuple in values)
                {
                    chart1.Series["Speed"].Points.AddXY(index, tuple.Item3);
                    index++;
                }
            }
            else
            {
                int index = 0;
                foreach (Tuple<int, int, int, int, int, int, int> tuple in values)
                {
                    chart1.Series["Speed"].Points.Clear();
                    index++;
                }
            }
        }

        private void Distance_checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (this.Distance_checkBox.Checked)
            {
                int index = 0;
                foreach (Tuple<int, int, int, int, int, int, int> tuple in values)
                {
                    chart1.Series["Distance"].Points.AddXY(index, tuple.Item4);
                    index++;
                }
            }
            else
            {
                int index = 0;
                foreach (Tuple<int, int, int, int, int, int, int> tuple in values)
                {
                    chart1.Series["Distance"].Points.Clear();
                    index++;
                }
            }
        }

        private void Power_checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (this.Power_checkBox.Checked)
            {
                int index = 0;
                foreach (Tuple<int, int, int, int, int, int, int> tuple in values)
                {
                    chart1.Series["Power"].Points.AddXY(index, tuple.Item5);
                    index++;
                }
            }
            else
            {
                int index = 0;
                foreach (Tuple<int, int, int, int, int, int, int> tuple in values)
                {
                    chart1.Series["Power"].Points.Clear();
                    index++;
                }
            }
        }

        private void Energy_checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (this.Energy_checkBox.Checked)
            {
                int index = 0;
                foreach (Tuple<int, int, int, int, int, int, int> tuple in values)
                {
                    chart1.Series["Energy"].Points.AddXY(index, tuple.Item6);
                    index++;
                }
            }
            else
            {
                int index = 0;
                foreach (Tuple<int, int, int, int, int, int, int> tuple in values)
                {
                    chart1.Series["Energy"].Points.Clear();
                    index++;
                }
            }
        }

        private void ActualPower_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.ActualPower_checkBox.Checked)
            {
                int index = 0;
                foreach (Tuple<int, int, int, int, int, int, int> tuple in values)
                {
                    chart1.Series["Actual power"].Points.AddXY(index, tuple.Item7);
                    index++;
                }
            }
            else
            {
                int index = 0;
                foreach (Tuple<int, int, int, int, int, int, int> tuple in values)
                {
                    chart1.Series["Actual power"].Points.Clear();
                    index++;
                }
            }
        }
    }
}
