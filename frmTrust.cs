using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiblePayTrustGenerator
{
    public partial class frmTrust : Form
    {
        public frmTrust()
        {
            InitializeComponent();
        }

        private void btnGenerateTrust_Click(object sender, EventArgs e)
        {
            DateTime dtInception = Convert.ToDateTime("1-1-2021");
            if (DateTime.Compare(dtMaturityDate.Value, dtInception) < 0)
            {
                MessageBox.Show("Sorry, the Maturity Date must be after Jan 1, 2021");
                return;
            }
            DateTime dtMax = Convert.ToDateTime("1-1-2078");
            if (DateTime.Compare(dtMaturityDate.Value, dtMax) > 0)
            {
                MessageBox.Show("Sorry, the Maturity Date must be before Jan 1, 2078");
                return;
            }
            timer1.Enabled = true;
            progressBar1.Value = 0;
            txtPrivKey.Text = "";
            txtPubKey.Text = "";
            progressBar1.Visible = true;

            bool fValid = Trust.SearchForHODL(chkTestNet.Checked, dtMaturityDate.Value.Month, dtMaturityDate.Value.Year);
            progressBar1.Value = 0;
            timer1.Enabled = false;

            txtPrivKey.Text = Trust.sPrivKey;
            txtPubKey.Text = Trust.sPubKey;
            progressBar1.Visible = false;
        }

        private void btnSaveToFile_Click(object sender, EventArgs e)
        {
            if (txtPrivKey.Text == "")
            {
                MessageBox.Show("Sorry, you must generate a trust first.");
                return;
            }
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                string sFN = "trust_" + txtPubKey.Text + ".txt";
                string sPath = System.IO.Path.Combine(folderDlg.SelectedPath, sFN);
                string sData = frmTrust.ActiveForm.Text + "\r\n";
                sData += "(Elapsed " + Trust.nSeconds.ToString() + "s, Work: " + Trust.nTries.ToString() + ")\r\n\r\n";
                sData += "Public Key: " + txtPubKey.Text + "\r\nPrivate Key: " + txtPrivKey.Text + "\r\n";
                long nHODL = Trust.IsHODLAddress(txtPubKey.Text);
                sData += "Maturity Date: " + Trust.ConvertUnixTimeStampToDateTime(nHODL).ToShortDateString() + "\r\n";
                
                string sNotes = "To redeem the trust, after the maturity date passes, from biblepay core wallet, from the RPC console, type: importprivkey private_key.";
                sNotes += "\r\nTo find your trust balance, navigate here:  https://chainz.cryptoid.info/bbp/    then type your Public Key into the Search Address field.\r\n";
                sNotes += "\r\nTo send your trust to the recipient:  (It is not recommended to E-mail the trust, due to potential intercept, but if it is a small amount you may consider storing the trust file in a password protected zip file then e-mailing it.) \r\n ";
                sNotes += "\r\nYou may also save the trust file to a flash drive and physically mail it to the recipient.";
                sNotes += "\r\n!IMPORTANT!  Please Back Up your trust file before you fund it!  Once this program is closed, the keys will not be stored anywhere else, except the trust file!\r\n";
                sNotes += "\r\nFor more information about Trusts, visit this page: " + Trust.msWikiPage;
                sData += "\r\n\r\n" + sNotes;

                System.IO.File.WriteAllText(sPath, sData);
                MessageBox.Show("Your trust has been saved to: " + sPath + " \r\nThank you for using BiblePay!");
            }
            // Todo:  Add ability to generate a password protected zip file that can be e-mailed to the recipient.

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.Value += 1;
            }
        }

        private void frmTrust_Load(object sender, EventArgs e)
        {
            lblInfo.Text = "** For help and information, please visit this page: ";
            lnkInfo.Text = Trust.msWikiPage;
        }

        private void lnkInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(lnkInfo.Text);
        }
    }
}
