namespace Dormitory.Forms
{
    partial class CapacityForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblcapacity1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsaken = new System.Windows.Forms.TextBox();
            this.txtempty = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtcap = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Zar", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(760, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = " ظرفیت خوابگاه: ";
            // 
            // lblcapacity1
            // 
            this.lblcapacity1.AutoSize = true;
            this.lblcapacity1.Location = new System.Drawing.Point(527, 271);
            this.lblcapacity1.Name = "lblcapacity1";
            this.lblcapacity1.Size = new System.Drawing.Size(0, 17);
            this.lblcapacity1.TabIndex = 1;
            this.lblcapacity1.Click += new System.EventHandler(this.label2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Zar", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(760, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 47);
            this.label2.TabIndex = 4;
            this.label2.Text = "  تعداد ساکنان خوابگاه: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("B Zar", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(760, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 47);
            this.label3.TabIndex = 6;
            this.label3.Text = "ظرفیت خالی :";
            // 
            // txtsaken
            // 
            this.txtsaken.Enabled = false;
            this.txtsaken.Font = new System.Drawing.Font("B Zar", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtsaken.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtsaken.Location = new System.Drawing.Point(531, 249);
            this.txtsaken.Multiline = true;
            this.txtsaken.Name = "txtsaken";
            this.txtsaken.ReadOnly = true;
            this.txtsaken.Size = new System.Drawing.Size(141, 36);
            this.txtsaken.TabIndex = 9;
            this.txtsaken.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtempty
            // 
            this.txtempty.Enabled = false;
            this.txtempty.Font = new System.Drawing.Font("B Zar", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtempty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtempty.Location = new System.Drawing.Point(531, 350);
            this.txtempty.Multiline = true;
            this.txtempty.Name = "txtempty";
            this.txtempty.ReadOnly = true;
            this.txtempty.Size = new System.Drawing.Size(141, 36);
            this.txtempty.TabIndex = 10;
            this.txtempty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtempty.TextChanged += new System.EventHandler(this.Txtempty_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtsaken);
            this.groupBox1.Controls.Add(this.txtempty);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtcap);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("B Zar", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(1116, 566);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اطلاعات خوابگاه";
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // txtcap
            // 
            this.txtcap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtcap.Enabled = false;
            this.txtcap.Font = new System.Drawing.Font("B Zar", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtcap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtcap.Location = new System.Drawing.Point(531, 152);
            this.txtcap.Multiline = true;
            this.txtcap.Name = "txtcap";
            this.txtcap.ReadOnly = true;
            this.txtcap.Size = new System.Drawing.Size(141, 36);
            this.txtcap.TabIndex = 8;
            this.txtcap.Text = "\r\n";
            this.txtcap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtcap.TextChanged += new System.EventHandler(this.txtcap_TextChanged);
            // 
            // CapacityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1150, 634);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblcapacity1);
            this.Name = "CapacityForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CapacityForm";
            this.Load += new System.EventHandler(this.CapacityForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblcapacity1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtsaken;
        private System.Windows.Forms.TextBox txtempty;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtcap;
    }
}