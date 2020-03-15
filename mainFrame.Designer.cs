namespace TimeProtocol {
    partial class mainFrame {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainFrame));
            this.panel_newTime = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtB_description = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtB_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtB_stopTime = new System.Windows.Forms.TextBox();
            this.txtB_startTime = new System.Windows.Forms.TextBox();
            this.btn_stopTimer = new System.Windows.Forms.Button();
            this.btn_startTimer = new System.Windows.Forms.Button();
            this.btn_addTime = new System.Windows.Forms.Button();
            this.panel_time = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblFile = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel_total = new System.Windows.Forms.Panel();
            this.lblTotalTime = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_protocolMan = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_openTimeFile = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_save = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_createExcelFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_close = new System.Windows.Forms.ToolStripMenuItem();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.panel_newTime.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel_total.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_newTime
            // 
            this.panel_newTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_newTime.BackColor = System.Drawing.Color.Gainsboro;
            this.panel_newTime.Controls.Add(this.label4);
            this.panel_newTime.Controls.Add(this.txtB_description);
            this.panel_newTime.Controls.Add(this.label3);
            this.panel_newTime.Controls.Add(this.txtB_name);
            this.panel_newTime.Controls.Add(this.label2);
            this.panel_newTime.Controls.Add(this.label1);
            this.panel_newTime.Controls.Add(this.txtB_stopTime);
            this.panel_newTime.Controls.Add(this.txtB_startTime);
            this.panel_newTime.Controls.Add(this.btn_stopTimer);
            this.panel_newTime.Controls.Add(this.btn_startTimer);
            this.panel_newTime.Controls.Add(this.btn_addTime);
            this.panel_newTime.Location = new System.Drawing.Point(535, 27);
            this.panel_newTime.Name = "panel_newTime";
            this.panel_newTime.Size = new System.Drawing.Size(188, 313);
            this.panel_newTime.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Description:";
            // 
            // txtB_description
            // 
            this.txtB_description.Location = new System.Drawing.Point(3, 147);
            this.txtB_description.Name = "txtB_description";
            this.txtB_description.Size = new System.Drawing.Size(182, 20);
            this.txtB_description.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Name:";
            // 
            // txtB_name
            // 
            this.txtB_name.Location = new System.Drawing.Point(3, 24);
            this.txtB_name.Name = "txtB_name";
            this.txtB_name.Size = new System.Drawing.Size(182, 20);
            this.txtB_name.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Stop Time:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Start Time:";
            // 
            // txtB_stopTime
            // 
            this.txtB_stopTime.Location = new System.Drawing.Point(3, 104);
            this.txtB_stopTime.Name = "txtB_stopTime";
            this.txtB_stopTime.ReadOnly = true;
            this.txtB_stopTime.Size = new System.Drawing.Size(182, 20);
            this.txtB_stopTime.TabIndex = 4;
            // 
            // txtB_startTime
            // 
            this.txtB_startTime.Location = new System.Drawing.Point(3, 63);
            this.txtB_startTime.Name = "txtB_startTime";
            this.txtB_startTime.ReadOnly = true;
            this.txtB_startTime.Size = new System.Drawing.Size(182, 20);
            this.txtB_startTime.TabIndex = 3;
            // 
            // btn_stopTimer
            // 
            this.btn_stopTimer.Location = new System.Drawing.Point(32, 228);
            this.btn_stopTimer.Name = "btn_stopTimer";
            this.btn_stopTimer.Size = new System.Drawing.Size(126, 34);
            this.btn_stopTimer.TabIndex = 2;
            this.btn_stopTimer.Text = "Stop Timer";
            this.btn_stopTimer.UseVisualStyleBackColor = true;
            this.btn_stopTimer.Click += new System.EventHandler(this.StopTimer_click);
            // 
            // btn_startTimer
            // 
            this.btn_startTimer.Location = new System.Drawing.Point(32, 189);
            this.btn_startTimer.Name = "btn_startTimer";
            this.btn_startTimer.Size = new System.Drawing.Size(126, 34);
            this.btn_startTimer.TabIndex = 1;
            this.btn_startTimer.Text = "Start Timer";
            this.btn_startTimer.UseVisualStyleBackColor = true;
            this.btn_startTimer.Click += new System.EventHandler(this.StartTimer_click);
            // 
            // btn_addTime
            // 
            this.btn_addTime.Location = new System.Drawing.Point(3, 268);
            this.btn_addTime.Name = "btn_addTime";
            this.btn_addTime.Size = new System.Drawing.Size(182, 37);
            this.btn_addTime.TabIndex = 0;
            this.btn_addTime.Text = "Add Time";
            this.btn_addTime.UseVisualStyleBackColor = true;
            this.btn_addTime.Click += new System.EventHandler(this.AddTime_click);
            // 
            // panel_time
            // 
            this.panel_time.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_time.AutoScroll = true;
            this.panel_time.BackColor = System.Drawing.Color.Gainsboro;
            this.panel_time.Location = new System.Drawing.Point(12, 27);
            this.panel_time.Name = "panel_time";
            this.panel_time.Size = new System.Drawing.Size(517, 411);
            this.panel_time.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblFile});
            this.statusStrip1.Location = new System.Drawing.Point(0, 443);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(735, 24);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblFile
            // 
            this.lblFile.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(64, 19);
            this.lblFile.Text = "Time File: ";
            // 
            // panel_total
            // 
            this.panel_total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_total.BackColor = System.Drawing.Color.Gainsboro;
            this.panel_total.Controls.Add(this.lblTotalTime);
            this.panel_total.Controls.Add(this.label5);
            this.panel_total.Location = new System.Drawing.Point(535, 346);
            this.panel_total.Name = "panel_total";
            this.panel_total.Size = new System.Drawing.Size(188, 94);
            this.panel_total.TabIndex = 3;
            // 
            // lblTotalTime
            // 
            this.lblTotalTime.AutoSize = true;
            this.lblTotalTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTime.Location = new System.Drawing.Point(3, 26);
            this.lblTotalTime.Name = "lblTotalTime";
            this.lblTotalTime.Size = new System.Drawing.Size(45, 16);
            this.lblTotalTime.TabIndex = 1;
            this.lblTotalTime.Text = "Total: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(2, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Total Time: ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(735, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_protocolMan,
            this.toolStripSeparator1,
            this.btn_openTimeFile,
            this.btn_save,
            this.btn_createExcelFile,
            this.toolStripSeparator2,
            this.btn_close});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // btn_protocolMan
            // 
            this.btn_protocolMan.Image = global::TimeProtocol.Properties.Resources.icon_open_folder;
            this.btn_protocolMan.Name = "btn_protocolMan";
            this.btn_protocolMan.Size = new System.Drawing.Size(169, 22);
            this.btn_protocolMan.Text = "Protocol Manager";
            this.btn_protocolMan.Click += new System.EventHandler(this.Btn_protocolMan_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(166, 6);
            // 
            // btn_openTimeFile
            // 
            this.btn_openTimeFile.Image = global::TimeProtocol.Properties.Resources.icon_open_time_file;
            this.btn_openTimeFile.Name = "btn_openTimeFile";
            this.btn_openTimeFile.Size = new System.Drawing.Size(169, 22);
            this.btn_openTimeFile.Text = "Open Time File";
            this.btn_openTimeFile.Click += new System.EventHandler(this.Btn_openTimeFile_Click);
            // 
            // btn_save
            // 
            this.btn_save.Image = global::TimeProtocol.Properties.Resources.icon_save;
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(169, 22);
            this.btn_save.Text = "Save";
            this.btn_save.Click += new System.EventHandler(this.Btn_save_Click);
            // 
            // btn_createExcelFile
            // 
            this.btn_createExcelFile.Image = global::TimeProtocol.Properties.Resources.icon_excel;
            this.btn_createExcelFile.Name = "btn_createExcelFile";
            this.btn_createExcelFile.Size = new System.Drawing.Size(169, 22);
            this.btn_createExcelFile.Text = "Save as Excel file";
            this.btn_createExcelFile.Click += new System.EventHandler(this.Btn_createExcelFile_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(166, 6);
            // 
            // btn_close
            // 
            this.btn_close.Image = global::TimeProtocol.Properties.Resources.icon_close;
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(169, 22);
            this.btn_close.Text = "Close";
            this.btn_close.Click += new System.EventHandler(this.Btn_close_Click);
            // 
            // mainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 467);
            this.Controls.Add(this.panel_total);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel_time);
            this.Controls.Add(this.panel_newTime);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(650, 506);
            this.Name = "mainFrame";
            this.Text = "Time Protocol";
            this.Load += new System.EventHandler(this.MainFrame_Load);
            this.ResizeBegin += new System.EventHandler(this.OnResizeStart);
            this.ResizeEnd += new System.EventHandler(this.OnResizeEnd);
            this.panel_newTime.ResumeLayout(false);
            this.panel_newTime.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel_total.ResumeLayout(false);
            this.panel_total.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_newTime;
        private System.Windows.Forms.Panel panel_time;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtB_description;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtB_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtB_stopTime;
        private System.Windows.Forms.TextBox txtB_startTime;
        private System.Windows.Forms.Button btn_stopTimer;
        private System.Windows.Forms.Button btn_startTimer;
        private System.Windows.Forms.Button btn_addTime;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblFile;
        private System.Windows.Forms.Panel panel_total;
        private System.Windows.Forms.Label lblTotalTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btn_save;
        private System.Windows.Forms.ToolStripMenuItem btn_protocolMan;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem btn_close;
        private System.Windows.Forms.ToolStripMenuItem btn_openTimeFile;
        private System.Windows.Forms.ToolStripMenuItem btn_createExcelFile;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
    }
}

