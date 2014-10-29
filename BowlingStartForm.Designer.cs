namespace Ours_Bowling
{
    partial class BowlingStartForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BowlingStartForm));
            this.Start_Label = new System.Windows.Forms.Label();
            this.Start_Button = new System.Windows.Forms.Button();
            this.Load_Button = new System.Windows.Forms.Button();
            this.HighScore_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Start_Label
            // 
            this.Start_Label.AutoSize = true;
            this.Start_Label.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Start_Label.Location = new System.Drawing.Point(91, 43);
            this.Start_Label.Name = "Start_Label";
            this.Start_Label.Size = new System.Drawing.Size(141, 19);
            this.Start_Label.TabIndex = 0;
            this.Start_Label.Text = "Bowling Game";
            // 
            // Start_Button
            // 
            this.Start_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Start_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Start_Button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Start_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Start_Button.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Start_Button.ForeColor = System.Drawing.Color.Red;
            this.Start_Button.Location = new System.Drawing.Point(56, 145);
            this.Start_Button.Name = "Start_Button";
            this.Start_Button.Size = new System.Drawing.Size(95, 40);
            this.Start_Button.TabIndex = 1;
            this.Start_Button.Text = "START";
            this.Start_Button.UseVisualStyleBackColor = true;
            this.Start_Button.Click += new System.EventHandler(this.Start_Button_Click);
            // 
            // Load_Button
            // 
            this.Load_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Load_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Load_Button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Load_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Load_Button.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Load_Button.ForeColor = System.Drawing.Color.Red;
            this.Load_Button.Location = new System.Drawing.Point(174, 145);
            this.Load_Button.Name = "Load_Button";
            this.Load_Button.Size = new System.Drawing.Size(95, 40);
            this.Load_Button.TabIndex = 2;
            this.Load_Button.Text = "LOAD";
            this.Load_Button.UseVisualStyleBackColor = true;
            this.Load_Button.Click += new System.EventHandler(this.Load_Button_Click);
            // 
            // HighScore_Button
            // 
            this.HighScore_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.HighScore_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HighScore_Button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.HighScore_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HighScore_Button.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.HighScore_Button.ForeColor = System.Drawing.Color.Red;
            this.HighScore_Button.Location = new System.Drawing.Point(102, 83);
            this.HighScore_Button.Name = "HighScore_Button";
            this.HighScore_Button.Size = new System.Drawing.Size(117, 28);
            this.HighScore_Button.TabIndex = 3;
            this.HighScore_Button.Text = "HIGH SCORE";
            this.HighScore_Button.UseVisualStyleBackColor = true;
            this.HighScore_Button.Click += new System.EventHandler(this.HighScore_Button_Click);
            // 
            // BowlingStartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(321, 203);
            this.Controls.Add(this.HighScore_Button);
            this.Controls.Add(this.Load_Button);
            this.Controls.Add(this.Start_Button);
            this.Controls.Add(this.Start_Label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BowlingStartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BowlingStartForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Start_Label;
        private System.Windows.Forms.Button Start_Button;
        private System.Windows.Forms.Button Load_Button;
        private System.Windows.Forms.Button HighScore_Button;
    }
}

