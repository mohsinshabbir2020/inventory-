namespace inventory_system
{
    partial class Department
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
            this.deleteasset = new System.Windows.Forms.Button();
            this.subdepart = new System.Windows.Forms.TextBox();
            this.labelassettype = new System.Windows.Forms.Label();
            this.deptname = new System.Windows.Forms.TextBox();
            this.labelassetname = new System.Windows.Forms.Label();
            this.deptid = new System.Windows.Forms.TextBox();
            this.labelAssetid = new System.Windows.Forms.Label();
            this.updateasset = new System.Windows.Forms.Button();
            this.addasset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.deptdes = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // deleteasset
            // 
            this.deleteasset.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.deleteasset.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteasset.Location = new System.Drawing.Point(265, 253);
            this.deleteasset.Name = "deleteasset";
            this.deleteasset.Size = new System.Drawing.Size(233, 37);
            this.deleteasset.TabIndex = 24;
            this.deleteasset.Text = "Update";
            this.deleteasset.UseVisualStyleBackColor = false;
            this.deleteasset.Click += new System.EventHandler(this.deleteasset_Click);
            // 
            // subdepart
            // 
            this.subdepart.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.subdepart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subdepart.Location = new System.Drawing.Point(265, 142);
            this.subdepart.Name = "subdepart";
            this.subdepart.Size = new System.Drawing.Size(198, 30);
            this.subdepart.TabIndex = 23;
            // 
            // labelassettype
            // 
            this.labelassettype.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.labelassettype.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelassettype.Location = new System.Drawing.Point(10, 144);
            this.labelassettype.Name = "labelassettype";
            this.labelassettype.Size = new System.Drawing.Size(216, 25);
            this.labelassettype.TabIndex = 22;
            this.labelassettype.Text = "Sub Department";
            // 
            // deptname
            // 
            this.deptname.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.deptname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deptname.Location = new System.Drawing.Point(265, 100);
            this.deptname.Name = "deptname";
            this.deptname.Size = new System.Drawing.Size(198, 30);
            this.deptname.TabIndex = 20;
            // 
            // labelassetname
            // 
            this.labelassetname.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.labelassetname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelassetname.Location = new System.Drawing.Point(12, 56);
            this.labelassetname.Name = "labelassetname";
            this.labelassetname.Size = new System.Drawing.Size(214, 25);
            this.labelassetname.TabIndex = 19;
            this.labelassetname.Text = "Department ID";
            // 
            // deptid
            // 
            this.deptid.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.deptid.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deptid.Location = new System.Drawing.Point(265, 51);
            this.deptid.Name = "deptid";
            this.deptid.Size = new System.Drawing.Size(198, 30);
            this.deptid.TabIndex = 18;
            // 
            // labelAssetid
            // 
            this.labelAssetid.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.labelAssetid.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAssetid.Location = new System.Drawing.Point(12, 100);
            this.labelAssetid.Name = "labelAssetid";
            this.labelAssetid.Size = new System.Drawing.Size(214, 25);
            this.labelAssetid.TabIndex = 17;
            this.labelAssetid.Text = "Department Name";
            // 
            // updateasset
            // 
            this.updateasset.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.updateasset.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateasset.Location = new System.Drawing.Point(17, 311);
            this.updateasset.Name = "updateasset";
            this.updateasset.Size = new System.Drawing.Size(481, 37);
            this.updateasset.TabIndex = 21;
            this.updateasset.Text = "Delete";
            this.updateasset.UseVisualStyleBackColor = false;
            this.updateasset.Click += new System.EventHandler(this.updateasset_Click);
            // 
            // addasset
            // 
            this.addasset.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.addasset.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addasset.Location = new System.Drawing.Point(12, 253);
            this.addasset.Name = "addasset";
            this.addasset.Size = new System.Drawing.Size(233, 37);
            this.addasset.TabIndex = 16;
            this.addasset.Text = "Add";
            this.addasset.UseVisualStyleBackColor = false;
            this.addasset.Click += new System.EventHandler(this.addasset_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 25);
            this.label1.TabIndex = 29;
            this.label1.Text = "Department Description";
            // 
            // deptdes
            // 
            this.deptdes.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.deptdes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deptdes.Location = new System.Drawing.Point(265, 186);
            this.deptdes.Name = "deptdes";
            this.deptdes.Size = new System.Drawing.Size(198, 30);
            this.deptdes.TabIndex = 30;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(504, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(645, 284);
            this.dataGridView1.TabIndex = 31;
            // 
            // Department
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1041, 494);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.deptdes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteasset);
            this.Controls.Add(this.subdepart);
            this.Controls.Add(this.labelassettype);
            this.Controls.Add(this.updateasset);
            this.Controls.Add(this.deptname);
            this.Controls.Add(this.labelassetname);
            this.Controls.Add(this.deptid);
            this.Controls.Add(this.labelAssetid);
            this.Controls.Add(this.addasset);
            this.Name = "Department";
            this.Text = "Department Name";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Department_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deleteasset;
        private System.Windows.Forms.TextBox subdepart;
        private System.Windows.Forms.Label labelassettype;
        private System.Windows.Forms.TextBox deptname;
        private System.Windows.Forms.Label labelassetname;
        private System.Windows.Forms.TextBox deptid;
        private System.Windows.Forms.Label labelAssetid;
        private System.Windows.Forms.Button updateasset;
        private System.Windows.Forms.Button addasset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox deptdes;
        private System.Windows.Forms.DataGridView dataGridView1;

    }
}