﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MonitoringApp_V2;
using NetLib;

namespace WindowsFormsApplication2
{
    public partial class Login : Form
    {
        private TcpClient client;
        private NetworkStream stream;
        private BinaryFormatter formatter;

        public Login()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
    
        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                //MessageBox.Show("check1");
                client = new TcpClient(Info.GetIp().ToString(), Info.Port);
                stream = client.GetStream();
            }
            catch (Exception)
            {
                MessageBox.Show("No connection with the server");
                Thread.CurrentThread.Abort();
            }
            //MessageBox.Show("check2");
            formatter = new BinaryFormatter();
            formatter.Serialize(stream, new PacketMonitor());

            //MessageBox.Show("check3");
            Packet loginPacket = new PacketLogin() { username = userNameTextBox.Text, password = passwordTextBox.Text };
            formatter.Serialize(stream, loginPacket);

           //MessageBox.Show("check4");
            PacketLoginResponse response = (PacketLoginResponse)formatter.Deserialize(stream);
            loginResponse(response.loginOk, response.dir);
            //loginResponse(true);
        }

        public void loginResponse(bool loginOk, string dir)
        {
            if (loginOk)
            {
                new Form1(client, stream, this,dir).Show();
                this.Hide();
            }
            else
            {
                client.Close();
                stream.Close();
                //MessageBox.Show("The username or password is wrong");
            }
        }

        public void ClearBoxes()
        {
            userNameTextBox.Clear();
            passwordTextBox.Clear();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
