using Frog.Componentes;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frog
{
    public partial class ComponenteTab : UserControl
    {
        public ComponenteTab()
        {
            InitializeComponent();

            tabControl1.Dock = DockStyle.Fill;

            var formComTabs = new ComponenteAba();
            formComTabs.Dock = DockStyle.Fill;            
            tabPage1.Controls.Add(formComTabs);
            formComTabs.Show();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = tabControl1.SelectedIndex;
            TabPage selectedTab = tabControl1.SelectedTab;

            if (selectedTab.Name == "tabAdd")
            {
                var qtde = tabControl1.TabCount;
                var novaAba = new TabPage();
                novaAba.Text = $"Page {qtde}";
                novaAba.Name = $"tabPage{qtde}";

                tabControl1.TabPages.Insert(qtde - 1, novaAba);
                tabControl1.SelectedIndex = qtde - 1;

                var formComTabs = new ComponenteAba();
                formComTabs.Dock = DockStyle.Fill;
                novaAba.Controls.Add(formComTabs);
                formComTabs.Show();
            }
        }
    }
}
