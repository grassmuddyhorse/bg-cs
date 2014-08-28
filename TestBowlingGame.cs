/***********************************************************************************************
 * Copyright @ 2014, Ours_Team
 * File name:   TestBowlingGame.cs
 * Author:  longdao      Date:  2014-8-25
 * 
 * Description:    // test the class
 *                 
 * History:       //  
 * *********************************************************************************************/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;


namespace Ours_Bowling
{
    [TestFixture]
    class TestBowlingGame
    {
        [Test]
        public void TestGameRecord()
        {
            try
            {
                GameRecord gRecord = new GameRecord();
                Assert.AreEqual("Jam 1", gRecord.GetRecord(gRecord._recordPath));
            }
            catch (Exception ex)
            {
                Assert.Fail();
            }
        }
    }
}
