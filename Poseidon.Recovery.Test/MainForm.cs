using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poseidon.Recovery.Test
{
    using Poseidon.Winform.Base;
    using Poseidon.Recovery.ClientDx;

    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void menuChargeBuildingMan_Click(object sender, EventArgs e)
        {
            ChildFormManage.LoadMdiForm(this, typeof(FrmChargeBuildingManage));
        }

        private void menuAccountMan_Click(object sender, EventArgs e)
        {
            ChildFormManage.LoadMdiForm(this, typeof(FrmAccountManage));
        }

        private void menuRecoveryReceipt_Click(object sender, EventArgs e)
        {
            ChildFormManage.LoadMdiForm(this, typeof(FrmRecoveryReceipt));
        }
    }
}
