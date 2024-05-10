namespace LabForms
{
    partial class Form2
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
            components = new System.ComponentModel.Container();
            bindingSource1 = new BindingSource(components);
            tableLayoutPanel1 = new TableLayoutPanel();
            individualButton = new RadioButton();
            allButton = new RadioButton();
            folderButton = new RadioButton();
            driveslistView = new ListView();
            columnHeader1 = new ColumnHeader();
            Total = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            flowLayoutPanel1 = new FlowLayoutPanel();
            textBox1 = new TextBox();
            button1 = new Button();
            flowLayoutPanel2 = new FlowLayoutPanel();
            okButton = new Button();
            cancelButton = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            folderBrowserDialog2 = new FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(individualButton, 0, 1);
            tableLayoutPanel1.Controls.Add(allButton, 0, 0);
            tableLayoutPanel1.Controls.Add(folderButton, 0, 3);
            tableLayoutPanel1.Controls.Add(driveslistView, 0, 2);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 4);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel2, 0, 5);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 45.34884F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 54.65116F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 69F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel1.Size = new Size(484, 261);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // individualButton
            // 
            individualButton.AutoSize = true;
            individualButton.Location = new Point(3, 41);
            individualButton.Name = "individualButton";
            individualButton.Size = new Size(106, 19);
            individualButton.TabIndex = 1;
            individualButton.TabStop = true;
            individualButton.Text = "Individual drive";
            individualButton.UseVisualStyleBackColor = true;
            individualButton.CheckedChanged += individualButton_CheckedChanged;
            // 
            // allButton
            // 
            allButton.AutoSize = true;
            allButton.Location = new Point(3, 3);
            allButton.Name = "allButton";
            allButton.Size = new Size(101, 19);
            allButton.TabIndex = 0;
            allButton.TabStop = true;
            allButton.Text = "All local drives";
            allButton.UseVisualStyleBackColor = true;
            allButton.CheckedChanged += allButton_CheckedChanged;
            // 
            // folderButton
            // 
            folderButton.AutoSize = true;
            folderButton.Location = new Point(3, 155);
            folderButton.Name = "folderButton";
            folderButton.Size = new Size(67, 19);
            folderButton.TabIndex = 2;
            folderButton.TabStop = true;
            folderButton.Text = "A folder";
            folderButton.UseVisualStyleBackColor = true;
            folderButton.CheckedChanged += folderButton_CheckedChanged;
            // 
            // driveslistView
            // 
            driveslistView.Columns.AddRange(new ColumnHeader[] { columnHeader1, Total, columnHeader3, columnHeader4, columnHeader2 });
            driveslistView.Dock = DockStyle.Fill;
            driveslistView.FullRowSelect = true;
            driveslistView.Location = new Point(3, 86);
            driveslistView.Name = "driveslistView";
            driveslistView.Size = new Size(478, 63);
            driveslistView.TabIndex = 3;
            driveslistView.UseCompatibleStateImageBehavior = false;
            driveslistView.View = View.Details;
            driveslistView.SelectedIndexChanged += driveslistView_Selected_Index_Changed;
            // 
            // columnHeader1
            // 
            columnHeader1.Tag = "Name";
            columnHeader1.Text = "Name";
            // 
            // Total
            // 
            Total.Text = "Total";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Free";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Used";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Used/Total";
            columnHeader2.Width = 90;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(textBox1);
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Location = new Point(3, 183);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(478, 38);
            flowLayoutPanel1.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(3, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(391, 23);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(400, 3);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "...";
            button1.UseVisualStyleBackColor = true;
            button1.Click += broweseButton_Click;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            flowLayoutPanel2.Controls.Add(okButton);
            flowLayoutPanel2.Controls.Add(cancelButton);
            flowLayoutPanel2.Location = new Point(315, 227);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(166, 31);
            flowLayoutPanel2.TabIndex = 6;
            // 
            // okButton
            // 
            okButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            okButton.Location = new Point(3, 3);
            okButton.Name = "okButton";
            okButton.Size = new Size(75, 23);
            okButton.TabIndex = 6;
            okButton.Text = "Ok";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cancelButton.Location = new Point(84, 3);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.TabIndex = 7;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // folderBrowserDialog1
            // 
            folderBrowserDialog1.HelpRequest += folderBrowserDialog1_HelpRequest;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 261);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MinimumSize = new Size(500, 300);
            Name = "Form2";
            Text = "Form2";
            FormClosing += Form2_FormClosing;
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private BindingSource bindingSource1;
        private TableLayoutPanel tableLayoutPanel1;
        private RadioButton individualButton;
        private RadioButton allButton;
        private RadioButton folderButton;
        private ListView driveslistView;
        private TextBox textBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button okButton;
        private Button cancelButton;
        private ColumnHeader columnHeader1;
        private ColumnHeader Total;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Button button1;
        private FolderBrowserDialog folderBrowserDialog1;
        private FolderBrowserDialog folderBrowserDialog2;
        private ColumnHeader columnHeader2;
    }
}