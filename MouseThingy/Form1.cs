using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace MouseThingy
{
    public partial class Form1 : Form
    {
        const int PROCESS_VM_WRITE = 0x0020;
        const int PROCESS_VM_OPERATION = 0x0008;

        [DllImport("kernel32.dll")]
        public static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);

        [DllImport("kernel32.dll")]
        public static extern bool ReadProcessMemory(int hProcess, int lpBaseAddress, byte[] lpBuffer, int dwSize, ref int lpNumberOfBytesRead);

        [DllImport("kernel32.dll")]
        private static extern Boolean WriteProcessMemory(IntPtr hProcess, uint lpBaseAddress, byte[] lpBuffer, int nSize, IntPtr lpNumberOfBytesWritten);

        private Process proc;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            processList.Items.Clear();

            Process[] processes = Process.GetProcesses();
            foreach(Process process in processes)
            {
                processList.Items.Add(process.ProcessName);
            }
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            byte[] data = null;

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

            int bytesWritten = 0;
            IntPtr procHandle = OpenProcess(PROCESS_VM_WRITE | PROCESS_VM_OPERATION, false, proc.Id);
            if (WriteProcessMemory(procHandle, memAddr, data, data.Length, new IntPtr(bytesWritten)))
            {
                MessageBox.Show("Success!\nGot " + data.Length + " bytes, \n" + "Wrote " + bytesWritten + " bytes!");
            }
            else
            {
                MessageBox.Show("Failed!\nGot " + data.Length + " bytes, \n" + "Wrote " + bytesWritten + " bytes!");
            }            
        }

        private void processList_SelectionChangeCommitted(object sender, System.EventArgs e)
        {
            Process[] procs = Process.GetProcessesByName(processList.SelectedItem.ToString());
            proc = procs[0];
        }
    }
}
