using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.VisualBasic;

namespace TimeProtocol {
    public partial class ProtocolManager : Form {
        public ProtocolManager() {
            InitializeComponent();
        }

        private Button currentlySelected;

        private void ProtocolManager_Load(object sender, EventArgs e) {
            // Search for all files *.cstp in the Application Path
            List<String> fileList = Directory.GetFiles(Application.StartupPath, "*.cstp", SearchOption.TopDirectoryOnly).ToList();
            for(int i = 0; i < fileList.Count; ++i) {
                string[] fileNamesArr = fileList[i].Split('\\');
                string filename = fileNamesArr[fileNamesArr.Length - 1];
                Button newButton = CreateButton(filename);
                panel_timePMan.Controls.Add(newButton);
                newButton.Location = new Point((i % 2) * 200, 20 * (i - (i % 2)));
            }
        }

        private Button CreateButton(string filename) {
            Button btn = new Button {
                Width = 194,
                Height = 31,
                Text = filename,
                TextAlign = ContentAlignment.MiddleLeft,
                ContextMenuStrip = contextMenuStrip1,
                FlatStyle = FlatStyle.Flat
            };
            btn.MouseDown += Btn_click;
            btn.Font = new Font(btn.Font.FontFamily, 14.25f);
            return btn;
        }

        private void Btn_click(object sender, MouseEventArgs e) {
            currentlySelected = (Button)sender;
            if(e.Button == MouseButtons.Left) {
                Button btn = (Button)sender;
                // Start with the selected file
                ProcessStartInfo startInfo = Process.GetCurrentProcess().StartInfo;
                startInfo.FileName = Application.ExecutablePath;
                startInfo.Arguments = btn.Text;
                var exit = typeof(Application).GetMethod("ExitInternal", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Static);
                exit.Invoke(null, null);
                Process.Start(startInfo);
            }
        }

        private void NewMenu_Click(object sender, EventArgs e) {
            string tp;
            do { // Let the user choose a name
                tp = Interaction.InputBox("Time Protocol Name", "", "tp" + panel_timePMan.Controls.Count);
                if (File.Exists(Application.StartupPath + "\\" + tp + ".cstp")) {
                    MessageBox.Show($"A file with the name {tp}.cstp already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } while (File.Exists(Application.StartupPath + "\\" + tp + ".cstp"));

            if (String.IsNullOrWhiteSpace(tp) || tp == "")
                return;
            
            DialogResult res = MessageBox.Show("Create Desktop shortcut?", "Shortcut", MessageBoxButtons.YesNo);
            if(res == DialogResult.Yes) 
                //Create empty file on the Desktop with the right name and extension
                File.Create(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory), tp + ".cstp")).Close();

            // Create the real file at the Application path
            File.Create(Application.StartupPath + "\\" + tp + ".cstp").Close();

            //add the Button
            Button btn = CreateButton(tp + ".cstp");
            int i = panel_timePMan.Controls.Count;
            btn.Location = new Point((i % 2) * 200, 20 * (i - (i % 2)));
            panel_timePMan.Controls.Add(btn);
        }

        private void Btn_createDesktopShortcut_Click(object sender, EventArgs e) {
            File.Create(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory), currentlySelected.Text)).Close();
        }
    }
}
