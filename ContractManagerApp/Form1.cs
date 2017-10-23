﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Codenut.ContractManager.UI.ContractManagerApp
{
    public partial class ContractAppMain : Form
    {
        public ContractAppMain()
        {
            InitializeComponent();
        }

        private void getContract_Click(object sender, EventArgs e)
        {
            var _contractManager = new Codenut.ContractManager.Logic.ContractManagement.Class1();
            var _contractResult = _contractManager.GetContracts(new CrossCutting.BusinessObjects.ContractFilter
            {
                ContractId = 15
            });

            foreach (var contract in _contractResult)
            {
                MessageBox.Show(contract.Id.ToString());
            }
        }
    }
}