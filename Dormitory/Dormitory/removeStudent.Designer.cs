namespace Dormitory
{
    partial class removeStudent
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
            this.btndeleted = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtstno = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btndeleted
            // 
            this.btndeleted.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btndeleted.Font = new System.Drawing.Font("B Zar", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btndeleted.ForeColor = System.Drawing.Color.White;
            this.btndeleted.Location = new System.Drawing.Point(314, 359);
            this.btndeleted.Name = "btndeleted";
            this.btndeleted.Size = new System.Drawing.Size(176, 50);
            this.btndeleted.TabIndex = 0;
            this.btndeleted.Text = "حذف";
            this.btndeleted.UseVisualStyleBackColor = false;
            this.btndeleted.Click += new System.EventHandler(this.btndeleted_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkCyan;
            this.label1.Font = new System.Drawing.Font("B Zar", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(692, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "شماره دانشجویی را وارد کنید :";
            // 
            // txtstno
            // 
            this.txtstno.Font = new System.Drawing.Font("B Zar", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtstno.Location = new System.Drawing.Point(314, 278);
            this.txtstno.Name = "txtstno";
            this.txtstno.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtstno.Size = new System.Drawing.Size(309, 52);
            this.txtstno.TabIndex = 2;
            this.txtstno.TextChanged += new System.EventHandler(this.txtstno_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btndeleted);
            this.groupBox1.Controls.Add(this.txtstno);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.Font = new System.Drawing.Font("B Zar", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(1143, 629);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "حذف دانشجو";
            // 
            // removeStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1150, 634);
            this.Controls.Add(this.groupBox1);
            this.Name = "removeStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DeleteStudent";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btndeleted;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtstno;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}