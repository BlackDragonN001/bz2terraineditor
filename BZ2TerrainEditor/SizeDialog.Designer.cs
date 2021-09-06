﻿namespace BZ2TerrainEditor
{
	partial class SizeDialog
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
            this.infoLabel = new System.Windows.Forms.Label();
            this.valueSelector = new System.Windows.Forms.NumericUpDown();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.versionSelector = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.valueSelector)).BeginInit();
            this.SuspendLayout();
            // 
            // infoLabel
            // 
            this.infoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.infoLabel.Location = new System.Drawing.Point(12, 9);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(310, 26);
            this.infoLabel.TabIndex = 0;
            this.infoLabel.Text = "Please enter the size of the terrain.";
            // 
            // valueSelector
            // 
            this.valueSelector.Increment = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.valueSelector.Location = new System.Drawing.Point(12, 38);
            this.valueSelector.Maximum = new decimal(new int[] {
            2048,
            0,
            0,
            0});
            this.valueSelector.Minimum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.valueSelector.Name = "valueSelector";
            this.valueSelector.Size = new System.Drawing.Size(310, 20);
            this.valueSelector.TabIndex = 1;
            this.valueSelector.Value = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.valueSelector.ValueChanged += new System.EventHandler(this.valueSelector_ValueChanged);
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.Location = new System.Drawing.Point(170, 89);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(152, 25);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "&OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cancelButton.Location = new System.Drawing.Point(12, 89);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(152, 25);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "&Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // versionSelector
            // 
            this.versionSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.versionSelector.FormattingEnabled = true;
            this.versionSelector.Items.AddRange(new object[] {
            "5",
            "4",
            "3",
            "2",
            "1",
            "0"});
            this.versionSelector.Location = new System.Drawing.Point(12, 64);
            this.versionSelector.Name = "versionSelector";
            this.versionSelector.Size = new System.Drawing.Size(310, 21);
            this.versionSelector.TabIndex = 3;
            this.versionSelector.SelectedIndexChanged += new System.EventHandler(this.versionSelector_SelectedIndexChanged);
            // 
            // SizeDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 126);
            this.Controls.Add(this.versionSelector);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.valueSelector);
            this.Controls.Add(this.infoLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SizeDialog";
            this.Text = "Select size";
            this.Load += new System.EventHandler(this.SizeDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.valueSelector)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label infoLabel;
		private System.Windows.Forms.NumericUpDown valueSelector;
		private System.Windows.Forms.Button okButton;
		private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ComboBox versionSelector;
    }
}