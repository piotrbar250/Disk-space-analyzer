using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.DataFormats;
using System.Security.AccessControl;
using System.Security.Principal;

namespace LabForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeTabControl();
            treeView1.Nodes.Clear();

            LoadDirectory(path);
        }
        private void InitializeTabControl()
        {
            labelFullPath.Text = "";
            labelSize.Text = "";
            labelItems.Text = "";
            labelFiles.Text = "";
            labelSubdirs.Text = "";
            labelLastChange.Text = "";

            progress.Value = 0;
            labelProgress.Text = $"Processing ...0%";
            progress.Update();

        }
        public void LoadDirectory(string Dir)
        {

            //treeView1.Nodes.Clear();
            DirectoryInfo di = new DirectoryInfo(Dir);

            //Setting ProgressBar Maximum Value
            //progressBar1.Maximum = Directory.GetFiles(Dir, "*.*", SearchOption.AllDirectories).Length + Directory.GetDirectories(Dir, "**", SearchOption.AllDirectories).Length;
            TreeNode tds = treeView1.Nodes.Add(di.Name);
            tds.Tag = di.FullName;
            tds.StateImageIndex = 0;
            LoadFiles(Dir, tds);
            LoadSubDirectories(Dir, tds);
        }

        private bool HasAccess(string dir)
        {
            string path = dir;

            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            DirectorySecurity directorySecurity = directoryInfo.GetAccessControl();

            AuthorizationRuleCollection accessRules = directorySecurity.GetAccessRules(true, true, typeof(System.Security.Principal.SecurityIdentifier));

            bool hasPermission = false;
            WindowsIdentity currentUser = WindowsIdentity.GetCurrent();
            SecurityIdentifier sid = currentUser.User;

            foreach (FileSystemAccessRule rule in accessRules)
            {
                if (sid.Equals(rule.IdentityReference))
                {
                    if ((FileSystemRights.ReadAndExecute & rule.FileSystemRights) == FileSystemRights.ReadAndExecute)
                    {
                        if (rule.AccessControlType == AccessControlType.Allow)
                        {
                            hasPermission = true;
                            break;
                        }
                    }
                }
            }
            return hasPermission;
        }

        private void LoadSubDirectories(string dir, TreeNode td)
        {
            if (!HasAccess(dir))
                return;
            // Get all subdirectories
            string[] subdirectoryEntries = Directory.GetDirectories(dir);
            // Loop through them to see if they have any other subdirectories
            foreach (string subdirectory in subdirectoryEntries)
            {
                DirectoryInfo di = new DirectoryInfo(subdirectory);
                TreeNode tds = td.Nodes.Add(di.Name);
                tds.StateImageIndex = 0;
                tds.Tag = di.FullName;

                //if (!HasAccess(dir))
                //    return;
                LoadFiles(subdirectory, tds);
                LoadSubDirectories(subdirectory, tds);
                //UpdateProgress();
            }
        }

        private void treeView1_MouseMove(object sender, MouseEventArgs e)
        {
            // Get the node at the current mouse pointer location.
            TreeNode theNode = this.treeView1.GetNodeAt(e.X, e.Y);

            // Set a ToolTip only if the mouse pointer is actually paused on a node.
            if (theNode != null && theNode.Tag != null)
            {
                // Change the ToolTip only if the pointer moved to a new node.
                if (theNode.Tag.ToString() != this.toolTip1.GetToolTip(this.treeView1))
                    this.toolTip1.SetToolTip(this.treeView1, theNode.Tag.ToString());
            }
            else     // Pointer is not over a node so clear the ToolTip.
            {
                this.toolTip1.SetToolTip(this.treeView1, "");
            }
        }

        private void LoadFiles(string dir, TreeNode td)
        {
            string[] Files = Directory.GetFiles(dir, "*.*");
            if (Files.Length <= 3)
            {
                // Loop through them to see files
                foreach (string file in Files)
                {
                    FileInfo fi = new FileInfo(file);
                    TreeNode tds = td.Nodes.Add(fi.Name);
                    tds.Tag = fi.FullName;
                    tds.StateImageIndex = 1;
                }
            }
            else
            {
                TreeNode group_node = td.Nodes.Add("<Files>");
                group_node.Tag = "<Files>";
                foreach (string file in Files)
                {
                    FileInfo fi = new FileInfo(file);
                    TreeNode tds = group_node.Nodes.Add(fi.Name);
                    tds.Tag = fi.FullName;
                    tds.StateImageIndex = 1;
                }
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }



        public enum dialog_exit_status_options
        {
            none,
            all,
            indi,
            folder,
            canceled
        }
        public static dialog_exit_status_options dialog_exit_status = dialog_exit_status_options.canceled;
        public static string path = "C:\\Users\\piotr\\OneDrive\\Pulpit\\4 semestr\\PIGE";
        //public static string path = "C:\\Users\\piotr\\OneDrive\\Pulpit\\4 semestr\\PIGE\\Windows Forms\\test\\test1\\file2.txt";
        //public static string path2 = "C:\\Users\\piotr\\OneDrive\\Pulpit\\4 semestr\\Projektowanie obiektowe";

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            dialog_exit_status = dialog_exit_status_options.canceled;

            Form2 f2 = new Form2();
            f2.ShowDialog();

            switch (dialog_exit_status)
            {
                case dialog_exit_status_options.none:
                    treeView1.Nodes.Clear();
                    InitializeTabControl();
                    break;

                case dialog_exit_status_options.all:
                    treeView1.Nodes.Clear();
                    InitializeTabControl();
                    DriveInfo[] allDrives = DriveInfo.GetDrives();
                    foreach (DriveInfo drive in allDrives)
                    {
                        if (drive.IsReady == true)
                        {
                            LoadDirectory(drive.Name);
                        }
                    }
                    break;

                case dialog_exit_status_options.canceled:
                    break;

                default:
                    treeView1.Nodes.Clear();
                    InitializeTabControl();
                    LoadDirectory(path);
                    break;
            }
        }

        private void selectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonSelect_Click(sender, e);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //System.Text.StringBuilder messageBoxCS = new System.Text.StringBuilder();
            if (treeView1.SelectedNode == null || treeView1.SelectedNode.Tag == "<Files>")
                return;

            string selected_path = (string)e.Node.Tag;
            //int items_count = Directory.GetFileSystemEntries(selected_path, "*", SearchOption.AllDirectories).Length;
            //int files_count = Directory.GetFiles(selected_path, "*", SearchOption.AllDirectories).Length;

            labelFullPath.Text = selected_path;
            labelSize.Text = "";
            labelItems.Text = "";
            labelFiles.Text = "";
            labelSubdirs.Text = "";
            labelLastChange.Text = Directory.GetLastAccessTime(selected_path).ToString();
            progress.Value = 0;
            labelProgress.Text = $"Processing ...0%";
            progress.Update();


            if ((File.GetAttributes(selected_path) & FileAttributes.Directory) == FileAttributes.Directory)
            {
                // The path points to a directory
                directory_data = new Directory_data();
                system_subdirs_count = Directory.GetDirectories(selected_path, "*", SearchOption.AllDirectories).Length;

                //startAsync();
            }
            else
            {
                // The path points to a file
                FileInfo fileInfo = new FileInfo(selected_path);

                labelFullPath.Text = selected_path;
                labelSize.Text += fileInfo.Length.ToString();
                labelItems.Text = "1";
                labelFiles.Text = "1";
                labelSubdirs.Text = "0";
                labelLastChange.Text = Directory.GetLastAccessTime(selected_path).ToString();
                progress.Value = 100;
                labelProgress.Text = $"Processing ...100%";
                progress.Update();
            }
        }

        struct DataParameter
        {
            public string path;
        }

        private DataParameter _inputparameter;

        struct Directory_data
        {
            public long size;
            public int items;
            public int files;
            public int subdirs;
        }

        private Directory_data directory_data;
        private int system_subdirs_count;
        private void backgroundWorker_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            progress.Value = e.ProgressPercentage;
            labelProgress.Text = $"Processing ...{e.ProgressPercentage}%";
            progress.Update();
        }

        private void backgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            string path = _inputparameter.path;
            ThreadLoadDirectory(path);
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            labelSize.Text = directory_data.size.ToString();
            labelItems.Text = directory_data.items.ToString();
            labelFiles.Text = directory_data.files.ToString();
            labelSubdirs.Text = directory_data.subdirs.ToString();
        }

        private void startAsync()
        {
            string selected_path = (string)treeView1.SelectedNode.Tag;
            if (!backgroundWorker.IsBusy)
            {
                _inputparameter.path = selected_path;
                backgroundWorker.RunWorkerAsync(_inputparameter);
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            startAsync();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            if (backgroundWorker.IsBusy)
            {
                backgroundWorker.CancelAsync();
            }
        }

        public void ThreadLoadDirectory(string Dir)
        {
            if (!backgroundWorker.CancellationPending)
            {
                DirectoryInfo di = new DirectoryInfo(Dir);
                ThreadLoadFiles(Dir);
                ThreadLoadSubDirectories(Dir);
            }
        }

        private void ThreadLoadSubDirectories(string dir)
        {
            if (!backgroundWorker.CancellationPending)
            {
                string[] subdirectoryEntries = Directory.GetDirectories(dir);

                foreach (string subdirectory in subdirectoryEntries)
                {
                    DirectoryInfo di = new DirectoryInfo(subdirectory);
                    directory_data.items++;
                    directory_data.subdirs++;
                    float div = (float)(directory_data.subdirs) / system_subdirs_count;
                    int perc = (int)div * 100;
                    backgroundWorker.ReportProgress(perc);
                    ThreadLoadFiles(subdirectory);
                    ThreadLoadSubDirectories(subdirectory);
                }
            }
        }
        private void ThreadLoadFiles(string dir)
        {
            if (!backgroundWorker.CancellationPending)
            {
                string[] Files = Directory.GetFiles(dir, "*.*");
                foreach (string file in Files)
                {
                    FileInfo fi = new FileInfo(file);
                    directory_data.items++;
                    directory_data.files++;
                    directory_data.size += fi.Length;
                }
            }
        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }

        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (backgroundWorker.IsBusy)
            {
                backgroundWorker.CancelAsync();
            }
        }
    }
}



//private void TreeView1_AfterExpand(object sender, TreeViewEventArgs e)
//{
//    System.Text.StringBuilder messageBoxCS = new System.Text.StringBuilder();

//    messageBoxCS.AppendFormat("{0} = {1}", "Node", e.Node.);
//    messageBoxCS.AppendLine();
//    messageBoxCS.AppendFormat("{0} = {1}", "Action", e.Action);
//    messageBoxCS.AppendLine();
//    MessageBox.Show(messageBoxCS.ToString(), "AfterExpand Event");
//}