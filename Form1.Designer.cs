namespace WindowsFormsApplication2
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.NumberInput = new System.Windows.Forms.TextBox();
            this.NumberCheckLabel = new System.Windows.Forms.Label();
            this.LookupNumButton = new System.Windows.Forms.Button();
            this.ProviderOutputBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.LoadFileTextBox = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.emailOutTextbox = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // NumberInput
            // 
            this.NumberInput.Location = new System.Drawing.Point(120, 17);
            this.NumberInput.Name = "NumberInput";
            this.NumberInput.Size = new System.Drawing.Size(271, 20);
            this.NumberInput.TabIndex = 0;
            this.NumberInput.TextChanged += new System.EventHandler(this.NumberInput_TextChanged);
            // 
            // NumberCheckLabel
            // 
            this.NumberCheckLabel.AutoSize = true;
            this.NumberCheckLabel.BackColor = System.Drawing.Color.Transparent;
            this.NumberCheckLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberCheckLabel.Location = new System.Drawing.Point(12, 20);
            this.NumberCheckLabel.Name = "NumberCheckLabel";
            this.NumberCheckLabel.Size = new System.Drawing.Size(102, 15);
            this.NumberCheckLabel.TabIndex = 1;
            this.NumberCheckLabel.Text = "Number to Check";
            // 
            // LookupNumButton
            // 
            this.LookupNumButton.Location = new System.Drawing.Point(397, 15);
            this.LookupNumButton.Name = "LookupNumButton";
            this.LookupNumButton.Size = new System.Drawing.Size(75, 23);
            this.LookupNumButton.TabIndex = 2;
            this.LookupNumButton.Text = "Lookup";
            this.LookupNumButton.UseVisualStyleBackColor = true;
            this.LookupNumButton.Click += new System.EventHandler(this.LookupNumButton_Click);
            // 
            // ProviderOutputBox
            // 
            this.ProviderOutputBox.BackColor = System.Drawing.SystemColors.Window;
            this.ProviderOutputBox.Location = new System.Drawing.Point(0, 0);
            this.ProviderOutputBox.Multiline = true;
            this.ProviderOutputBox.Name = "ProviderOutputBox";
            this.ProviderOutputBox.ReadOnly = true;
            this.ProviderOutputBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ProviderOutputBox.Size = new System.Drawing.Size(482, 226);
            this.ProviderOutputBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(-2, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(498, 2);
            this.label3.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("DengXian", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Location = new System.Drawing.Point(-2, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(494, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "Load Rules Database";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(397, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Load";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 353);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Database Path";
            // 
            // LoadFileTextBox
            // 
            this.LoadFileTextBox.Location = new System.Drawing.Point(106, 351);
            this.LoadFileTextBox.Name = "LoadFileTextBox";
            this.LoadFileTextBox.Size = new System.Drawing.Size(285, 20);
            this.LoadFileTextBox.TabIndex = 8;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "DatabaseLoadFile";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 43);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(490, 251);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ProviderOutputBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(482, 225);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Full Provider Output";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.emailOutTextbox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(482, 225);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Email Address Output";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // emailOutTextbox
            // 
            this.emailOutTextbox.BackColor = System.Drawing.SystemColors.Window;
            this.emailOutTextbox.Location = new System.Drawing.Point(0, 0);
            this.emailOutTextbox.Multiline = true;
            this.emailOutTextbox.Name = "emailOutTextbox";
            this.emailOutTextbox.ReadOnly = true;
            this.emailOutTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.emailOutTextbox.Size = new System.Drawing.Size(482, 226);
            this.emailOutTextbox.TabIndex = 5;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(331, 41);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(146, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Ignore non-email domains";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(397, 396);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(91, 10);
            this.progressBar1.TabIndex = 13;
            this.progressBar1.Visible = false;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(-3, 391);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(498, 2);
            this.label1.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 396);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Ready - No Rules Database Loaded";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(492, 411);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LoadFileTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LookupNumButton);
            this.Controls.Add(this.NumberCheckLabel);
            this.Controls.Add(this.NumberInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Number Provider Lookup Tool by Chris Boseak";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NumberInput;
        private System.Windows.Forms.Label NumberCheckLabel;
        private System.Windows.Forms.Button LookupNumButton;
        private System.Windows.Forms.TextBox ProviderOutputBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox LoadFileTextBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox emailOutTextbox;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}

