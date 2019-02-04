namespace SpeechMetricon
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openLeftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.punctuationCheckBox = new System.Windows.Forms.CheckBox();
            this.apostrophesCheckBox = new System.Windows.Forms.CheckBox();
            this.pronounsCheckBox2 = new System.Windows.Forms.CheckBox();
            this.caseSensitiveCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.totalLinesLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.serLabel = new System.Windows.Forms.Label();
            this.werLabel = new System.Windows.Forms.Label();
            this.wcrLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(811, 343);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dataGridView1_RowStateChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(13, 395);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBox1.Size = new System.Drawing.Size(811, 84);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(966, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openLeftToolStripMenuItem,
            this.makeReportToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openLeftToolStripMenuItem
            // 
            this.openLeftToolStripMenuItem.Name = "openLeftToolStripMenuItem";
            this.openLeftToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.openLeftToolStripMenuItem.Text = "Open Source";
            this.openLeftToolStripMenuItem.Click += new System.EventHandler(this.openLeftToolStripMenuItem_Click);
            // 
            // makeReportToolStripMenuItem
            // 
            this.makeReportToolStripMenuItem.Name = "makeReportToolStripMenuItem";
            this.makeReportToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.makeReportToolStripMenuItem.Text = "Make report CSV";
            this.makeReportToolStripMenuItem.Click += new System.EventHandler(this.makeReportToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "?";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.punctuationCheckBox);
            this.groupBox1.Controls.Add(this.apostrophesCheckBox);
            this.groupBox1.Controls.Add(this.pronounsCheckBox2);
            this.groupBox1.Controls.Add(this.caseSensitiveCheckBox);
            this.groupBox1.Location = new System.Drawing.Point(830, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(129, 112);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings of sensitivity";
            // 
            // punctuationCheckBox
            // 
            this.punctuationCheckBox.AutoSize = true;
            this.punctuationCheckBox.Enabled = false;
            this.punctuationCheckBox.Location = new System.Drawing.Point(6, 89);
            this.punctuationCheckBox.Name = "punctuationCheckBox";
            this.punctuationCheckBox.Size = new System.Drawing.Size(114, 17);
            this.punctuationCheckBox.TabIndex = 3;
            this.punctuationCheckBox.Text = "Punctuation marks";
            this.punctuationCheckBox.UseVisualStyleBackColor = true;
            // 
            // apostrophesCheckBox
            // 
            this.apostrophesCheckBox.AutoSize = true;
            this.apostrophesCheckBox.Enabled = false;
            this.apostrophesCheckBox.Location = new System.Drawing.Point(6, 65);
            this.apostrophesCheckBox.Name = "apostrophesCheckBox";
            this.apostrophesCheckBox.Size = new System.Drawing.Size(85, 17);
            this.apostrophesCheckBox.TabIndex = 2;
            this.apostrophesCheckBox.Text = "Apostrophes";
            this.apostrophesCheckBox.UseVisualStyleBackColor = true;
            this.apostrophesCheckBox.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // pronounsCheckBox2
            // 
            this.pronounsCheckBox2.AutoSize = true;
            this.pronounsCheckBox2.Enabled = false;
            this.pronounsCheckBox2.Location = new System.Drawing.Point(6, 42);
            this.pronounsCheckBox2.Name = "pronounsCheckBox2";
            this.pronounsCheckBox2.Size = new System.Drawing.Size(120, 17);
            this.pronounsCheckBox2.TabIndex = 1;
            this.pronounsCheckBox2.Text = "Pronoun: -s endings";
            this.pronounsCheckBox2.UseVisualStyleBackColor = true;
            // 
            // caseSensitiveCheckBox
            // 
            this.caseSensitiveCheckBox.AutoSize = true;
            this.caseSensitiveCheckBox.Checked = true;
            this.caseSensitiveCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.caseSensitiveCheckBox.Enabled = false;
            this.caseSensitiveCheckBox.Location = new System.Drawing.Point(6, 19);
            this.caseSensitiveCheckBox.Name = "caseSensitiveCheckBox";
            this.caseSensitiveCheckBox.Size = new System.Drawing.Size(94, 17);
            this.caseSensitiveCheckBox.TabIndex = 0;
            this.caseSensitiveCheckBox.Text = "Case-sensitive";
            this.caseSensitiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(836, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(836, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.totalLinesLabel);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.serLabel);
            this.groupBox2.Controls.Add(this.werLabel);
            this.groupBox2.Controls.Add(this.wcrLabel);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(830, 149);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(129, 170);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Summary";
            // 
            // totalLinesLabel
            // 
            this.totalLinesLabel.AutoSize = true;
            this.totalLinesLabel.Location = new System.Drawing.Point(69, 141);
            this.totalLinesLabel.Name = "totalLinesLabel";
            this.totalLinesLabel.Size = new System.Drawing.Size(10, 13);
            this.totalLinesLabel.TabIndex = 7;
            this.totalLinesLabel.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Total lines:";
            // 
            // serLabel
            // 
            this.serLabel.AutoSize = true;
            this.serLabel.Location = new System.Drawing.Point(69, 107);
            this.serLabel.Name = "serLabel";
            this.serLabel.Size = new System.Drawing.Size(10, 13);
            this.serLabel.TabIndex = 5;
            this.serLabel.Text = "-";
            // 
            // werLabel
            // 
            this.werLabel.AutoSize = true;
            this.werLabel.Location = new System.Drawing.Point(69, 69);
            this.werLabel.Name = "werLabel";
            this.werLabel.Size = new System.Drawing.Size(10, 13);
            this.werLabel.TabIndex = 4;
            this.werLabel.Text = "-";
            // 
            // wcrLabel
            // 
            this.wcrLabel.AutoSize = true;
            this.wcrLabel.Location = new System.Drawing.Point(69, 31);
            this.wcrLabel.Name = "wcrLabel";
            this.wcrLabel.Size = new System.Drawing.Size(10, 13);
            this.wcrLabel.TabIndex = 3;
            this.wcrLabel.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "SER (%) :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "WER (%) :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "WCR (%) :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 492);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "SpeechMetricon";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openLeftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox apostrophesCheckBox;
        private System.Windows.Forms.CheckBox pronounsCheckBox2;
        private System.Windows.Forms.CheckBox caseSensitiveCheckBox;
        private System.Windows.Forms.CheckBox punctuationCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label serLabel;
        private System.Windows.Forms.Label werLabel;
        private System.Windows.Forms.Label wcrLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label totalLinesLabel;
        private System.Windows.Forms.Label label7;
    }
}

