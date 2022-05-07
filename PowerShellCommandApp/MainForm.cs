using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PowerShellCommandApp
{
    public partial class MainForm : Form
    {
        PowerShellConnector _powerShellConnector;
        public MainForm()
        {
            InitializeComponent();
            _powerShellConnector = new PowerShellConnector();
        }

        private async void btnExecuteCommand_Click(object sender, EventArgs e)
        {
            btnExecuteCommand.Enabled = false;
            var task = Task.Factory.StartNew<string>(() => { return _powerShellConnector.RunScript(tbCommand.Text); });
            await Task.WhenAll(task);
            rtbCommandResult.Text = task.Result;
            btnExecuteCommand.Enabled = true;
        }
    }
}
