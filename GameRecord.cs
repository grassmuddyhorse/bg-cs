/***********************************************************************************************
 * Copyright @ 2014, Ours_Team
 * File name:   GameRecord.cs
 * Author:  longdao      Date:  2014-8-23
 * 
 * Description:    // Bowing game record management,abstract class
 *                 
 * History:       //  
 * *********************************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Record
{
    abstract class GameRecord
    {
        /// <summary>
        ///  file path
        /// </summary>
        public string _recordPath = "GameRecord.txt";                // game record,contains players'playing info 
        public string _highScorePath = "HighScore.txt";              // high score record,contains high score info for top 4


        public string recordPath
        {
            get { return this._recordPath; }
            set { this._recordPath = value; }
        }


        public string highScorePath
        {
            get { return this._highScorePath; }
            set { this._highScorePath = value; }
        }

        /// <summary>
        /// Fuction:get game or high score record
        /// </summary>
        /// <returns></returns>
        virtual public string GetRecord(string path)
        {
            StreamReader recordReader = new StreamReader(path);
            string recordLine = string.Empty;
            recordLine = recordReader.ReadToEnd();
            recordReader.Close();
            return recordLine;
        }

        /// <summary>
        /// Fuction:save game or high score record
        /// </summary>
        /// <returns></returns>
        virtual public bool SaveRecord(string path, string game_record)
        {
            FileStream myStream = null;
            StreamWriter sWriter = null;
            try
            {
                myStream = new FileStream(path, FileMode.Append, FileAccess.Write);
                sWriter = new StreamWriter(myStream);
                sWriter.Write(game_record);
                sWriter.Close();
                myStream.Close();
                return true;
            }
            catch (System.Exception ex)
            {
                if (null != myStream) { myStream.Close(); }
                if (null != sWriter) { sWriter.Close(); }
                return false;	
            }
        }


        /// <summary>
        /// Fuction:get game record or high score,as lines
        /// </summary>
        /// <returns></returns>
        virtual public List<string> GetRecordLine(string path)
        {
            List<string> record_List = new List<string>();
            StreamReader recordReader = new StreamReader(path);
            string line = string.Empty;
            while ((line = recordReader.ReadLine()) != null)
            {
                record_List.Add(line);
            }
            recordReader.Close();
            return record_List;
        }

        /// <summary>
        /// Fuction:clear game or high score record
        /// </summary>
        /// <returns></returns>
        virtual public bool ClearRecord(string path)
        {
            FileStream myStream = null;
            StreamWriter sWriter = null;
            try
            {
                myStream = new FileStream(path, FileMode.Create, FileAccess.Write);
                sWriter = new StreamWriter(myStream);
                sWriter.WriteLine("");
                sWriter.Close();
                myStream.Close();
                return true;
            }
            catch (System.Exception ex)
            {
                if (null != myStream) { myStream.Close(); }
                if (null != sWriter) { sWriter.Close(); }
                return false;
            }

        }

    }
}
