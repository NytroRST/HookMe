using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace hook.Core.Auxiliar
{
    public static class Memory
    {
        [Flags]
        public enum ProcessAccessFlags : uint
        {
            All = 0x001F0FFF,
            Terminate = 0x00000001,
            CreateThread = 0x00000002,
            VMOperation = 0x00000008,
            VMRead = 0x00000010,
            VMWrite = 0x00000020,
            DupHandle = 0x00000040,
            SetInformation = 0x00000200,
            QueryInformation = 0x00000400,
            Synchronize = 0x00100000
        }

        [DllImport("kernel32.dll")]
        private static extern IntPtr OpenProcess(ProcessAccessFlags dwDesiredAccess, [MarshalAs(UnmanagedType.Bool)] bool bInheritHandle, int dwProcessId);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, uint nSize, out int lpNumberOfBytesWritten);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, [Out] byte[] lpBuffer, int dwSize, out int lpNumberOfBytesRead);

        [DllImport("kernel32.dll")]
        public static extern Int32 CloseHandle(IntPtr hProcess);

        public static byte[] ReadMemory(int processID, IntPtr address, int numOfBytes, out int bytesRead)
        {
            IntPtr hProc = OpenProcess(ProcessAccessFlags.All, false, processID);

            byte[] buffer = new byte[numOfBytes];

            ReadProcessMemory(hProc, address, buffer, numOfBytes, out bytesRead);
            return buffer;
        }

        public static int WriteMemory(int processID, IntPtr address, byte[] buffer)
        {
            IntPtr hProc = OpenProcess(ProcessAccessFlags.All, false, processID);
            int bytesWrited;
            WriteProcessMemory(hProc, address, buffer, (uint) buffer.Length, out bytesWrited);

            return bytesWrited;
        }
    }
}
