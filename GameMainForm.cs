/***********************************************************************************************
 * Copyright @ 2014, Ours_Team
 * File name:   GameMainForm.cs
 * Author:  longdao      Date:  2014-8-23
 * 
 * Description:    // Bowing game main UI
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
using System.Threading;

namespace Ours_Bowling
{
    public partial class GameMainForm : Form
    {
        private int m_gridCount = 0;                                          // cast time
        private TypeDef.timeScore m_totalScore = new TypeDef.timeScore();     // cast score
        private int m_playerTime = 1;                                         // the completed player number 
        bool mFlag = false;
        SpareForm sf=new SpareForm(); 


        public GameMainForm(bool flag)
        {
            InitializeComponent();
            mFlag = flag;
            InitData(flag);               // init data
        }

        /// <summary>
        /// Fuction:close main form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GameMainForm_FormClosed(object sender, FormClosedEventArgs e)
        { // program exit
            Application.Exit();
        }


        /// <summary>
        /// Fuction：Init data,get the player list
        /// </summary>
        private void InitData(bool flag=false)
        {
            // get and set the player list
            for (int i = 0; i < PlayerManagement.playInfo.Count; i++)
            {
                Label playerName = new Label();
                Label playerTb = new Label();
                playerName.Text = "Player " + (i + 1).ToString() + ":";
                
                TypeDef.playerStruc player=new TypeDef.playerStruc();
                PlayerManagement.playInfo.TryGetValue(i+1, out player);

                playerTb.Name = "Player " + (i + 1).ToString();
                playerTb.Text = player.playerName;
                if (flag)
                {
                    if (player.playerScore.Equals(0))
                    { playerTb.BackColor = Color.YellowGreen; }
                    else { ShowPlayerInfo(player, i + 1); this.m_playerTime = i + 2; }
                }
                else { playerTb.BackColor = Color.SkyBlue; } 
                playerTb.Width = Constants.TB_MAX_WIDTH*3/5;
                this.PlayerName_Panel.Controls.Add(playerName);
                this.PlayerName_Panel.Controls.Add(playerTb);
                playerName.Location = new Point(Constants.POS_X+Constants.POS_X_ADD, (i+1) * Constants.POS_Y*2/3);
                playerTb.Location = new Point(Constants.POS_X + Constants.POS_Y_ADD, (i+1) * Constants.POS_Y*2/3);
            }

            TypeDef.High_Score _highScore = new TypeDef.High_Score();
            string highScore = HighScore.GetInstance().GetRecord(Constants.HIGH_SCORE_PATH);
            if (!highScore.Equals(""))
            {
                string[] scores = highScore.Split('*');
                _highScore.highName = scores[0];
                _highScore.highName = scores[1];
                PlayerManagement.highScore = _highScore;
            }
        }

        /// <summary>
        /// Fuction:click the "STRIKE" button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void STRIKE_Button_Click(object sender, EventArgs e)
        {
            m_gridCount++;
            if (m_gridCount>10) return; // Total 10 Grids
            else{this.GameTextBox.Text += "  X|";}
            switch (m_gridCount)
            {
                case 1:
                    m_totalScore.time1Score.timeScore += 10;
                    m_totalScore.time1Score.timeCount = 2;
                    m_totalScore.time1Score.timeFlag = false; break;
                case 2:
                    if (!m_totalScore.time1Score.timeFlag)
                    {
                        if (2 == m_totalScore.time1Score.timeCount)
                        {m_totalScore.time1Score.timeScore += 10;
                         m_totalScore.time1Score.timeCount --;
                         m_totalScore.time1Score.timeFlag = false;}
                        else if (1 == m_totalScore.time1Score.timeCount)
                        {m_totalScore.time1Score.timeScore += 10;
                         m_totalScore.time1Score.timeCount--;
                         m_totalScore.time1Score.timeFlag = true;}
                    }
                    m_totalScore.time2Score.timeScore += 10;
                    m_totalScore.time2Score.timeCount = 2;
                    m_totalScore.time2Score.timeFlag=false;break;
                case 3:
                    if (!m_totalScore.time1Score.timeFlag && (1 == m_totalScore.time1Score.timeCount))
                    {
                        m_totalScore.time1Score.timeScore += 10;
                        m_totalScore.time1Score.timeCount--;
                        m_totalScore.time1Score.timeFlag = true;
                    }
                    if (!m_totalScore.time2Score.timeFlag)
                    {
                        if (2 == m_totalScore.time2Score.timeCount)
                        {m_totalScore.time2Score.timeScore += 10;
                        m_totalScore.time2Score.timeCount--;
                         m_totalScore.time2Score.timeFlag = false;}
                        else if (1 == m_totalScore.time2Score.timeCount)
                        {
                            m_totalScore.time2Score.timeScore += 10;
                            m_totalScore.time2Score.timeCount--;
                            m_totalScore.time2Score.timeFlag = true;
                        }
                    }
                    m_totalScore.time3Score.timeScore += 10;
                    m_totalScore.time3Score.timeCount = 2;
                    m_totalScore.time3Score.timeFlag = false;break;
                case 4:
                    if (!m_totalScore.time2Score.timeFlag && (1 == m_totalScore.time2Score.timeCount))
                    {
                        m_totalScore.time2Score.timeScore += 10;
                        m_totalScore.time2Score.timeCount--;
                        m_totalScore.time2Score.timeFlag = true;
                    }
                    if (!m_totalScore.time3Score.timeFlag)
                    {
                        if (2 == m_totalScore.time3Score.timeCount)
                        {
                            m_totalScore.time3Score.timeScore += 10;
                            m_totalScore.time3Score.timeCount--;
                            m_totalScore.time3Score.timeFlag = false;
                        }
                        else if (1 == m_totalScore.time3Score.timeCount)
                        {
                            m_totalScore.time3Score.timeScore += 10;
                            m_totalScore.time3Score.timeCount--;
                            m_totalScore.time3Score.timeFlag = true;
                        }
                    }
                    m_totalScore.time4Score.timeScore += 10;
                    m_totalScore.time4Score.timeCount = 2;
                    m_totalScore.time4Score.timeFlag = false;break;
                case 5:
                    if (!m_totalScore.time3Score.timeFlag && (1 == m_totalScore.time3Score.timeCount))
                    {
                        m_totalScore.time3Score.timeScore += 10;
                        m_totalScore.time3Score.timeCount--;
                        m_totalScore.time3Score.timeFlag = true;
                    }
                    if (!m_totalScore.time4Score.timeFlag)
                    {
                        if (2 == m_totalScore.time4Score.timeCount)
                        {
                            m_totalScore.time4Score.timeScore += 10;
                            m_totalScore.time4Score.timeCount--;
                            m_totalScore.time4Score.timeFlag = false;
                        }
                        else if (1 == m_totalScore.time4Score.timeCount)
                        {
                            m_totalScore.time4Score.timeScore += 10;
                            m_totalScore.time4Score.timeCount--;
                            m_totalScore.time4Score.timeFlag = true;
                        }
                    }
                    m_totalScore.time5Score.timeScore += 10;
                    m_totalScore.time5Score.timeCount = 2;
                    m_totalScore.time5Score.timeFlag = false;break;
                case 6:
                    if (!m_totalScore.time4Score.timeFlag && (1 == m_totalScore.time4Score.timeCount))
                    {
                        m_totalScore.time4Score.timeScore += 10;
                        m_totalScore.time4Score.timeCount--;
                        m_totalScore.time4Score.timeFlag = true;
                    }
                    if (!m_totalScore.time5Score.timeFlag)
                    {
                        if (2 == m_totalScore.time5Score.timeCount)
                        {
                            m_totalScore.time5Score.timeScore += 10;
                            m_totalScore.time5Score.timeCount--;
                            m_totalScore.time5Score.timeFlag = false;
                        }
                        else if (1 == m_totalScore.time5Score.timeCount)
                        {
                            m_totalScore.time5Score.timeScore += 10;
                            m_totalScore.time5Score.timeCount--;
                            m_totalScore.time5Score.timeFlag = true;
                        }
                    }
                    m_totalScore.time6Score.timeScore += 10;
                    m_totalScore.time6Score.timeCount = 2;
                    m_totalScore.time6Score.timeFlag = false;break;
                case 7:
                    if (!m_totalScore.time5Score.timeFlag && (1 == m_totalScore.time5Score.timeCount))
                    {
                        m_totalScore.time5Score.timeScore += 10;
                        m_totalScore.time5Score.timeCount--;
                        m_totalScore.time5Score.timeFlag = true;
                    }
                    if (!m_totalScore.time6Score.timeFlag)
                    {
                        if (2 == m_totalScore.time6Score.timeCount)
                        {
                            m_totalScore.time6Score.timeScore += 10;
                            m_totalScore.time6Score.timeCount--;
                            m_totalScore.time6Score.timeFlag = false;
                        }
                        else if (1 == m_totalScore.time6Score.timeCount)
                        {
                            m_totalScore.time6Score.timeScore += 10;
                            m_totalScore.time6Score.timeCount--;
                            m_totalScore.time6Score.timeFlag = true;
                        }
                    }
                    m_totalScore.time7Score.timeScore += 10;
                    m_totalScore.time7Score.timeCount=2;
                    m_totalScore.time7Score.timeFlag = false;break;
                case 8:
                    if (!m_totalScore.time6Score.timeFlag && (1 == m_totalScore.time6Score.timeCount))
                    {
                        m_totalScore.time6Score.timeScore += 10;
                        m_totalScore.time6Score.timeCount--;
                        m_totalScore.time6Score.timeFlag = true;
                    }
                    if (!m_totalScore.time7Score.timeFlag)
                    {
                        if (2 == m_totalScore.time7Score.timeCount)
                        {
                            m_totalScore.time7Score.timeScore += 10;
                            m_totalScore.time7Score.timeCount--;
                            m_totalScore.time7Score.timeFlag = false;
                        }
                        else if (1 == m_totalScore.time7Score.timeCount)
                        {
                            m_totalScore.time7Score.timeScore += 10;
                            m_totalScore.time7Score.timeCount--;
                            m_totalScore.time7Score.timeFlag = true;
                        }
                    }
                    m_totalScore.time8Score.timeScore += 10;
                    m_totalScore.time8Score.timeCount=2;
                    m_totalScore.time8Score.timeFlag = false;break;
                case 9:
                    if (!m_totalScore.time7Score.timeFlag && (1 == m_totalScore.time7Score.timeCount))
                    {
                        m_totalScore.time7Score.timeScore += 10;
                        m_totalScore.time7Score.timeCount--;
                        m_totalScore.time7Score.timeFlag = true;
                    }
                    if (!m_totalScore.time8Score.timeFlag)
                    {
                        if (2 == m_totalScore.time8Score.timeCount)
                        {
                            m_totalScore.time8Score.timeScore += 10;
                            m_totalScore.time8Score.timeCount--;
                            m_totalScore.time8Score.timeFlag = false;
                        }
                        else if (1 == m_totalScore.time8Score.timeCount)
                        {
                            m_totalScore.time8Score.timeScore += 10;
                            m_totalScore.time8Score.timeCount--;
                            m_totalScore.time8Score.timeFlag = true;
                        }
                    }
                    m_totalScore.time9Score.timeScore += 10;
                    m_totalScore.time9Score.timeCount=2;
                    m_totalScore.time9Score.timeFlag = false;break;
                case 10:
                    if (!m_totalScore.time8Score.timeFlag && (1 == m_totalScore.time8Score.timeCount))
                    {
                        m_totalScore.time8Score.timeScore += 10;
                        m_totalScore.time8Score.timeCount--;
                        m_totalScore.time8Score.timeFlag = true;
                    }
                    if (!m_totalScore.time9Score.timeFlag)
                    {
                        if (2 == m_totalScore.time9Score.timeCount)
                        {
                            m_totalScore.time9Score.timeScore += 20;
                            m_totalScore.time9Score.timeCount-=2;
                            m_totalScore.time9Score.timeFlag = false;
                        }
                        else if (1 == m_totalScore.time9Score.timeCount)
                        {
                            m_totalScore.time9Score.timeScore += 10;
                            m_totalScore.time9Score.timeCount--;
                            m_totalScore.time9Score.timeFlag = true;
                        }
                    }
                    m_totalScore.time10Score.timeScore += 10;
                    m_totalScore.time10Score.timeScore += 20;      // 后两次随机全中
                    m_totalScore.time10Score.timeCount=2;
                    m_totalScore.time10Score.timeFlag = true;
                    ScoreBoard();break;
                default:break;
            }
        }

        /// <summary>
        ///  record the ex player's score,
        ///  start the next record
        /// </summary>
        private void ScoreBoard()
        {
            int _totalScore = m_totalScore.time1Score.timeScore + m_totalScore.time2Score.timeScore +
                            m_totalScore.time3Score.timeScore + m_totalScore.time4Score.timeScore +
                            m_totalScore.time5Score.timeScore + m_totalScore.time6Score.timeScore +
                            m_totalScore.time7Score.timeScore + m_totalScore.time8Score.timeScore +
                            m_totalScore.time9Score.timeScore + m_totalScore.time10Score.timeScore;
            // record the current player's score
            TypeDef.playerStruc player = new TypeDef.playerStruc();
            if (PlayerManagement.playInfo.Count >= 1)
            { PlayerManagement.playInfo.TryGetValue(this.m_playerTime, out player); }
            player.playerScore = _totalScore;
            player.playerRecord=this.GameTextBox.Text.ToString();
            PlayerManagement.playInfo[this.m_playerTime] = player;

            // show the completed player's info
            ShowPlayerInfo(player,this.m_playerTime);

            // turn the next player
            this.m_gridCount = 0;    // next turn
            m_totalScore = new TypeDef.timeScore();
            this.m_playerTime += 1;
            if (PlayerManagement.playInfo.Count < this.m_playerTime)
            {
                this.GoBowing_Button.Enabled = false;
                this.STRIKE_Button.Enabled = false;
                this.SPARE_Button.Enabled = false;
                this.SaveButton.Enabled = true;
                this.returnButton.Enabled = true;
                this.ExitButton.Enabled = true;
                this.GameTextBox.Text = string.Empty;
                return;
            }
            foreach (Control conUnit in this.PlayerName_Panel.Controls)
            {
                if (conUnit is Label)
                {
                    conUnit.BackColor = Color.SkyBlue;
                    if (conUnit.Name.Equals("Player " + this.m_playerTime.ToString()))
                    { conUnit.BackColor = Color.YellowGreen; break; }
                }
            }
            this.GameTextBox.Text = string.Empty;
        }

        /// <summary>
        /// Fuction:Show Player Info
        /// </summary>
        /// <param name="player"></param>
        private void ShowPlayerInfo(TypeDef.playerStruc player, int m_playerTime)
        {
            Label playerName = new Label();
            playerName.Text = player.playerName;
            playerName.BackColor = Color.SkyBlue;
            Label playerRecord = new Label();
            playerRecord.Text = player.playerRecord;


            playerRecord.Width = Constants.MAX_WIDTH+50;
            playerRecord.BackColor = Color.SkyBlue;

            Label playerScore = new Label();
            playerScore.Text = player.playerScore.ToString();
            playerScore.BackColor = Color.SkyBlue;
            this.Score_Panel.Controls.Add(playerName);
            this.Score_Panel.Controls.Add(playerRecord);
            this.Score_Panel.Controls.Add(playerScore);
            playerName.Location = new Point(Constants.POS_X + Constants.POS_X_ADD, m_playerTime * Constants.POS_Y * 2 / 3);
            playerRecord.Location = new Point(Constants.POS_X + Constants.POS_Y_ADD, m_playerTime * Constants.POS_Y * 2 / 3);
            playerScore.Location = new Point(Constants.POS_X + Constants.POS_Y_ADD + playerRecord.Width, m_playerTime * Constants.POS_Y * 2 / 3);

            if (this.m_playerTime==PlayerManagement.playInfo.Count)
            {
                this.GoBowing_Button.Enabled = false;
                this.STRIKE_Button.Enabled = false;
                this.SPARE_Button.Enabled = false;
                this.SaveButton.Enabled = false;
                this.returnButton.Enabled = true;
                this.ExitButton.Enabled = true;
            }
        }


        /// <summary>
        /// Fuction:click the "GoBowing" button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GoBowing_Button_Click(object sender, EventArgs e)
        {
            if (!mFlag)
            {
                foreach (Control conUnit in this.PlayerName_Panel.Controls)
                {
                    if (conUnit is Label)
                    {
                        if (conUnit.Name.Equals("Player 1"))
                        { conUnit.BackColor = Color.YellowGreen; break; }
                    }
                }
            }


            // record the current player
            TypeDef.curPlayer currentPlayer=new TypeDef.curPlayer();
            currentPlayer.playerNo = 1;

            TypeDef.playerStruc player = new TypeDef.playerStruc();
            if (PlayerManagement.playInfo.Count>=1)
            {PlayerManagement.playInfo.TryGetValue(currentPlayer.playerNo, out player);}
            currentPlayer.playerName = player.playerName;
            PlayerManagement.curPlayer = currentPlayer;

            this.STRIKE_Button.Enabled = true;
            this.SPARE_Button.Enabled = true;
            this.SaveButton.Enabled = true;
            this.returnButton.Enabled = true;
            this.ExitButton.Enabled = true;
        }

        /// <summary>
        /// Fuction:click the "SPARE" button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SPARE_Button_Click(object sender, EventArgs e)
        {
            m_gridCount++;
            if (m_gridCount > 10) return;  // Total 10 Grids
            sf.ShowDialog();
            this.GameTextBox.Text += " "+PlayerManagement.SpareScore+"/|"; 
            switch (m_gridCount)
            {
                case 1:
                    m_totalScore.time1Score.timeScore += 10;
                    m_totalScore.time1Score.timeCount = 1; 
                    m_totalScore.time1Score.timeFlag = false; break;
                case 2:
                    if (!m_totalScore.time1Score.timeFlag)
                    {
                        if (2 == m_totalScore.time1Score.timeCount)
                        {
                            m_totalScore.time1Score.timeScore += PlayerManagement.SpareScore; // 
                            m_totalScore.time1Score.timeScore += 10;
                            m_totalScore.time1Score.timeCount-=2;
                            m_totalScore.time1Score.timeFlag = true;
                        }
                        else if (1 == m_totalScore.time1Score.timeCount)
                        {
                            m_totalScore.time1Score.timeScore += PlayerManagement.SpareScore; // 
                            m_totalScore.time1Score.timeCount--;
                            m_totalScore.time1Score.timeFlag = true;
                        }
                    }
                    m_totalScore.time2Score.timeScore += 10;
                    m_totalScore.time2Score.timeCount = 1;
                    m_totalScore.time2Score.timeFlag = false; break;
                case 3:
                    if (!m_totalScore.time2Score.timeFlag)
                    {
                        if (2 == m_totalScore.time2Score.timeCount)
                        {
                            m_totalScore.time2Score.timeScore += PlayerManagement.SpareScore; // 
                            m_totalScore.time2Score.timeScore += 10;
                            m_totalScore.time2Score.timeCount -= 2;
                            m_totalScore.time2Score.timeFlag = true;
                        }
                        else if (1 == m_totalScore.time2Score.timeCount)
                        {
                            m_totalScore.time2Score.timeScore += PlayerManagement.SpareScore; // 
                            m_totalScore.time2Score.timeCount--;
                            m_totalScore.time2Score.timeFlag = true;
                        }
                    }
                    m_totalScore.time3Score.timeScore += 10;
                    m_totalScore.time3Score.timeCount = 1;
                    m_totalScore.time3Score.timeFlag = false; break;
                case 4:
                    if (!m_totalScore.time3Score.timeFlag)
                    {
                        if (2 == m_totalScore.time3Score.timeCount)
                        {
                            m_totalScore.time3Score.timeScore += PlayerManagement.SpareScore; // 
                            m_totalScore.time3Score.timeScore += 10;
                            m_totalScore.time3Score.timeCount -= 2;
                            m_totalScore.time3Score.timeFlag = true;
                        }
                        else if (1 == m_totalScore.time3Score.timeCount)
                        {
                            m_totalScore.time3Score.timeScore += PlayerManagement.SpareScore; // 
                            m_totalScore.time3Score.timeCount--;
                            m_totalScore.time3Score.timeFlag = true;
                        }
                    }
                    m_totalScore.time4Score.timeScore += 10;
                    m_totalScore.time4Score.timeCount = 1;
                    m_totalScore.time4Score.timeFlag = false; break;
                case 5:
                    if (!m_totalScore.time4Score.timeFlag)
                    {
                        if (2 == m_totalScore.time4Score.timeCount)
                        {
                            m_totalScore.time4Score.timeScore += PlayerManagement.SpareScore; // 
                            m_totalScore.time4Score.timeScore += 10;
                            m_totalScore.time4Score.timeCount -= 2;
                            m_totalScore.time4Score.timeFlag = true;
                        }
                        else if (1 == m_totalScore.time4Score.timeCount)
                        {
                            m_totalScore.time4Score.timeScore += PlayerManagement.SpareScore; // 
                            m_totalScore.time4Score.timeCount--;
                            m_totalScore.time4Score.timeFlag = true;
                        }
                    }
                    m_totalScore.time5Score.timeScore += 10;
                    m_totalScore.time5Score.timeCount = 1;
                    m_totalScore.time5Score.timeFlag = false; break;
                case 6:
                    if (!m_totalScore.time5Score.timeFlag)
                    {
                        if (2 == m_totalScore.time5Score.timeCount)
                        {
                            m_totalScore.time5Score.timeScore += PlayerManagement.SpareScore; // 
                            m_totalScore.time5Score.timeScore += 10;
                            m_totalScore.time5Score.timeCount -= 2;
                            m_totalScore.time5Score.timeFlag = true;
                        }
                        else if (1 == m_totalScore.time5Score.timeCount)
                        {
                            m_totalScore.time5Score.timeScore += PlayerManagement.SpareScore; // 
                            m_totalScore.time5Score.timeCount--;
                            m_totalScore.time5Score.timeFlag = true;
                        }
                    }
                    m_totalScore.time6Score.timeScore += 10;
                    m_totalScore.time6Score.timeCount = 1;
                    m_totalScore.time6Score.timeFlag = false; break;
                case 7:
                    if (!m_totalScore.time6Score.timeFlag)
                    {
                        if (2 == m_totalScore.time6Score.timeCount)
                        {
                            m_totalScore.time6Score.timeScore += PlayerManagement.SpareScore; // 
                            m_totalScore.time6Score.timeScore += 10;
                            m_totalScore.time6Score.timeCount -= 2;
                            m_totalScore.time6Score.timeFlag = true;
                        }
                        else if (1 == m_totalScore.time6Score.timeCount)
                        {
                            m_totalScore.time6Score.timeScore += PlayerManagement.SpareScore; // 
                            m_totalScore.time6Score.timeCount--;
                            m_totalScore.time6Score.timeFlag = true;
                        }
                    }
                    m_totalScore.time7Score.timeScore += 10;
                    m_totalScore.time7Score.timeCount = 1;
                    m_totalScore.time7Score.timeFlag = false; break;
                case 8:
                    if (!m_totalScore.time7Score.timeFlag)
                    {
                        if (2 == m_totalScore.time7Score.timeCount)
                        {
                            m_totalScore.time7Score.timeScore += PlayerManagement.SpareScore; // 
                            m_totalScore.time7Score.timeScore += 10;
                            m_totalScore.time7Score.timeCount -= 2;
                            m_totalScore.time7Score.timeFlag = true;
                        }
                        else if (1 == m_totalScore.time7Score.timeCount)
                        {
                            m_totalScore.time7Score.timeScore += PlayerManagement.SpareScore; // 
                            m_totalScore.time7Score.timeCount--;
                            m_totalScore.time7Score.timeFlag = true;
                        }
                    }
                    m_totalScore.time8Score.timeScore += 10;
                    m_totalScore.time8Score.timeCount = 1;
                    m_totalScore.time8Score.timeFlag = false; break;
                case 9:
                    if (!m_totalScore.time8Score.timeFlag)
                    {
                        if (2 == m_totalScore.time8Score.timeCount)
                        {
                            m_totalScore.time8Score.timeScore += PlayerManagement.SpareScore; // 
                            m_totalScore.time8Score.timeScore += 10;
                            m_totalScore.time8Score.timeCount -= 2;
                            m_totalScore.time8Score.timeFlag = true;
                        }
                        else if (1 == m_totalScore.time8Score.timeCount)
                        {
                            m_totalScore.time8Score.timeScore += PlayerManagement.SpareScore; // 
                            m_totalScore.time8Score.timeCount--;
                            m_totalScore.time8Score.timeFlag = true;
                        }
                    }
                    m_totalScore.time9Score.timeScore += 10;
                    m_totalScore.time9Score.timeCount = 1;
                    m_totalScore.time9Score.timeFlag = false; break;
                case 10:
                    if (!m_totalScore.time9Score.timeFlag)
                    {
                        if (2 == m_totalScore.time9Score.timeCount)
                        {
                            m_totalScore.time9Score.timeScore += PlayerManagement.SpareScore; // 
                            m_totalScore.time9Score.timeScore += 10;
                            m_totalScore.time9Score.timeCount -= 2;
                            m_totalScore.time9Score.timeFlag = true;
                        }
                        else if (1 == m_totalScore.time9Score.timeCount)
                        {
                            m_totalScore.time9Score.timeScore += PlayerManagement.SpareScore; // 
                            m_totalScore.time9Score.timeCount--;
                            m_totalScore.time9Score.timeFlag = true;
                        }
                    }
                    m_totalScore.time10Score.timeScore += 10;
                    m_totalScore.time10Score.timeScore += 10;       // all
                    m_totalScore.time10Score.timeCount = 1;
                    m_totalScore.time10Score.timeFlag = true;ScoreBoard();break;
                default: break;
            }
        }


        /// <summary>
        /// Fuction:click the Exit button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        /// <summary>
        /// Fuction:click the return button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void returnButton_Click(object sender, EventArgs e)
        {
            PlayerManagement.playInfo.Clear();
            this.Hide();
            BowlingStartForm startForm = new BowlingStartForm();
            startForm.ShowDialog();
        }


        /// <summary>
        /// Fuction:save the game record
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveButton_Click(object sender, EventArgs e)
        {
            TypeDef.playerStruc player = new TypeDef.playerStruc();
            string record = string.Empty;
            for (int i = 0; i < PlayerManagement.playInfo.Count; i++)
            {
                if (PlayerManagement.playInfo.Count >= 1)
                { PlayerManagement.playInfo.TryGetValue(i + 1, out player); }
                record += "\r\n" + player.playerName + "*" + player.playerRecord + "*" + player.playerScore;
            }
            record += "\r\n\r\n";
            Thread twRecord = new Thread(WriteRecord);
            twRecord.Start(record);
            this.SaveButton.Enabled = false;
            this.SPARE_Button.Enabled = false;
            this.STRIKE_Button.Enabled = false;

            Thread twHighScore = new Thread(CountHighScore);
            twHighScore.Start(record);
        }

        /// <summary>
        /// Fuction:write the info into record
        /// </summary>
        /// <param name="record">record</param>
        private static void WriteRecord(object data)
        {
            string record=(string)data;
            if (GameProgress.GetInstance().SaveRecord(Constants.RECORD_PATH, record))
            { MessageBox.Show("save success"); }
            else
            { MessageBox.Show("save failed"); }
        }

        /// <summary>
        /// Fuction:count the high score and save
        /// </summary>
        /// <param name="data">record</param>
        private static void CountHighScore(object data)
        {
            HighScore.GetInstance().CountHighScore((string)data);
        }
    }
}
