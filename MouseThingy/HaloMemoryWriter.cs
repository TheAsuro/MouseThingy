using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace MouseThingy
{
    static class HaloMemoryWriter
    {
        const int PROCESS_WM_READ = 0x0010;
        const int PROCESS_VM_WRITE = 0x0020;
        const int PROCESS_VM_OPERATION = 0x0008;

        [DllImport("kernel32.dll")]
        private static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);

        [DllImport("kernel32.dll")]
        private static extern bool ReadProcessMemory(IntPtr hProcess, uint lpBaseAddress, [Out] byte[] lpBuffer, int dwSize, IntPtr lpNumberOfBytesRead);

        [DllImport("kernel32.dll")]
        private static extern bool WriteProcessMemory(IntPtr hProcess, uint lpBaseAddress, byte[] lpBuffer, int nSize, IntPtr lpNumberOfBytesWritten);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsIconic(IntPtr hWnd);

        private static Process selectedProcess;
        private static IntPtr processHandle;
        private static bool connected = false;

        public static List<string> GetProcessNames()
        {
            List<string> names = new List<string>();

            Process[] processes = Process.GetProcesses();
            foreach (Process process in processes)
            {
                names.Add(process.ProcessName);
            }

            return names;
        }

        public static bool TryConnectToProcess(string name)
        {
            Process[] processes = Process.GetProcessesByName(name);

            if (processes.Length == 0)
                return false;

            selectedProcess = processes[0];
            processHandle = OpenProcess(PROCESS_WM_READ | PROCESS_VM_WRITE | PROCESS_VM_OPERATION, false, selectedProcess.Id);
            connected = true;
            return true;
        }

        public static bool WriteToMemory(uint memoryAddress, byte[] data)
        {
            if (!connected)
                return false;

            int bytesWritten = 0;
            return WriteProcessMemory(processHandle, memoryAddress, data, data.Length, new IntPtr(bytesWritten));
        }

        public static bool ReadFromMemory(uint memoryAddress, [Out] byte[] data)
        {
            if (!connected)
                return false;

            int bytesRead = 0;
            return ReadProcessMemory(processHandle, memoryAddress, data, data.Length, new IntPtr(bytesRead));
        }

        public static bool IsWindowMinimized()
        {
            return IsIconic(selectedProcess.MainWindowHandle);
        }
    }
}
