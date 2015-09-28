using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientApp
{
    public partial class Client : Form
    {
        private Communication reader;

        public Client(Communication reader)
        {
            InitializeComponent();
            this.reader = reader;
            Thread thread = new Thread(new ThreadStart(UpdateBox));
            //thread.Start();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void UpdateBox()
        {
            while (true)
            {
                if (reader.parts.Length > 7 && reader.parts != null)
                {
                    Console.WriteLine("reader size: " + reader.parts.Length);
                    {
                        MethodInvoker mi1 = delegate () { this.textBox1.Text = reader.parts[0]; };
                        this.Invoke(mi1);
                        MethodInvoker mi2 = delegate () { this.textBox2.Text = reader.parts[1]; };
                        this.Invoke(mi2);
                        MethodInvoker mi3 = delegate () { this.textBox3.Text = reader.parts[2]; };
                        this.Invoke(mi3);
                        MethodInvoker mi4 = delegate () { this.textBox4.Text = reader.parts[3]; };
                        this.Invoke(mi4);
                        MethodInvoker mi5 = delegate () { this.textBox5.Text = reader.parts[4]; };
                        this.Invoke(mi5);
                        MethodInvoker mi6 = delegate () { this.textBox6.Text = reader.parts[5]; };
                        this.Invoke(mi6);
                        MethodInvoker mi7 = delegate () { this.textBox9.Text = reader.parts[6]; };
                        this.Invoke(mi7);
                        MethodInvoker mi8 = delegate () { this.textBox10.Text = reader.parts[7]; };
                        this.Invoke(mi8);
                        Thread.Sleep(1000);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox7.AppendText(this.textBox8.Text + Environment.NewLine);
                textBox7.TextAlign = HorizontalAlignment.Right;
                textBox8.Clear(); 
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
