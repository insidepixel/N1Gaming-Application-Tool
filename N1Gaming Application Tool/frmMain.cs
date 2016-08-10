using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N1Gaming_Application_Tool
{
    public partial class frmMain : Form
    {
        //Variables for user info
        private string username;
        private string TSID;
        private string applicationLink;

        //Variables for posts made in the user's application thread
        private string acceptedString;
        private string declinedString;
        private string trialString;

        //Variables for feedback thread
        private string feedbackTitle;
        private string feedbackContent;

        //Some slightly more complicated variables, used mostly for internal stuff
        private string tsIP = "ts.n1gaming.net";
        private Dictionary<int, string> declineReasons = new Dictionary<int, string>();
        private Dictionary<int, string> sectionInterviewStrings = new Dictionary<int, string>();
        private int reason = 0;
        private DateTime date;

        public frmMain()
        {
            InitializeComponent();
        }

        private void updateTextBoxes()
        {
            updateAcceptedString();
            updateDeclinedString();
            updateFeedbackTitle();
            updateFeedbackContent();
            updateTrialString();
        }

        private void updateAcceptedString()
        {
            acceptedString = string.Format("Hi there {0}! I'm happy to announce that your application to join N1Gaming has been accepted.\r\n\r\nPlease join us on Teamspeak at {1} so that we can continue with your application.\r\n\r\nIf you connect to our server and join one of the waiting rooms (located just below the main lobby) the first available staff member will be able to help you.\r\n\r\nWe look forward to hearing from you :)", username, tsIP);
            tbAccepted.Text = acceptedString;
        }

        private void updateDeclinedString()
        {
            declinedString = string.Format("Hi there {0}!\r\n\r\nUnfortunately I'm going to have to decline your application as {1}", username, declineReasons[reason]);
            tbDeclined.Text = declinedString;
        }

        private void updateTrialString()
        {
            trialString = string.Format("Hi there {0}!\r\n\r\nWe spoke on Teamspeak earlier and your application has been finalised. Your trial begins on {1} and ends on {2}.\r\n\r\nWelcome to N1Gaming, we hope you enjoy your time with us!", username, date.ToShortDateString(), date.AddDays(14).ToShortDateString());
            tbTrial.Text = trialString;
        }

        private void updateFeedbackTitle()
        {
            feedbackTitle = string.Format("{0} feedback {1} - {2}", username, date.ToShortDateString(), date.AddDays(14).ToShortDateString());
            tbFeedbackTitle.Text = feedbackTitle;
        }

        private void updateFeedbackContent()
        {
            feedbackContent = string.Format("Username: {0}\r\nTeamspeak3 ID: {1}\r\nLink to application: {2}\r\n\r\nThis is the feedback thread for {0}. Please give +1 or -1 feedback in this thread.\r\nRemember that you must give a reason for your feedback and your feedback must be personality based, not skill based.", username, TSID, applicationLink);
            tbFeedbackContent.Text = feedbackContent;
        }

        private void cbDeclined_SelectedIndexChanged(object sender, EventArgs e)
        {
            reason = cbDeclined.SelectedIndex;
            updateDeclinedString();
        }

        private void tbTSID_TextChanged(object sender, EventArgs e)
        {
            TSID = tbTSID.Text;
            updateTextBoxes();
        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {
            username = tbUsername.Text;
            updateTextBoxes();
        }

        private void tbApplicationLink_TextChanged(object sender, EventArgs e)
        {
            applicationLink = tbApplicationLink.Text;
            updateTextBoxes();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            declineReasons.Add(0, "you're below the age limit required to join N1Gaming. Feel free to reapply when you turn 15. Hopefully we'll hear from you soon!");
            declineReasons.Add(1, "you've been previously banned from our community. Please contact an administrator if you wish to appeal your ban.");
            declineReasons.Add(2, "your forum name has been deemed inappropriate for our community. Please contact an administrator if you wish to have it changed so that you can reapply.");
            date = DateTime.UtcNow;
            updateTextBoxes();
            sectionInterviewStrings.Add(0, "- Make sure that they've read the section rules.\r\n- Invite them to the N1Gaming steam group.\r\n- Take them over the CS:GO channels, explaining what they're for including that they should be in AFK if they're not there.\r\n- Explain what a ten man game is, ensure they've read the rules on them.");
            sectionInterviewStrings.Add(1, "- Make sure that they've read the section rules.\r\n- Invite them to the N1Gaming League of Legends Club.\r\n- Take them over the CS:GO channels, explaining what they're for including that they should be in AFK if they're not there.\r\n- If the club is full, let them know that we use a chat room (N1GamingLeagueEUW) to communicate.\r\n- Remind them that the chat room name is not to be given out to non-members.");
            sectionInterviewStrings.Add(2, "- Please contact Roast on the forums to get this section sorted.");
            sectionInterviewStrings.Add(3, "- Please contact Roast on the forums to get this section sorted.");
            cbDeclined.SelectedIndex = 0;
            cbInterview.SelectedIndex = 0;
        }

        private void changelogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f is frmChangelog)
                {
                    f.Focus();
                    return;
                }
            }
            new frmChangelog().Show();
        }

        private void tbMouseEnter(object sender, EventArgs e)
        {
            RichTextBox s = (RichTextBox)sender;
            s.SelectAll();
            s.Focus();
        }

        private void cbInterview_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbInterviewSpecific.Text = sectionInterviewStrings[cbInterview.SelectedIndex];
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f is frmChangelog)
                {
                    f.Focus();
                    return;
                }
            }
            new frmChangelog().Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
