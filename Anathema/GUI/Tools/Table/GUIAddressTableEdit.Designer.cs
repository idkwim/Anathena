﻿namespace Anathema
{
    partial class GUIAddressTableEdit
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
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.ValueTypeComboBox = new System.Windows.Forms.ComboBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.ValueTypeLabel = new System.Windows.Forms.Label();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.ValueLabel = new System.Windows.Forms.Label();
            this.OffsetListBox = new System.Windows.Forms.ListBox();
            this.OffsetTextBox = new System.Windows.Forms.TextBox();
            this.AddOffsetButton = new System.Windows.Forms.Button();
            this.RemoveOffsetButton = new System.Windows.Forms.Button();
            this.OffsetLabel = new System.Windows.Forms.Label();
            this.AcceptButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.ValueTextBox = new Anathema.WatermarkTextBox();
            this.SuspendLayout();
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Location = new System.Drawing.Point(81, 12);
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(286, 20);
            this.DescriptionTextBox.TabIndex = 0;
            // 
            // ValueTypeComboBox
            // 
            this.ValueTypeComboBox.FormattingEnabled = true;
            this.ValueTypeComboBox.Location = new System.Drawing.Point(81, 39);
            this.ValueTypeComboBox.Name = "ValueTypeComboBox";
            this.ValueTypeComboBox.Size = new System.Drawing.Size(124, 21);
            this.ValueTypeComboBox.TabIndex = 1;
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(12, 15);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(63, 13);
            this.DescriptionLabel.TabIndex = 2;
            this.DescriptionLabel.Text = "Description:";
            // 
            // ValueTypeLabel
            // 
            this.ValueTypeLabel.AutoSize = true;
            this.ValueTypeLabel.Location = new System.Drawing.Point(11, 42);
            this.ValueTypeLabel.Name = "ValueTypeLabel";
            this.ValueTypeLabel.Size = new System.Drawing.Size(64, 13);
            this.ValueTypeLabel.TabIndex = 3;
            this.ValueTypeLabel.Text = "Value Type:";
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(81, 107);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(286, 20);
            this.AddressTextBox.TabIndex = 4;
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(27, 110);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(48, 13);
            this.AddressLabel.TabIndex = 5;
            this.AddressLabel.Text = "Address:";
            // 
            // ValueLabel
            // 
            this.ValueLabel.AutoSize = true;
            this.ValueLabel.Location = new System.Drawing.Point(38, 75);
            this.ValueLabel.Name = "ValueLabel";
            this.ValueLabel.Size = new System.Drawing.Size(37, 13);
            this.ValueLabel.TabIndex = 7;
            this.ValueLabel.Text = "Value:";
            // 
            // OffsetListBox
            // 
            this.OffsetListBox.FormattingEnabled = true;
            this.OffsetListBox.Location = new System.Drawing.Point(81, 168);
            this.OffsetListBox.Name = "OffsetListBox";
            this.OffsetListBox.Size = new System.Drawing.Size(286, 43);
            this.OffsetListBox.TabIndex = 8;
            // 
            // OffsetTextBox
            // 
            this.OffsetTextBox.Location = new System.Drawing.Point(81, 142);
            this.OffsetTextBox.Name = "OffsetTextBox";
            this.OffsetTextBox.Size = new System.Drawing.Size(124, 20);
            this.OffsetTextBox.TabIndex = 9;
            // 
            // AddOffsetButton
            // 
            this.AddOffsetButton.Location = new System.Drawing.Point(292, 140);
            this.AddOffsetButton.Name = "AddOffsetButton";
            this.AddOffsetButton.Size = new System.Drawing.Size(75, 23);
            this.AddOffsetButton.TabIndex = 10;
            this.AddOffsetButton.Text = "Add";
            this.AddOffsetButton.UseVisualStyleBackColor = true;
            // 
            // RemoveOffsetButton
            // 
            this.RemoveOffsetButton.Location = new System.Drawing.Point(211, 140);
            this.RemoveOffsetButton.Name = "RemoveOffsetButton";
            this.RemoveOffsetButton.Size = new System.Drawing.Size(75, 23);
            this.RemoveOffsetButton.TabIndex = 11;
            this.RemoveOffsetButton.Text = "Remove";
            this.RemoveOffsetButton.UseVisualStyleBackColor = true;
            // 
            // OffsetLabel
            // 
            this.OffsetLabel.AutoSize = true;
            this.OffsetLabel.Location = new System.Drawing.Point(37, 145);
            this.OffsetLabel.Name = "OffsetLabel";
            this.OffsetLabel.Size = new System.Drawing.Size(38, 13);
            this.OffsetLabel.TabIndex = 12;
            this.OffsetLabel.Text = "Offset:";
            // 
            // AcceptButton
            // 
            this.AcceptButton.Location = new System.Drawing.Point(81, 217);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(75, 23);
            this.AcceptButton.TabIndex = 13;
            this.AcceptButton.Text = "Accept";
            this.AcceptButton.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Location = new System.Drawing.Point(162, 217);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 14;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // ValueTextBox
            // 
            this.ValueTextBox.ForeColor = System.Drawing.Color.Gray;
            this.ValueTextBox.Location = new System.Drawing.Point(81, 72);
            this.ValueTextBox.Name = "ValueTextBox";
            this.ValueTextBox.Size = new System.Drawing.Size(285, 20);
            this.ValueTextBox.TabIndex = 15;
            this.ValueTextBox.Text = "(Insert A Value to Overwrite Current Value)";
            this.ValueTextBox.WatermarkActive = true;
            this.ValueTextBox.WatermarkText = "";
            // 
            // GUIAddressTableEdit
            // 
            this.AcceptButton = this.AcceptButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelButton;
            this.ClientSize = new System.Drawing.Size(378, 247);
            this.Controls.Add(this.ValueTextBox);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AcceptButton);
            this.Controls.Add(this.OffsetLabel);
            this.Controls.Add(this.RemoveOffsetButton);
            this.Controls.Add(this.AddOffsetButton);
            this.Controls.Add(this.OffsetTextBox);
            this.Controls.Add(this.OffsetListBox);
            this.Controls.Add(this.ValueLabel);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.AddressTextBox);
            this.Controls.Add(this.ValueTypeLabel);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.ValueTypeComboBox);
            this.Controls.Add(this.DescriptionTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "GUIAddressTableEdit";
            this.Text = "Edit Address Table Entry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.ComboBox ValueTypeComboBox;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Label ValueTypeLabel;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Label ValueLabel;
        private System.Windows.Forms.ListBox OffsetListBox;
        private System.Windows.Forms.TextBox OffsetTextBox;
        private System.Windows.Forms.Button AddOffsetButton;
        private System.Windows.Forms.Button RemoveOffsetButton;
        private System.Windows.Forms.Label OffsetLabel;
        private System.Windows.Forms.Button AcceptButton;
        private System.Windows.Forms.Button CancelButton;
        private WatermarkTextBox ValueTextBox;
    }
}