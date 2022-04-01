namespace WinFormsApp_JustFields
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.CBPreSetList = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BTNDemo = new System.Windows.Forms.Button();
            this.BTNProcess = new System.Windows.Forms.Button();
            this.RTBOutput = new System.Windows.Forms.RichTextBox();
            this.RTBMainFilter = new System.Windows.Forms.RichTextBox();
            this.RTBPreFilter = new System.Windows.Forms.RichTextBox();
            this.RTBInput = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(813, 387);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.Controls.Add(this.CBPreSetList);
            this.tabPage1.Controls.Add(this.richTextBox1);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.BTNDemo);
            this.tabPage1.Controls.Add(this.BTNProcess);
            this.tabPage1.Controls.Add(this.RTBOutput);
            this.tabPage1.Controls.Add(this.RTBMainFilter);
            this.tabPage1.Controls.Add(this.RTBPreFilter);
            this.tabPage1.Controls.Add(this.RTBInput);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(805, 359);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // CBPreSetList
            // 
            this.CBPreSetList.FormattingEnabled = true;
            this.CBPreSetList.Items.AddRange(new object[] {
            "Demo"});
            this.CBPreSetList.Location = new System.Drawing.Point(659, 74);
            this.CBPreSetList.Name = "CBPreSetList";
            this.CBPreSetList.Size = new System.Drawing.Size(140, 23);
            this.CBPreSetList.TabIndex = 11;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(225, 305);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(422, 41);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(451, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Output";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(227, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Main-filter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(226, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Pre-filter";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Input";
            // 
            // BTNDemo
            // 
            this.BTNDemo.Location = new System.Drawing.Point(656, 23);
            this.BTNDemo.Name = "BTNDemo";
            this.BTNDemo.Size = new System.Drawing.Size(143, 45);
            this.BTNDemo.TabIndex = 5;
            this.BTNDemo.Text = "Load preset";
            this.BTNDemo.UseVisualStyleBackColor = true;
            this.BTNDemo.Click += new System.EventHandler(this.BTNDemo_Click);
            // 
            // BTNProcess
            // 
            this.BTNProcess.Location = new System.Drawing.Point(6, 305);
            this.BTNProcess.Name = "BTNProcess";
            this.BTNProcess.Size = new System.Drawing.Size(197, 41);
            this.BTNProcess.TabIndex = 4;
            this.BTNProcess.Text = "Process";
            this.BTNProcess.UseVisualStyleBackColor = true;
            this.BTNProcess.Click += new System.EventHandler(this.button1_Click);
            // 
            // RTBOutput
            // 
            this.RTBOutput.Location = new System.Drawing.Point(451, 23);
            this.RTBOutput.Name = "RTBOutput";
            this.RTBOutput.Size = new System.Drawing.Size(196, 262);
            this.RTBOutput.TabIndex = 3;
            this.RTBOutput.Text = "";
            // 
            // RTBMainFilter
            // 
            this.RTBMainFilter.Location = new System.Drawing.Point(227, 172);
            this.RTBMainFilter.Name = "RTBMainFilter";
            this.RTBMainFilter.Size = new System.Drawing.Size(197, 113);
            this.RTBMainFilter.TabIndex = 2;
            this.RTBMainFilter.Text = "";
            // 
            // RTBPreFilter
            // 
            this.RTBPreFilter.Location = new System.Drawing.Point(227, 36);
            this.RTBPreFilter.Name = "RTBPreFilter";
            this.RTBPreFilter.Size = new System.Drawing.Size(197, 114);
            this.RTBPreFilter.TabIndex = 1;
            this.RTBPreFilter.Text = "";
            // 
            // RTBInput
            // 
            this.RTBInput.Location = new System.Drawing.Point(6, 23);
            this.RTBInput.Name = "RTBInput";
            this.RTBInput.Size = new System.Drawing.Size(197, 262);
            this.RTBInput.TabIndex = 0;
            this.RTBInput.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(805, 359);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 406);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private RichTextBox RTBOutput;
        private RichTextBox RTBMainFilter;
        private RichTextBox RTBPreFilter;
        private RichTextBox RTBInput;
        private TabPage tabPage2;
        private Button BTNProcess;
        private Button BTNDemo;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private RichTextBox richTextBox1;
        private ComboBox CBPreSetList;
    }
}