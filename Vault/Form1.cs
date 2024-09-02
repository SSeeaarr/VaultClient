

using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Net;
using System.Net.Http.Headers;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace Vault
{

    public partial class Form1 : Form
    {
        private object filePath;
        private object openFileDialog;
        Queue paths = new Queue();

        public Form1()
        {
            InitializeComponent();
            string path = @"config.txt";

            if (File.Exists(path))
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    string line = sr.ReadLine();
                    string toRemove = "IPv4 ";
                    string result = string.Empty;
                    int i = line.IndexOf(toRemove);
                    if (i >= 0)
                    {
                        result = line.Remove(i, toRemove.Length);
                        ipBox.Text = result;
                    }

                    string portline = sr.ReadLine();
                    string remove = "Port ";
                    result = string.Empty;
                    i = portline.IndexOf(remove);
                    if (i >= 0)
                    {
                        result = portline.Remove(i, remove.Length);
                        portBox.Text = result;
                    }


                }
            }
        }


        private void saveButton_Click(object sender, EventArgs e)
        {
            string ipval = ipBox.Text;
            string port = portBox.Text;
            MessageBox.Show("Changes saved.");
            string path = @"config.txt";

            var dict = new Dictionary<string, string> //save inputs to dictionary in a config file.
            {
                ["IPv4 "] = ipval,
                ["Port "] = port
            };

            if (File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    foreach (string key in dict.Keys)
                    {
                        sw.WriteLine(key + dict[key]);
                    }

                }
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("No config file detected! Creating a new file.");
                using (StreamWriter sw = File.CreateText(path))
                {
                    foreach (string key in dict.Keys)
                    {
                        sw.WriteLine(key + dict[key]);
                    }
                }
            }



            foreach (string key in dict.Keys)
            {
                System.Diagnostics.Debug.WriteLine(key + dict[key]);
            }
        }


        private void selectFiles_Click(object sender, EventArgs e)
        {




            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Multiselect = true;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    runBox.Enabled = true; //enable only when at least one file is selected to be sent
                    foreach (String file in ofd.FileNames)
                    {
                        paths.Enqueue(file);
                        System.Diagnostics.Debug.WriteLine("path queued for: " + file);

                    }

                }
            }
        }

        private void run_Click(object sender, EventArgs e)
        {


            TcpClient client = new TcpClient(ipBox.Text, Int32.Parse(portBox.Text)); //connect to server on inputted ip and port
            System.Diagnostics.Debug.WriteLine("connected.");


            while (paths.Count > 0)
            {
                var temp = paths.Dequeue();
                var convertedstring = Convert.ToString(temp); //have to convert queue values into a string so it can be passed through
                SendFile(convertedstring, client); 
                System.Diagnostics.Debug.WriteLine("File: " + convertedstring + " has been sent.");


            }
            
        }

        private static void SendFile(string filePath, TcpClient client)
        {

            using FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read); //point file stream to the file path we want to send.


            byte[] buffer = new byte[4 * 1024]; //send 4kb at a time
            int bytesRead;


            using NetworkStream nws = client.GetStream();
            using BinaryWriter writer = new BinaryWriter(nws); //pass the network stream into the binary writer

            while ((bytesRead = fs.Read(buffer, 0, buffer.Length)) > 0)
            {
                writer.Write(buffer, 0, bytesRead);
                writer.Flush();
            }
        }

       
    }
}
