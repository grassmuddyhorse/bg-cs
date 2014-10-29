/***********************************************************************************************
 * Copyright @ 2014, Ours_Team
 * File name:   SpareForm.cs
 * Author:  longdao      Date:  2014-8-24
 * 
 * Description:    // edit the spare,the first time score
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
    public partial class SpareForm : Form
    {
        public SpareForm()
        {
            InitializeComponent();
            this.SparetextBox.LostFocus += new EventHandler(SparetextBox_LostFocus);
        }


        /// <summary>
        /// Fuction:the input lost focus
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void SparetextBox_LostFocus(object sender, EventArgs e)
        {
            int textContent=-1;
            if (!int.TryParse(this.SparetextBox.Text, out textContent))
            {
                this.SparetextBox.Text = string.Empty;
                return;
            }
            if (textContent < 0 || textContent>9)
            {
                this.SparetextBox.Text = string.Empty;
                return;
            }
        }

        /// <summary>
        /// Fuction:click the Ok button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void okButton_Click(object sender, EventArgs e)
        {
            if (!this.SparetextBox.Text.Equals(string.Empty))
            {
                PlayerManagement.SpareScore = Int32.Parse(this.SparetextBox.Text);
                this.Close();
            }
        }
    }
}
