/***********************************************************************************************
 * Copyright @ 2014, Ours_Team
 * File name:   GameProgress.cs
 * Author:  longdao      Date:  2014-10-23
 * 
 * Description:    // Bowing game progress record,implement GameRecord class
 *                 
 * History:       //  
 * *********************************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Record;

namespace Ours_Bowling
{
    class GameProgress : GameRecord
    {

        //private static string m_gameRecord = string.Empty;// game process record
        private static GameRecord instance = null;      // Instance

        ///// <summary>
        ///// extern entry
        ///// </summary>

        //// GameRecord
        //public static string GameRecord
        //{
        //    get { return m_gameRecord; }
        //    set { m_gameRecord = value; }
        //}

        // GameProgress class Instance
        public static GameRecord GetInstance()
        {
            if (instance == null)
            {
                instance = new GameProgress();
            }
            return instance;
        }
    }
}
