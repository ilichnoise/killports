using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Killports
{
    public partial class Form1 : Form
    {
       

        public Form1()
        {
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RefreshProcesses();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //kill process

           
            String task = "";
            try { 
                    task= p.SelectedItem.ToString();
                    task = Regex.Replace(task, @"\s+", " ");
                    task = task.Split(' ')[5];
            }
            catch(Exception exc) {
                System.Diagnostics.Debug.WriteLine(exc.ToString());
                MessageBox.Show("Process no selected");
            }
           
            if (task != "")
            {
                MessageBox.Show("Killing port");
                // String cmd_st = "taskkill /F /PID "+task;
                KillProcess(Int32.Parse(task));
                RefreshProcesses();
            }
           
         
        }

        private void RefreshProcesses()
        {
            //list process
            p.Items.Clear();
            String cmd_st = "/c netstat -ano | findstr :" + wPort.Value.ToString();
            String process = execute(cmd_st).Replace("\n", "#");
            string[] programms = process.Split('#');

            for (var i = 0; i < programms.Length; i++)
            {
                if (programms[i].Trim() != "")
                    p.Items.Add(programms[i]);
            }
            if (p.Items.Count == 0)
            {
                MessageBox.Show("There were not found more processes using the port " + wPort.Value.ToString());
            }
        }
        private String execute(String cmd_st)
        {
            var processInfo = new ProcessStartInfo("cmd.exe", cmd_st)
            {
                CreateNoWindow = true,
                UseShellExecute = false,
                RedirectStandardError = true,
                RedirectStandardOutput = true,
                WorkingDirectory = @"C:\Windows\System32\"
            };

            StringBuilder sb = new StringBuilder();
            Process command = Process.Start(processInfo);
            command.OutputDataReceived += (send, args) => sb.AppendLine(args.Data);
            command.BeginOutputReadLine();
            command.WaitForExit();
            return sb.ToString();
        }

        private void KillProcess(int pid)
        {
         
            try
            {
                Process proc = Process.GetProcessById(pid);
                proc.Kill();
            }
            catch (ArgumentException)
            {
                // Process already exited.
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
