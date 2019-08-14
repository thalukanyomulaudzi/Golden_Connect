﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design370
{
    public partial class Photoshoot_Package_Add : Form
    {
        public Photoshoot_Package_Add()
        {
            InitializeComponent();
            ToolTip toolTip1 = new ToolTip();
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(listBox1, "Multiple items can be selected");
            toolTip1.SetToolTip(listBox2, "Multiple items can be selected");
            toolTip1.SetToolTip(listBox3, "Multiple items can be selected");
            toolTip1.SetToolTip(listBox4, "Multiple items can be selected");
        }

        private void Photoshoot_Package_Add_Load(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection sourceItems = listBox3.SelectedItems;
            foreach (var item in sourceItems)
            {
                listBox1.Items.Add(item);
            }
            while (listBox3.SelectedItems.Count > 0)
            {
                listBox3.Items.Remove(listBox3.SelectedItems[0]);
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection sourceItems = listBox1.SelectedItems;
            foreach (var item in sourceItems)
            {
                listBox3.Items.Add(item);
            }
            while (listBox1.SelectedItems.Count > 0)
            {
                listBox1.Items.Remove(listBox1.SelectedItems[0]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection sourceItems = listBox4.SelectedItems;
            foreach (var item in sourceItems)
            {
                listBox2.Items.Add(item);
            }
            while (listBox4.SelectedItems.Count > 0)
            {
                listBox4.Items.Remove(listBox4.SelectedItems[0]);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection sourceItems = listBox2.SelectedItems;
            foreach (var item in sourceItems)
            {
                listBox4.Items.Add(item);
            }
            while (listBox2.SelectedItems.Count > 0)
            {
                listBox2.Items.Remove(listBox2.SelectedItems[0]);
            }
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ListBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }

        private void ListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
