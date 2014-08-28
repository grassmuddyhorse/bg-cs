namespace Ours_Bowling
{
    partial class PlayerManagementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerManagementForm));
            this.PM_SplitContainer = new System.Windows.Forms.SplitContainer();
            this.PlayerNum_TextBox = new System.Windows.Forms.MaskedTextBox();
            this.Next_Button = new System.Windows.Forms.Button();
            this.label_1_4 = new System.Windows.Forms.Label();
            this.PlayerNum_Label = new System.Windows.Forms.Label();
            this.PlayerMA_groupBox = new System.Windows.Forms.GroupBox();
            this.Back_Button = new System.Windows.Forms.Button();
            this.Start_Button = new System.Windows.Forms.Button();
            this.PlayerNa_panel = new System.Windows.Forms.Panel();
            this.PlayerNa_Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PM_SplitContainer)).BeginInit();
            this.PM_SplitContainer.Panel1.SuspendLayout();
            this.PM_SplitContainer.Panel2.SuspendLayout();
            this.PM_SplitContainer.SuspendLayout();
            this.PlayerMA_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // PM_SplitContainer
            // 
            this.PM_SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PM_SplitContainer.IsSplitterFixed = true;
            this.PM_SplitContainer.Location = new System.Drawing.Point(0, 0);
            this.PM_SplitContainer.Name = "PM_SplitContainer";
            this.PM_SplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // PM_SplitContainer.Panel1
            // 
            this.PM_SplitContainer.Panel1.Controls.Add(this.PlayerNum_TextBox);
            this.PM_SplitContainer.Panel1.Controls.Add(this.Next_Button);
            this.PM_SplitContainer.Panel1.Controls.Add(this.label_1_4);
            this.PM_SplitContainer.Panel1.Controls.Add(this.PlayerNum_Label);
            // 
            // PM_SplitContainer.Panel2
            // 
            this.PM_SplitContainer.Panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PM_SplitContainer.Panel2.BackgroundImage")));
            this.PM_SplitContainer.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PM_SplitContainer.Panel2.Controls.Add(this.PlayerMA_groupBox);
            this.PM_SplitContainer.Size = new System.Drawing.Size(365, 344);
            this.PM_SplitContainer.SplitterDistance = 52;
            this.PM_SplitContainer.TabIndex = 0;
            // 
            // PlayerNum_TextBox
            // 
            this.PlayerNum_TextBox.BackColor = System.Drawing.Color.SkyBlue;
            this.PlayerNum_TextBox.Location = new System.Drawing.Point(174, 17);
            this.PlayerNum_TextBox.Mask = "9";
            this.PlayerNum_TextBox.Name = "PlayerNum_TextBox";
            this.PlayerNum_TextBox.Size = new System.Drawing.Size(53, 21);
            this.PlayerNum_TextBox.TabIndex = 4;
            // 
            // Next_Button
            // 
            this.Next_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Next_Button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Next_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Next_Button.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Next_Button.ForeColor = System.Drawing.Color.Red;
            this.Next_Button.Location = new System.Drawing.Point(272, 11);
            this.Next_Button.Name = "Next_Button";
            this.Next_Button.Size = new System.Drawing.Size(75, 32);
            this.Next_Button.TabIndex = 3;
            this.Next_Button.Text = "NEXT";
            this.Next_Button.UseVisualStyleBackColor = true;
            this.Next_Button.Click += new System.EventHandler(this.Next_Button_Click);
            // 
            // label_1_4
            // 
            this.label_1_4.AutoSize = true;
            this.label_1_4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_1_4.Location = new System.Drawing.Point(11, 34);
            this.label_1_4.Name = "label_1_4";
            this.label_1_4.Size = new System.Drawing.Size(40, 12);
            this.label_1_4.TabIndex = 1;
            this.label_1_4.Text = "(1-4)";
            // 
            // PlayerNum_Label
            // 
            this.PlayerNum_Label.AutoSize = true;
            this.PlayerNum_Label.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PlayerNum_Label.Location = new System.Drawing.Point(5, 14);
            this.PlayerNum_Label.Name = "PlayerNum_Label";
            this.PlayerNum_Label.Size = new System.Drawing.Size(152, 16);
            this.PlayerNum_Label.TabIndex = 0;
            this.PlayerNum_Label.Text = "How many players";
            // 
            // PlayerMA_groupBox
            // 
            this.PlayerMA_groupBox.Controls.Add(this.Back_Button);
            this.PlayerMA_groupBox.Controls.Add(this.Start_Button);
            this.PlayerMA_groupBox.Controls.Add(this.PlayerNa_panel);
            this.PlayerMA_groupBox.Controls.Add(this.PlayerNa_Label);
            this.PlayerMA_groupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlayerMA_groupBox.Location = new System.Drawing.Point(0, 0);
            this.PlayerMA_groupBox.Name = "PlayerMA_groupBox";
            this.PlayerMA_groupBox.Size = new System.Drawing.Size(365, 288);
            this.PlayerMA_groupBox.TabIndex = 0;
            this.PlayerMA_groupBox.TabStop = false;
            this.PlayerMA_groupBox.Visible = false;
            // 
            // Back_Button
            // 
            this.Back_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Back_Button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Back_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back_Button.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Back_Button.ForeColor = System.Drawing.Color.Red;
            this.Back_Button.Location = new System.Drawing.Point(228, 248);
            this.Back_Button.Name = "Back_Button";
            this.Back_Button.Size = new System.Drawing.Size(125, 32);
            this.Back_Button.TabIndex = 5;
            this.Back_Button.Text = "BACK";
            this.Back_Button.UseVisualStyleBackColor = true;
            this.Back_Button.Click += new System.EventHandler(this.Back_Button_Click);
            // 
            // Start_Button
            // 
            this.Start_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Start_Button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Start_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Start_Button.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Start_Button.ForeColor = System.Drawing.Color.Red;
            this.Start_Button.Location = new System.Drawing.Point(13, 245);
            this.Start_Button.Name = "Start_Button";
            this.Start_Button.Size = new System.Drawing.Size(125, 32);
            this.Start_Button.TabIndex = 4;
            this.Start_Button.Text = "START";
            this.Start_Button.UseVisualStyleBackColor = true;
            this.Start_Button.Click += new System.EventHandler(this.Start_Button_Click);
            // 
            // PlayerNa_panel
            // 
            this.PlayerNa_panel.Location = new System.Drawing.Point(34, 46);
            this.PlayerNa_panel.Name = "PlayerNa_panel";
            this.PlayerNa_panel.Size = new System.Drawing.Size(300, 191);
            this.PlayerNa_panel.TabIndex = 2;
            // 
            // PlayerNa_Label
            // 
            this.PlayerNa_Label.AutoSize = true;
            this.PlayerNa_Label.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PlayerNa_Label.Location = new System.Drawing.Point(105, 17);
            this.PlayerNa_Label.Name = "PlayerNa_Label";
            this.PlayerNa_Label.Size = new System.Drawing.Size(170, 16);
            this.PlayerNa_Label.TabIndex = 1;
            this.PlayerNa_Label.Text = "Enter player names";
            // 
            // PlayerManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(365, 344);
            this.Controls.Add(this.PM_SplitContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PlayerManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.PM_SplitContainer.Panel1.ResumeLayout(false);
            this.PM_SplitContainer.Panel1.PerformLayout();
            this.PM_SplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PM_SplitContainer)).EndInit();
            this.PM_SplitContainer.ResumeLayout(false);
            this.PlayerMA_groupBox.ResumeLayout(false);
            this.PlayerMA_groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer PM_SplitContainer;
        private System.Windows.Forms.Label PlayerNum_Label;
        private System.Windows.Forms.Label label_1_4;
        private System.Windows.Forms.Button Next_Button;
        private System.Windows.Forms.MaskedTextBox PlayerNum_TextBox;
        private System.Windows.Forms.GroupBox PlayerMA_groupBox;
        private System.Windows.Forms.Label PlayerNa_Label;
        private System.Windows.Forms.Panel PlayerNa_panel;
        private System.Windows.Forms.Button Start_Button;
        private System.Windows.Forms.Button Back_Button;
    }
}