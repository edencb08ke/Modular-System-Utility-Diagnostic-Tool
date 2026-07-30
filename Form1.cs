using System.Diagnostics;
using LibreHardwareMonitor.Hardware;

namespace mod_sysutil_diag_and_maint
{
    public partial class Form1 : Form
    {
        private Computer _computer;
        public Form1()
        {
            InitializeComponent();
            InitializeHardwareMonitor();
        }
        private void InitializeHardwareMonitor()
        {
            _computer = new Computer
            {
                IsCpuEnabled = true,
                IsGpuEnabled = true
            };
            _computer.Open();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            float? cpuTemp = null;
            float? gpuTemp = null;
            foreach (IHardware hardware in _computer.Hardware)
            {
                hardware.Update();
                if (hardware.HardwareType == HardwareType.Cpu)
                {
                    foreach (ISensor sensor in hardware.Sensors)
                    {
                        if (sensor.SensorType == SensorType.Temperature && sensor.Value.HasValue)
                        {
                            cpuTemp = sensor.Value.Value;
                            break;
                        }
                    }
                }
                if (hardware.HardwareType == HardwareType.GpuNvidia 
                    || hardware.HardwareType == HardwareType.GpuAmd 
                    || hardware.HardwareType == HardwareType.GpuIntel)
                {
                    foreach (ISensor sensor in hardware.Sensors)
                    {
                        if (sensor.SensorType==SensorType.Temperature
                            && sensor.Value.HasValue)
                        {
                            gpuTemp = sensor.Value.Value;
                            break;
                        }
                    }
                }
            }
            lblCpuTemp.Text = cpuTemp.HasValue
                ? $"CPU Temp: {Math.Round(cpuTemp.Value)}°C"
                : "CPU Temp: N/A";
            lblGpuTemp.Text = gpuTemp.HasValue
                ? $"GPU Temp: {Math.Round(gpuTemp.Value)} °C"
                : "GPU Temp: N/A";
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (_computer != null)
            {
                _computer.Close();
            }
            base.OnFormClosing(e);
        }
        private void btnFLushDNS_Click(object sender, EventArgs e)
        {
            try
            {
                lblStatus.Text = "Status: Flushing DNS...";

                // Configures cmd process
                ProcessStartInfo processInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = "/c ipconfig /flushdns",    // /c tells CMD to execute -> exit
                    CreateNoWindow = true,                  // Run in background
                    UseShellExecute = false,
                    RedirectStandardOutput = true
                };

                // Executes process
                using (Process process = Process.Start(processInfo))
                {
                    // Reads output from cmd
                    string output = process.StandardOutput.ReadToEnd();
                    process.WaitForExit();

                    // Prints output to text log
                    txtLog.AppendText(output + Environment.NewLine);
                }

                lblStatus.Text = "Status: DNS Flushed successfully!";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error running command: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblStatus.Text = "Status: Failed.";
            }
        }

        private void btnDeleteTemp_Click(object sender, EventArgs e)
        {
            string tempPath = System.IO.Path.GetTempPath(); // Gets C:\Users\...\AppData\Local\Temp folder
            int deletedCount = 0;

            txtLog.AppendText($"Scanning {tempPath}...\n");

            System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(tempPath);

            foreach (System.IO.FileInfo file in di.GetFiles())
            {
                try
                {
                    file.Delete();
                    deletedCount++;
                }
                catch
                {
                    // Skips files locked by open programs
                    continue;
                }
            }

            txtLog.AppendText($"Cleaned up {deletedCount} temporary files.\n");

        }

        private void lblCpuTemp_Click(object sender, EventArgs e)
        {

        }
    }
}
