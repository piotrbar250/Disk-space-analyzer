namespace LabForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            selectToolStripMenuItem = new ToolStripMenuItem();
            cancelToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            splitContainer1 = new SplitContainer();
            tableLayoutPanel1 = new TableLayoutPanel();
            buttonSelect = new Button();
            treeView1 = new TreeView();
            buttonStop = new Button();
            buttonStart = new Button();
            progress = new ProgressBar();
            labelProgress = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            labelLastChange = new Label();
            labelSubdirs = new Label();
            labelFiles = new Label();
            labelItems = new Label();
            labelSize = new Label();
            labelFullPath = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            toolTip1 = new ToolTip(components);
            backgroundWorker = new System.ComponentModel.BackgroundWorker();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(784, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { selectToolStripMenuItem, cancelToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // selectToolStripMenuItem
            // 
            selectToolStripMenuItem.Name = "selectToolStripMenuItem";
            selectToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            selectToolStripMenuItem.Size = new Size(180, 22);
            selectToolStripMenuItem.Text = "Select";
            selectToolStripMenuItem.Click += selectToolStripMenuItem_Click;
            // 
            // cancelToolStripMenuItem
            // 
            cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
            cancelToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.T;
            cancelToolStripMenuItem.Size = new Size(180, 22);
            cancelToolStripMenuItem.Text = "Cancel";
            cancelToolStripMenuItem.Click += cancelToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.F4;
            exitToolStripMenuItem.Size = new Size(180, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(107, 22);
            aboutToolStripMenuItem.Text = "About";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 24);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(buttonStop);
            splitContainer1.Panel2.Controls.Add(buttonStart);
            splitContainer1.Panel2.Controls.Add(progress);
            splitContainer1.Panel2.Controls.Add(labelProgress);
            splitContainer1.Panel2.Controls.Add(tabControl1);
            splitContainer1.Size = new Size(784, 426);
            splitContainer1.SplitterDistance = 141;
            splitContainer1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(buttonSelect, 0, 0);
            tableLayoutPanel1.Controls.Add(treeView1, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.338028F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 93.66197F));
            tableLayoutPanel1.Size = new Size(141, 426);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // buttonSelect
            // 
            buttonSelect.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSelect.Location = new Point(63, 3);
            buttonSelect.Name = "buttonSelect";
            buttonSelect.Size = new Size(75, 21);
            buttonSelect.TabIndex = 0;
            buttonSelect.Text = "Select";
            buttonSelect.UseVisualStyleBackColor = true;
            buttonSelect.Click += buttonSelect_Click;
            // 
            // treeView1
            // 
            treeView1.Dock = DockStyle.Fill;
            treeView1.Location = new Point(3, 30);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(135, 393);
            treeView1.TabIndex = 1;
            treeView1.AfterSelect += treeView1_AfterSelect;
            // 
            // buttonStop
            // 
            buttonStop.Location = new Point(548, 380);
            buttonStop.Name = "buttonStop";
            buttonStop.Size = new Size(75, 23);
            buttonStop.TabIndex = 4;
            buttonStop.Text = "Stop";
            buttonStop.UseVisualStyleBackColor = true;
            buttonStop.Click += buttonStop_Click;
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(467, 380);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(75, 23);
            buttonStart.TabIndex = 3;
            buttonStart.Text = "Start";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // progress
            // 
            progress.Location = new Point(19, 351);
            progress.Name = "progress";
            progress.Size = new Size(604, 23);
            progress.TabIndex = 2;
            progress.Click += progressBar1_Click;
            // 
            // labelProgress
            // 
            labelProgress.AutoSize = true;
            labelProgress.Location = new Point(269, 333);
            labelProgress.Name = "labelProgress";
            labelProgress.Size = new Size(98, 15);
            labelProgress.TabIndex = 1;
            labelProgress.Text = "Processing .... 0%";
            labelProgress.Click += label1_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(15, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(612, 292);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(labelLastChange);
            tabPage1.Controls.Add(labelSubdirs);
            tabPage1.Controls.Add(labelFiles);
            tabPage1.Controls.Add(labelItems);
            tabPage1.Controls.Add(labelSize);
            tabPage1.Controls.Add(labelFullPath);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(604, 264);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Details";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click_1;
            // 
            // labelLastChange
            // 
            labelLastChange.AutoSize = true;
            labelLastChange.Location = new Point(101, 133);
            labelLastChange.Name = "labelLastChange";
            labelLastChange.Size = new Size(44, 15);
            labelLastChange.TabIndex = 11;
            labelLastChange.Text = "label12";
            // 
            // labelSubdirs
            // 
            labelSubdirs.AutoSize = true;
            labelSubdirs.Location = new Point(101, 109);
            labelSubdirs.Name = "labelSubdirs";
            labelSubdirs.Size = new Size(44, 15);
            labelSubdirs.TabIndex = 10;
            labelSubdirs.Text = "label11";
            // 
            // labelFiles
            // 
            labelFiles.AutoSize = true;
            labelFiles.Location = new Point(101, 85);
            labelFiles.Name = "labelFiles";
            labelFiles.Size = new Size(44, 15);
            labelFiles.TabIndex = 9;
            labelFiles.Text = "label10";
            // 
            // labelItems
            // 
            labelItems.AutoSize = true;
            labelItems.Location = new Point(101, 61);
            labelItems.Name = "labelItems";
            labelItems.Size = new Size(38, 15);
            labelItems.TabIndex = 8;
            labelItems.Text = "label9";
            // 
            // labelSize
            // 
            labelSize.AutoSize = true;
            labelSize.Location = new Point(101, 37);
            labelSize.Name = "labelSize";
            labelSize.Size = new Size(38, 15);
            labelSize.TabIndex = 7;
            labelSize.Text = "label8";
            // 
            // labelFullPath
            // 
            labelFullPath.AutoSize = true;
            labelFullPath.Location = new Point(101, 12);
            labelFullPath.Name = "labelFullPath";
            labelFullPath.Size = new Size(38, 15);
            labelFullPath.TabIndex = 6;
            labelFullPath.Text = "label7";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 133);
            label6.Name = "label6";
            label6.Size = new Size(73, 15);
            label6.TabIndex = 5;
            label6.Text = "Last change:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 109);
            label5.Name = "label5";
            label5.Size = new Size(46, 15);
            label5.TabIndex = 4;
            label5.Text = "Subdirs";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 85);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 3;
            label4.Text = "Files:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 61);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 2;
            label3.Text = "Items:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 37);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 1;
            label2.Text = "Size:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 12);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 0;
            label1.Text = "Full path:";
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new Size(604, 264);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Charts";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // backgroundWorker
            // 
            backgroundWorker.WorkerReportsProgress = true;
            backgroundWorker.WorkerSupportsCancellation = true;
            backgroundWorker.DoWork += backgroundWorker_DoWork;
            backgroundWorker.ProgressChanged += backgroundWorker_ProgressChanged;
            backgroundWorker.RunWorkerCompleted += backgroundWorker_RunWorkerCompleted;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 450);
            Controls.Add(splitContainer1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(800, 450);
            Name = "Form1";
            Text = "Dik Space Analyzer";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem selectToolStripMenuItem;
        private ToolStripMenuItem cancelToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private SplitContainer splitContainer1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button buttonSelect;
        private TreeView treeView1;
        private ToolTip toolTip1;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private TabControl tabControl1;
        private Label labelProgress;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ProgressBar progress;
        private Button buttonStop;
        private Button buttonStart;
        private Label labelLastChange;
        private Label labelSubdirs;
        private Label labelFiles;
        private Label labelItems;
        private Label labelSize;
        private Label labelFullPath;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}