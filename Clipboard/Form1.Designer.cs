namespace Clipboard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chosebutton = new System.Windows.Forms.Button();
            this.filebutton = new System.Windows.Forms.Button();
            this.deleteallbutton = new System.Windows.Forms.Button();
            this.deletebutton = new System.Windows.Forms.Button();
            this.contentpanel = new System.Windows.Forms.Panel();
            this.outtextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cutbutton = new System.Windows.Forms.Button();
            this.copybutton = new System.Windows.Forms.Button();
            this.intextBox = new System.Windows.Forms.TextBox();
            this.clipboardDataGridView = new System.Windows.Forms.DataGridView();
            this.contentcol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Timecol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.contentpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clipboardDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.chosebutton);
            this.panel1.Controls.Add(this.filebutton);
            this.panel1.Controls.Add(this.deleteallbutton);
            this.panel1.Controls.Add(this.deletebutton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 744);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1522, 87);
            this.panel1.TabIndex = 1;
            // 
            // chosebutton
            // 
            this.chosebutton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chosebutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chosebutton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chosebutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chosebutton.Location = new System.Drawing.Point(22, 22);
            this.chosebutton.Margin = new System.Windows.Forms.Padding(6);
            this.chosebutton.Name = "chosebutton";
            this.chosebutton.Size = new System.Drawing.Size(167, 42);
            this.chosebutton.TabIndex = 4;
            this.chosebutton.Text = "Paste";
            this.chosebutton.UseVisualStyleBackColor = false;
            this.chosebutton.Click += new System.EventHandler(this.chosebutton_Click);
            // 
            // filebutton
            // 
            this.filebutton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.filebutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.filebutton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filebutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.filebutton.Location = new System.Drawing.Point(546, 22);
            this.filebutton.Margin = new System.Windows.Forms.Padding(6);
            this.filebutton.Name = "filebutton";
            this.filebutton.Size = new System.Drawing.Size(167, 42);
            this.filebutton.TabIndex = 3;
            this.filebutton.Text = "Lưu vào file";
            this.filebutton.UseVisualStyleBackColor = false;
            this.filebutton.Click += new System.EventHandler(this.filebutton_Click);
            // 
            // deleteallbutton
            // 
            this.deleteallbutton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.deleteallbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteallbutton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteallbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deleteallbutton.Location = new System.Drawing.Point(368, 22);
            this.deleteallbutton.Margin = new System.Windows.Forms.Padding(6);
            this.deleteallbutton.Name = "deleteallbutton";
            this.deleteallbutton.Size = new System.Drawing.Size(167, 42);
            this.deleteallbutton.TabIndex = 2;
            this.deleteallbutton.Text = "Xóa tất cả";
            this.deleteallbutton.UseVisualStyleBackColor = false;
            this.deleteallbutton.Click += new System.EventHandler(this.deleteallbutton_Click);
            // 
            // deletebutton
            // 
            this.deletebutton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.deletebutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deletebutton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deletebutton.Location = new System.Drawing.Point(191, 22);
            this.deletebutton.Margin = new System.Windows.Forms.Padding(6);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(167, 42);
            this.deletebutton.TabIndex = 0;
            this.deletebutton.Text = "Xóa";
            this.deletebutton.UseVisualStyleBackColor = false;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // contentpanel
            // 
            this.contentpanel.Controls.Add(this.outtextBox);
            this.contentpanel.Controls.Add(this.panel2);
            this.contentpanel.Controls.Add(this.cutbutton);
            this.contentpanel.Controls.Add(this.copybutton);
            this.contentpanel.Controls.Add(this.intextBox);
            this.contentpanel.Controls.Add(this.clipboardDataGridView);
            this.contentpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentpanel.Location = new System.Drawing.Point(0, 0);
            this.contentpanel.Margin = new System.Windows.Forms.Padding(6);
            this.contentpanel.Name = "contentpanel";
            this.contentpanel.Size = new System.Drawing.Size(1522, 744);
            this.contentpanel.TabIndex = 2;
            this.contentpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.contentpanel_Paint);
            // 
            // outtextBox
            // 
            this.outtextBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.outtextBox.Location = new System.Drawing.Point(1219, 0);
            this.outtextBox.Multiline = true;
            this.outtextBox.Name = "outtextBox";
            this.outtextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outtextBox.Size = new System.Drawing.Size(303, 744);
            this.outtextBox.TabIndex = 8;
            this.outtextBox.TextChanged += new System.EventHandler(this.outtextBox_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(1212, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 744);
            this.panel2.TabIndex = 7;
            // 
            // cutbutton
            // 
            this.cutbutton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cutbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cutbutton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cutbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cutbutton.Location = new System.Drawing.Point(1036, 69);
            this.cutbutton.Margin = new System.Windows.Forms.Padding(6);
            this.cutbutton.Name = "cutbutton";
            this.cutbutton.Size = new System.Drawing.Size(167, 42);
            this.cutbutton.TabIndex = 6;
            this.cutbutton.Text = "Cut";
            this.cutbutton.UseVisualStyleBackColor = false;
            this.cutbutton.Click += new System.EventHandler(this.cutbutton_Click);
            // 
            // copybutton
            // 
            this.copybutton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.copybutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.copybutton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copybutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.copybutton.Location = new System.Drawing.Point(1036, 15);
            this.copybutton.Margin = new System.Windows.Forms.Padding(6);
            this.copybutton.Name = "copybutton";
            this.copybutton.Size = new System.Drawing.Size(167, 42);
            this.copybutton.TabIndex = 5;
            this.copybutton.Text = "Copy";
            this.copybutton.UseVisualStyleBackColor = false;
            this.copybutton.Click += new System.EventHandler(this.copybutton_Click);
            // 
            // intextBox
            // 
            this.intextBox.Location = new System.Drawing.Point(22, 12);
            this.intextBox.Multiline = true;
            this.intextBox.Name = "intextBox";
            this.intextBox.Size = new System.Drawing.Size(1005, 99);
            this.intextBox.TabIndex = 1;
            this.intextBox.TextChanged += new System.EventHandler(this.intextBox_TextChanged);
            // 
            // clipboardDataGridView
            // 
            this.clipboardDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.clipboardDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.clipboardDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.clipboardDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clipboardDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.contentcol,
            this.Timecol});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.clipboardDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.clipboardDataGridView.EnableHeadersVisualStyles = false;
            this.clipboardDataGridView.Location = new System.Drawing.Point(22, 123);
            this.clipboardDataGridView.Margin = new System.Windows.Forms.Padding(6);
            this.clipboardDataGridView.Name = "clipboardDataGridView";
            this.clipboardDataGridView.RowHeadersVisible = false;
            this.clipboardDataGridView.RowHeadersWidth = 72;
            this.clipboardDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.clipboardDataGridView.Size = new System.Drawing.Size(1181, 609);
            this.clipboardDataGridView.TabIndex = 0;
            this.clipboardDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clipboardDataGridView_CellContentClick);
            this.clipboardDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clipboardDataGridView_CellDoubleClick);
            // 
            // contentcol
            // 
            this.contentcol.HeaderText = "Nội dung";
            this.contentcol.MinimumWidth = 9;
            this.contentcol.Name = "contentcol";
            this.contentcol.ReadOnly = true;
            // 
            // Timecol
            // 
            this.Timecol.HeaderText = "Thời gian copy";
            this.Timecol.MinimumWidth = 9;
            this.Timecol.Name = "Timecol";
            this.Timecol.ReadOnly = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1522, 831);
            this.Controls.Add(this.contentpanel);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Clipboard Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.contentpanel.ResumeLayout(false);
            this.contentpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clipboardDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button deletebutton;
        private System.Windows.Forms.Button deleteallbutton;
        private System.Windows.Forms.Button filebutton;
        private System.Windows.Forms.Panel contentpanel;
        private System.Windows.Forms.DataGridView clipboardDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn contentcol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Timecol;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button chosebutton;
        private System.Windows.Forms.Button copybutton;
        private System.Windows.Forms.TextBox intextBox;
        private System.Windows.Forms.Button cutbutton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox outtextBox;
    }
}

