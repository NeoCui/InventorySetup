using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TDSDBSetup
{
    using System.Collections.ObjectModel;
    using System.Diagnostics;
    using System.Management.Automation;
    using System.Management.Automation.Runspaces;
    using System.Runtime.CompilerServices;

    public partial class TdsDBSetup : Form
    {
        private string entityString;
        private string entityNameString;
        private string phaseString;
        private string quantityString;

        public TdsDBSetup()
        {
            this.InitializeComponent();
        }

        private void PhaseSelectorChanged(object sender, EventArgs e)
        {
            this.phaseString = Environment.NewLine + $"Phase: {this.phaseSelector.Text}";
        }

        private void CreateEntitiesClick(object sender, EventArgs e)
        {
            if (this.entitySelector.SelectedIndex == 0)
            {
                this.entityString = Environment.NewLine + "Please select an entity category!";
            }
            else
            {
                this.entityString = Environment.NewLine + $"Entity: {this.entitySelector.Text}";
            }

            if (this.phaseSelector.SelectedIndex == 0)
            {
                this.phaseString = Environment.NewLine + "Please select an phase!";
            }
            else
            {
                this.phaseString = Environment.NewLine + $"Phase: {this.phaseSelector.Text}";
            }

            if (this.quantityInput.Value == 0)
            {
                this.quantityString = Environment.NewLine + "Please select the quantity!";
            }
            else
            {
                this.quantityString = Environment.NewLine + $"Quantity: {this.quantityInput.Value}";
            }

            if(string.IsNullOrWhiteSpace(this.entityNameInput.Text))
            {
                this.entityNameString = Environment.NewLine + "Please input the entity name!";
            }
            else
            {
                this.entityNameString = Environment.NewLine + $"Entity Name: {this.entityNameInput.Text}";
            }

            ShowMessage(this.entityNameString +
                        this.entityString +
                        this.phaseString +
                        this.quantityString
            );
        }

        private void TdsNameInput(object sender, EventArgs e)
        {
            this.connectTDS.Enabled = true;
        }

        private void ConnectTdsClick(object sender, EventArgs e)
        {
            var TDSName = this.tdsNameInput.Text;
            string cmd = "$secpasswd = ConvertTo-SecureString 'T%nt0wn' -AsPlainText -force;" +
                         "$mycreds = New-Object System.Management.Automation.PSCredential ('Administrator', $secpasswd);" +
                         $"Invoke-Command -ComputerName {TDSName} -ScriptBlock {{Get-ChildItem C:\\windows}} -Credential $mycreds";

            InitialSessionState initial = InitialSessionState.CreateDefault();
            Runspace runspace = RunspaceFactory.CreateRunspace(initial);
            runspace.Open();
            Pipeline pipeline = runspace.CreatePipeline();
            pipeline.Commands.AddScript(cmd);
            Collection<PSObject> results = pipeline.Invoke();
            string resultString = null;
            foreach (var result in results)
            {
                resultString += result.ToString();
            }
            ShowMessage(resultString);
            this.initDB.Enabled = true;
        }

        private void ClearDataClick(object sender, EventArgs e)
        {
            this.entitySelector.SelectedIndex = 0;
            this.phaseSelector.SelectedIndex = 0;
            this.entityNameInput.Clear();
            this.quantityInput.Text = "0";
        }

        private void EntitySelectorChanged(object sender, EventArgs e)
        {
            this.entityString= Environment.NewLine + $"Entity: {this.entitySelector.Text}";
        }

        private void EntityNameInput(object sender, EventArgs e)
        {
            this.entityNameString = Environment.NewLine + $"EntityName: {this.entityNameInput.Text}";
        }

        private void QuantityInputValueChanged(object sender, EventArgs e)
        {
            this.quantityString = Environment.NewLine + $"Quantity: {this.quantityInput.Value}";
        }

        private static void ShowMessage(string message)
        {
            if (message != null)
            {
                MessageBox.Show(message,
                    "Message",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

    }
}
