﻿namespace DesktopShark
{
    partial class frmSettings
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
            btnSave = new Button();
            label1 = new Label();
            cbAlwaysOnTop = new CheckBox();
            tbSeconds = new NumericUpDown();
            label2 = new Label();
            cbIAmSpeed = new CheckBox();
            cbChaseCursor = new CheckBox();
            cbFollowCursor = new CheckBox();
            label3 = new Label();
            tbChaseProb = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)tbSeconds).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbChaseProb).BeginInit();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Black;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 14F);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(241, 285);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(73, 40);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(64, 15);
            label1.Name = "label1";
            label1.Size = new Size(184, 37);
            label1.TabIndex = 1;
            label1.Text = "Shark Settings";
            // 
            // cbAlwaysOnTop
            // 
            cbAlwaysOnTop.AutoSize = true;
            cbAlwaysOnTop.Font = new Font("Segoe UI", 12F);
            cbAlwaysOnTop.Location = new Point(12, 82);
            cbAlwaysOnTop.Name = "cbAlwaysOnTop";
            cbAlwaysOnTop.Size = new Size(128, 25);
            cbAlwaysOnTop.TabIndex = 2;
            cbAlwaysOnTop.Text = "Always on Top";
            cbAlwaysOnTop.UseVisualStyleBackColor = true;
            // 
            // tbSeconds
            // 
            tbSeconds.Location = new Point(12, 153);
            tbSeconds.Name = "tbSeconds";
            tbSeconds.Size = new Size(120, 23);
            tbSeconds.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(12, 121);
            label2.Name = "label2";
            label2.Size = new Size(188, 21);
            label2.TabIndex = 4;
            label2.Text = "Seconds between Moving";
            // 
            // cbIAmSpeed
            // 
            cbIAmSpeed.AutoSize = true;
            cbIAmSpeed.Font = new Font("Segoe UI", 12F);
            cbIAmSpeed.Location = new Point(12, 182);
            cbIAmSpeed.Name = "cbIAmSpeed";
            cbIAmSpeed.Size = new Size(108, 25);
            cbIAmSpeed.TabIndex = 5;
            cbIAmSpeed.Text = "I Am Speed";
            cbIAmSpeed.UseVisualStyleBackColor = true;
            // 
            // cbChaseCursor
            // 
            cbChaseCursor.AutoSize = true;
            cbChaseCursor.Font = new Font("Segoe UI", 12F);
            cbChaseCursor.Location = new Point(12, 244);
            cbChaseCursor.Name = "cbChaseCursor";
            cbChaseCursor.Size = new Size(203, 25);
            cbChaseCursor.TabIndex = 6;
            cbChaseCursor.Text = "Enable Cursor Chomping";
            cbChaseCursor.UseVisualStyleBackColor = true;
            // 
            // cbFollowCursor
            // 
            cbFollowCursor.AutoSize = true;
            cbFollowCursor.Font = new Font("Segoe UI", 12F);
            cbFollowCursor.Location = new Point(12, 213);
            cbFollowCursor.Name = "cbFollowCursor";
            cbFollowCursor.Size = new Size(126, 25);
            cbFollowCursor.TabIndex = 7;
            cbFollowCursor.Text = "Follow Cursor";
            cbFollowCursor.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(12, 272);
            label3.Name = "label3";
            label3.Size = new Size(176, 21);
            label3.TabIndex = 9;
            label3.Text = "Probability of Chase (%)";
            // 
            // tbChaseProb
            // 
            tbChaseProb.Location = new Point(12, 302);
            tbChaseProb.Name = "tbChaseProb";
            tbChaseProb.Size = new Size(120, 23);
            tbChaseProb.TabIndex = 8;
            tbChaseProb.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // frmSettings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            ClientSize = new Size(326, 337);
            Controls.Add(label3);
            Controls.Add(tbChaseProb);
            Controls.Add(btnSave);
            Controls.Add(cbFollowCursor);
            Controls.Add(cbChaseCursor);
            Controls.Add(cbIAmSpeed);
            Controls.Add(label2);
            Controls.Add(tbSeconds);
            Controls.Add(cbAlwaysOnTop);
            Controls.Add(label1);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmSettings";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Shark Settings";
            ((System.ComponentModel.ISupportInitialize)tbSeconds).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbChaseProb).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private Label label1;
        private CheckBox cbAlwaysOnTop;
        private NumericUpDown tbSeconds;
        private Label label2;
        private CheckBox cbIAmSpeed;
        private CheckBox cbChaseCursor;
        private CheckBox cbFollowCursor;
        private Label label3;
        private NumericUpDown tbChaseProb;
    }
}