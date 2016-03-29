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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.percentage = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.RefreshInterval = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxURLBase = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.quickLink = new System.Windows.Forms.LinkLabel();
            this.buttonDismissMessage = new System.Windows.Forms.Button();
            this.messageBoard = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.knifeGrid = new System.Windows.Forms.DataGridView();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.KnifeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KnifeURL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedianPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LowPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DesiredPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.percentage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RefreshInterval)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.knifeGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.percentage);
            this.groupBox1.Controls.Add(this.label6);
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
            this.groupBox1.Size = new System.Drawing.Size(512, 157);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Setup";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(260, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Percent";
            // 
            // percentage
            // 
            this.percentage.BackColor = System.Drawing.SystemColors.WindowText;
            this.percentage.ForeColor = System.Drawing.SystemColors.Control;
            this.percentage.Location = new System.Drawing.Point(133, 85);
            this.percentage.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.percentage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.percentage.Name = "percentage";
            this.percentage.Size = new System.Drawing.Size(120, 20);
            this.percentage.TabIndex = 8;
            this.percentage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.percentage.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.percentage.ValueChanged += new System.EventHandler(this.percentage_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Price Percentage:";
            // 
            // buttonStop
            // 
            this.buttonStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonStop.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.buttonStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStop.Location = new System.Drawing.Point(259, 121);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(231, 28);
            this.buttonStop.TabIndex = 6;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = false;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonStart.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Location = new System.Drawing.Point(22, 121);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(231, 28);
            this.buttonStart.TabIndex = 5;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
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
            this.RefreshInterval.ValueChanged += new System.EventHandler(this.RefreshInterval_ValueChanged);
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
            // textBoxURLBase
            // 
            this.textBoxURLBase.BackColor = System.Drawing.SystemColors.WindowText;
            this.textBoxURLBase.ForeColor = System.Drawing.SystemColors.Control;
            this.textBoxURLBase.Location = new System.Drawing.Point(102, 20);
            this.textBoxURLBase.Name = "textBoxURLBase";
            this.textBoxURLBase.ReadOnly = true;
            this.textBoxURLBase.Size = new System.Drawing.Size(385, 20);
            this.textBoxURLBase.TabIndex = 1;
            this.textBoxURLBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.quickLink);
            this.groupBox2.Controls.Add(this.buttonDismissMessage);
            this.groupBox2.Controls.Add(this.messageBoard);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(532, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(385, 157);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Message Board ";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Quick Link: ";
            // 
            // quickLink
            // 
            this.quickLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.quickLink.AutoSize = true;
            this.quickLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.quickLink.Location = new System.Drawing.Point(76, 126);
            this.quickLink.Name = "quickLink";
            this.quickLink.Size = new System.Drawing.Size(55, 13);
            this.quickLink.TabIndex = 2;
            this.quickLink.TabStop = true;
            this.quickLink.Text = "linkLabel1";
            // 
            // buttonDismissMessage
            // 
            this.buttonDismissMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDismissMessage.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.buttonDismissMessage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDismissMessage.Location = new System.Drawing.Point(293, 121);
            this.buttonDismissMessage.Name = "buttonDismissMessage";
            this.buttonDismissMessage.Size = new System.Drawing.Size(85, 23);
            this.buttonDismissMessage.TabIndex = 1;
            this.buttonDismissMessage.Text = "Dismiss";
            this.buttonDismissMessage.UseVisualStyleBackColor = false;
            this.buttonDismissMessage.Click += new System.EventHandler(this.buttonDismissMessage_Click);
            // 
            // messageBoard
            // 
            this.messageBoard.BackColor = System.Drawing.SystemColors.WindowText;
            this.messageBoard.ForeColor = System.Drawing.SystemColors.Control;
            this.messageBoard.FormattingEnabled = true;
            this.messageBoard.Location = new System.Drawing.Point(7, 20);
            this.messageBoard.Name = "messageBoard";
            this.messageBoard.ScrollAlwaysVisible = true;
            this.messageBoard.Size = new System.Drawing.Size(372, 95);
            this.messageBoard.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.knifeGrid);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Location = new System.Drawing.Point(13, 176);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(904, 432);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Knife Stats";
            // 
            // knifeGrid
            // 
            this.knifeGrid.BackgroundColor = System.Drawing.SystemColors.WindowText;
            this.knifeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.knifeGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KnifeName,
            this.KnifeURL,
            this.MedianPrice,
            this.LowPrice,
            this.DesiredPrice});
            this.knifeGrid.GridColor = System.Drawing.SystemColors.WindowFrame;
            this.knifeGrid.Location = new System.Drawing.Point(22, 29);
            this.knifeGrid.Name = "knifeGrid";
            this.knifeGrid.ReadOnly = true;
            this.knifeGrid.Size = new System.Drawing.Size(858, 387);
            this.knifeGrid.TabIndex = 0;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // KnifeName
            // 
            this.KnifeName.HeaderText = "Knife Name";
            this.KnifeName.Name = "KnifeName";
            this.KnifeName.ReadOnly = true;
            this.KnifeName.Width = 300;
            // 
            // KnifeURL
            // 
            this.KnifeURL.HeaderText = "Knife URL";
            this.KnifeURL.Name = "KnifeURL";
            this.KnifeURL.ReadOnly = true;
            this.KnifeURL.Width = 300;
            // 
            // MedianPrice
            // 
            this.MedianPrice.HeaderText = "Median Price";
            this.MedianPrice.Name = "MedianPrice";
            this.MedianPrice.ReadOnly = true;
            this.MedianPrice.Width = 75;
            // 
            // LowPrice
            // 
            this.LowPrice.HeaderText = "Lowest Price";
            this.LowPrice.Name = "LowPrice";
            this.LowPrice.ReadOnly = true;
            this.LowPrice.Width = 75;
            // 
            // DesiredPrice
            // 
            this.DesiredPrice.HeaderText = "Desired Price";
            this.DesiredPrice.Name = "DesiredPrice";
            this.DesiredPrice.ReadOnly = true;
            this.DesiredPrice.Width = 75;
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
            ((System.ComponentModel.ISupportInitialize)(this.percentage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RefreshInterval)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.knifeGrid)).EndInit();
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
        private System.Windows.Forms.DataGridView knifeGrid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown percentage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.DataGridViewTextBoxColumn DesiredPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn LowPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedianPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn KnifeURL;
        private System.Windows.Forms.DataGridViewTextBoxColumn KnifeName;
    }
}

