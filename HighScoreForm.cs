/***********************************************************************************************
 * Copyright @ 2014, Ours_Team
 * File name:   HighScoreForm.cs
 * Author:  longdao      Date:  2014-10-23
 * 
 * Description:    // high score interface
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
    public partial class HighScoreForm : Form
    {
        public HighScoreForm()
        {
            InitializeComponent();
            InitData();
        }


        /// <summary>
        /// Fuction:init high score data
        /// </summary>
        private void InitData()
        {
            string highScore = HighScore.GetInstance().GetRecord(Constants.HIGH_SCORE_PATH);
            if (!highScore.Equals(""))
            {
                string[] scores = highScore.Split('*');
                string showItem = scores[0] + "  :  "+scores[1];
                this.highScoreLabel.Text = showItem;
            }

        }
    }
}
