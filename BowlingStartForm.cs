/***********************************************************************************************
 * Copyright @ 2014, Ours_Team
 * File name:   BowlingStartForm.cs
 * Author:  longdao      Date:  2014-8-23
 * 
 * Description:    // Bowing game starting interface
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
    public partial class BowlingStartForm : Form
    {
        PlayerManagementForm playerMa = null;

        public BowlingStartForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Fuction:click the "START"button,trigger the following events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Start_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            playerMa = new PlayerManagementForm();
            playerMa.ShowDialog();
        }


        /// <summary>
        /// Fuction:click the "LOAD"button,trigger the following events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Load_Button_Click(object sender, EventArgs e)
        {
            // read the game score
        }


        /// <summary>
        /// Fuction:click the "HIGH SCORE"button,trigger the following events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HighScore_Button_Click(object sender, EventArgs e)
        {
            // read the high score
        }
    }
}
