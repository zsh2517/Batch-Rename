namespace BatchRename
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.fileLV = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.replaceFromLabel = new System.Windows.Forms.Label();
            this.replaceToLabel = new System.Windows.Forms.Label();
            this.replaceFromText = new System.Windows.Forms.TextBox();
            this.replaceToText = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addBeforeLabel = new System.Windows.Forms.Label();
            this.addBeforeText = new System.Windows.Forms.TextBox();
            this.addAfterLabel = new System.Windows.Forms.Label();
            this.addAfterText = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.deleteTextLabel = new System.Windows.Forms.Label();
            this.deleteTextText = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.suffixChangeText = new System.Windows.Forms.TextBox();
            this.suffixChangeCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(552, 771);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(544, 736);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "替换添加删除";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(544, 736);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "选择元素";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // fileLV
            // 
            this.fileLV.CheckBoxes = true;
            this.fileLV.ForeColor = System.Drawing.SystemColors.WindowText;
            this.fileLV.HideSelection = false;
            this.fileLV.Location = new System.Drawing.Point(604, 86);
            this.fileLV.Name = "fileLV";
            this.fileLV.Size = new System.Drawing.Size(1089, 691);
            this.fileLV.TabIndex = 1;
            this.fileLV.UseCompatibleStateImageBehavior = false;
            this.fileLV.View = System.Windows.Forms.View.Details;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(826, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 46);
            this.button1.TabIndex = 2;
            this.button1.Text = "生成名称";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(604, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 46);
            this.button2.TabIndex = 3;
            this.button2.Text = "获取文件列表";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1063, 27);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(164, 46);
            this.button3.TabIndex = 4;
            this.button3.Text = "重命名";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 31);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(544, 736);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "排序";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // replaceFromLabel
            // 
            this.replaceFromLabel.AutoSize = true;
            this.replaceFromLabel.Location = new System.Drawing.Point(21, 32);
            this.replaceFromLabel.Name = "replaceFromLabel";
            this.replaceFromLabel.Size = new System.Drawing.Size(31, 21);
            this.replaceFromLabel.TabIndex = 0;
            this.replaceFromLabel.Text = "把";
            // 
            // replaceToLabel
            // 
            this.replaceToLabel.AutoSize = true;
            this.replaceToLabel.Location = new System.Drawing.Point(21, 75);
            this.replaceToLabel.Name = "replaceToLabel";
            this.replaceToLabel.Size = new System.Drawing.Size(73, 21);
            this.replaceToLabel.TabIndex = 1;
            this.replaceToLabel.Text = "替换为";
            // 
            // replaceFromText
            // 
            this.replaceFromText.Location = new System.Drawing.Point(119, 30);
            this.replaceFromText.Name = "replaceFromText";
            this.replaceFromText.Size = new System.Drawing.Size(350, 31);
            this.replaceFromText.TabIndex = 2;
            this.replaceFromText.TextChanged += new System.EventHandler(this.replaceFromText_TextChanged);
            // 
            // replaceToText
            // 
            this.replaceToText.Location = new System.Drawing.Point(119, 72);
            this.replaceToText.Name = "replaceToText";
            this.replaceToText.Size = new System.Drawing.Size(350, 31);
            this.replaceToText.TabIndex = 3;
            this.replaceToText.TextChanged += new System.EventHandler(this.replaceToText_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.replaceToText);
            this.groupBox1.Controls.Add(this.replaceFromText);
            this.groupBox1.Controls.Add(this.replaceToLabel);
            this.groupBox1.Controls.Add(this.replaceFromLabel);
            this.groupBox1.Location = new System.Drawing.Point(17, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(498, 117);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "替换";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // addBeforeLabel
            // 
            this.addBeforeLabel.AutoSize = true;
            this.addBeforeLabel.Location = new System.Drawing.Point(21, 37);
            this.addBeforeLabel.Name = "addBeforeLabel";
            this.addBeforeLabel.Size = new System.Drawing.Size(94, 21);
            this.addBeforeLabel.TabIndex = 6;
            this.addBeforeLabel.Text = "前面添加";
            // 
            // addBeforeText
            // 
            this.addBeforeText.Location = new System.Drawing.Point(119, 33);
            this.addBeforeText.Name = "addBeforeText";
            this.addBeforeText.Size = new System.Drawing.Size(350, 31);
            this.addBeforeText.TabIndex = 7;
            this.addBeforeText.TextChanged += new System.EventHandler(this.addBeforeText_TextChanged);
            // 
            // addAfterLabel
            // 
            this.addAfterLabel.AutoSize = true;
            this.addAfterLabel.Location = new System.Drawing.Point(21, 83);
            this.addAfterLabel.Name = "addAfterLabel";
            this.addAfterLabel.Size = new System.Drawing.Size(94, 21);
            this.addAfterLabel.TabIndex = 8;
            this.addAfterLabel.Text = "后面添加";
            // 
            // addAfterText
            // 
            this.addAfterText.Location = new System.Drawing.Point(119, 79);
            this.addAfterText.Name = "addAfterText";
            this.addAfterText.Size = new System.Drawing.Size(350, 31);
            this.addAfterText.TabIndex = 9;
            this.addAfterText.TextChanged += new System.EventHandler(this.addAfterText_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.addAfterText);
            this.groupBox2.Controls.Add(this.addAfterLabel);
            this.groupBox2.Controls.Add(this.addBeforeText);
            this.groupBox2.Controls.Add(this.addBeforeLabel);
            this.groupBox2.Location = new System.Drawing.Point(17, 156);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(498, 126);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "文件名添加（不包含扩展名）";
            // 
            // deleteTextLabel
            // 
            this.deleteTextLabel.AutoSize = true;
            this.deleteTextLabel.Location = new System.Drawing.Point(21, 37);
            this.deleteTextLabel.Name = "deleteTextLabel";
            this.deleteTextLabel.Size = new System.Drawing.Size(94, 21);
            this.deleteTextLabel.TabIndex = 12;
            this.deleteTextLabel.Text = "删除文本";
            // 
            // deleteTextText
            // 
            this.deleteTextText.Location = new System.Drawing.Point(119, 34);
            this.deleteTextText.Name = "deleteTextText";
            this.deleteTextText.Size = new System.Drawing.Size(350, 31);
            this.deleteTextText.TabIndex = 13;
            this.deleteTextText.TextChanged += new System.EventHandler(this.deleteTextText_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.deleteTextText);
            this.groupBox3.Controls.Add(this.deleteTextLabel);
            this.groupBox3.Location = new System.Drawing.Point(17, 288);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(498, 82);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "文件名删除";
            // 
            // suffixChangeText
            // 
            this.suffixChangeText.Enabled = false;
            this.suffixChangeText.Location = new System.Drawing.Point(319, 30);
            this.suffixChangeText.Name = "suffixChangeText";
            this.suffixChangeText.Size = new System.Drawing.Size(150, 31);
            this.suffixChangeText.TabIndex = 13;
            this.suffixChangeText.TextChanged += new System.EventHandler(this.suffixChangeText_TextChanged);
            // 
            // suffixChangeCheckBox
            // 
            this.suffixChangeCheckBox.AutoSize = true;
            this.suffixChangeCheckBox.Location = new System.Drawing.Point(25, 36);
            this.suffixChangeCheckBox.Name = "suffixChangeCheckBox";
            this.suffixChangeCheckBox.Size = new System.Drawing.Size(162, 25);
            this.suffixChangeCheckBox.TabIndex = 14;
            this.suffixChangeCheckBox.Text = "修改扩展名？";
            this.suffixChangeCheckBox.UseVisualStyleBackColor = true;
            this.suffixChangeCheckBox.CheckedChanged += new System.EventHandler(this.suffixChangeCheckBox_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.suffixChangeCheckBox);
            this.groupBox4.Controls.Add(this.suffixChangeText);
            this.groupBox4.Location = new System.Drawing.Point(17, 376);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(498, 82);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "扩展名";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1714, 789);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fileLV);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView fileLV;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox suffixChangeCheckBox;
        private System.Windows.Forms.TextBox suffixChangeText;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox deleteTextText;
        private System.Windows.Forms.Label deleteTextLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox addAfterText;
        private System.Windows.Forms.Label addAfterLabel;
        private System.Windows.Forms.TextBox addBeforeText;
        private System.Windows.Forms.Label addBeforeLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox replaceToText;
        private System.Windows.Forms.TextBox replaceFromText;
        private System.Windows.Forms.Label replaceToLabel;
        private System.Windows.Forms.Label replaceFromLabel;
    }
}

