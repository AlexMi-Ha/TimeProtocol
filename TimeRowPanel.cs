using System;
using System.Windows.Forms;

namespace TimeProtocol {
    public partial class TimeRowPanel : UserControl {

        public string SplitName {
            get { return tb_name.Text; }
            set { tb_name.Text = value; }
        }
        public string StartTime {
            get { return tb_start.Text; }
            set { tb_start.Text = value; }
        }

        public string StopTime {
            get { return tb_stop.Text; }
            set { tb_stop.Text = value; }
        }
        public string Delta {
            get { return tb_delta.Text; }
            set { tb_delta.Text = value; }
        }
        public string SplitDescription {
            get { return tb_desc.Text; }
            set { tb_desc.Text = value; }
        }
        public Boolean Active {
            get { return cb_active.Checked; }
            set { cb_active.Checked = value; }
        }
        public int Index {
            get { return Int32.Parse(cb_active.Tag.ToString()); }
            set { cb_active.Tag = value; }
        }

        public EventHandler OnActiveChanged {
            set => cb_active.CheckedChanged += value;
        }

        public TimeRowPanel() {
            InitializeComponent();
        }
    }
}
