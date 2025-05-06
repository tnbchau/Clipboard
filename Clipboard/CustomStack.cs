using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace Clipboard
{
    // Lưu thông tin một mục clipboard
    public class ClipboardItem
    {
        public string Content { get; set; }
        public DateTime Timestamp { get; set; }

        public ClipboardItem(string content)
        {
            Content = content;
            Timestamp = DateTime.Now;
        }

        public override string ToString()
        {
            return $"{Content}|{Timestamp:yyyy-MM-dd HH:mm:ss}";
        }
    }

    // Ngăn xếp tùy chỉnh để lưu các mục clipboard
    internal class CustomStack<T>
    {
        private Node<T> top;

        private class Node<U>
        {
            public U data;
            public Node<U> next;
        }

        // Kiểm tra rỗng
        public bool IsEmpty()
        {
            return top == null;
        }

        // Thêm phần tử
        public void Push(T ele)
        {
            Node<T> n = new Node<T> { data = ele, next = top };
            top = n;
        }

        // Lấy và xóa phần tử đầu
        public T Pop()
        {
            if (top == null) throw new InvalidOperationException("Stack rỗng!");
            T data = top.data;
            top = top.next;
            return data;
        }

        // Xem phần tử đầu
        public T Peek()
        {
            if (top == null) throw new InvalidOperationException("Stack rỗng!");
            return top.data;
        }

        // Xóa phần tử tại vị trí bất kỳ
        public void RemoveAt(int index)
        {
            if (index == 0)
            {
                top = top.next;
                return;
            }

            Node<T> current = top;
            Node<T> prev = null;
            int count = 0;

            while (current != null && count < index)
            {
                prev = current;
                current = current.next;
                count++;
            }

            if (current == null || prev == null)
                throw new ArgumentOutOfRangeException(nameof(index), "Vị trí không hợp lệ.");

            prev.next = current.next;
        }

        // Truy cập phần tử tại vị trí
        public T GetAt(int index)
        {
            if (index < 0) throw new ArgumentOutOfRangeException(nameof(index));

            Node<T> current = top;
            int count = 0;

            while (current != null)
            {
                if (count == index)
                    return current.data;

                current = current.next;
                count++;
            }

            throw new ArgumentOutOfRangeException(nameof(index), "Vị trí vượt quá chiều dài của ngăn xếp.");
        }

        // Xóa toàn bộ ngăn xếp
        public void Clear()
        {
            top = null;
        }

        // Duyệt từng phần tử và thực thi hành động
        public void ForEach(Action<T> action)
        {
            Node<T> current = top;
            while (current != null)
            {
                action(current.data);
                current = current.next;
            }
        }

        // Lưu dữ liệu ngăn xếp vào file
        public void SaveToFile()
        {
            if (IsEmpty())
            {
                MessageBox.Show(
                    "Clipboard trống, không có gì để lưu!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            string timestamp = DateTime.Now.ToString("ddMMyyyy_HHmmss");
            string fileName = $"ClipboardData_{timestamp}.txt";
            string path = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
                "Downloads",
                fileName
            );  // Đường dẫn đến thư mục Downloads

            using (StreamWriter writer = new StreamWriter(path))
            {
                ForEach(item => writer.WriteLine(item.ToString()));
            } // Ghi nội dung vào file

            MessageBox.Show(
                $"Đã lưu nội dung Clipboard vào tệp {fileName} trong thư mục Downloads!",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}
