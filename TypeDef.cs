/***********************************************************************************************
 * Copyright @ 2014, Ours_Team
 * File name:   TypeDef.cs
 * Author:  longdao      Date:  2014-10-16
 * 
 * Description:    // define the new type
 *                 
 * History:       //  
 * *********************************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ours_Bowling
{
    public class TypeDef
    {
        /// <summary>
        /// save player's info
        /// </summary>
        public struct playerStruc
        {
            public string playerName;
            public string playerRecord;
            public int playerScore;
        }

        /// <summary>
        /// save current player
        /// </summary>
        public struct curPlayer
        {
            public int playerNo;
            public string playerName;
            public int playerScore;
        }

        /// <summary>
        /// one time,
        /// player play score and flag 
        /// which identifies whether this time is complete,
        /// timeCount identifies the added score from where
        /// </summary>
        public struct TimeFlag
        {
            public int timeScore;
            public int timeCount;     
            public bool timeFlag;
        }

        /// <summary>
        /// player play time and score,toal 10 grids =10 times
        /// </summary>
        public struct timeScore
        {
            public TimeFlag time1Score;
            public TimeFlag time2Score;
            public TimeFlag time3Score;
            public TimeFlag time4Score;
            public TimeFlag time5Score;
            public TimeFlag time6Score;
            public TimeFlag time7Score;
            public TimeFlag time8Score;
            public TimeFlag time9Score;
            public TimeFlag time10Score;
        }

        /// <summary>
        /// player's high score
        /// </summary>
        public struct High_Score
        {
            public string highName;
            public int highScore;
        }
    }
}
