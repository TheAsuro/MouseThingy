using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseThingy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            UpdateProcesses();

            MouseInput.Start();
        }

        private void bnUpdate_Click(object sender, EventArgs e)
        {
            UpdateProcesses();
        }

        private void UpdateProcesses()
        {
            processList.Items.Clear();

            HaloMemoryWriter.GetProcessNames().ForEach((string name) => processList.Items.Add(name));
        }

        private void bnOk_Click(object sender, System.EventArgs e)
        {
            byte[] data = null;


            if (dataList.SelectedItem == null)
                return;

            switch (dataList.SelectedItem.ToString())
            {
                case "Int":
                    int unconvertedInt;
                    if (int.TryParse(tbData.Text, out unconvertedInt))
                    {
                        data = BitConverter.GetBytes(unconvertedInt);
                    }
                    break;
                case "String":
                    char[] unconvertedString = tbData.Text.ToCharArray();
                    data = Encoding.UTF8.GetBytes(unconvertedString);
                    break;
                case "Float":
                    float unconvertedFloat;
                    if (float.TryParse(tbData.Text, out unconvertedFloat))
                    {
                        data = BitConverter.GetBytes(unconvertedFloat);
                    }
                    break;
                default:
                    MessageBox.Show("Please select a valid type!");
                    return;
            }

            if (data == null)
            {
                MessageBox.Show("Couldn't parse data!");
                return;
            }

            uint memAddr;
            if (!uint.TryParse(tbAddress.Text, out memAddr))
            {
                MessageBox.Show("Couldn't parse address!");
                return;
            }

            MessageBox.Show(HaloMemoryWriter.WriteToMemory(memAddr, data).ToString());
        }

        private void processList_SelectionChangeCommitted(object sender, System.EventArgs e)
        {
            if (processList.SelectedItem != null)
                HaloMemoryWriter.TryConnectToProcess(processList.SelectedItem.ToString());
        }
    }
}
