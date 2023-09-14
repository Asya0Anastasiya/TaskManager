using System;
using System.Diagnostics;
using System.Management;
using System.Runtime.InteropServices;
using System.Security.Principal;
using Microsoft.VisualBasic;

namespace TaskManager
{
    public partial class Form1 : Form
    {
        private List<Process> processList = new();

        public Form1()
        {
            InitializeComponent();
        }

        private void GetProcesses()
        {
            processList.Clear();

            processList = Process.GetProcesses().ToList();
        }

        private void RefreshProcessesList()
        {
            for (int i = 0; i < processList.Capacity; i++)
            {
                try
                {
                    string[] row = new string[] { processList[i].ProcessName.ToString(), processList[i].WorkingSet64.ToString(), processList[i].Id.ToString(), processList[i].PriorityClass.ToString(), processList[i].BasePriority.ToString(), processList[i].Threads.Count.ToString(), GetUsername(processList[i].SessionId) };
                    listView1.Items.Add(new ListViewItem(row));
                    treeView1.Nodes.Add(processList[i].ProcessName.ToString());
                    for (int j = 0; j < processList[i].Threads.Count; j++)
                    {
                        treeView1.Nodes[i].Nodes.Add(processList[i].Threads[j].Id.ToString() + " " + processList[i].Threads[j].PriorityLevel);
                    }
                }
                catch (Exception)
                {
                    string[] row = new string[] { processList[i].ProcessName.ToString(), processList[i].WorkingSet64.ToString(), processList[i].Id.ToString(), "Access denied", processList[i].BasePriority.ToString(), processList[i].Threads.Count.ToString(), GetUsername(processList[i].SessionId) };
                    listView1.Items.Add(new ListViewItem(row));
                    treeView1.Nodes.Add(processList[i].ProcessName.ToString());
                    for (int j = 0; j < processList[i].Threads.Count; j++)
                    {
                        treeView1.Nodes[i].Nodes.Add(processList[i].Threads[j].Id.ToString());
                    }
                    continue;
                }
                //string[] row = new string[] { process.ProcessName.ToString(), Math.Round(memSize, 1).ToString(), process.Id.ToString(), "   ", process.BasePriority.ToString(), process.Threads.Count.ToString() };
            }

            Text = $"Processes executed: " + processList.Count.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            proccess = new();

            GetProcesses();

            RefreshProcessesList();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {

        }

        [DllImport("Wtsapi32.dll")]
        private static extern bool WTSQuerySessionInformation(IntPtr hServer, int sessionId, WtsInfoClass wtsInfoClass, out IntPtr ppBuffer, out int pBytesReturned);
        [DllImport("Wtsapi32.dll")]
        private static extern void WTSFreeMemory(IntPtr pointer);

        private enum WtsInfoClass
        {
            WTSUserName = 5,
            WTSDomainName = 7,
        }

        private static string GetUsername(int sessionId, bool prependDomain = true)
        {
            IntPtr buffer;
            int strLen;
            string username = "SYSTEM";
            if (WTSQuerySessionInformation(IntPtr.Zero, sessionId, WtsInfoClass.WTSUserName, out buffer, out strLen) && strLen > 1)
            {
                username = Marshal.PtrToStringAnsi(buffer);
                WTSFreeMemory(buffer);
                if (prependDomain)
                {
                    if (WTSQuerySessionInformation(IntPtr.Zero, sessionId, WtsInfoClass.WTSDomainName, out buffer, out strLen) && strLen > 1)
                    {
                        username = Marshal.PtrToStringAnsi(buffer) + "\\" + username;
                        WTSFreeMemory(buffer);
                    }
                }
            }
            return username;
        }
    }
}