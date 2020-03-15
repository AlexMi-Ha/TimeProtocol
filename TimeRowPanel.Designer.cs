namespace TimeProtocol {
    partial class TimeRowPanel {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.tableRow = new System.Windows.Forms.TableLayoutPanel();
            this.tb_desc = new System.Windows.Forms.TextBox();
            this.tb_delta = new System.Windows.Forms.TextBox();
            this.tb_stop = new System.Windows.Forms.TextBox();
            this.tb_start = new System.Windows.Forms.TextBox();
            this.cb_active = new System.Windows.Forms.CheckBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tableRow.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableRow
            // 
            this.tableRow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableRow.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableRow.ColumnCount = 6;
            this.tableRow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableRow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.08909F));
            this.tableRow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.76797F));
            this.tableRow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.76797F));
            this.tableRow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.28589F));
            this.tableRow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.08909F));
            this.tableRow.Controls.Add(this.tb_desc, 5, 0);
            this.tableRow.Controls.Add(this.tb_delta, 4, 0);
            this.tableRow.Controls.Add(this.tb_stop, 3, 0);
            this.tableRow.Controls.Add(this.tb_start, 2, 0);
            this.tableRow.Controls.Add(this.cb_active, 0, 0);
            this.tableRow.Controls.Add(this.tb_name, 1, 0);
            this.tableRow.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tableRow.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableRow.Location = new System.Drawing.Point(0, 0);
            this.tableRow.Name = "tableRow";
            this.tableRow.RowCount = 1;
            this.tableRow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableRow.Size = new System.Drawing.Size(458, 22);
            this.tableRow.TabIndex = 0;
            // 
            // tb_desc
            // 
            this.tb_desc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_desc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_desc.Location = new System.Drawing.Point(358, 4);
            this.tb_desc.Name = "tb_desc";
            this.tb_desc.ReadOnly = true;
            this.tb_desc.Size = new System.Drawing.Size(96, 13);
            this.tb_desc.TabIndex = 5;
            // 
            // tb_delta
            // 
            this.tb_delta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_delta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_delta.Location = new System.Drawing.Point(287, 4);
            this.tb_delta.Name = "tb_delta";
            this.tb_delta.ReadOnly = true;
            this.tb_delta.Size = new System.Drawing.Size(64, 13);
            this.tb_delta.TabIndex = 4;
            // 
            // tb_stop
            // 
            this.tb_stop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_stop.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_stop.Location = new System.Drawing.Point(206, 4);
            this.tb_stop.Name = "tb_stop";
            this.tb_stop.ReadOnly = true;
            this.tb_stop.Size = new System.Drawing.Size(74, 13);
            this.tb_stop.TabIndex = 3;
            // 
            // tb_start
            // 
            this.tb_start.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_start.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_start.Location = new System.Drawing.Point(125, 4);
            this.tb_start.Name = "tb_start";
            this.tb_start.ReadOnly = true;
            this.tb_start.Size = new System.Drawing.Size(74, 13);
            this.tb_start.TabIndex = 2;
            // 
            // cb_active
            // 
            this.cb_active.AutoSize = true;
            this.cb_active.Checked = true;
            this.cb_active.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_active.Location = new System.Drawing.Point(4, 4);
            this.cb_active.Name = "cb_active";
            this.cb_active.Size = new System.Drawing.Size(14, 14);
            this.cb_active.TabIndex = 0;
            this.cb_active.UseVisualStyleBackColor = true;
            // 
            // tb_name
            // 
            this.tb_name.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_name.Location = new System.Drawing.Point(25, 4);
            this.tb_name.Name = "tb_name";
            this.tb_name.ReadOnly = true;
            this.tb_name.Size = new System.Drawing.Size(93, 13);
            this.tb_name.TabIndex = 1;
            // 
            // TimeRowPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableRow);
            this.Name = "TimeRowPanel";
            this.Size = new System.Drawing.Size(458, 22);
            this.tableRow.ResumeLayout(false);
            this.tableRow.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableRow;
        private System.Windows.Forms.CheckBox cb_active;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_desc;
        private System.Windows.Forms.TextBox tb_delta;
        private System.Windows.Forms.TextBox tb_stop;
        private System.Windows.Forms.TextBox tb_start;
    }
}
