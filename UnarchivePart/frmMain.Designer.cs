namespace UnarchivePart
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnUnarchiveLot = new System.Windows.Forms.Button();
            this.btnUnarchivePart = new System.Windows.Forms.Button();
            this.btnFindPart = new System.Windows.Forms.Button();
            this.lblInformation = new System.Windows.Forms.Label();
            this.lblVTLot = new System.Windows.Forms.Label();
            this.lblSubstId = new System.Windows.Forms.Label();
            this.lblTableName = new System.Windows.Forms.Label();
            this.nudVTLot = new System.Windows.Forms.NumericUpDown();
            this.nudSubstId = new System.Windows.Forms.NumericUpDown();
            this.txtTableName = new System.Windows.Forms.TextBox();
            this.btnHidden = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudVTLot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSubstId)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUnarchiveLot
            // 
            this.btnUnarchiveLot.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUnarchiveLot.ForeColor = System.Drawing.Color.Black;
            this.btnUnarchiveLot.Location = new System.Drawing.Point(286, 408);
            this.btnUnarchiveLot.Name = "btnUnarchiveLot";
            this.btnUnarchiveLot.Size = new System.Drawing.Size(184, 53);
            this.btnUnarchiveLot.TabIndex = 0;
            this.btnUnarchiveLot.Text = "Unarchive Lot";
            this.btnUnarchiveLot.UseVisualStyleBackColor = false;
            this.btnUnarchiveLot.Click += new System.EventHandler(this.btnUnarchiveLot_Click);
            // 
            // btnUnarchivePart
            // 
            this.btnUnarchivePart.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUnarchivePart.ForeColor = System.Drawing.Color.Black;
            this.btnUnarchivePart.Location = new System.Drawing.Point(609, 408);
            this.btnUnarchivePart.Name = "btnUnarchivePart";
            this.btnUnarchivePart.Size = new System.Drawing.Size(184, 53);
            this.btnUnarchivePart.TabIndex = 1;
            this.btnUnarchivePart.Text = "Unarchive Part";
            this.btnUnarchivePart.UseVisualStyleBackColor = false;
            this.btnUnarchivePart.Click += new System.EventHandler(this.btnUnarchivePart_Click);
            // 
            // btnFindPart
            // 
            this.btnFindPart.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFindPart.ForeColor = System.Drawing.Color.Black;
            this.btnFindPart.Location = new System.Drawing.Point(510, 271);
            this.btnFindPart.Name = "btnFindPart";
            this.btnFindPart.Size = new System.Drawing.Size(184, 53);
            this.btnFindPart.TabIndex = 2;
            this.btnFindPart.Text = "Database Lookup";
            this.btnFindPart.UseVisualStyleBackColor = false;
            this.btnFindPart.Click += new System.EventHandler(this.btnFindPart_Click);
            // 
            // lblInformation
            // 
            this.lblInformation.AutoSize = true;
            this.lblInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblInformation.Location = new System.Drawing.Point(132, 50);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(815, 87);
            this.lblInformation.TabIndex = 3;
            this.lblInformation.Text = "Please provide a VT Lot Number and Substrate ID for unarchiving purposes\r\nAfter e" +
    "ntering these, please press Tab\r\nThis could take a couple minutes, especially if" +
    " not archived, please wait";
            this.lblInformation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVTLot
            // 
            this.lblVTLot.AutoSize = true;
            this.lblVTLot.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblVTLot.Location = new System.Drawing.Point(307, 162);
            this.lblVTLot.Name = "lblVTLot";
            this.lblVTLot.Size = new System.Drawing.Size(182, 29);
            this.lblVTLot.TabIndex = 4;
            this.lblVTLot.Text = "VT Lot Number:";
            // 
            // lblSubstId
            // 
            this.lblSubstId.AutoSize = true;
            this.lblSubstId.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblSubstId.Location = new System.Drawing.Point(307, 214);
            this.lblSubstId.Name = "lblSubstId";
            this.lblSubstId.Size = new System.Drawing.Size(150, 29);
            this.lblSubstId.TabIndex = 5;
            this.lblSubstId.Text = "Substrate ID:";
            // 
            // lblTableName
            // 
            this.lblTableName.AutoSize = true;
            this.lblTableName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblTableName.Location = new System.Drawing.Point(307, 348);
            this.lblTableName.Name = "lblTableName";
            this.lblTableName.Size = new System.Drawing.Size(154, 29);
            this.lblTableName.TabIndex = 6;
            this.lblTableName.Text = "Part exists in:";
            this.lblTableName.Visible = false;
            // 
            // nudVTLot
            // 
            this.nudVTLot.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudVTLot.Location = new System.Drawing.Point(560, 163);
            this.nudVTLot.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nudVTLot.Minimum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudVTLot.Name = "nudVTLot";
            this.nudVTLot.Size = new System.Drawing.Size(211, 22);
            this.nudVTLot.TabIndex = 7;
            this.nudVTLot.Value = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudVTLot.ValueChanged += new System.EventHandler(this.nudVTLot_ValueChanged);
            // 
            // nudSubstId
            // 
            this.nudSubstId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudSubstId.Location = new System.Drawing.Point(560, 215);
            this.nudSubstId.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nudSubstId.Minimum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudSubstId.Name = "nudSubstId";
            this.nudSubstId.Size = new System.Drawing.Size(211, 22);
            this.nudSubstId.TabIndex = 8;
            this.nudSubstId.Value = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudSubstId.ValueChanged += new System.EventHandler(this.nudSubstId_ValueChanged);
            // 
            // txtTableName
            // 
            this.txtTableName.Enabled = false;
            this.txtTableName.Location = new System.Drawing.Point(560, 349);
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.Size = new System.Drawing.Size(211, 26);
            this.txtTableName.TabIndex = 9;
            this.txtTableName.Visible = false;
            // 
            // btnHidden
            // 
            this.btnHidden.BackColor = System.Drawing.Color.Teal;
            this.btnHidden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHidden.ForeColor = System.Drawing.Color.Teal;
            this.btnHidden.Location = new System.Drawing.Point(1, 1);
            this.btnHidden.Name = "btnHidden";
            this.btnHidden.Size = new System.Drawing.Size(10, 10);
            this.btnHidden.TabIndex = 10;
            this.btnHidden.Text = "button1";
            this.btnHidden.UseVisualStyleBackColor = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1079, 515);
            this.Controls.Add(this.btnHidden);
            this.Controls.Add(this.txtTableName);
            this.Controls.Add(this.nudSubstId);
            this.Controls.Add(this.nudVTLot);
            this.Controls.Add(this.lblTableName);
            this.Controls.Add(this.lblSubstId);
            this.Controls.Add(this.lblVTLot);
            this.Controls.Add(this.lblInformation);
            this.Controls.Add(this.btnFindPart);
            this.Controls.Add(this.btnUnarchivePart);
            this.Controls.Add(this.btnUnarchiveLot);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMain";
            this.Text = "ZECT Unarchive";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudVTLot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSubstId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUnarchiveLot;
        private System.Windows.Forms.Button btnUnarchivePart;
        private System.Windows.Forms.Button btnFindPart;
        private System.Windows.Forms.Label lblInformation;
        private System.Windows.Forms.Label lblVTLot;
        private System.Windows.Forms.Label lblSubstId;
        private System.Windows.Forms.Label lblTableName;
        private System.Windows.Forms.NumericUpDown nudVTLot;
        private System.Windows.Forms.NumericUpDown nudSubstId;
        private System.Windows.Forms.TextBox txtTableName;
        private System.Windows.Forms.Button btnHidden;
    }
}

