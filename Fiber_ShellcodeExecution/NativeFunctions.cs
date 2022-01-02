using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static Fiber_ShellcodeExecution.NativeStructs;

namespace Fiber_ShellcodeExecution
{
    class NativeFunctions
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern IntPtr ConvertThreadToFiber(IntPtr lpParameter);

        [DllImport("kernel32", SetLastError = true)]
        public static extern IntPtr VirtualAlloc(
            IntPtr lpStartAddr,
            UInt32 size,
            AllocationType flAllocationType,
            AllocationProtect flProtect);

        [DllImport("kernel32.dll", SetLastError = true)]
        public extern static IntPtr CreateFiber(int dwStackSize, IntPtr lpStartAddress, IntPtr lpParameter);

        [DllImport("kernel32.dll", SetLastError = true)]
        public extern static IntPtr SwitchToFiber(IntPtr fiberAddress);
    }
}
