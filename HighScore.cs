/***********************************************************************************************
 * Copyright @ 2014, Ours_Team
 * File name:   HighScore.cs
 * Author:  longdao      Date:  2014-10-23
 * 
 * Description:    // Bowing game high score record,implement GameRecord class
 *                 
 * History:       //  
 * *********************************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Record;
using PlayerInfo;

namespace Ours_Bowling
{
    class HighScore:GameRecord
    {
        private static HighScore instance = null;      // Instance

        // HighScore class Instance
        public static HighScore GetInstance()
        {
            if (instance == null)
            {
                instance = new HighScore();
            }
            return instance;
        }

        /// <summary>
        /// Fuction:count the high score
        /// </summary>
        /// <param name="record"></param>
        public void CountHighScore(string record)
        {
            TypeDef.High_Score highScore=new TypeDef.High_Score();
            string[] records = record.Split(new char[] { '\r', '\n'});
            for (int i = 0; i < records.Count();i++ )
            {
                if (!records[i].Equals(""))
                {
                    string[] items = records[i].Split('*');
                    highScore.highName = items[0];
                    highScore.highScore = Int32.Parse(items[2]);
                    if (PlayerManagement.highScore.highScore < highScore.highScore)
                    {
                        PlayerManagement.highScore=highScore;
                    }
                }
            }

            string HighScore=GetInstance().GetRecord(Constants.HIGH_SCORE_PATH);
            if (!HighScore.Equals(""))
            {
                string[] scoreContent = HighScore.Split('*');
                highScore.highName = scoreContent[0];
                highScore.highScore = Int32.Parse(scoreContent[1]);

                if (PlayerManagement.highScore.highScore < Int32.Parse(scoreContent[1]))
                {
                    PlayerManagement.highScore = highScore;
                }
            }
            string l_highScore = PlayerManagement.highScore.highName + "*" + PlayerManagement.highScore.highScore;
            GetInstance().ClearRecord(Constants.HIGH_SCORE_PATH);
            GetInstance().SaveRecord(Constants.HIGH_SCORE_PATH, l_highScore);
        }
    }
}
