using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace BatchRename
{
    public partial class Form1 : Form
    {
        private List<String> fileList = new List<string>();
        public Form1()
        {
            InitializeComponent();
            //String test = "gitignore.qqw.";
            //String fileName, fileSuffix;
            //splitFileName(test, out fileName, out fileSuffix);
            //MessageBox.Show(fileName, fileSuffix);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.fileLV.Columns.Add("原名称", 240, HorizontalAlignment.Left);
            this.fileLV.Columns.Add("新名称", 240, HorizontalAlignment.Left);
            this.fileLV.Columns.Add("状态", 120, HorizontalAlignment.Left);
        }
        private void splitFileName(String origin, out String fileName, out String fileSuffix)
        {
            int temp = origin.LastIndexOf('.');
            if (temp == -1)
            {
                // donot have suffix
                fileName = origin;
                fileSuffix = "";
            }
            else
            {
                fileName = origin.Substring(0, temp);
                fileSuffix = origin.Substring(temp + 1);
            }
        }
        private void try_process()
        {
            //MessageBox.Show("qwq".IndexOf('.', 1).ToString());
            //List<String> newFileList = new List<String>(fileList.ToArray());
            List<String> newFileList = new List<String>();
            fileList.ForEach(i => newFileList.Add(i));
            for (int i = 0; i < newFileList.ToArray().Length; i++)
            {
                String fileName, fileSuffix;
                splitFileName(newFileList[i], out fileName, out fileSuffix);
                // ————————————————————————————————————————————
                // 这里写所有处理流程
                if (this.replaceFromText.Text != "")
                {
                    fileName = fileName.Replace(this.replaceFromText.Text,this.replaceToText.Text);
                }
                if (this.deleteTextText.Text != "")
                {
                    fileName = fileName.Replace(this.deleteTextText.Text, "");
                }
                fileName = this.addBeforeText.Text + fileName + this.addAfterText.Text;
                if (this.suffixChangeCheckBox.Checked)
                {
                    fileSuffix = suffixChangeText.Text;
                }
                // ————————————————————————————————————————————
                newFileList[i] = fileName + "." + fileSuffix;
            }
            for (int i = 0; i < this.fileLV.Items.Count; i++)
            {
                fileLV.Items[i].SubItems[1].Text = newFileList[i];
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try_process();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fileList.Clear();
            fileLV.Items.Clear();
            String path = @"C:\Users\zsh2517\OneDrive - stu.hit.edu.cn\Class\大学物理\大物同步练习";
            if (!Directory.Exists(path))
            {
                MessageBox.Show("The directory is not exists");
                return;
            }
            DirectoryInfo dinfo = new DirectoryInfo(path);
            foreach (FileInfo finfo in dinfo.GetFiles())
            {
                fileList.Add(finfo.Name);
            }
            fileList.Reverse();
            for (int i = 0; i < fileList.ToArray().Length; i++)
            {
                ListViewItem item = this.fileLV.Items.Add(fileList[i]);
                item.SubItems.Add(fileList[i]);
            }
            MessageBox.Show($"一共有{fileList.ToArray().Length.ToString()}个");
        }

            private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void addAfterText_TextChanged(object sender, EventArgs e)
        {
            try_process();
        }

        private void deleteTextText_TextChanged(object sender, EventArgs e)
        {
            try_process();
        }

        private void replaceFromText_TextChanged(object sender, EventArgs e)
        {
            try_process();
        }

        private void replaceToText_TextChanged(object sender, EventArgs e)
        {
            try_process();
        }        

        private void addBeforeText_TextChanged(object sender, EventArgs e)
        {
            try_process();
        }

        private void suffixChangeText_TextChanged(object sender, EventArgs e)
        {
            try_process();
        }

        private void suffixChangeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            suffixChangeText.Enabled = suffixChangeCheckBox.Checked;
            try_process();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
