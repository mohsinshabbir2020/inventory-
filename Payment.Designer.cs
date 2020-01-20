namespace inventory_system
{
    partial class Payment
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
            this.searchinvoice = new System.Windows.Forms.Button();
            this.deleteinvoice = new System.Windows.Forms.Button();
            this.labelassettype = new System.Windows.Forms.Label();
            this.updateinvoice = new System.Windows.Forms.Button();
            this.invsertxt = new System.Windows.Forms.TextBox();
            this.labelassetname = new System.Windows.Forms.Label();
            this.invnumtxt = new System.Windows.Forms.TextBox();
            this.labelAssetid = new System.Windows.Forms.Label();
            this.addinvoice = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.invdestxt = new System.Windows.Forms.TextBox();
            this.invdatetxt = new System.Windows.Forms.DateTimePicker();
            this.GridViewpo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewpo)).BeginInit();
            this.SuspendLayout();
            // 
            // searchinvoice
            // 
            this.searchinvoice.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.searchinvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchinvoice.Location = new System.Drawing.Point(652, 400);
            this.searchinvoice.Name = "searchinvoice";
            this.searchinvoice.Size = new System.Drawing.Size(161, 37);
            this.searchinvoice.TabIndex = 35;
            this.searchinvoice.Text = "Search invoice";
            this.searchinvoice.UseVisualStyleBackColor = false;
            this.searchinvoice.Click += new System.EventHandler(this.searchinvoice_Click);
            // 
            // deleteinvoice
            // 
            this.deleteinvoice.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.deleteinvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteinvoice.Location = new System.Drawing.Point(449, 400);
            this.deleteinvoice.Name = "deleteinvoice";
            this.deleteinvoice.Size = new System.Drawing.Size(161, 37);
            this.deleteinvoice.TabIndex = 34;
            this.deleteinvoice.Text = "Delete Innvoice";
            this.deleteinvoice.UseVisualStyleBackColor = false;
            this.deleteinvoice.Click += new System.EventHandler(this.deleteinvoice_Click);
            // 
            // labelassettype
            // 
            this.labelassettype.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.labelassettype.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelassettype.Location = new System.Drawing.Point(26, 256);
            this.labelassettype.Name = "labelassettype";
            this.labelassettype.Size = new System.Drawing.Size(184, 25);
            this.labelassettype.TabIndex = 32;
            this.labelassettype.Text = "Item Serial";
            // 
            // updateinvoice
            // 
            this.updateinvoice.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.updateinvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateinvoice.Location = new System.Drawing.Point(242, 400);
            this.updateinvoice.Name = "updateinvoice";
            this.updateinvoice.Size = new System.Drawing.Size(161, 37);
            this.updateinvoice.TabIndex = 31;
            this.updateinvoice.Text = "Update Invoice";
            this.updateinvoice.UseVisualStyleBackColor = false;
            this.updateinvoice.Click += new System.EventHandler(this.updateinvoice_Click);
            // 
            // invsertxt
            // 
            this.invsertxt.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.invsertxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invsertxt.Location = new System.Drawing.Point(253, 256);
            this.invsertxt.Name = "invsertxt";
            this.invsertxt.Size = new System.Drawing.Size(198, 30);
            this.invsertxt.TabIndex = 30;
            // 
            // labelassetname
            // 
            this.labelassetname.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.labelassetname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelassetname.Location = new System.Drawing.Point(26, 136);
            this.labelassetname.Name = "labelassetname";
            this.labelassetname.Size = new System.Drawing.Size(184, 25);
            this.labelassetname.TabIndex = 29;
            this.labelassetname.Text = "Date";
            // 
            // invnumtxt
            // 
            this.invnumtxt.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.invnumtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invnumtxt.Location = new System.Drawing.Point(253, 75);
            this.invnumtxt.Name = "invnumtxt";
            this.invnumtxt.Size = new System.Drawing.Size(198, 30);
            this.invnumtxt.TabIndex = 28;
            // 
            // labelAssetid
            // 
            this.labelAssetid.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.labelAssetid.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAssetid.Location = new System.Drawing.Point(26, 78);
            this.labelAssetid.Name = "labelAssetid";
            this.labelAssetid.Size = new System.Drawing.Size(184, 25);
            this.labelAssetid.TabIndex = 27;
            this.labelAssetid.Text = "Invoice Number";
            // 
            // addinvoice
            // 
            this.addinvoice.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.addinvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addinvoice.Location = new System.Drawing.Point(22, 400);
            this.addinvoice.Name = "addinvoice";
            this.addinvoice.Size = new System.Drawing.Size(161, 37);
            this.addinvoice.TabIndex = 26;
            this.addinvoice.Text = "Add Innvoice";
            this.addinvoice.UseVisualStyleBackColor = false;
            this.addinvoice.Click += new System.EventHandler(this.addinvoice_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 25);
            this.label1.TabIndex = 36;
            this.label1.Text = "Invoice Description";
            // 
            // invdestxt
            // 
            this.invdestxt.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.invdestxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invdestxt.Location = new System.Drawing.Point(255, 193);
            this.invdestxt.Name = "invdestxt";
            this.invdestxt.Size = new System.Drawing.Size(198, 30);
            this.invdestxt.TabIndex = 37;
            // 
            // invdatetxt
            // 
            this.invdatetxt.Location = new System.Drawing.Point(253, 141);
            this.invdatetxt.Name = "invdatetxt";
            this.invdatetxt.Size = new System.Drawing.Size(200, 20);
            this.invdatetxt.TabIndex = 38;
            // 
            // GridViewpo
            // 
            this.GridViewpo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewpo.Location = new System.Drawing.Point(484, 48);
            this.GridViewpo.Name = "GridViewpo";
            this.GridViewpo.Size = new System.Drawing.Size(793, 233);
            this.GridViewpo.TabIndex = 39;
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(966, 498);
            this.Controls.Add(this.GridViewpo);
            this.Controls.Add(this.invdatetxt);
            this.Controls.Add(this.invdestxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchinvoice);
            this.Controls.Add(this.deleteinvoice);
            this.Controls.Add(this.labelassettype);
            this.Controls.Add(this.updateinvoice);
            this.Controls.Add(this.invsertxt);
            this.Controls.Add(this.labelassetname);
            this.Controls.Add(this.invnumtxt);
            this.Controls.Add(this.labelAssetid);
            this.Controls.Add(this.addinvoice);
            this.Name = "Payment";
            this.Text = "s";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Payment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewpo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchinvoice;
        private System.Windows.Forms.Button deleteinvoice;
        private System.Windows.Forms.Label labelassettype;
        private System.Windows.Forms.Button updateinvoice;
        private System.Windows.Forms.TextBox invsertxt;
        private System.Windows.Forms.Label labelassetname;
        private System.Windows.Forms.TextBox invnumtxt;
        private System.Windows.Forms.Label labelAssetid;
        private System.Windows.Forms.Button addinvoice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox invdestxt;
        private System.Windows.Forms.DateTimePicker invdatetxt;
        private System.Windows.Forms.DataGridView GridViewpo;
    }
}