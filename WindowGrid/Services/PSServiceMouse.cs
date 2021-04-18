using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;

namespace WindowGrid.Services
{
    public class PSServiceMouse
    {
        public static Tuple<int,int> GetCursorPostions()
        {
            PowerShell ps = PowerShell.Create();
            ps.AddScript(File.ReadAllText(@"PS1\CursorPostions.ps1"));

            IAsyncResult asyncpl = ps.BeginInvoke();

            // Using the PowerShell.Invoke method, run the command
            PSObject result = ps.EndInvoke(asyncpl).FirstOrDefault();
            Hashtable ht = result.ImmediateBaseObject as Hashtable;

            return new Tuple<int, int>((int)ht["X"], (int)ht["Y"]);
        }
    }
}
