using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Clipboard
{
    public partial class Form1 : Form
    {
        private CustomStack<ClipboardItem> clipboardStack = new CustomStack<ClipboardItem>();
        public Form1()
        {
            InitializeComponent();
        }
        private void UpdateGridView()
        {
            clipboardDataGridView.Rows.Clear();
            int index = 0;
            clipboardStack.ForEach(item =>
            {
                string preview = item.Content.Length > 50
                    ? item.Content.Substring(0, 50) + "..."
                    : item.Content;

                clipboardDataGridView.Rows.Add(preview, item.Timestamp.ToString("dd/MM/yyyy HH:mm:ss"));
                index++;
            });
        }
        private void AddClipboardItem(string content)
        {
            //Tạo clipboard mới
            ClipboardItem item = new ClipboardItem(content);
            clipboardStack.Push(item);
            //Cập nhật giao diện
            UpdateGridView();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateGridView();
        }
        private void clipboardDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    ClipboardItem item = clipboardStack.GetAt(e.RowIndex);
                    string fullContent = item.Content;

                    // Mở cửa sổ DetailClipboardCell để hiển thị nội dung
                    DetailClipboardCell.Instance.SetClipboardText(fullContent);
                    DetailClipboardCell.Instance.ShowDialog();
                }
                catch (ArgumentOutOfRangeException)
                {
                    MessageBox.Show("Không thể truy cập nội dung clipboard!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void deletebutton_Click(object sender, EventArgs e)
        {
            if (clipboardDataGridView.SelectedRows.Count > 0)
            {
                int selectedIndex = clipboardDataGridView.SelectedRows[0].Index;
                clipboardStack.RemoveAt(selectedIndex); // Xóa mục được chọn
                UpdateGridView();                
            }
        }
        private void deleteallbutton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show
            (
                "Bạn có chắc chắn muốn xóa tất cả nội dung clipboard?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );
            if (result == DialogResult.Yes)
            {
                clipboardStack.Clear();
                UpdateGridView();
            }
        }
        private void chosebutton_Click(object sender, EventArgs e)
        {
            if (clipboardStack.IsEmpty())
            {
                MessageBox.Show("Clipboard trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedText = "";
            if (clipboardDataGridView.SelectedRows.Count > 0)
            {
                int selectedIndex = clipboardDataGridView.SelectedRows[0].Index;
                ClipboardItem item = clipboardStack.GetAt(selectedIndex);
                selectedText = item.Content;
            }
            else
            {
                selectedText = clipboardStack.Peek().Content;
            }

            if (!string.IsNullOrEmpty(outtextBox.Text))
                outtextBox.AppendText(Environment.NewLine);

            outtextBox.AppendText(selectedText);
        }
        private void filebutton_Click(object sender, EventArgs e)
        {
            clipboardStack.SaveToFile();
        }

        private void copybutton_Click(object sender, EventArgs e)
        {
            string text = intextBox.Text;
            if (!string.IsNullOrEmpty(text))
            {
                AddClipboardItem(text);
            }
        }
        private void cutbutton_Click(object sender, EventArgs e)
        {
            string text = intextBox.Text;
            if (!string.IsNullOrEmpty(text))
            {
                AddClipboardItem(text); // Lưu vào stack
                intextBox.Clear(); // Xóa nội dung trên inTextBox
            }
        }
        private void minibutton_Click(object sender, EventArgs e)
        {

        }

        private void intextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void contentpanel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void outtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void clipboardDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
