using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Design370
{
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
        }

        private void HelpForm_Load(object sender, EventArgs e)
        {
            axAcroPDF1.LoadFile("Manual.pdf");
            axAcroPDF1.setShowToolbar(true);
            LoadTreeViewFromXmlFile("Treeview.xml", treeView1);
            treeView1.CollapseAll();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            axAcroPDF1.Select();
            SendKeys.Send("^f");
            SendKeys.Flush();
            SendKeys.Send(txtSearchManual.Text);
            SendKeys.Flush();
            SendKeys.Send("^g");
            SendKeys.Flush();
        }

        private void txtSearchManual_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                axAcroPDF1.Select();
                SendKeys.Send("^f");
                SendKeys.Flush();
                SendKeys.Send(txtSearchManual.Text);
                SendKeys.Flush();
                SendKeys.Send("^g");
                SendKeys.Flush();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            axAcroPDF1.Select();
            SendKeys.Send("^(S)");
        }

        private void LoadTreeViewFromXmlFile(string filename, TreeView trv)
        {
            // Load the XML document.
            XmlDocument xml_doc = new XmlDocument();
            xml_doc.Load(filename);

            // Add the root node's children to the TreeView.
            trv.Nodes.Clear();
            AddTreeViewChildNodes(trv.Nodes, xml_doc.DocumentElement);
        }

        private void AddTreeViewChildNodes(TreeNodeCollection parent_nodes, XmlNode xml_node)
        {
            foreach (XmlNode child_node in xml_node.ChildNodes)
            {
                // Make the new TreeView node.
                TreeNode new_node = parent_nodes.Add(child_node.Name);

                // Recursively make this node's descendants.
                AddTreeViewChildNodes(new_node.Nodes, child_node);

                // If this is a leaf node, make sure it's visible.
                if (new_node.Nodes.Count == 0) new_node.EnsureVisible();
            }
        }
    }
}
