namespace Ours_Bowling
{
    partial class GameMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameMainForm));
            this.PlayerName_Panel = new System.Windows.Forms.Panel();
            this.Player_Label = new System.Windows.Forms.Label();
            this.Score_Panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.GameEffectPanel = new System.Windows.Forms.Panel();
            this.GameTextBox = new System.Windows.Forms.TextBox();
            this.GameLabel = new System.Windows.Forms.Label();
            this.GoBowing_Button = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.STRIKE_Button = new System.Windows.Forms.Button();
            this.SPARE_Button = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            this.PlayerName_Panel.SuspendLayout();
            this.Score_Panel.SuspendLayout();
            this.GameEffectPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PlayerName_Panel
            // 
            this.PlayerName_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PlayerName_Panel.Controls.Add(this.Player_Label);
            this.PlayerName_Panel.Location = new System.Drawing.Point(2, 1);
            this.PlayerName_Panel.Name = "PlayerName_Panel";
            this.PlayerName_Panel.Size = new System.Drawing.Size(223, 197);
            this.PlayerName_Panel.TabIndex = 0;
            // 
            // Player_Label
            // 
            this.Player_Label.AutoSize = true;
            this.Player_Label.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Player_Label.Location = new System.Drawing.Point(4, 4);
            this.Player_Label.Name = "Player_Label";
            this.Player_Label.Size = new System.Drawing.Size(82, 12);
            this.Player_Label.TabIndex = 0;
            this.Player_Label.Text = "Player List";
            // 
            // Score_Panel
            // 
            this.Score_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Score_Panel.Controls.Add(this.label1);
            this.Score_Panel.Location = new System.Drawing.Point(227, 1);
            this.Score_Panel.Name = "Score_Panel";
            this.Score_Panel.Size = new System.Drawing.Size(452, 197);
            this.Score_Panel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Score";
            // 
            // GameEffectPanel
            // 
            this.GameEffectPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GameEffectPanel.Controls.Add(this.GameTextBox);
            this.GameEffectPanel.Controls.Add(this.GameLabel);
            this.GameEffectPanel.Location = new System.Drawing.Point(2, 200);
            this.GameEffectPanel.Name = "GameEffectPanel";
            this.GameEffectPanel.Size = new System.Drawing.Size(677, 179);
            this.GameEffectPanel.TabIndex = 2;
            // 
            // GameTextBox
            // 
            this.GameTextBox.BackColor = System.Drawing.Color.SkyBlue;
            this.GameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GameTextBox.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GameTextBox.Location = new System.Drawing.Point(6, 32);
            this.GameTextBox.Name = "GameTextBox";
            this.GameTextBox.ReadOnly = true;
            this.GameTextBox.Size = new System.Drawing.Size(381, 23);
            this.GameTextBox.TabIndex = 1;
            // 
            // GameLabel
            // 
            this.GameLabel.AutoSize = true;
            this.GameLabel.Location = new System.Drawing.Point(4, 4);
            this.GameLabel.Name = "GameLabel";
            this.GameLabel.Size = new System.Drawing.Size(95, 12);
            this.GameLabel.TabIndex = 0;
            this.GameLabel.Text = "Total Ten Grids";
            // 
            // GoBowing_Button
            // 
            this.GoBowing_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GoBowing_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoBowing_Button.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GoBowing_Button.Location = new System.Drawing.Point(31, 383);
            this.GoBowing_Button.Name = "GoBowing_Button";
            this.GoBowing_Button.Size = new System.Drawing.Size(84, 23);
            this.GoBowing_Button.TabIndex = 3;
            this.GoBowing_Button.Text = "Go Bowing";
            this.GoBowing_Button.UseVisualStyleBackColor = true;
            this.GoBowing_Button.Click += new System.EventHandler(this.GoBowing_Button_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveButton.Enabled = false;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SaveButton.Location = new System.Drawing.Point(356, 383);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(84, 23);
            this.SaveButton.TabIndex = 4;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.Enabled = false;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ExitButton.Location = new System.Drawing.Point(568, 383);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(84, 23);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // STRIKE_Button
            // 
            this.STRIKE_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.STRIKE_Button.Enabled = false;
            this.STRIKE_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.STRIKE_Button.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.STRIKE_Button.Location = new System.Drawing.Point(138, 383);
            this.STRIKE_Button.Name = "STRIKE_Button";
            this.STRIKE_Button.Size = new System.Drawing.Size(84, 23);
            this.STRIKE_Button.TabIndex = 6;
            this.STRIKE_Button.Text = "STRIKE";
            this.STRIKE_Button.UseVisualStyleBackColor = true;
            this.STRIKE_Button.Click += new System.EventHandler(this.STRIKE_Button_Click);
            // 
            // SPARE_Button
            // 
            this.SPARE_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SPARE_Button.Enabled = false;
            this.SPARE_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SPARE_Button.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SPARE_Button.Location = new System.Drawing.Point(248, 383);
            this.SPARE_Button.Name = "SPARE_Button";
            this.SPARE_Button.Size = new System.Drawing.Size(84, 23);
            this.SPARE_Button.TabIndex = 7;
            this.SPARE_Button.Text = "SPARE";
            this.SPARE_Button.UseVisualStyleBackColor = true;
            this.SPARE_Button.Click += new System.EventHandler(this.SPARE_Button_Click);
            // 
            // returnButton
            // 
            this.returnButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.returnButton.Enabled = false;
            this.returnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnButton.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.returnButton.Location = new System.Drawing.Point(462, 383);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(84, 23);
            this.returnButton.TabIndex = 8;
            this.returnButton.Text = "Return";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // GameMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(682, 410);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.SPARE_Button);
            this.Controls.Add(this.STRIKE_Button);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.GoBowing_Button);
            this.Controls.Add(this.GameEffectPanel);
            this.Controls.Add(this.Score_Panel);
            this.Controls.Add(this.PlayerName_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GameMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BowlingGame";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GameMainForm_FormClosed);
            this.PlayerName_Panel.ResumeLayout(false);
            this.PlayerName_Panel.PerformLayout();
            this.Score_Panel.ResumeLayout(false);
            this.Score_Panel.PerformLayout();
            this.GameEffectPanel.ResumeLayout(false);
            this.GameEffectPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PlayerName_Panel;
        private System.Windows.Forms.Panel Score_Panel;
        private System.Windows.Forms.Panel GameEffectPanel;
        private System.Windows.Forms.Label Player_Label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button GoBowing_Button;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button STRIKE_Button;
        private System.Windows.Forms.Button SPARE_Button;
        private System.Windows.Forms.Label GameLabel;
        private System.Windows.Forms.TextBox GameTextBox;
        private System.Windows.Forms.Button returnButton;

    }
}