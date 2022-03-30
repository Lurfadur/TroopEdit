
namespace TroopEdit
{
    partial class TroopPublisher
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
            this.LoadJsonButton = new System.Windows.Forms.Button();
            this.SelectedTroopNameLabel = new System.Windows.Forms.Label();
            this.SelectedTroopNameBox = new System.Windows.Forms.TextBox();
            this.SelectedTroopTypeLabel = new System.Windows.Forms.Label();
            this.SelectedTroopDamageLabel = new System.Windows.Forms.Label();
            this.SelectedTroopHealthLabel = new System.Windows.Forms.Label();
            this.SelectedTroopTargetLabel = new System.Windows.Forms.Label();
            this.SelectedTroopDamageBox = new System.Windows.Forms.TextBox();
            this.SelectedTroopHealthBox = new System.Windows.Forms.TextBox();
            this.SelectedTroopTypeComboBox = new System.Windows.Forms.ComboBox();
            this.SelectedTroopTargetComboBox = new System.Windows.Forms.ComboBox();
            this.SaveJsonFile = new System.Windows.Forms.Button();
            this.LoadedTroopsLabel = new System.Windows.Forms.Label();
            this.ExportToBinaryButton = new System.Windows.Forms.Button();
            this.TroopTreeView = new System.Windows.Forms.TreeView();
            this.AddTroopButton = new System.Windows.Forms.Button();
            this.IsDerivedTroopLabel = new System.Windows.Forms.Label();
            this.MainTroopBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RemoveTroopButton = new System.Windows.Forms.Button();
            this.UpdateTroopButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoadJsonButton
            // 
            this.LoadJsonButton.Location = new System.Drawing.Point(12, 12);
            this.LoadJsonButton.Name = "LoadJsonButton";
            this.LoadJsonButton.Size = new System.Drawing.Size(75, 23);
            this.LoadJsonButton.TabIndex = 0;
            this.LoadJsonButton.Text = "Load JSON";
            this.LoadJsonButton.UseVisualStyleBackColor = true;
            this.LoadJsonButton.Click += new System.EventHandler(this.LoadJsonButton_Click);
            // 
            // SelectedTroopNameLabel
            // 
            this.SelectedTroopNameLabel.AutoSize = true;
            this.SelectedTroopNameLabel.Location = new System.Drawing.Point(203, 66);
            this.SelectedTroopNameLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.SelectedTroopNameLabel.Name = "SelectedTroopNameLabel";
            this.SelectedTroopNameLabel.Size = new System.Drawing.Size(38, 13);
            this.SelectedTroopNameLabel.TabIndex = 2;
            this.SelectedTroopNameLabel.Text = "Name:";
            // 
            // SelectedTroopNameBox
            // 
            this.SelectedTroopNameBox.Location = new System.Drawing.Point(260, 64);
            this.SelectedTroopNameBox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.SelectedTroopNameBox.Name = "SelectedTroopNameBox";
            this.SelectedTroopNameBox.Size = new System.Drawing.Size(104, 20);
            this.SelectedTroopNameBox.TabIndex = 3;
            // 
            // SelectedTroopTypeLabel
            // 
            this.SelectedTroopTypeLabel.AutoSize = true;
            this.SelectedTroopTypeLabel.Location = new System.Drawing.Point(203, 93);
            this.SelectedTroopTypeLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.SelectedTroopTypeLabel.Name = "SelectedTroopTypeLabel";
            this.SelectedTroopTypeLabel.Size = new System.Drawing.Size(34, 13);
            this.SelectedTroopTypeLabel.TabIndex = 4;
            this.SelectedTroopTypeLabel.Text = "Type:";
            // 
            // SelectedTroopDamageLabel
            // 
            this.SelectedTroopDamageLabel.AutoSize = true;
            this.SelectedTroopDamageLabel.Location = new System.Drawing.Point(203, 116);
            this.SelectedTroopDamageLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.SelectedTroopDamageLabel.Name = "SelectedTroopDamageLabel";
            this.SelectedTroopDamageLabel.Size = new System.Drawing.Size(50, 13);
            this.SelectedTroopDamageLabel.TabIndex = 5;
            this.SelectedTroopDamageLabel.Text = "Damage:";
            // 
            // SelectedTroopHealthLabel
            // 
            this.SelectedTroopHealthLabel.AutoSize = true;
            this.SelectedTroopHealthLabel.Location = new System.Drawing.Point(203, 139);
            this.SelectedTroopHealthLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.SelectedTroopHealthLabel.Name = "SelectedTroopHealthLabel";
            this.SelectedTroopHealthLabel.Size = new System.Drawing.Size(41, 13);
            this.SelectedTroopHealthLabel.TabIndex = 6;
            this.SelectedTroopHealthLabel.Text = "Health:";
            // 
            // SelectedTroopTargetLabel
            // 
            this.SelectedTroopTargetLabel.AutoSize = true;
            this.SelectedTroopTargetLabel.Location = new System.Drawing.Point(203, 159);
            this.SelectedTroopTargetLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.SelectedTroopTargetLabel.Name = "SelectedTroopTargetLabel";
            this.SelectedTroopTargetLabel.Size = new System.Drawing.Size(41, 13);
            this.SelectedTroopTargetLabel.TabIndex = 7;
            this.SelectedTroopTargetLabel.Text = "Target:";
            // 
            // SelectedTroopDamageBox
            // 
            this.SelectedTroopDamageBox.Location = new System.Drawing.Point(260, 113);
            this.SelectedTroopDamageBox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.SelectedTroopDamageBox.Name = "SelectedTroopDamageBox";
            this.SelectedTroopDamageBox.Size = new System.Drawing.Size(104, 20);
            this.SelectedTroopDamageBox.TabIndex = 9;
            // 
            // SelectedTroopHealthBox
            // 
            this.SelectedTroopHealthBox.Location = new System.Drawing.Point(260, 137);
            this.SelectedTroopHealthBox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.SelectedTroopHealthBox.Name = "SelectedTroopHealthBox";
            this.SelectedTroopHealthBox.Size = new System.Drawing.Size(104, 20);
            this.SelectedTroopHealthBox.TabIndex = 10;
            // 
            // SelectedTroopTypeComboBox
            // 
            this.SelectedTroopTypeComboBox.FormattingEnabled = true;
            this.SelectedTroopTypeComboBox.Items.AddRange(new object[] {
            "(none)",
            "ground",
            "air"});
            this.SelectedTroopTypeComboBox.Location = new System.Drawing.Point(260, 90);
            this.SelectedTroopTypeComboBox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.SelectedTroopTypeComboBox.Name = "SelectedTroopTypeComboBox";
            this.SelectedTroopTypeComboBox.Size = new System.Drawing.Size(63, 21);
            this.SelectedTroopTypeComboBox.TabIndex = 11;
            // 
            // SelectedTroopTargetComboBox
            // 
            this.SelectedTroopTargetComboBox.FormattingEnabled = true;
            this.SelectedTroopTargetComboBox.Items.AddRange(new object[] {
            "(none)",
            "ground",
            "air",
            "all"});
            this.SelectedTroopTargetComboBox.Location = new System.Drawing.Point(260, 159);
            this.SelectedTroopTargetComboBox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.SelectedTroopTargetComboBox.Name = "SelectedTroopTargetComboBox";
            this.SelectedTroopTargetComboBox.Size = new System.Drawing.Size(63, 21);
            this.SelectedTroopTargetComboBox.TabIndex = 12;
            // 
            // SaveJsonFile
            // 
            this.SaveJsonFile.Enabled = false;
            this.SaveJsonFile.Location = new System.Drawing.Point(12, 206);
            this.SaveJsonFile.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.SaveJsonFile.Name = "SaveJsonFile";
            this.SaveJsonFile.Size = new System.Drawing.Size(120, 24);
            this.SaveJsonFile.TabIndex = 13;
            this.SaveJsonFile.Text = "Update JSON File";
            this.SaveJsonFile.UseVisualStyleBackColor = true;
            this.SaveJsonFile.Click += new System.EventHandler(this.SaveJsonFile_Click);
            // 
            // LoadedTroopsLabel
            // 
            this.LoadedTroopsLabel.AutoSize = true;
            this.LoadedTroopsLabel.Location = new System.Drawing.Point(10, 51);
            this.LoadedTroopsLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LoadedTroopsLabel.Name = "LoadedTroopsLabel";
            this.LoadedTroopsLabel.Size = new System.Drawing.Size(82, 13);
            this.LoadedTroopsLabel.TabIndex = 14;
            this.LoadedTroopsLabel.Text = "Loaded Troops:";
            // 
            // ExportToBinaryButton
            // 
            this.ExportToBinaryButton.Enabled = false;
            this.ExportToBinaryButton.Location = new System.Drawing.Point(116, 12);
            this.ExportToBinaryButton.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.ExportToBinaryButton.Name = "ExportToBinaryButton";
            this.ExportToBinaryButton.Size = new System.Drawing.Size(104, 23);
            this.ExportToBinaryButton.TabIndex = 15;
            this.ExportToBinaryButton.Text = "Export To Binary";
            this.ExportToBinaryButton.UseVisualStyleBackColor = true;
            this.ExportToBinaryButton.Click += new System.EventHandler(this.ExportToBinaryButton_Click);
            // 
            // TroopTreeView
            // 
            this.TroopTreeView.Location = new System.Drawing.Point(12, 66);
            this.TroopTreeView.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.TroopTreeView.Name = "TroopTreeView";
            this.TroopTreeView.Size = new System.Drawing.Size(151, 129);
            this.TroopTreeView.TabIndex = 16;
            this.TroopTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TroopTreeView_AfterSelect);
            // 
            // AddTroopButton
            // 
            this.AddTroopButton.Enabled = false;
            this.AddTroopButton.Location = new System.Drawing.Point(210, 238);
            this.AddTroopButton.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.AddTroopButton.Name = "AddTroopButton";
            this.AddTroopButton.Size = new System.Drawing.Size(92, 24);
            this.AddTroopButton.TabIndex = 17;
            this.AddTroopButton.Text = "Add New Troop";
            this.AddTroopButton.UseVisualStyleBackColor = true;
            this.AddTroopButton.Click += new System.EventHandler(this.AddTroopButton_Click);
            // 
            // IsDerivedTroopLabel
            // 
            this.IsDerivedTroopLabel.AutoSize = true;
            this.IsDerivedTroopLabel.Location = new System.Drawing.Point(203, 181);
            this.IsDerivedTroopLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.IsDerivedTroopLabel.Name = "IsDerivedTroopLabel";
            this.IsDerivedTroopLabel.Size = new System.Drawing.Size(104, 13);
            this.IsDerivedTroopLabel.TabIndex = 8;
            this.IsDerivedTroopLabel.Text = "Troop Derived From:";
            // 
            // MainTroopBox
            // 
            this.MainTroopBox.Location = new System.Drawing.Point(310, 180);
            this.MainTroopBox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.MainTroopBox.Name = "MainTroopBox";
            this.MainTroopBox.Size = new System.Drawing.Size(104, 20);
            this.MainTroopBox.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(205, 217);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Add or remove the above Troop to the Troop data.";
            // 
            // RemoveTroopButton
            // 
            this.RemoveTroopButton.Enabled = false;
            this.RemoveTroopButton.Location = new System.Drawing.Point(325, 238);
            this.RemoveTroopButton.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.RemoveTroopButton.Name = "RemoveTroopButton";
            this.RemoveTroopButton.Size = new System.Drawing.Size(92, 24);
            this.RemoveTroopButton.TabIndex = 20;
            this.RemoveTroopButton.Text = "Remove Troop";
            this.RemoveTroopButton.UseVisualStyleBackColor = true;
            this.RemoveTroopButton.Click += new System.EventHandler(this.RemoveTroopButton_Click);
            // 
            // UpdateTroopButton
            // 
            this.UpdateTroopButton.Location = new System.Drawing.Point(387, 71);
            this.UpdateTroopButton.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.UpdateTroopButton.Name = "UpdateTroopButton";
            this.UpdateTroopButton.Size = new System.Drawing.Size(88, 30);
            this.UpdateTroopButton.TabIndex = 21;
            this.UpdateTroopButton.Text = "Update Troop";
            this.UpdateTroopButton.UseVisualStyleBackColor = true;
            this.UpdateTroopButton.Click += new System.EventHandler(this.UpdateTroopButton_Click);
            // 
            // TroopPublisher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 293);
            this.Controls.Add(this.UpdateTroopButton);
            this.Controls.Add(this.RemoveTroopButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MainTroopBox);
            this.Controls.Add(this.AddTroopButton);
            this.Controls.Add(this.TroopTreeView);
            this.Controls.Add(this.ExportToBinaryButton);
            this.Controls.Add(this.LoadedTroopsLabel);
            this.Controls.Add(this.SaveJsonFile);
            this.Controls.Add(this.SelectedTroopTargetComboBox);
            this.Controls.Add(this.SelectedTroopTypeComboBox);
            this.Controls.Add(this.SelectedTroopHealthBox);
            this.Controls.Add(this.SelectedTroopDamageBox);
            this.Controls.Add(this.IsDerivedTroopLabel);
            this.Controls.Add(this.SelectedTroopTargetLabel);
            this.Controls.Add(this.SelectedTroopHealthLabel);
            this.Controls.Add(this.SelectedTroopDamageLabel);
            this.Controls.Add(this.SelectedTroopTypeLabel);
            this.Controls.Add(this.SelectedTroopNameBox);
            this.Controls.Add(this.SelectedTroopNameLabel);
            this.Controls.Add(this.LoadJsonButton);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "TroopPublisher";
            this.Text = "Troop Publisher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoadJsonButton;
        private System.Windows.Forms.Label SelectedTroopNameLabel;
        private System.Windows.Forms.TextBox SelectedTroopNameBox;
        private System.Windows.Forms.Label SelectedTroopTypeLabel;
        private System.Windows.Forms.Label SelectedTroopDamageLabel;
        private System.Windows.Forms.Label SelectedTroopHealthLabel;
        private System.Windows.Forms.Label SelectedTroopTargetLabel;
        private System.Windows.Forms.TextBox SelectedTroopDamageBox;
        private System.Windows.Forms.TextBox SelectedTroopHealthBox;
        private System.Windows.Forms.ComboBox SelectedTroopTypeComboBox;
        private System.Windows.Forms.ComboBox SelectedTroopTargetComboBox;
        private System.Windows.Forms.Button SaveJsonFile;
        private System.Windows.Forms.Label LoadedTroopsLabel;
        private System.Windows.Forms.Button ExportToBinaryButton;
        private System.Windows.Forms.TreeView TroopTreeView;
        private System.Windows.Forms.Button AddTroopButton;
        private System.Windows.Forms.Label IsDerivedTroopLabel;
        private System.Windows.Forms.TextBox MainTroopBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RemoveTroopButton;
        private System.Windows.Forms.Button UpdateTroopButton;
    }
}

