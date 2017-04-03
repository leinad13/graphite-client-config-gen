using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net.NetworkInformation;

namespace GraphiteClientGenerator
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

        private void LoadPerformanceCounters(string hostname)
        {
            // Check Host is alive / online
            try
            {
                // Get IP Address of System
                System.Net.IPAddress address = System.Net.Dns.GetHostEntry(hostname).AddressList.First();

                // Ping Object
                Ping ping = new Ping();
                // Ping buffer - 32 byte buffer (create empty)
                byte[] buffer = new byte[32];
                // Ping Options
                PingOptions pingOptions = new PingOptions(128, true);

                // Ping Host 4 times
                for (int i = 0; i < 4; i++)
                {
                    // PingReply Object
                    PingReply pingReply = ping.Send(address, 1000, buffer, pingOptions);
                    //make sure we dont have a null reply
                    if (!(pingReply == null))
                    {
                        switch (pingReply.Status)
                        {
                            case IPStatus.Success:
                                break;
                            case IPStatus.TimedOut:
                                throw new PingException("Timed Out");
                            default:
                                throw new PingException("Ping Failed");
                        }
                    }
                }        
            }
            catch (PingException ex)
            {
                MessageBox.Show(ex.Message, "Problem Connecting to "+hostname,MessageBoxButtons.OK);
                return;
            }

            // Get Hostname to use for root tree node
            TreeNode rootnode = new TreeNode(hostname);

            // Get Performance Counter Categories
            List<PerformanceCounterCategory> categories = PerformanceCounterCategory.GetCategories(hostname).OrderBy(category => category.CategoryName).ToList();

            foreach (PerformanceCounterCategory cat in categories)
            {
                TreeNode node = new TreeNode(cat.CategoryName);
                try
                {
                    // Get Perf Counter Instance
                    string[] instances = cat.GetInstanceNames();
                    foreach (string instance in instances)
                    {
                        TreeNode n = new TreeNode(instance);

                        // Get Perf Counter Name
                        PerformanceCounter[] perfs = cat.GetCounters(instance);
                        foreach (PerformanceCounter perf in perfs)
                        {
                            TreeNode counternode = new TreeNode(perf.CounterName);
                            n.Nodes.Add(counternode);
                        }

                        node.Nodes.Add(n);
                    }
                } catch (Exception ex)
                {
                    // Some Performance Counters throw an error when trying to enumerate instances
                }
                PerformanceCounter[] counters = cat.GetCounters("");
                rootnode.Nodes.Add(node);
            }

            // Add Nodes to TreeView
            trvPerfs.Nodes.Add(rootnode);
            trvPerfs.Nodes[0].SetIsCheckBoxVisible(false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadPerformanceCounters(txtHostname.Text);
        }

        private void trvPerfs_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (e.Action != TreeViewAction.Unknown)
            {
                if (e.Node.Nodes.Count > 0)
                {
                    this.CheckAllChildNodes(e.Node, e.Node.Checked);
                    this.SelectParents(e.Node, e.Node.Checked);
                }
            }
        }

        // Updates all child tree nodes recursively.
        private void CheckAllChildNodes(TreeNode treeNode, bool nodeChecked)
        {
            foreach (TreeNode node in treeNode.Nodes)
            {
                node.Checked = nodeChecked;
                if (node.Nodes.Count > 0)
                {
                    // If the current node has child nodes, call the CheckAllChildsNodes method recursively.
                    this.CheckAllChildNodes(node, nodeChecked);
                }
            }
        }

        // Updates all parent tree nodes
        private void SelectParents(TreeNode treeNode, bool isChecked)
        {
            var parent = treeNode.Parent;

            if (parent == null)
                return;
            if (isChecked)
            {
                parent.Checked = true;
                SelectParents(parent, true);
            }
            else
            {
                if (parent.Nodes.Cast<TreeNode>().Any(n => n.Checked))
                    return; // do not uncheck parent if there are other checked nodes
                SelectParents(parent, false);
            }
        }

    }
}
