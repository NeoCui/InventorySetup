namespace TDSDBSetup
{
    partial class TdsDBSetup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TdsDBSetup));
            this.tdsName = new System.Windows.Forms.Label();
            this.connectTDS = new System.Windows.Forms.Button();
            this.tdsNameInput = new System.Windows.Forms.TextBox();
            this.initDB = new System.Windows.Forms.Button();
            this.customPanel = new System.Windows.Forms.GroupBox();
            this.quantityInput = new System.Windows.Forms.NumericUpDown();
            this.entityNameInput = new System.Windows.Forms.TextBox();
            this.entityName = new System.Windows.Forms.Label();
            this.clearData = new System.Windows.Forms.Button();
            this.createEntities = new System.Windows.Forms.Button();
            this.quantity = new System.Windows.Forms.Label();
            this.phaseSelector = new System.Windows.Forms.ComboBox();
            this.phaseName = new System.Windows.Forms.Label();
            this.entityCategory = new System.Windows.Forms.Label();
            this.entitySelector = new System.Windows.Forms.ComboBox();
            this.customPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityInput)).BeginInit();
            this.SuspendLayout();
            // 
            // tdsName
            // 
            this.tdsName.AutoSize = true;
            this.tdsName.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tdsName.Location = new System.Drawing.Point(38, 29);
            this.tdsName.Name = "tdsName";
            this.tdsName.Size = new System.Drawing.Size(79, 19);
            this.tdsName.TabIndex = 0;
            this.tdsName.Text = "TDS Name";
            // 
            // connectTDS
            // 
            this.connectTDS.Enabled = false;
            this.connectTDS.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectTDS.Location = new System.Drawing.Point(413, 24);
            this.connectTDS.Name = "connectTDS";
            this.connectTDS.Size = new System.Drawing.Size(75, 28);
            this.connectTDS.TabIndex = 1;
            this.connectTDS.Text = "Connect";
            this.connectTDS.UseVisualStyleBackColor = true;
            this.connectTDS.Click += new System.EventHandler(this.ConnectTdsClick);
            // 
            // tdsNameInput
            // 
            this.tdsNameInput.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tdsNameInput.Location = new System.Drawing.Point(127, 26);
            this.tdsNameInput.MaxLength = 16;
            this.tdsNameInput.Name = "tdsNameInput";
            this.tdsNameInput.Size = new System.Drawing.Size(172, 24);
            this.tdsNameInput.TabIndex = 2;
            this.tdsNameInput.TextChanged += new System.EventHandler(this.TdsNameInput);
            // 
            // initDB
            // 
            this.initDB.Enabled = false;
            this.initDB.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.initDB.Location = new System.Drawing.Point(545, 24);
            this.initDB.Name = "initDB";
            this.initDB.Size = new System.Drawing.Size(75, 28);
            this.initDB.TabIndex = 3;
            this.initDB.Text = "Initialize";
            this.initDB.UseVisualStyleBackColor = true;
            // 
            // customPanel
            // 
            this.customPanel.Controls.Add(this.quantityInput);
            this.customPanel.Controls.Add(this.entityNameInput);
            this.customPanel.Controls.Add(this.entityName);
            this.customPanel.Controls.Add(this.clearData);
            this.customPanel.Controls.Add(this.createEntities);
            this.customPanel.Controls.Add(this.quantity);
            this.customPanel.Controls.Add(this.phaseSelector);
            this.customPanel.Controls.Add(this.phaseName);
            this.customPanel.Controls.Add(this.entityCategory);
            this.customPanel.Controls.Add(this.entitySelector);
            this.customPanel.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customPanel.Location = new System.Drawing.Point(79, 77);
            this.customPanel.Name = "customPanel";
            this.customPanel.Size = new System.Drawing.Size(646, 337);
            this.customPanel.TabIndex = 5;
            this.customPanel.TabStop = false;
            this.customPanel.Text = "Customize";
            // 
            // quantityInput
            // 
            this.quantityInput.Location = new System.Drawing.Point(452, 112);
            this.quantityInput.Name = "quantityInput";
            this.quantityInput.Size = new System.Drawing.Size(62, 28);
            this.quantityInput.TabIndex = 10;
            this.quantityInput.ValueChanged += new System.EventHandler(this.QuantityInputValueChanged);
            // 
            // entityNameInput
            // 
            this.entityNameInput.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entityNameInput.Location = new System.Drawing.Point(134, 112);
            this.entityNameInput.MaxLength = 16;
            this.entityNameInput.Name = "entityNameInput";
            this.entityNameInput.Size = new System.Drawing.Size(161, 24);
            this.entityNameInput.TabIndex = 9;
            this.entityNameInput.TextChanged += new System.EventHandler(this.EntityNameInput);
            // 
            // entityName
            // 
            this.entityName.AutoSize = true;
            this.entityName.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entityName.Location = new System.Drawing.Point(18, 113);
            this.entityName.Name = "entityName";
            this.entityName.Size = new System.Drawing.Size(89, 19);
            this.entityName.TabIndex = 8;
            this.entityName.Text = "Entity Name";
            // 
            // clearData
            // 
            this.clearData.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearData.Location = new System.Drawing.Point(515, 291);
            this.clearData.Name = "clearData";
            this.clearData.Size = new System.Drawing.Size(75, 28);
            this.clearData.TabIndex = 7;
            this.clearData.Text = "Clear";
            this.clearData.UseVisualStyleBackColor = true;
            this.clearData.Click += new System.EventHandler(this.ClearDataClick);
            // 
            // createEntities
            // 
            this.createEntities.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createEntities.Location = new System.Drawing.Point(372, 291);
            this.createEntities.Name = "createEntities";
            this.createEntities.Size = new System.Drawing.Size(75, 28);
            this.createEntities.TabIndex = 6;
            this.createEntities.Text = "Create";
            this.createEntities.UseVisualStyleBackColor = true;
            this.createEntities.Click += new System.EventHandler(this.CreateEntitiesClick);
            // 
            // quantity
            // 
            this.quantity.AutoSize = true;
            this.quantity.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity.Location = new System.Drawing.Point(377, 115);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(65, 19);
            this.quantity.TabIndex = 4;
            this.quantity.Text = "Quantity";
            // 
            // phaseSelector
            // 
            this.phaseSelector.DisplayMember = "SupplyChain";
            this.phaseSelector.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phaseSelector.FormattingEnabled = true;
            this.phaseSelector.Items.AddRange(new object[] {
            "None",
            "SupplyChain",
            "ImportMSAsset",
            "ServerDiscovery",
            "Burn-In",
            "Allocation",
            "Deployment",
            "ServiceReadiness",
            "GoLive"});
            this.phaseSelector.Location = new System.Drawing.Point(452, 46);
            this.phaseSelector.Name = "phaseSelector";
            this.phaseSelector.Size = new System.Drawing.Size(121, 27);
            this.phaseSelector.TabIndex = 3;
            this.phaseSelector.Text = "None";
            this.phaseSelector.SelectedIndexChanged += new System.EventHandler(this.PhaseSelectorChanged);
            // 
            // phaseName
            // 
            this.phaseName.AutoSize = true;
            this.phaseName.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phaseName.Location = new System.Drawing.Point(380, 49);
            this.phaseName.Name = "phaseName";
            this.phaseName.Size = new System.Drawing.Size(48, 19);
            this.phaseName.TabIndex = 2;
            this.phaseName.Text = "Phase";
            // 
            // entityCategory
            // 
            this.entityCategory.AutoSize = true;
            this.entityCategory.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entityCategory.Location = new System.Drawing.Point(16, 49);
            this.entityCategory.Name = "entityCategory";
            this.entityCategory.Size = new System.Drawing.Size(110, 19);
            this.entityCategory.TabIndex = 1;
            this.entityCategory.Text = "Entity Category";
            // 
            // entitySelector
            // 
            this.entitySelector.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entitySelector.FormattingEnabled = true;
            this.entitySelector.Items.AddRange(new object[] {
            "None",
            "Location",
            "Stamp",
            "CapacityOrderType",
            "CapacityOrder",
            "Forest",
            "Pod",
            "RackType",
            "RackDefinition",
            "Rack",
            "Dag",
            "CapacityUnitDefinition",
            "CapacityUnit",
            "CapacityOrderUnit",
            "Machine"});
            this.entitySelector.Location = new System.Drawing.Point(135, 46);
            this.entitySelector.Name = "entitySelector";
            this.entitySelector.Size = new System.Drawing.Size(161, 27);
            this.entitySelector.TabIndex = 0;
            this.entitySelector.Text = "None";
            this.entitySelector.SelectedIndexChanged += new System.EventHandler(this.EntitySelectorChanged);
            // 
            // TdsDBSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.customPanel);
            this.Controls.Add(this.initDB);
            this.Controls.Add(this.tdsNameInput);
            this.Controls.Add(this.connectTDS);
            this.Controls.Add(this.tdsName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TdsDBSetup";
            this.Text = "TDSDBSetup";
            this.customPanel.ResumeLayout(false);
            this.customPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tdsName;
        private System.Windows.Forms.Button connectTDS;
        private System.Windows.Forms.TextBox tdsNameInput;
        private System.Windows.Forms.Button initDB;
        private System.Windows.Forms.GroupBox customPanel;
        private System.Windows.Forms.Button clearData;
        private System.Windows.Forms.Button createEntities;
        private System.Windows.Forms.Label quantity;
        private System.Windows.Forms.ComboBox phaseSelector;
        private System.Windows.Forms.Label phaseName;
        private System.Windows.Forms.Label entityCategory;
        private System.Windows.Forms.ComboBox entitySelector;
        private System.Windows.Forms.TextBox entityNameInput;
        private System.Windows.Forms.Label entityName;
        private System.Windows.Forms.NumericUpDown quantityInput;
    }
}

