using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using OfficeOpenXml;

namespace TimeProtocol {
    public partial class mainFrame : Form {

        private DateTime startTime; //Date when the timer was started
        private DateTime stopTime;  //Date when the timer was stopped

        private TimeSpan totalTime; //Overall total of time elapsed

        private DataManager dataManager; 

        private bool timerRunning = false;

        public mainFrame() {
            InitializeComponent();
        }


        private void MainFrame_Load(object sender, EventArgs e) {
            Setup();
            this.FormClosing += Form_close;
        }

        private void Setup(string path = "default.cstp") {
            string pathDisp = path;

            // Get and customize Console arguments
            path = Application.StartupPath + "\\" + path;
            string[] args = Environment.GetCommandLineArgs();
            if (!(args.Length <= 1 || args == null || String.IsNullOrWhiteSpace(args[1]) || args[1] == "")) {
                // Filter out just the filename (without path)
                string[] argArr = args[1].Split('\\');
                argArr[argArr.Length - 1] = argArr[argArr.Length - 1].Replace(".cstp", "");
                path = Application.StartupPath + "\\" + argArr[argArr.Length - 1] + ".cstp";
                pathDisp = argArr[argArr.Length - 1] + ".cstp";
            }
            // Create the DataManager on the file representation in the Application Path
            dataManager = new DataManager(path);
            lblFile.Text = "Time File: " + pathDisp;

            TimeSpan timeCount = new TimeSpan();

            int count = dataManager.GetJsonObject().timeItems.Count;
            for (int i = 0; i < count; i++) {
                // Read all TimeSplits in the Time file
                TimeItem tI = dataManager.GetJsonObject().timeItems[i];
                TimeItem _tI = new TimeItem {
                    Name = tI.Name,
                    dateStart = tI.dateStart,
                    dateStop = tI.dateStop,
                    description = tI.description
                };
                // Calculate time delta
                TimeSpan span = _tI.dateStop - _tI.dateStart;
                _tI.timeDifference = $"{span.Hours}:{span.Minutes}:{span.Seconds}";
                tI.timeDifference = _tI.timeDifference;
                dataManager.Save();

                timeCount += span;

                // Create the final Row Control object
                string startTime = $"{_tI.dateStart.Hour}:{_tI.dateStart.Minute}:{_tI.dateStart.Second} {_tI.dateStart.ToString("dd/MM")}";
                string stopTime = $"{_tI.dateStop.Hour}:{_tI.dateStop.Minute}:{_tI.dateStop.Second} {_tI.dateStop.ToString("dd/MM")}";
                
                TimeRowPanel rowPanel = CreateNewRow(i, _tI.Name, startTime, stopTime, _tI.timeDifference, _tI.description);
                panel_time.Controls.Add(rowPanel);
                rowPanel.Location = new Point(0, i * rowPanel.Height);
            }
            // Update the total Time
            totalTime = timeCount;
            dataManager.GetJsonObject().totalTime = timeCount;
            dataManager.Save();
            lblTotalTime.Text = $"{totalTime.Days}d:{totalTime.Hours}h:{totalTime.Minutes}m:{totalTime.Seconds}s";
        }


        // Returns a new TimeRowPanel object
        private TimeRowPanel CreateNewRow(int index, string name, string startTime, string stopTime, string delta, string description) {
            TimeRowPanel rowPanel = new TimeRowPanel {
                Index = index,
                SplitName = name,
                StartTime = startTime,
                StopTime = stopTime,
                Delta = delta,
                SplitDescription = description,
                Anchor = (AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left),
                Width = panel_time.Width,

                OnActiveChanged = CalcActivatedTimes
            };
            return rowPanel;
        }

        private void StartTimer_click(object sender, EventArgs e) {
            DialogResult res;
            if (timerRunning) // Is the Timer already running?
                res = MessageBox.Show("Start new Timer?", "Start", MessageBoxButtons.YesNo);
             else  // No timer running at the moment
                res = DialogResult.Yes;
            
            if (res == DialogResult.Yes) {
                //Start the timer
                startTime = DateTime.Now;
                txtB_startTime.Text = startTime.Hour + ":" + startTime.Minute + ":" + startTime.Second + " " + startTime.ToString("dd/MM");
                txtB_stopTime.Text = "";

                timerRunning = true;
            }
        }

        private void StopTimer_click(object sender, EventArgs e) {
            if (!timerRunning) {
                MessageBox.Show("You haven't started a Timer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!String.IsNullOrWhiteSpace(txtB_stopTime.Text) || txtB_stopTime.Text != "") {  //Timer already stopped
                DialogResult res = MessageBox.Show("Overwrite current Stop Time?", "Stop", MessageBoxButtons.YesNo);
                if (res == DialogResult.No)
                    return;
            }
            //Stop the timer
            stopTime = DateTime.Now;
            txtB_stopTime.Text = $"{stopTime.Hour}:{stopTime.Minute}:{stopTime.Second} {stopTime.ToString("dd/MM")}";
            timerRunning = false;
        }

        private void AddTime_click(object sender, EventArgs e) {
            if (String.IsNullOrWhiteSpace(txtB_startTime.Text) || txtB_startTime.Text == "" || String.IsNullOrWhiteSpace(txtB_stopTime.Text) || txtB_stopTime.Text == "" || timerRunning) {
                MessageBox.Show("No Timer entry!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create new TimerRowPanel Control object
            TimeSpan span = stopTime - startTime;
            TimeRowPanel rowPanel = CreateNewRow(panel_time.Controls.Count, txtB_name.Text, txtB_startTime.Text, txtB_stopTime.Text, $"{span.Hours}:{span.Minutes}:{span.Seconds}", txtB_description.Text);
            if (panel_time.Controls.Count > 0) {
                rowPanel.Location = new Point(0, panel_time.Controls[panel_time.Controls.Count - 1].Location.Y + rowPanel.Height);
            }else {
                rowPanel.Location = new Point(0, 0);
            }
            panel_time.Controls.Add(rowPanel);

            // Create an entry in the Time file
            TimeItem tI = new TimeItem {
                Name = txtB_name.Text,
                timeDifference = $"{span.Hours}:{span.Minutes}:{span.Seconds}",
                description = txtB_description.Text,
                dateStart = startTime,
                dateStop = stopTime
            };
            dataManager.GetJsonObject().timeItems.Add(tI);
            // update total time
            totalTime += span;
            lblTotalTime.Text = $"{totalTime.Days}d:{totalTime.Hours}h:{totalTime.Minutes}m:{totalTime.Seconds}s";
            dataManager.GetJsonObject().totalTime = totalTime;
            dataManager.Save();

            // Reset timer text boxes
            txtB_description.Text = "";
            txtB_name.Text = "";
            txtB_startTime.Text = "";
            txtB_stopTime.Text = "";
        }

        // Event when a Time Split has been activated/deactivated
        private void CalcActivatedTimes(object sender, EventArgs e) {
            CheckBox cb = (CheckBox)sender;
            TimeItem ti = dataManager.GetJsonObject().timeItems[Int32.Parse(cb.Tag.ToString())]; 
            //update total time based on checked state
            if (cb.Checked)
                totalTime += (ti.dateStop - ti.dateStart);
            else
                totalTime -= (ti.dateStop - ti.dateStart);

            lblTotalTime.Text = $"{totalTime.Days}d:{totalTime.Hours}h:{totalTime.Minutes}m:{totalTime.Seconds}s";
        }

        

        private void Form_close(object sender, CancelEventArgs e) {
            // Warn on close if the timer is running
            if (timerRunning) {
                DialogResult res = MessageBox.Show("The Timer is running and won't be saved.\nAre you sure you want to close the Application?", "Close", MessageBoxButtons.YesNo);
                if (res == DialogResult.No) {
                    e.Cancel = true;
                }
            }
            dataManager.Save();
        }

        private void Btn_save_Click(object sender, EventArgs e) {
            dataManager.Save();
        }

        private void Btn_protocolMan_Click(object sender, EventArgs e) {
            // Open the Protocol Manager
            using (ProtocolManager PMan = new ProtocolManager()) {
                PMan.ShowDialog();
            }
        }

        private void Btn_close_Click(object sender, EventArgs e) {
            Application.Exit();
        }


        private void Btn_openTimeFile_Click(object sender, EventArgs e) {
            // Open the associated Time file
            String file = dataManager.GetJsonFile();
            System.Diagnostics.Process.Start("notepad.exe", file);
        }

        private void Btn_createExcelFile_Click(object sender, EventArgs e) {
            using (ExcelPackage excel = new ExcelPackage()) {
                excel.Workbook.Worksheets.Add("Worksheet1");
                FileInfo excelFile;
                if (folderBrowser.ShowDialog() == DialogResult.OK) {
                    String file = dataManager.GetJsonFile();
                    String[] fileArr = file.Split('\\');
                    file = fileArr[fileArr.Length - 1].Substring(0, fileArr[fileArr.Length - 1].Length - 5);
                    String filename = $"{folderBrowser.SelectedPath}\\{file}.xlsx";
                    Console.WriteLine(filename);
                    excelFile = new FileInfo(@filename);
                    
                } else {
                    excel.Dispose();
                    return;
                }
                var headerRow = new List<string[]> {
                    new string[] {"Name", "Start Time", "Stop Time", "Delta Time", "Description"}
                };
                string headerRange = "A1:" + Char.ConvertFromUtf32(headerRow[0].Length + 64) + "1";

                var worksheet = excel.Workbook.Worksheets["Worksheet1"];
                worksheet.Cells[headerRange].LoadFromArrays(headerRow);

                var cellData = new List<string[]>();
                // Write time data in the excel file
                foreach(TimeItem ti in dataManager.GetJsonObject().timeItems) {
                    cellData.Add(new string[] {
                        ti.Name, ti.dateStart.ToString(), ti.dateStop.ToString(), ti.timeDifference, ti.description
                    });
                }

                worksheet.Cells[2, 1].LoadFromArrays(cellData);

                for (int i = 0; i < dataManager.GetJsonObject().timeItems.Count; ++i) {
                    worksheet.Cells[$"B{i + 2}"].Style.Numberformat.Format = "dd/mm/yyyy hh:mm:ss";
                    worksheet.Cells[$"C{i + 2}"].Style.Numberformat.Format = "dd/mm/yyyy hh:mm:ss";
                    worksheet.Cells[$"D{i + 2}"].Style.Numberformat.Format = "hh:mm:ss";
                }


                try {
                    excel.SaveAs(excelFile);
                }catch(Exception ex) {
                    MessageBox.Show($"Error: {ex.Data}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (Type.GetTypeFromProgID("Excel.Application") != null)
                    System.Diagnostics.Process.Start(excelFile.ToString());
            }
        }

        //Manage Resizing
        private void OnResizeStart(object sender, EventArgs e) {
            this.SuspendLayout(); // Pause layout on resize
        }

        private void OnResizeEnd(object sender, EventArgs e) {
            this.ResumeLayout(true); // Resume layout on resize end
        }
    }
}
