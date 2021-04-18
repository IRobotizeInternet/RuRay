using System.Diagnostics;

namespace RobotizeFacebook.Services
{
    public class ServiceTask
    {
        public static void CloseTask(string taskName)
        {
            foreach (var process in Process.GetProcessesByName(taskName)) process.Kill();
        }

        public static void RunScript(string taskName, string arg = "")
        {
            var p = new Process
            {
                StartInfo = new ProcessStartInfo(taskName)
                {
                    UseShellExecute = true,
                    Arguments = arg
                }
            };
            p.Start();
        }
    }
}
