﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poseidon.Recovery.ClientDx
{
    using Poseidon.Base.Framework;
    using Poseidon.Core.BL;
    using Poseidon.Core.DL;
    using Poseidon.Winform.Base;
    using Poseidon.Recovery.Core.BL;
    using Poseidon.Recovery.Core.DL;

    /// <summary>
    /// 费用回收单据窗体
    /// </summary>
    public partial class FrmRecoveryReceipt : BaseMdiForm
    {
        #region Constructor
        public FrmRecoveryReceipt()
        {
            InitializeComponent();
        }
        #endregion //Constructor
    }
}