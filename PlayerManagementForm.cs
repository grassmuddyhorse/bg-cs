/***********************************************************************************************
 * Copyright @ 2014, Ours_Team
 * File name:   PlayerManagementForm.cs
 * Author:  longdao      Date:  2014-8-23
 * 
 * Description:    // Bowing game player management interface
 *                 
 * History:       //  
 * *********************************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ours_Bowling
{
    public partial class PlayerManagementForm : Form
    {
        public PlayerManagementForm()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Fuction:click the "LOAD"button,trigger the following events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Next_Button_Click(object sender, EventArgs e)
        {
            if (this.PlayerNum_TextBox.Text.ToString()=="")
            {
                return;
            }
            if ((Int32.Parse(this.PlayerNum_TextBox.Text.ToString())>4)
                ||(Int32.Parse(this.PlayerNum_TextBox.Text.ToString())<1))
            {
                return;
            }
            this.PlayerNum_TextBox.Enabled = false;
            this.Next_Button.Visible = false;
            this.PlayerMA_groupBox.Visible = true;
            this.PlayerNa_panel.Controls.Clear();

            // add control,edit players'info
            for (int i=0;i<(Int32.Parse(this.PlayerNum_TextBox.Text.ToString()));i++)
            {
                Label playerName = new Label();
                TextBox playerTb = new TextBox();
                playerName.Text = "Player "+(i+1).ToString()+":";
                playerTb.Name="Player "+(i+1).ToString();
                playerTb.BackColor = Color.SkyBlue;
                playerTb.MaxLength=Constants.TB_MAX_LEN;
                playerTb.Width = Constants.TB_MAX_WIDTH;
                this.PlayerNa_panel.Controls.Add(playerName);
                this.PlayerNa_panel.Controls.Add(playerTb);
                playerName.Location = new Point(Constants.POS_X+Constants.POS_X_ADD, (i)*Constants.POS_Y);
                playerTb.Location = new Point(Constants.POS_X+Constants.POS_Y_ADD, (i) * Constants.POS_Y);
            }

        }

        /// <summary>
        /// Fuction:the "START"button,trigger the following events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Start_Button_Click(object sender, EventArgs e)
        {
            // save players
            PlayerManagement.playInfo.Clear();
            for (int i = 0; i < (Int32.Parse(this.PlayerNum_TextBox.Text.ToString())); i++)
            {
                foreach(Control tb in this.PlayerNa_panel.Controls)
                {
                    if ((tb is TextBox))
                    {
                        if (!(tb.Text.Equals("")))
                        {
                            if (tb.Name.Equals(("Player " + (i + 1).ToString())))
                            {
                                PlayerManagement.playInfo.Add((i + 1), tb.Text);
                                break;
                            }
                        }
                        else
                        { // players'name is not null
                            Label hint = new Label();
                            hint.Width = Constants.TB_MAX_WIDTH * 2;
                            hint.Text = "players' name not null\r\n";
                            hint.ForeColor = Color.Red;
                            this.PlayerNa_panel.Controls.Add(hint);
                            hint.Location = new Point(Constants.POS_X + Constants.POS_Y_ADD * 2 / 3, 4 * Constants.POS_Y);
                            return;
                        }
                    }
                }
            }
        }


        /// <summary>
        ///  Fuction:the "BACK"button,trigger the following events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Back_Button_Click(object sender, EventArgs e)
        {
            this.PlayerNum_TextBox.Enabled = true;
            this.Next_Button.Visible = true;
            this.PlayerMA_groupBox.Visible = false;
        }
    }
}
