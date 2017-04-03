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
using System.Xml;
using System.Xml.Serialization;

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
            // Set MinSize of Right Panel
            splitContainer1.Panel2MinSize = 131;
            // Set default choice in graphite transport option combobox
            cmbGraphiteTransport.SelectedIndex = 0;
        }

        private void LoadPerformanceCounters_Level1(string hostname)
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
                MessageBox.Show(ex.Message, "Problem Connecting to " + hostname, MessageBoxButtons.OK);
                return;
            }

            // Get Hostname to use for root tree node
            TreeNode rootnode = new TreeNode(hostname);

            // Get Performance Counter Categories
            List<PerformanceCounterCategory> categories = PerformanceCounterCategory.GetCategories(hostname).OrderBy(category => category.CategoryName).ToList();

            foreach (PerformanceCounterCategory cat in categories)
            {
                TreeNode node = new TreeNode(cat.CategoryName);
                TreeNode child = new TreeNode("dummy");
                node.Nodes.Add(child);

                PerformanceCounter[] counters = cat.GetCounters("");
                rootnode.Nodes.Add(node);
            }

            // Add Nodes to TreeView
            trvPerfs.Nodes.Add(rootnode);
            trvPerfs.Nodes[0].SetIsCheckBoxVisible(false);
            foreach(TreeNode n in trvPerfs.Nodes[0].Nodes)
            {
                n.SetIsCheckBoxVisible(false);
            }
        }
 
        private void button1_Click(object sender, EventArgs e)
        {
            //LoadPerformanceCounters(txtHostname.Text);
            LoadPerformanceCounters_Level1(txtHostname.Text);
        }

        private void trvPerfs_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (e.Action != TreeViewAction.Unknown)
            {
                if (e.Node.Nodes.Count > 0)
                {
                    this.CheckAllChildNodes(e.Node, e.Node.Checked);
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

        private void btnSaveConfig_Click(object sender, EventArgs e)
        {
            string output_config_address;
            string output_config_port;
            string output_config_path;
            string output_config_transport;
            
            // Check Output Options
            try
            {
                // destination path to save to
                output_config_path = txtConfigPath.Text;
                // graphite server address
                output_config_address = txtGraphiteAddress.Text;
                // graphite server port
                output_config_port = int.Parse(txtGraphitePort.Text).ToString();
                // graphite server transport protocol
                output_config_transport = cmbGraphiteTransport.SelectedItem.ToString();

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Problem with Output Options", MessageBoxButtons.OK);
                return;
            }
            

            // rootnode = configuration
            XmlDocument xmlDoc = new XmlDocument();
            XmlNode rootnode = xmlDoc.CreateElement("configuration");
            xmlDoc.AppendChild(rootnode);

            // configSections
            XmlNode configsectionNode = xmlDoc.CreateElement("configSections");
            // section
            XmlNode graphite = xmlDoc.CreateElement("section");
            XmlAttribute graphite_name = xmlDoc.CreateAttribute("name");
            graphite_name.Value = "graphite";
            XmlAttribute graphite_type = xmlDoc.CreateAttribute("type");
            graphite_type.Value = "Graphite.Configuration.GraphiteConfiguration, Graphite";
            graphite.Attributes.Append(graphite_name);
            graphite.Attributes.Append(graphite_type);
            configsectionNode.AppendChild(graphite);
            //section
            XmlNode graphite_system = xmlDoc.CreateElement("section");
            XmlAttribute graphite_system_name = xmlDoc.CreateAttribute("name");
            graphite_system_name.Value = "graphite.system";
            XmlAttribute graphite_system_type = xmlDoc.CreateAttribute("type");
            graphite_system_type.Value = "Graphite.System.Configuration.GraphiteSystemConfiguration, PerfCounterMonitor";
            graphite_system.Attributes.Append(graphite_system_name);
            graphite_system.Attributes.Append(graphite_system_type);
            // configSectionsEnd
            configsectionNode.AppendChild(graphite_system);
            rootnode.AppendChild(configsectionNode);

            XmlNode maingraphite = xmlDoc.CreateElement("graphite", "http://github.com/peschuster/Graphite/Configuration");
            XmlNode graphite_config = xmlDoc.CreateElement("graphite", "http://github.com/peschuster/Graphite/Configuration");
            XmlAttribute graphite_config_address = xmlDoc.CreateAttribute("address");
            graphite_config_address.Value = output_config_address;
            graphite_config.Attributes.Append(graphite_config_address);
            XmlAttribute graphite_config_port = xmlDoc.CreateAttribute("port");
            graphite_config_port.Value = output_config_port;
            graphite_config.Attributes.Append(graphite_config_port);
            XmlAttribute graphite_config_transport = xmlDoc.CreateAttribute("transport");
            graphite_config_transport.Value = output_config_transport;
            graphite_config.Attributes.Append(graphite_config_transport);
            maingraphite.AppendChild(graphite_config);
            rootnode.AppendChild(maingraphite);

            XmlNode maingraphite_system = xmlDoc.CreateElement("graphite.system", "http://github.com/peschuster/Graphite/Configuration");
            XmlNode counters = xmlDoc.CreateElement("counters", "http://github.com/peschuster/Graphite/Configuration");
            XmlNode clear = xmlDoc.CreateElement("clear","http://github.com/peschuster/Graphite/Configuration");
            counters.AppendChild(clear);

            List<CounterConfig> counterConfigs = new List<CounterConfig>();

            // Children of 'hostname' - category
            foreach (TreeNode node0 in trvPerfs.Nodes[0].Nodes)
            {
                // Children of category - instance OR counter
                foreach (TreeNode node1 in node0.Nodes)
                {
                    // Is counter? (no instance)
                    if ((node1.Tag != null) && (node1.Tag.ToString() == "counter"))
                    {
                        // Is checked?
                        if (node1.Checked == true)
                        {
                            CounterConfig counterConfig = new CounterConfig();
                            counterConfig.counter = node1.Text;
                            counterConfig.category = node1.Parent.Text;
                            counterConfigs.Add(counterConfig);
                        }
                    }
                    if (node1.Nodes.Count > 0)
                    {
                        // Children of instance - counter
                        foreach (TreeNode node2 in node1.Nodes)
                        {
                            if ((node2.Tag.ToString() == "counter") && (node2.Checked == true))
                            {
                                CounterConfig counterConfig = new CounterConfig();
                                counterConfig.counter = node1.Text;
                                counterConfig.instance = node1.Parent.Text;
                                counterConfig.category = node1.Parent.Parent.Text;
                                counterConfigs.Add(counterConfig);
                            }
                        }
                    }
                }   
            }

            foreach (CounterConfig conf in counterConfigs)
            {
                XmlNode childnode = xmlDoc.CreateElement("add", "http://github.com/peschuster/Graphite/Configuration");
                XmlAttribute attrCounter = xmlDoc.CreateAttribute("counter");
                attrCounter.Value = conf.counter;
                childnode.Attributes.Append(attrCounter);

                XmlAttribute attrInstance = xmlDoc.CreateAttribute("instance");
                XmlAttribute attrKey = xmlDoc.CreateAttribute("key");
                string counterKey = conf.counter.Replace('/', '_');
                counterKey = counterKey.Replace(' ', '_');
                string categoryKey = conf.category.Replace(' ', '_');
                categoryKey = categoryKey.Replace('.', '-');
                if (conf.instance == null)
                {
                    attrInstance.Value = "";
                    attrKey.Value = txtHostname.Text + "." + categoryKey + "." + counterKey;
                } else
                {
                    attrInstance.Value = conf.instance;
                    attrKey.Value = txtHostname.Text + "." + categoryKey + "." + conf.instance + "." + counterKey;
                }
                childnode.Attributes.Append(attrInstance);
                childnode.Attributes.Append(attrKey);
                XmlAttribute attrCategory = xmlDoc.CreateAttribute("category");
                attrCategory.Value = conf.category;
                childnode.Attributes.Append(attrCategory);

                XmlAttribute attrType = xmlDoc.CreateAttribute("type");
                XmlAttribute attrTarget = xmlDoc.CreateAttribute("target");
                XmlAttribute attrInterval = xmlDoc.CreateAttribute("interval");
                attrType.Value = "guage";
                attrTarget.Value = "graphite";
                attrInterval.Value = txtDefaultInterval.Text;
                childnode.Attributes.Append(attrType);
                childnode.Attributes.Append(attrTarget);
                childnode.Attributes.Append(attrInterval);

                counters.AppendChild(childnode);
            }
            

            maingraphite_system.AppendChild(counters);
            rootnode.AppendChild(maingraphite_system);

            // Save Out XML
            xmlDoc.Save(output_config_path);

        }

        private void trvPerfs_AfterExpand(object sender, TreeViewEventArgs e)
        {
            // Get Node to expand
            TreeNode node = e.Node;

            if (node.Level != 1)
            {
                return;
            }
            if (node.Nodes.Count != 1)
            {
                if (node.Nodes[0].Text != "dummy")
                {
                    // Dont load again if already loaded
                    return;
                }
            } else if (node.Nodes[0].Text != "dummy")
            {
                return;
            }

            try
            {
                // Get IP Address of System
                System.Net.IPAddress address = System.Net.Dns.GetHostEntry(txtHostname.Text).AddressList.First();

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
                MessageBox.Show(ex.Message, "Problem Connecting to " + txtHostname.Text, MessageBoxButtons.OK);
                return;
            }

            // Host is Up (otherwise function has already returned)
            PerformanceCounterCategory cat = PerformanceCounterCategory.GetCategories(txtHostname.Text).ToList().Single(s => s.CategoryName == node.Text);

            // Remove Existing nodes
            e.Node.Nodes.Clear();
            string[] instances = cat.GetInstanceNames();
            
            if (instances.Length > 0)
            {
                foreach (string instance in cat.GetInstanceNames())
                {
                    TreeNode instanceNode = new TreeNode(instance);
                    // Get Counters per instance
                    foreach (PerformanceCounter counter in cat.GetCounters(instance))
                    {
                        TreeNode counterNode = new TreeNode(counter.CounterName);
                        counterNode.Tag = "counter";
                        instanceNode.Nodes.Add(counterNode);
                    }

                    e.Node.Nodes.Add(instanceNode);
                }
            } else
            {
                foreach (PerformanceCounter counter in cat.GetCounters())
                {
                    TreeNode counterNode = new TreeNode(counter.CounterName);
                    counterNode.Tag = "counter";
                    e.Node.Nodes.Add(counterNode);
                }
            }
            
            
        }
    }
}
