﻿/******************************************************************************
 * Xicht - Visual CPU load monitoring tool                                    *
 * About form                                                                  *
 * Copyright (C) 2018 by Ralf Kilian                                          *
 * Distributed under the MIT License (https://opensource.org/licenses/MIT)    *
 *                                                                            *
 * GitHub: https://github.com/urbanware-org/xicht                             *
 ******************************************************************************/
 
using System;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;

namespace Xicht
{
    public partial class AboutForm : Form
    {

        #region Main form constructor and load event handler

        public AboutForm()
        {
            InitializeComponent();
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {
            var versionInfo = FileVersionInfo.GetVersionInfo(Assembly.GetEntryAssembly().Location);
            var copyright = versionInfo.LegalCopyright;

            lblCopyright.Text = copyright;
            lblVersion.Text = "Version " + versionInfo.FileVersion;
        }

        #endregion

        #region Close button

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Link related

        private void lnkLicense_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://opensource.org/licenses/MIT");
        }

        private void lnkReinchard_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.doomworld.com/profile/8949-reinchard");
        }

        #endregion

    }
}

/* EOF */
