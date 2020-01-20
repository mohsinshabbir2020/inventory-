namespace inventory_system
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.labelname = new System.Windows.Forms.Label();
            this.textBoxadminname = new System.Windows.Forms.TextBox();
            this.textBoxadminpass = new System.Windows.Forms.TextBox();
            this.labeladminpassqord = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(352, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelname
            // 
            this.labelname.AutoSize = true;
            this.labelname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelname.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelname.Location = new System.Drawing.Point(293, 151);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(110, 25);
            this.labelname.TabIndex = 1;
            this.labelname.Text = "User Name";
            this.labelname.Click += new System.EventHandler(this.labelname_Click);
            // 
            // textBoxadminname
            // 
            this.textBoxadminname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxadminname.Location = new System.Drawing.Point(438, 146);
            this.textBoxadminname.Name = "textBoxadminname";
            this.textBoxadminname.Size = new System.Drawing.Size(148, 30);
            this.textBoxadminname.TabIndex = 2;
            this.textBoxadminname.TextChanged += new System.EventHandler(this.textBoxadminname_TextChanged);
            // 
            // textBoxadminpass
            // 
            this.textBoxadminpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxadminpass.Location = new System.Drawing.Point(438, 197);
            this.textBoxadminpass.Name = "textBoxadminpass";
            this.textBoxadminpass.PasswordChar = '#';
            this.textBoxadminpass.Size = new System.Drawing.Size(148, 30);
            this.textBoxadminpass.TabIndex = 4;
            this.textBoxadminpass.TextChanged += new System.EventHandler(this.textBoxadminpass_TextChanged);
            // 
            // labeladminpassqord
            // 
            this.labeladminpassqord.AutoSize = true;
            this.labeladminpassqord.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeladminpassqord.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labeladminpassqord.Location = new System.Drawing.Point(293, 202);
            this.labeladminpassqord.Name = "labeladminpassqord";
            this.labeladminpassqord.Size = new System.Drawing.Size(98, 25);
            this.labeladminpassqord.TabIndex = 3;
            this.labeladminpassqord.Text = "Password";
            this.labeladminpassqord.Click += new System.EventHandler(this.labeladminpassqord_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(507, 280);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 37);
            this.button2.TabIndex = 5;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(357, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(445, 33);
            this.label1.TabIndex = 7;
            this.label1.Text = "Inventory Management System";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::inventory_system.Properties.Resources.login;
            this.pictureBox1.Location = new System.Drawing.Point(676, 117);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 200);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(352, 368);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(283, 37);
            this.button3.TabIndex = 8;
            this.button3.Text = "Close";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1102, 491);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBoxadminpass);
            this.Controls.Add(this.labeladminpassqord);
            this.Controls.Add(this.textBoxadminname);
            this.Controls.Add(this.labelname);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.TextBox textBoxadminname;
        private System.Windows.Forms.TextBox textBoxadminpass;
        private System.Windows.Forms.Label labeladminpassqord;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
    }
}

