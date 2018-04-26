using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CancelButton = this.button1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("国家");
            dt.Columns.Add("城市");
            dt.Columns.Add("男");
            dt.Columns.Add("女");
            dt.Rows.Add("中国", "上海", "5000", "7000");
            dt.Rows.Add("中国", "北京", "3000", "5600");
            dt.Rows.Add("美国", "纽约", "6000", "8600");
            dt.Rows.Add("美国", "华劢顿", "8000", "9000");
            dt.Rows.Add("英国", "伦敦", "7000", "8800");
            dt.Rows.Add("英国", "伯明翰", "6000", "9800");
            this.rowMergeView1.DataSource = dt;
            this.rowMergeView1.ColumnHeadersHeight = 40;
            this.rowMergeView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.rowMergeView1.MergeColumnNames.Add("国家");
            this.rowMergeView1.AddSpanHeader(2, 2, "收入");
            for (int i = 0; i < this.rowMergeView1.Columns.Count; i++)
            {
                this.rowMergeView1.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;//这里是去掉点击表头排序的功能，如果不禁掉，排序时会影响到合并的列
            }
        }
    }
}