using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 工程实践
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if(e.Action == TreeViewAction.ByMouse)
            {
                if(e.Node.Parent != null && e.Node.Parent.Index == 6)
                {
                    if(e.Node.Index == 2)
                    {
                        tabPage1.Parent = this.tabControl1;

                        tabControl1.SelectedIndex = tabControl1.TabCount - 1;
                    }
                    if (e.Node.Index == 2)
                    {
                        tabPage1.Parent = this.tabControl1;

                        tabControl1.SelectedIndex = tabControl1.TabCount - 1;
                    }
                }
                if (e.Node.Parent != null && e.Node.Parent.Index == 8)
                {
                    if (e.Node.Index == 0)
                    {
                        tabPage2.Parent = this.tabControl1;

                        tabControl1.SelectedIndex = tabControl1.TabCount - 1;
                    }
                    if (e.Node.Index == 2)
                    {
                        tabPage3.Parent = this.tabControl1;

                        tabControl1.SelectedIndex = tabControl1.TabCount - 1;
                    }
                }
                if(e.Node.Parent != null && e.Node.Parent.Index == 7)
                {
                    if (e.Node.Index == 1)
                    {
                        tabPage7.Parent = this.tabControl1;

                        tabControl1.SelectedIndex = tabControl1.TabCount - 1;
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
           
            
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            tabPage1.Parent = null;
            tabPage2.Parent = null;
            tabPage3.Parent = null;
            tabPage7.Parent = null;
            tabPage9.Parent = null;
            tabPage11.Parent = null;

        }
    }
}
