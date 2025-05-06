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
        
        // 1. Constructor & Load
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateGridView();
        }

        // 2. Private helpers: cập nhật lưới và thêm item
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
            ClipboardItem item = new ClipboardItem(content);
            clipboardStack.Push(item);
            UpdateGridView();
        }

        // 3. Clipboard actions: Copy, Cut, Paste, Save
        private void copybutton_Click(object sender, EventArgs e) //Nút Copy
        {
            string text = intextBox.Text;
            if (!string.IsNullOrEmpty(text))
            {
                AddClipboardItem(text);
            }
        }
        private void cutbutton_Click(object sender, EventArgs e)  //Nút Cut
        {
            string text = intextBox.Text;
            if (!string.IsNullOrEmpty(text))
            {
                AddClipboardItem(text);
                intextBox.Clear();
            }
        }
        private void chosebutton_Click(object sender, EventArgs e) //Nút Paste
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

        private void filebutton_Click(object sender, EventArgs e) //Nút Lưu vào file
        {
            clipboardStack.SaveToFile();
        }

        // 4. DataGridView interactions
        private void clipboardDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    ClipboardItem item = clipboardStack.GetAt(e.RowIndex);
                    string fullContent = item.Content;

                    DetailClipboardCell.Instance.SetClipboardText(fullContent);
                    DetailClipboardCell.Instance.ShowDialog();
                }
                catch (ArgumentOutOfRangeException)
                {
                    MessageBox.Show("Không thể truy cập nội dung clipboard!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void clipboardDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        // 5. Delete & Delete All
        private void deletebutton_Click(object sender, EventArgs e) //Nút Xóa
        {
            if (clipboardDataGridView.SelectedRows.Count > 0)
            {
                int selectedIndex = clipboardDataGridView.SelectedRows[0].Index;
                clipboardStack.RemoveAt(selectedIndex);
                UpdateGridView();
            }
        }
        private void deleteallbutton_Click(object sender, EventArgs e) //Nút Xóa tất cả
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

        // 6. Giao diện phụ

        private void intextBox_TextChanged(object sender, EventArgs e)
        {
        }
        private void outtextBox_TextChanged(object sender, EventArgs e)
        {
        }
        private void contentpanel_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
