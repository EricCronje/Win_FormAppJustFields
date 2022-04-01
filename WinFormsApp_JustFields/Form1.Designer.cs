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
            this.BTNProcess = new System.Windows.Forms.Button();
            this.RTBOutput = new System.Windows.Forms.RichTextBox();
            this.RTBMainFilter = new System.Windows.Forms.RichTextBox();
            this.RTBPreFilter = new System.Windows.Forms.RichTextBox();
            this.RTBInput = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.BTNDemo = new System.Windows.Forms.Button();
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
            this.tabControl1.Size = new System.Drawing.Size(759, 380);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.Controls.Add(this.BTNDemo);
            this.tabPage1.Controls.Add(this.BTNProcess);
            this.tabPage1.Controls.Add(this.RTBOutput);
            this.tabPage1.Controls.Add(this.RTBMainFilter);
            this.tabPage1.Controls.Add(this.RTBPreFilter);
            this.tabPage1.Controls.Add(this.RTBInput);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(751, 352);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            this.tabPage2.Size = new System.Drawing.Size(751, 352);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // BTNDemo
            // 
            this.BTNDemo.Location = new System.Drawing.Point(656, 23);
            this.BTNDemo.Name = "BTNDemo";
            this.BTNDemo.Size = new System.Drawing.Size(92, 41);
            this.BTNDemo.TabIndex = 5;
            this.BTNDemo.Text = "Demo";
            this.BTNDemo.UseVisualStyleBackColor = true;
            this.BTNDemo.Click += new System.EventHandler(this.BTNDemo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
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
    }
}