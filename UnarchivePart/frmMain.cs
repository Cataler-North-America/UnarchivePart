using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Principal;

namespace UnarchivePart
{
    public partial class frmMain : Form
    {
        dsSCADATableAdapters.QueriesTableAdapter queries = new dsSCADATableAdapters.QueriesTableAdapter();
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnUnarchiveLot.Visible = false;
            btnUnarchivePart.Visible = false;
            btnFindPart.Visible = false;
            nudSubstId.Controls[0].Visible = false;
            nudSubstId.Text = "";
            nudVTLot.Controls[0].Visible = false;
            nudVTLot.Text = "";
        }

        private void btnUnarchiveLot_Click(object sender, EventArgs e)
        {
            queries.sp_UnarchiveLot(nudVTLot.Text, nudSubstId.Text);
            MessageBox.Show("Lot was unarchived. Resetting in case another needs unarchived.");
            clearEntry();
        }

        private void btnFindPart_Click(object sender, EventArgs e)
        {
            string lotNo = "";
            queries.sp_FindPartForUnarchive(nudVTLot.Text, nudSubstId.Text, ref lotNo);
            txtTableName.Text = lotNo;
            txtTableName.Visible = true;
            lblTableName.Visible = true;
            nudVTLot.Enabled = false;
            nudSubstId.Enabled = false;

            if (txtTableName.Text != "Part not in any archive")
            {
                WindowsIdentity myIdentity = WindowsIdentity.GetCurrent();
                WindowsPrincipal myPrincipal = new WindowsPrincipal(myIdentity);

                if (myPrincipal.IsInRole("IT Group"))
                {
                    btnUnarchiveLot.Visible = true;
                }
                btnUnarchivePart.Visible = true;
            }
            else
            {
                MessageBox.Show("Part does not exist in archives. Please reverify the info if you wish to try again.");
                clearEntry();
            }
        }

        private void btnUnarchivePart_Click(object sender, EventArgs e)
        {
            queries.usp_UnarchivePart(nudVTLot.Text, nudSubstId.Text);
            MessageBox.Show("Part was unarchived. Resetting in case another needs unarchived.");
            clearEntry();
        }

        private void nudSubstId_ValueChanged(object sender, EventArgs e)
        {
            if ((nudSubstId.Value == 10000000) || (nudVTLot.Value == 10000000))
            {
                return;
            }
            btnFindPart.Visible = true;
        }

        private void nudVTLot_ValueChanged(object sender, EventArgs e)
        {
            if ((nudSubstId.Value == 10000000) || (nudVTLot.Value == 10000000))
            {
                return;
            }
            btnFindPart.Visible = true;
        }

        private void clearEntry()
        {
            nudSubstId.Value = 10000000;
            nudSubstId.Text = "";
            nudSubstId.Enabled = true;
            nudVTLot.Value = 10000000;
            nudVTLot.Text = "";
            nudVTLot.Enabled = true;
            txtTableName.Clear();
            txtTableName.Visible = false;
            lblTableName.Visible = false;
            btnUnarchiveLot.Visible = false;
            btnUnarchivePart.Visible = false;
            btnFindPart.Visible = false;
            nudVTLot.Select();
        }
    }
}
