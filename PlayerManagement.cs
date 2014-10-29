/***********************************************************************************************
 * Copyright @ 2014, Ours_Team
 * File name:   PlayerManagement.cs
 * Author:  longdao      Date:  2014-8-23
 * 
 * Description:    // Bowing game player management
 *                 
 * History:       //  
 * *********************************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using Ours_Bowling;

namespace PlayerInfo
{
    public static class PlayerManagement
    {
        /// <summary>
        /// save the players' info
        /// </summary>
        private static Dictionary<int, TypeDef.playerStruc> _playInfo = new Dictionary<int, TypeDef.playerStruc>();

        /// <summary>
        /// save the current player info
        /// </summary>
        private static TypeDef.curPlayer _curPlayer=new TypeDef.curPlayer();

        private static TypeDef.High_Score _highScore = new TypeDef.High_Score();

        public static Dictionary<int, TypeDef.playerStruc> playInfo
        {
            get { return _playInfo; }
            set { _playInfo = value; }
        }

        public static TypeDef.curPlayer curPlayer
        {
            get { return _curPlayer; }
            set { _curPlayer = value; }
        }

        public static TypeDef.High_Score highScore
        {
            get { return _highScore; }
            set { _highScore = value; }
        }

        public static int SpareScore = -1;

    }
}
