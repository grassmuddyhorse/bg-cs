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

namespace Ours_Bowling
{
    public static class PlayerManagement
    {
        /// <summary>
        /// save the players' info
        /// </summary>
        private static Dictionary<int,string> _playInfo=new Dictionary<int,string>();

        public static Dictionary<int, string> playInfo
        {
            get { return _playInfo; }
            set { _playInfo = value; }
        }

    }
}
