namespace Yuginizer
{
    partial class FrmCreateListing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCreateListing));
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnViewSimilar = new System.Windows.Forms.LinkLabel();
            this.tbxTitle = new System.Windows.Forms.TextBox();
            this.lblBody = new System.Windows.Forms.Label();
            this.tbxBody = new System.Windows.Forms.RichTextBox();
            this.bntDone = new System.Windows.Forms.Button();
            this.lblCondition = new System.Windows.Forms.Label();
            this.chkMint = new System.Windows.Forms.RadioButton();
            this.chkNearMint = new System.Windows.Forms.RadioButton();
            this.chkOther = new System.Windows.Forms.RadioButton();
            this.lblPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(12, 52);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(31, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title:";
            // 
            // btnViewSimilar
            // 
            this.btnViewSimilar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewSimilar.AutoSize = true;
            this.btnViewSimilar.Location = new System.Drawing.Point(328, 52);
            this.btnViewSimilar.Name = "btnViewSimilar";
            this.btnViewSimilar.Size = new System.Drawing.Size(144, 13);
            this.btnViewSimilar.TabIndex = 1;
            this.btnViewSimilar.TabStop = true;
            this.btnViewSimilar.Text = "View Similar Listings (eBay)";
            this.btnViewSimilar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnViewSimilar_LinkClicked);
            // 
            // tbxTitle
            // 
            this.tbxTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxTitle.Location = new System.Drawing.Point(15, 68);
            this.tbxTitle.Name = "tbxTitle";
            this.tbxTitle.Size = new System.Drawing.Size(457, 22);
            this.tbxTitle.TabIndex = 2;
            // 
            // lblBody
            // 
            this.lblBody.AutoSize = true;
            this.lblBody.Location = new System.Drawing.Point(12, 103);
            this.lblBody.Name = "lblBody";
            this.lblBody.Size = new System.Drawing.Size(36, 13);
            this.lblBody.TabIndex = 3;
            this.lblBody.Text = "Body:";
            // 
            // tbxBody
            // 
            this.tbxBody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxBody.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxBody.Location = new System.Drawing.Point(15, 119);
            this.tbxBody.Name = "tbxBody";
            this.tbxBody.Size = new System.Drawing.Size(457, 301);
            this.tbxBody.TabIndex = 4;
            this.tbxBody.Text = "";
            // 
            // bntDone
            // 
            this.bntDone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bntDone.Location = new System.Drawing.Point(397, 426);
            this.bntDone.Name = "bntDone";
            this.bntDone.Size = new System.Drawing.Size(75, 23);
            this.bntDone.TabIndex = 5;
            this.bntDone.Text = "Done";
            this.bntDone.UseVisualStyleBackColor = true;
            this.bntDone.Click += new System.EventHandler(this.bntDone_Click);
            // 
            // lblCondition
            // 
            this.lblCondition.AutoSize = true;
            this.lblCondition.Location = new System.Drawing.Point(12, 9);
            this.lblCondition.Name = "lblCondition";
            this.lblCondition.Size = new System.Drawing.Size(62, 13);
            this.lblCondition.TabIndex = 6;
            this.lblCondition.Text = "Condition:";
            // 
            // chkMint
            // 
            this.chkMint.AutoSize = true;
            this.chkMint.Location = new System.Drawing.Point(15, 25);
            this.chkMint.Name = "chkMint";
            this.chkMint.Size = new System.Drawing.Size(104, 17);
            this.chkMint.TabIndex = 7;
            this.chkMint.TabStop = true;
            this.chkMint.Text = "Mint Condition";
            this.chkMint.UseVisualStyleBackColor = true;
            this.chkMint.CheckedChanged += new System.EventHandler(this.Option_CheckedChange);
            // 
            // chkNearMint
            // 
            this.chkNearMint.AutoSize = true;
            this.chkNearMint.Location = new System.Drawing.Point(125, 25);
            this.chkNearMint.Name = "chkNearMint";
            this.chkNearMint.Size = new System.Drawing.Size(131, 17);
            this.chkNearMint.TabIndex = 8;
            this.chkNearMint.TabStop = true;
            this.chkNearMint.Text = "Near Mint Condition";
            this.chkNearMint.UseVisualStyleBackColor = true;
            this.chkNearMint.CheckedChanged += new System.EventHandler(this.Option_CheckedChange);
            // 
            // chkOther
            // 
            this.chkOther.AutoSize = true;
            this.chkOther.Location = new System.Drawing.Point(262, 25);
            this.chkOther.Name = "chkOther";
            this.chkOther.Size = new System.Drawing.Size(55, 17);
            this.chkOther.TabIndex = 9;
            this.chkOther.TabStop = true;
            this.chkOther.Text = "Other";
            this.chkOther.UseVisualStyleBackColor = true;
            this.chkOther.CheckedChanged += new System.EventHandler(this.Option_CheckedChange);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(393, 12);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(79, 30);
            this.lblPrice.TabIndex = 10;
            this.lblPrice.Text = "$1.000";
            // 
            // FrmCreateListing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.chkOther);
            this.Controls.Add(this.chkNearMint);
            this.Controls.Add(this.chkMint);
            this.Controls.Add(this.lblCondition);
            this.Controls.Add(this.bntDone);
            this.Controls.Add(this.tbxBody);
            this.Controls.Add(this.lblBody);
            this.Controls.Add(this.tbxTitle);
            this.Controls.Add(this.btnViewSimilar);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCreateListing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create Listing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.LinkLabel btnViewSimilar;
        private System.Windows.Forms.TextBox tbxTitle;
        private System.Windows.Forms.Label lblBody;
        private System.Windows.Forms.RichTextBox tbxBody;
        private System.Windows.Forms.Button bntDone;
        private System.Windows.Forms.Label lblCondition;
        private System.Windows.Forms.RadioButton chkMint;
        private System.Windows.Forms.RadioButton chkNearMint;
        private System.Windows.Forms.RadioButton chkOther;
        private System.Windows.Forms.Label lblPrice;
    }
}