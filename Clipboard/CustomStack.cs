using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace Clipboard
{
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
    internal class CustomStack<T>
    {
        private Node<T> top;

        private class Node<U>
        {
            public U data;
            public Node<U> next;
        }

        public bool IsEmpty()
        {
            return top == null;
        }

        public void Push(T ele)
        {
            Node<T> n = new Node<T> { data = ele, next = top };
            top = n;
        }

        public T Pop()
        {
            if (top == null) throw new InvalidOperationException("Stack rỗng!");
            T data = top.data;
            top = top.next;
            return data;
        }
        public T Peek()
        {
            if (top == null) throw new InvalidOperationException("Stack rỗng!");
            return top.data;
        }

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
            while (current != null && count < index) //Tìm đến phần tử cần xóa
            {
                prev = current;
                current = current.next;
                count++;
            }
            prev.next = current.next; //Xóa: bỏ qua phần tử đó
        }
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
            public void Clear()
        {
            top = null;
        }
        public void ForEach(Action<T> action)
        {
            Node<T> current = top;
            while (current != null)
            {
                action(current.data);
                current = current.next;
            }
        }
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
            );

            using (StreamWriter writer = new StreamWriter(path))
            {
                ForEach(item => writer.WriteLine(item.ToString()));
            }

            MessageBox.Show(
                $"Đã lưu nội dung Clipboard vào tệp {fileName} trong thư mục Downloads!",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
    
}
