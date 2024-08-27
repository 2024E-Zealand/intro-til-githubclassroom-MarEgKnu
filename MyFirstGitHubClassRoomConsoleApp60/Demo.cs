using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstGitHubClassRoomConsoleApp60
{
    public class Demo
    {
        public byte DemoByte { get; set; }

        public Vector3 DemoLocation { get; set; }

        public IntPtr DemoPointer { get; set; } = (IntPtr)0x00356;

        public void Lol()
        {
            DemoPointer = DemoPointer + 1;
            Lol();
            Lol();
        }
    }
}
