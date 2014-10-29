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
using PlayerInfo;

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
            List<string> recordList=GameProgress.GetInstance().GetRecordLine(Constants.RECORD_PATH);
            if (recordList.Count<=0)
            {
                MessageBox.Show("no record");
                return;
            }

            TypeDef.playerStruc player = new TypeDef.playerStruc();
            int lineNu=0,key = 0;
            for (int i = recordList.Count-1; i >= 0; i--)
            {
                string record=recordList[i];
                if (record.Equals("") && i != (recordList.Count - 1))
                { lineNu = i; break; }  // locate the latest record
            }

            while (lineNu<recordList.Count-1)
            {
                string line = recordList[++lineNu];
                if (!line.Equals(""))
                {
                    string[] items = line.Split('*');
                    player.playerName = items[0];
                    player.playerRecord = items[1];
                    player.playerScore = Int32.Parse(items[2]);
                    PlayerManagement.playInfo.Add(++key, player);
                }
            }
            this.Visible = false;
            GameMainForm gMain = new GameMainForm(true);
            gMain.ShowDialog();
        }


        /// <summary>
        /// Fuction:click the "HIGH SCORE"button,trigger the following events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HighScore_Button_Click(object sender, EventArgs e)
        {
            // read the high score
            HighScoreForm highForm = new HighScoreForm();
            highForm.ShowDialog();
        }


        /// <summary>
        /// Fuction:click the CLOSE button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BowlingStartForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
