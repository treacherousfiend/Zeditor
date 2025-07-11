namespace Zeditor
{
    partial class StateDataEditor
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
			idBox = new System.Windows.Forms.NumericUpDown();
			nameBox = new System.Windows.Forms.TextBox();
			label1 = new System.Windows.Forms.Label();
			label2 = new System.Windows.Forms.Label();
			okBtn = new System.Windows.Forms.Button();
			cancelBtn = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)idBox).BeginInit();
			SuspendLayout();
			// 
			// idBox
			// 
			idBox.Location = new System.Drawing.Point(62, 12);
			idBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			idBox.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
			idBox.Name = "idBox";
			idBox.Size = new System.Drawing.Size(140, 23);
			idBox.TabIndex = 1;
			idBox.ValueChanged += idBox_ValueChanged;
			// 
			// nameBox
			// 
			nameBox.Location = new System.Drawing.Point(62, 42);
			nameBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			nameBox.Name = "nameBox";
			nameBox.Size = new System.Drawing.Size(139, 23);
			nameBox.TabIndex = 0;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new System.Drawing.Point(14, 45);
			label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(39, 15);
			label1.TabIndex = 2;
			label1.Text = "Name";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new System.Drawing.Point(34, 14);
			label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(18, 15);
			label2.TabIndex = 3;
			label2.Text = "ID";
			// 
			// okBtn
			// 
			okBtn.Location = new System.Drawing.Point(130, 72);
			okBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			okBtn.Name = "okBtn";
			okBtn.Size = new System.Drawing.Size(72, 27);
			okBtn.TabIndex = 4;
			okBtn.Text = "OK";
			okBtn.UseVisualStyleBackColor = true;
			okBtn.Click += okBtn_Click;
			// 
			// cancelBtn
			// 
			cancelBtn.Location = new System.Drawing.Point(47, 72);
			cancelBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			cancelBtn.Name = "cancelBtn";
			cancelBtn.Size = new System.Drawing.Size(76, 27);
			cancelBtn.TabIndex = 5;
			cancelBtn.Text = "Cancel";
			cancelBtn.UseVisualStyleBackColor = true;
			cancelBtn.Click += cancelBtn_Click;
			// 
			// StateDataEditor
			// 
			AcceptButton = okBtn;
			AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			CancelButton = cancelBtn;
			ClientSize = new System.Drawing.Size(223, 107);
			ControlBox = false;
			Controls.Add(cancelBtn);
			Controls.Add(okBtn);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(nameBox);
			Controls.Add(idBox);
			FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "StateDataEditor";
			SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			Text = "Edit State";
			((System.ComponentModel.ISupportInitialize)idBox).EndInit();
			ResumeLayout(false);
			PerformLayout();

		}

		#endregion

		private System.Windows.Forms.NumericUpDown idBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}