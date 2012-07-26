namespace Kopa_Shamsu
{
    partial class FormMain
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
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.dataGridViewServerarameters = new System.Windows.Forms.DataGridView();
            this.ColumnParameter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxServer = new System.Windows.Forms.GroupBox();
            this.groupBoxServerParameters = new System.Windows.Forms.GroupBox();
            this.groupBoxPlayers = new System.Windows.Forms.GroupBox();
            this.dataGridViewPlayers = new System.Windows.Forms.DataGridView();
            this.ColumnAlias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnKills = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServerarameters)).BeginInit();
            this.groupBoxServer.SuspendLayout();
            this.groupBoxServerParameters.SuspendLayout();
            this.groupBoxPlayers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlayers)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(317, 21);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(119, 38);
            this.buttonUpdate.TabIndex = 1;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(6, 19);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(191, 20);
            this.textBoxAddress.TabIndex = 2;
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(203, 19);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(90, 20);
            this.textBoxPort.TabIndex = 3;
            // 
            // dataGridViewServerarameters
            // 
            this.dataGridViewServerarameters.AllowUserToAddRows = false;
            this.dataGridViewServerarameters.AllowUserToDeleteRows = false;
            this.dataGridViewServerarameters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewServerarameters.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnParameter,
            this.ColumnValue});
            this.dataGridViewServerarameters.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewServerarameters.Name = "dataGridViewServerarameters";
            this.dataGridViewServerarameters.ReadOnly = true;
            this.dataGridViewServerarameters.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewServerarameters.Size = new System.Drawing.Size(418, 150);
            this.dataGridViewServerarameters.TabIndex = 4;
            // 
            // ColumnParameter
            // 
            this.ColumnParameter.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnParameter.DataPropertyName = "Parameter";
            this.ColumnParameter.HeaderText = "Parameter";
            this.ColumnParameter.Name = "ColumnParameter";
            this.ColumnParameter.ReadOnly = true;
            // 
            // ColumnValue
            // 
            this.ColumnValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnValue.DataPropertyName = "Value";
            this.ColumnValue.FillWeight = 150F;
            this.ColumnValue.HeaderText = "Value";
            this.ColumnValue.Name = "ColumnValue";
            this.ColumnValue.ReadOnly = true;
            // 
            // groupBoxServer
            // 
            this.groupBoxServer.Controls.Add(this.textBoxAddress);
            this.groupBoxServer.Controls.Add(this.textBoxPort);
            this.groupBoxServer.Location = new System.Drawing.Point(12, 12);
            this.groupBoxServer.Name = "groupBoxServer";
            this.groupBoxServer.Size = new System.Drawing.Size(299, 52);
            this.groupBoxServer.TabIndex = 5;
            this.groupBoxServer.TabStop = false;
            this.groupBoxServer.Text = "Server";
            // 
            // groupBoxServerParameters
            // 
            this.groupBoxServerParameters.Controls.Add(this.dataGridViewServerarameters);
            this.groupBoxServerParameters.Location = new System.Drawing.Point(12, 70);
            this.groupBoxServerParameters.Name = "groupBoxServerParameters";
            this.groupBoxServerParameters.Size = new System.Drawing.Size(430, 180);
            this.groupBoxServerParameters.TabIndex = 6;
            this.groupBoxServerParameters.TabStop = false;
            this.groupBoxServerParameters.Text = "Server Parameters";
            // 
            // groupBoxPlayers
            // 
            this.groupBoxPlayers.Controls.Add(this.dataGridViewPlayers);
            this.groupBoxPlayers.Location = new System.Drawing.Point(12, 256);
            this.groupBoxPlayers.Name = "groupBoxPlayers";
            this.groupBoxPlayers.Size = new System.Drawing.Size(430, 180);
            this.groupBoxPlayers.TabIndex = 7;
            this.groupBoxPlayers.TabStop = false;
            this.groupBoxPlayers.Text = "Online Players";
            // 
            // dataGridViewPlayers
            // 
            this.dataGridViewPlayers.AllowUserToAddRows = false;
            this.dataGridViewPlayers.AllowUserToDeleteRows = false;
            this.dataGridViewPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPlayers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnAlias,
            this.ColumnKills,
            this.ColumnPing});
            this.dataGridViewPlayers.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewPlayers.Name = "dataGridViewPlayers";
            this.dataGridViewPlayers.ReadOnly = true;
            this.dataGridViewPlayers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPlayers.Size = new System.Drawing.Size(418, 150);
            this.dataGridViewPlayers.TabIndex = 4;
            // 
            // ColumnAlias
            // 
            this.ColumnAlias.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnAlias.DataPropertyName = "Alias";
            this.ColumnAlias.HeaderText = "Alias";
            this.ColumnAlias.Name = "ColumnAlias";
            this.ColumnAlias.ReadOnly = true;
            // 
            // ColumnKills
            // 
            this.ColumnKills.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnKills.DataPropertyName = "Kills";
            this.ColumnKills.FillWeight = 50F;
            this.ColumnKills.HeaderText = "Kills";
            this.ColumnKills.Name = "ColumnKills";
            this.ColumnKills.ReadOnly = true;
            // 
            // ColumnPing
            // 
            this.ColumnPing.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnPing.DataPropertyName = "Ping";
            this.ColumnPing.FillWeight = 50F;
            this.ColumnPing.HeaderText = "Ping";
            this.ColumnPing.Name = "ColumnPing";
            this.ColumnPing.ReadOnly = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 454);
            this.Controls.Add(this.groupBoxPlayers);
            this.Controls.Add(this.groupBoxServerParameters);
            this.Controls.Add(this.groupBoxServer);
            this.Controls.Add(this.buttonUpdate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Kopa Shamsu";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServerarameters)).EndInit();
            this.groupBoxServer.ResumeLayout(false);
            this.groupBoxServer.PerformLayout();
            this.groupBoxServerParameters.ResumeLayout(false);
            this.groupBoxPlayers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlayers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.DataGridView dataGridViewServerarameters;
        private System.Windows.Forms.GroupBox groupBoxServer;
        private System.Windows.Forms.GroupBox groupBoxServerParameters;
        private System.Windows.Forms.GroupBox groupBoxPlayers;
        private System.Windows.Forms.DataGridView dataGridViewPlayers;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnParameter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAlias;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnKills;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPing;
    }
}

