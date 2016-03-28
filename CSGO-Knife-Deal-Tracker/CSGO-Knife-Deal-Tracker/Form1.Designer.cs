namespace CSGO_Knife_Deal_Tracker
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.messageBoard = new System.Windows.Forms.ListBox();
            this.buttonDismissMessage = new System.Windows.Forms.Button();
            this.quickLink = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxURLBase = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.RefreshInterval = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.KnifeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LowPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RefreshInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonStop);
            this.groupBox1.Controls.Add(this.buttonStart);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.RefreshInterval);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxURLBase);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(512, 288);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Setup";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.quickLink);
            this.groupBox2.Controls.Add(this.buttonDismissMessage);
            this.groupBox2.Controls.Add(this.messageBoard);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(532, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(385, 288);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Message Board ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Location = new System.Drawing.Point(13, 308);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(904, 300);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Knife Stats";
            // 
            // messageBoard
            // 
            this.messageBoard.BackColor = System.Drawing.SystemColors.WindowText;
            this.messageBoard.FormattingEnabled = true;
            this.messageBoard.Location = new System.Drawing.Point(7, 20);
            this.messageBoard.Name = "messageBoard";
            this.messageBoard.ScrollAlwaysVisible = true;
            this.messageBoard.Size = new System.Drawing.Size(372, 225);
            this.messageBoard.TabIndex = 0;
            // 
            // buttonDismissMessage
            // 
            this.buttonDismissMessage.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.buttonDismissMessage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDismissMessage.Location = new System.Drawing.Point(293, 252);
            this.buttonDismissMessage.Name = "buttonDismissMessage";
            this.buttonDismissMessage.Size = new System.Drawing.Size(85, 23);
            this.buttonDismissMessage.TabIndex = 1;
            this.buttonDismissMessage.Text = "Dismiss";
            this.buttonDismissMessage.UseVisualStyleBackColor = false;
            // 
            // quickLink
            // 
            this.quickLink.AutoSize = true;
            this.quickLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.quickLink.Location = new System.Drawing.Point(76, 257);
            this.quickLink.Name = "quickLink";
            this.quickLink.Size = new System.Drawing.Size(55, 13);
            this.quickLink.TabIndex = 2;
            this.quickLink.TabStop = true;
            this.quickLink.Text = "linkLabel1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Quick Link: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Base URL: ";
            // 
            // textBoxURLBase
            // 
            this.textBoxURLBase.BackColor = System.Drawing.SystemColors.WindowText;
            this.textBoxURLBase.ForeColor = System.Drawing.SystemColors.Control;
            this.textBoxURLBase.Location = new System.Drawing.Point(102, 20);
            this.textBoxURLBase.Name = "textBoxURLBase";
            this.textBoxURLBase.Size = new System.Drawing.Size(385, 20);
            this.textBoxURLBase.TabIndex = 1;
            this.textBoxURLBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Refresh Interval: ";
            // 
            // RefreshInterval
            // 
            this.RefreshInterval.BackColor = System.Drawing.SystemColors.WindowText;
            this.RefreshInterval.ForeColor = System.Drawing.SystemColors.Control;
            this.RefreshInterval.Location = new System.Drawing.Point(133, 54);
            this.RefreshInterval.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.RefreshInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.RefreshInterval.Name = "RefreshInterval";
            this.RefreshInterval.Size = new System.Drawing.Size(120, 20);
            this.RefreshInterval.TabIndex = 3;
            this.RefreshInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RefreshInterval.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(260, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Second(s)";
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Location = new System.Drawing.Point(22, 252);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(231, 28);
            this.buttonStart.TabIndex = 5;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = false;
            // 
            // buttonStop
            // 
            this.buttonStop.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.buttonStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStop.Location = new System.Drawing.Point(259, 252);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(231, 28);
            this.buttonStop.TabIndex = 6;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KnifeName,
            this.LowPrice});
            this.dataGridView1.Location = new System.Drawing.Point(22, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // KnifeName
            // 
            this.KnifeName.HeaderText = "Knife Name";
            this.KnifeName.Name = "KnifeName";
            this.KnifeName.ReadOnly = true;
            // 
            // LowPrice
            // 
            this.LowPrice.HeaderText = "Lowest Price";
            this.LowPrice.Name = "LowPrice";
            this.LowPrice.ReadOnly = true;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(929, 620);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(945, 659);
            this.MinimumSize = new System.Drawing.Size(945, 659);
            this.Name = "mainForm";
            this.Opacity = 0.9D;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "CSGO Knife Deal Tracker";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RefreshInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel quickLink;
        private System.Windows.Forms.Button buttonDismissMessage;
        private System.Windows.Forms.ListBox messageBoard;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxURLBase;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown RefreshInterval;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn KnifeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LowPrice;
    }
}

