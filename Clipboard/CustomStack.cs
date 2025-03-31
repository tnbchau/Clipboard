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

        public void Clear()
        {
            top = null;
        }

        public List<T> GetAllItems()
        {
            List<T> items = new List<T>();
            Node<T> n = top;
            while (n != null)
            {
                items.Add(n.data);
                n = n.next;
            }
            return items;
        }
        public void SaveToFile()
        {
            List<T> items = GetAllItems();
            if (items.Count == 0)
            {
                MessageBox.Show
                (
                    "Clipboard trống, không có gì để lưu!", 
                    "Thông báo", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Warning
                );
                return;
            }
            string path = Path.Combine
                (
                    Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), 
                    "Downloads", 
                    "ClipboardData.txt"
                );
            File.WriteAllLines(path, items.ConvertAll(i => i.ToString()));
            MessageBox.Show
                (
                    "Đã lưu nội dung Clipboard vào tệp!", 
                    "Thông báo", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Information
                );
        }
    }
    
}
