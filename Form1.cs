using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Diagnostics;

namespace Simple_GUI
{
    public partial class Form1 : Form
    {
        //Global Variables///////////////////////////////////////
        string sVideoName;          // name of file
        string sVideoPath;          // path of file
        string sVideoFolder;        // path of folder containing file

        string sSaveLoc;            // path of folder where output will be saved

        int iStartH, iStartM, iStartS, iStartMS;
        string sDuration;

        bool nonNumberEntered;

        ////////////////////////////////////////////////////////
        public Form1()
        {
            InitializeComponent();
        }

        ////////////////////////////////////////////////////////
        private void txtVideo_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = ofdVideo.ShowDialog();      // show the dialog

            if (dialogResult == DialogResult.OK || dialogResult == DialogResult.Yes)    // if a file has been selected
            {
                sVideoName = ofdVideo.SafeFileName;                 // name of file  e.g. awesomeMovie.mp4
                sVideoPath = ofdVideo.FileName;                     // path of file  e.g. c:\users\home\desktop\awesomeMovie.mp4
                sVideoFolder = sVideoPath.Replace(sVideoName, "");  // path of folder containing file e.g. c:\users\home\desktop\

                txtVideo.Text = sVideoName;                         // update content of textbox (visual feedback)
            }
        }

        ////////////////////////////////////////////////////////
        private void txtSaveLoc_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = fbdSaveLoc.ShowDialog();    // show the dialog

            if (dialogResult == DialogResult.OK || dialogResult == DialogResult.Yes)    // if a folder has been selected
            {
                sSaveLoc = fbdSaveLoc.SelectedPath + "\\";          // set selected path as save location of output
            }
            else
            {
                sSaveLoc = sVideoFolder;                            // else default to location of video
            }

            txtSaveLoc.Text = sSaveLoc;                             // update content of textbox (visual feedback)
        }

        ////////////////////////////////////////////////////////
        private void btnStart_Click(object sender, EventArgs e)
        {
            calcDuration();
        }

        ////////////////////////////////////////////////////////
        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (sSaveLoc != null)           // if a save location has been chosen,
            {
                Process.Start(sSaveLoc);    // open it
            }
        }

        ////////////////////////////////////////////////////////
        private void calcDuration()
        {
            int iStopH, iStopM, iStopS, iStopMS;
            int iStopTime, iStartTime;
            int iDuration;
            int iDurationH, iDurationM, iDurationS, iDurationMS;

            // Convert string to integer. If blank, set to zero

                //if (txtStopH.Text == null)                    
                if (string.IsNullOrEmpty(txtStopH.Text))        // check if string is empty
                {
                    iStopH = 0;                                 // if empty, set iStopH to zero
                }
                else
                {
                    iStopH = Convert.ToInt32(txtStopH.Text);    // else, convert string to integer and set as iStopH
                }

                iStopM = string.IsNullOrEmpty(txtStopM.Text) ? 0 : Convert.ToInt32(txtStopM.Text);
                iStopS = string.IsNullOrEmpty(txtStopS.Text) ? 0 : Convert.ToInt32(txtStopS.Text);
                iStopMS = string.IsNullOrEmpty(txtStopMS.Text) ? 0 : Convert.ToInt32(txtStopMS.Text);
                iStartH = string.IsNullOrEmpty(txtStartH.Text) ? 0 : Convert.ToInt32(txtStartH.Text);
                iStartM = string.IsNullOrEmpty(txtStartM.Text) ? 0 : Convert.ToInt32(txtStartM.Text);
                iStartS = string.IsNullOrEmpty(txtStartS.Text) ? 0 : Convert.ToInt32(txtStartS.Text);
                iStartMS = string.IsNullOrEmpty(txtStartMS.Text) ? 0 : Convert.ToInt32(txtStartMS.Text);

            // Convert stopTime and startTime to MS

                iStopTime = iStopH * 60 * 60 * 1000 +
                            iStopM * 60 * 1000 +
                            iStopS * 1000 +
                            iStopMS;

                iStartTime = iStartH * 60 * 60 * 1000 +
                                iStartM * 60 * 1000 +
                                iStartS * 1000 +
                                iStartMS;

            // Subtract to get duration (MS)
                iDuration = iStopTime - iStartTime;

            // Convert duration to H:M:S:MS format
                //Note: integer division rounds down (in C#). Which is ideal for our needs.

                int iRemainder = iDuration;                     // initialize

                iDurationH = iRemainder / (60 * 60 * 1000);     // get hours

                if (iDurationH != 0)
                {
                    iRemainder = iRemainder % iDurationH;
                }

                iDurationM = iRemainder / (60 * 1000);          // get minutes

                if (iDurationM != 0)
                {
                    iRemainder = iRemainder % iDurationM;
                }

                iDurationS = iRemainder / 1000;                 // get seconds

                if (iDurationS != 0)
                {
                    iRemainder = iRemainder % iDurationS;
                }

                iDurationMS = iRemainder;                       // get milliseconds

                //There is probably a more elegant way to do the above conversion

            // Convert iDuration into formatted string
                //Thankfully FFMPEG is not strict about 00:00:00.000 format,
                //otherwise would have to insert leading zeros accordingly
                sDuration = Convert.ToString(iDurationH) + ":" +
                            Convert.ToString(iDurationM) + ":" +
                            Convert.ToString(iDurationS) + "." +
                            Convert.ToString(iDurationMS);

            // Start extraction
                if ((txtVideo.Text != null) && (txtSaveLoc.Text != null) &&
                    (txtFps.Text != null) && (sDuration != null))
                {
                    extractFrames();                            // if no empty fieds, start
                }

        }

        ////////////////////////////////////////////////////////
        private void extractFrames()
        {
            // Concatenate various inputs into a string that we will pass to the commandline    
                //ffmpeg -ss 00:00:00 -t 00:01:00 -i "myVideo.mp4" -r 6 -f image2 "scene_%01d.png"

                string sStart = Convert.ToString(iStartH) + ":" +
                                Convert.ToString(iStartM) + ":" +
                                Convert.ToString(iStartS) + "." +
                                Convert.ToString(iStartMS);

                string sArgs = "-ss " + sStart + " -t " + sDuration + " -i \"" + sVideoPath + "\" -r " +
                                txtFps.Text + " -f image2 \"" + sSaveLoc + "frame_%01d.png\"";

            // Send to commandline
                Process.Start("ffmpeg.exe", sArgs);
        }

        ////////////////////////////////////////////////////////
        private void limitToDigits_kDown(KeyEventArgs e)
        {
            // Initialize the flag to false
            nonNumberEntered = false;

            // Determine whether the keystroke is a number from the top of the keyboard
            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                // Dertermine whether the keystroke is a number from the keypad
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                {
                    // Determine whether the keystroke is a backspace
                    if (e.KeyCode != Keys.Back)
                    {
                        // A non-numerical keystroke was pressed.
                        // Set the flag to true and evaluate in KeyPress event
                        nonNumberEntered = true;
                    }
                }
            }
            // If shift key was pressed, it's not a number
            if (Control.ModifierKeys == Keys.Shift)
            {
                nonNumberEntered = true;
            }
        }

        private void limitToDigits_kPress(KeyPressEventArgs e)
        {
            // Check for the flag being set in the keyDown event
            if (nonNumberEntered)
            {
                // Stop the character from being entered into the control since it is non-numerical
                e.Handled = true;
            }
        }

        ////////////////////////////////////////////////////////
        private void limitNumSize(TextBox myTextBox)
        {
            if (!(string.IsNullOrEmpty(myTextBox.Text)))        // if textbox is not empty,
            {
                if (Convert.ToInt32(myTextBox.Text) > 60)       // and if the value is greater than 60,
                {
                    myTextBox.Text = "";                        // set to blank
                }
            }
        }

        ////////////////////////////////////////////////////////
        // Limit to digits
        private void txtStartH_KeyDown(object sender, KeyEventArgs e)
        {
            limitToDigits_kDown(e);
        }
        private void txtStartH_KeyPress(object sender, KeyPressEventArgs e)
        {
            limitToDigits_kPress(e);
        }
        private void txtStartM_KeyDown(object sender, KeyEventArgs e)
        {
            limitToDigits_kDown(e);
        }
        private void txtStartM_KeyPress(object sender, KeyPressEventArgs e)
        {
            limitToDigits_kPress(e);
        }
        private void txtStartS_KeyDown(object sender, KeyEventArgs e)
        {
            limitToDigits_kDown(e);
        }
        private void txtStartS_KeyPress(object sender, KeyPressEventArgs e)
        {
            limitToDigits_kPress(e);
        }
        private void txtStartMS_KeyDown(object sender, KeyEventArgs e)
        {
            limitToDigits_kDown(e);
        }
        private void txtStartMS_KeyPress(object sender, KeyPressEventArgs e)
        {
            limitToDigits_kPress(e);
        }
        private void txtStopH_KeyDown(object sender, KeyEventArgs e)
        {
            limitToDigits_kDown(e);
        }
        private void txtStopH_KeyPress(object sender, KeyPressEventArgs e)
        {
            limitToDigits_kPress(e);
        }
        private void txtStopM_KeyDown(object sender, KeyEventArgs e)
        {
            limitToDigits_kDown(e);
        }
        private void txtStopM_KeyPress(object sender, KeyPressEventArgs e)
        {
            limitToDigits_kPress(e);
        }
        private void txtStopS_KeyDown(object sender, KeyEventArgs e)
        {
            limitToDigits_kDown(e);
        }
        private void txtStopS_KeyPress(object sender, KeyPressEventArgs e)
        {
            limitToDigits_kPress(e);
        }
        private void txtStopMS_KeyDown(object sender, KeyEventArgs e)
        {
            limitToDigits_kDown(e);
        }
        private void txtStopMS_KeyPress(object sender, KeyPressEventArgs e)
        {
            limitToDigits_kPress(e);
        }
        private void txtFps_KeyDown(object sender, KeyEventArgs e)
        {
            limitToDigits_kDown(e);
        }
        private void txtFps_KeyPress(object sender, KeyPressEventArgs e)
        {
            limitToDigits_kPress(e);
        }

        ////////////////////////////////////////////////////////
        // Limit number size
        private void txtStartM_Leave(object sender, EventArgs e)
        {
            limitNumSize(txtStartM);
        }
        private void txtStartS_Leave(object sender, EventArgs e)
        {
            limitNumSize(txtStartS);
        }
        private void txtStopM_Leave(object sender, EventArgs e)
        {
            limitNumSize(txtStopM);
        }
        private void txtStopS_Leave(object sender, EventArgs e)
        {
            limitNumSize(txtStopS);
        }

        ////////////////////////////////////////////////////////
        // SelectAll on click or enter

        private void txtStartH_Click(object sender, EventArgs e)
        {
            txtStartH.SelectAll();
        }
        private void txtStartH_Enter(object sender, EventArgs e)
        {
            txtStartH.SelectAll();
        }
        private void txtStartM_Click(object sender, EventArgs e)
        {
            txtStartM.SelectAll();
        }
        private void txtStartM_Enter(object sender, EventArgs e)
        {
            txtStartM.SelectAll();
        }
        private void txtStartS_Click(object sender, EventArgs e)
        {
            txtStartS.SelectAll();
        }
        private void txtStartS_Enter(object sender, EventArgs e)
        {
            txtStartS.SelectAll();
        }
        private void txtStartMS_Click(object sender, EventArgs e)
        {
            txtStartMS.SelectAll();
        }
        private void txtStartMS_Enter(object sender, EventArgs e)
        {
            txtStartMS.SelectAll();
        }
        private void txtStopH_Click(object sender, EventArgs e)
        {
            txtStopH.SelectAll();
        }
        private void txtStopH_Enter(object sender, EventArgs e)
        {
            txtStopH.SelectAll();
        }
        private void txtStopM_Click(object sender, EventArgs e)
        {
            txtStopM.SelectAll();
        }
        private void txtStopM_Enter(object sender, EventArgs e)
        {
            txtStopM.SelectAll();
        }
        private void txtStopS_Click(object sender, EventArgs e)
        {
            txtStopS.SelectAll();
        }
        private void txtStopS_Enter(object sender, EventArgs e)
        {
            txtStopS.SelectAll();
        }
        private void txtStopMS_Click(object sender, EventArgs e)
        {
            txtStopMS.SelectAll();
        }
        private void txtStopMS_Enter(object sender, EventArgs e)
        {
            txtStopMS.SelectAll();
        }
        private void txtFps_Click(object sender, EventArgs e)
        {
            txtFps.SelectAll();
        }
        private void txtFps_Enter(object sender, EventArgs e)
        {
            txtFps.SelectAll();
        }



    } //end class
}// end namespace
