namespace inventory_system
{
    partial class Report
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
            this.dateTimePickerinvoice = new System.Windows.Forms.DateTimePicker();
            this.deleteinvoice = new System.Windows.Forms.Button();
            this.updateinvoice = new System.Windows.Forms.Button();
            this.labelassetname = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.GridViewreport = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewreport)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePickerinvoice
            // 
            this.dateTimePickerinvoice.Location = new System.Drawing.Point(220, 27);
            this.dateTimePickerinvoice.Name = "dateTimePickerinvoice";
            this.dateTimePickerinvoice.Size = new System.Drawing.Size(180, 20);
            this.dateTimePickerinvoice.TabIndex = 50;
            // 
            // deleteinvoice
            // 
            this.deleteinvoice.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.deleteinvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteinvoice.Location = new System.Drawing.Point(12, 166);
            this.deleteinvoice.Name = "deleteinvoice";
            this.deleteinvoice.Size = new System.Drawing.Size(174, 37);
            this.deleteinvoice.TabIndex = 46;
            this.deleteinvoice.Text = "Departments";
            this.deleteinvoice.UseVisualStyleBackColor = false;
            this.deleteinvoice.Click += new System.EventHandler(this.deleteinvoice_Click);
            // 
            // updateinvoice
            // 
            this.updateinvoice.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.updateinvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateinvoice.Location = new System.Drawing.Point(12, 123);
            this.updateinvoice.Name = "updateinvoice";
            this.updateinvoice.Size = new System.Drawing.Size(174, 37);
            this.updateinvoice.TabIndex = 44;
            this.updateinvoice.Text = "PO\'s";
            this.updateinvoice.UseVisualStyleBackColor = false;
            this.updateinvoice.Click += new System.EventHandler(this.updateinvoice_Click);
            // 
            // labelassetname
            // 
            this.labelassetname.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.labelassetname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelassetname.Location = new System.Drawing.Point(12, 22);
            this.labelassetname.Name = "labelassetname";
            this.labelassetname.Size = new System.Drawing.Size(184, 25);
            this.labelassetname.TabIndex = 42;
            this.labelassetname.Text = "Date";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 37);
            this.button1.TabIndex = 51;
            this.button1.Text = "Assets";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GridViewreport
            // 
            this.GridViewreport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewreport.Location = new System.Drawing.Point(192, 65);
            this.GridViewreport.Name = "GridViewreport";
            this.GridViewreport.Size = new System.Drawing.Size(1094, 286);
            this.GridViewreport.TabIndex = 52;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 223);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 37);
            this.button2.TabIndex = 53;
            this.button2.Text = "Users";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(12, 279);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(174, 37);
            this.button3.TabIndex = 54;
            this.button3.Text = "Invoices";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(12, 322);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(174, 37);
            this.button4.TabIndex = 55;
            this.button4.Text = "Vendors";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(998, 556);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.GridViewreport);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePickerinvoice);
            this.Controls.Add(this.deleteinvoice);
            this.Controls.Add(this.updateinvoice);
            this.Controls.Add(this.labelassetname);
            this.Name = "Report";
            this.Text = "Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewreport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerinvoice;
        private System.Windows.Forms.Button deleteinvoice;
        private System.Windows.Forms.Button updateinvoice;
        private System.Windows.Forms.Label labelassetname;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView GridViewreport;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;

    }
}