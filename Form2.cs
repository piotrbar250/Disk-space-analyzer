using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LabForms
{
    public partial class Form2 : Form
    {

        private void InitializeListView()
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            foreach (DriveInfo d in allDrives)
            {
                if (d.IsReady == true)
                {
                    float div = (float)d.TotalFreeSpace / d.TotalSize;
                    int perc = (int)(div * 100);

                    ListViewItem item = new ListViewItem(d.Name);
                    ProgressBar pb = new ProgressBar();
                    item.SubItems.Add((d.TotalSize / 1000000000).ToString() + " GB");
                    item.SubItems.Add((d.TotalFreeSpace / 1000000000).ToString() + " GB");
                    item.SubItems.Add("");
                    item.SubItems.Add(perc.ToString() + "%");
                    driveslistView.Items.Add(item);

                    ProgressBar progressBar = new ProgressBar();
                    Rectangle r = item.SubItems[3].Bounds;
                    progressBar.SetBounds(r.X, r.Y, r.Width, r.Height);
                    progressBar.Minimum = 0;
                    progressBar.Maximum = (int)(d.TotalSize / 1000000000);
                    progressBar.Value = (int)((d.TotalSize - d.TotalFreeSpace) / 1000000000);
                    driveslistView.Controls.Add(progressBar);
                }
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(!Directory.Exists(textBox1.Text))
            {
                textBox1.ForeColor = Color.Red;
                return;
            }

            if (onefolder == true)
            {
                Form1.path = textBox1.Text;
            }

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void broweseButton_Click(object sender, EventArgs e)
        {
            DialogResult drResult = folderBrowserDialog1.ShowDialog();
            if (drResult == System.Windows.Forms.DialogResult.OK)
                textBox1.Text = folderBrowserDialog1.SelectedPath;
        }

        enum Mode
        {
            None,
            All,
            Individual,
            Folder
        }

        private Mode mode;
        private string chosen_drive = "";
        bool onefolder = true;
        public Form2()
        {
            InitializeComponent();
            mode = Mode.All;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            switch (mode)
            {
                case Mode.None:
                    Form1.path = "";
                    Form1.dialog_exit_status = Form1.dialog_exit_status_options.none;
                    break;

                case Mode.All:
                    Form1.path = "";
                    Form1.dialog_exit_status = Form1.dialog_exit_status_options.all;
                    break;

                case Mode.Individual:
                    Form1.path = chosen_drive;
                    Form1.dialog_exit_status = Form1.dialog_exit_status_options.indi;
                    break;

                case Mode.Folder:
                    Form1.path = textBox1.Text;
                    Form1.dialog_exit_status = Form1.dialog_exit_status_options.folder;
                    break;
            }
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Form1.DialogboxRunning = false;
        }

        private void allButton_CheckedChanged(object sender, EventArgs e)
        {
            mode = Mode.All;
        }

        private void individualButton_CheckedChanged(object sender, EventArgs e)
        {
            mode = Mode.Individual;
        }

        private void folderButton_CheckedChanged(object sender, EventArgs e)
        {
            mode = Mode.Folder;
        }

        private void driveslistView_Selected_Index_Changed(object sender, EventArgs e)
        {
            if (driveslistView.SelectedItems.Count > 0)
            {
                chosen_drive = driveslistView.SelectedItems[0].SubItems[0].Text;
                individualButton.PerformClick();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            InitializeListView();
            textBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox1.AutoCompleteSource = AutoCompleteSource.FileSystem;
        }
    }
}

//individualButton.PerformClick();
//string message = "Simple MessageBoxssss";
//MessageBox.Show(message);