namespace TimeProtocol {
    partial class ProtocolManager {
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
            this.components = new System.ComponentModel.Container();
            this.panel_timePMan = new System.Windows.Forms.Panel();
            this.newMenu = new System.Windows.Forms.Button();
            this.btn_cancle = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btn_createDesktopShortcut = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_timePMan
            // 
            this.panel_timePMan.BackColor = System.Drawing.Color.Gainsboro;
            this.panel_timePMan.Location = new System.Drawing.Point(12, 12);
            this.panel_timePMan.Name = "panel_timePMan";
            this.panel_timePMan.Size = new System.Drawing.Size(396, 353);
            this.panel_timePMan.TabIndex = 0;
            // 
            // newMenu
            // 
            this.newMenu.Location = new System.Drawing.Point(12, 371);
            this.newMenu.Name = "newMenu";
            this.newMenu.Size = new System.Drawing.Size(151, 30);
            this.newMenu.TabIndex = 1;
            this.newMenu.Text = "New Time Protocol";
            this.newMenu.UseVisualStyleBackColor = true;
            this.newMenu.Click += new System.EventHandler(this.NewMenu_Click);
            // 
            // btn_cancle
            // 
            this.btn_cancle.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.btn_cancle.Location = new System.Drawing.Point(257, 371);
            this.btn_cancle.Name = "btn_cancle";
            this.btn_cancle.Size = new System.Drawing.Size(151, 30);
            this.btn_cancle.TabIndex = 2;
            this.btn_cancle.Text = "Cancle";
            this.btn_cancle.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_createDesktopShortcut});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(203, 26);
            // 
            // btn_createDesktopShortcut
            // 
            this.btn_createDesktopShortcut.Name = "btn_createDesktopShortcut";
            this.btn_createDesktopShortcut.Size = new System.Drawing.Size(202, 22);
            this.btn_createDesktopShortcut.Text = "Create Desktop Shortcut";
            this.btn_createDesktopShortcut.Click += new System.EventHandler(this.Btn_createDesktopShortcut_Click);
            // 
            // ProtocolManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_cancle;
            this.ClientSize = new System.Drawing.Size(420, 405);
            this.Controls.Add(this.btn_cancle);
            this.Controls.Add(this.newMenu);
            this.Controls.Add(this.panel_timePMan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ProtocolManager";
            this.Text = "ProtocolManager";
            this.Load += new System.EventHandler(this.ProtocolManager_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_timePMan;
        private System.Windows.Forms.Button newMenu;
        private System.Windows.Forms.Button btn_cancle;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btn_createDesktopShortcut;
    }
}