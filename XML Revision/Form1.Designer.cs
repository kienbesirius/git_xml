namespace XML_Revision
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            bai01ToolStripMenuItem = new ToolStripMenuItem();
            bai02ToolStripMenuItem = new ToolStripMenuItem();
            bai03ToolStripMenuItem = new ToolStripMenuItem();
            bai04ToolStripMenuItem = new ToolStripMenuItem();
            tableLayoutPanel1 = new TableLayoutPanel();
            dataGridViewAll = new DataGridView();
            tableLayoutPanel2 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            buttonAdd = new Button();
            buttonUpdate = new Button();
            buttonDelete = new Button();
            buttonSearch = new Button();
            button5 = new Button();
            buttonRefresh = new Button();
            menuStrip1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAll).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { bai01ToolStripMenuItem, bai02ToolStripMenuItem, bai03ToolStripMenuItem, bai04ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1182, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // bai01ToolStripMenuItem
            // 
            bai01ToolStripMenuItem.Name = "bai01ToolStripMenuItem";
            bai01ToolStripMenuItem.Size = new Size(64, 24);
            bai01ToolStripMenuItem.Text = "Bài 01";
            // 
            // bai02ToolStripMenuItem
            // 
            bai02ToolStripMenuItem.Name = "bai02ToolStripMenuItem";
            bai02ToolStripMenuItem.Size = new Size(64, 24);
            bai02ToolStripMenuItem.Text = "Bài 02";
            // 
            // bai03ToolStripMenuItem
            // 
            bai03ToolStripMenuItem.Name = "bai03ToolStripMenuItem";
            bai03ToolStripMenuItem.Size = new Size(64, 24);
            bai03ToolStripMenuItem.Text = "Bài 03";
            bai03ToolStripMenuItem.Click += bai03ToolStripMenuItem_Click;
            // 
            // bai04ToolStripMenuItem
            // 
            bai04ToolStripMenuItem.Name = "bai04ToolStripMenuItem";
            bai04ToolStripMenuItem.Size = new Size(64, 24);
            bai04ToolStripMenuItem.Text = "Bài 04";
            bai04ToolStripMenuItem.Click += bai04ToolStripMenuItem_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.Controls.Add(dataGridViewAll, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 1);
            tableLayoutPanel1.Location = new Point(0, 28);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1182, 725);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // dataGridViewAll
            // 
            dataGridViewAll.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAll.Dock = DockStyle.Fill;
            dataGridViewAll.Location = new Point(3, 3);
            dataGridViewAll.Name = "dataGridViewAll";
            dataGridViewAll.RowHeadersWidth = 51;
            dataGridViewAll.Size = new Size(821, 356);
            dataGridViewAll.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(label2, 0, 1);
            tableLayoutPanel2.Controls.Add(label3, 0, 2);
            tableLayoutPanel2.Controls.Add(label4, 0, 3);
            tableLayoutPanel2.Controls.Add(label5, 0, 4);
            tableLayoutPanel2.Controls.Add(label6, 0, 5);
            tableLayoutPanel2.Controls.Add(label7, 0, 6);
            tableLayoutPanel2.Controls.Add(label8, 0, 7);
            tableLayoutPanel2.Controls.Add(label9, 0, 8);
            tableLayoutPanel2.Controls.Add(textBox1, 1, 0);
            tableLayoutPanel2.Controls.Add(textBox2, 1, 1);
            tableLayoutPanel2.Controls.Add(textBox3, 1, 2);
            tableLayoutPanel2.Controls.Add(textBox4, 1, 3);
            tableLayoutPanel2.Controls.Add(textBox5, 1, 4);
            tableLayoutPanel2.Controls.Add(textBox6, 1, 5);
            tableLayoutPanel2.Controls.Add(textBox7, 1, 6);
            tableLayoutPanel2.Controls.Add(textBox8, 1, 7);
            tableLayoutPanel2.Controls.Add(textBox9, 1, 8);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(830, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 9;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel2.Size = new Size(349, 356);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(168, 20);
            label1.TabIndex = 0;
            label1.Text = "label1";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(3, 48);
            label2.Name = "label2";
            label2.Size = new Size(168, 20);
            label2.TabIndex = 1;
            label2.Text = "label2";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(3, 87);
            label3.Name = "label3";
            label3.Size = new Size(168, 20);
            label3.TabIndex = 2;
            label3.Text = "label3";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(3, 126);
            label4.Name = "label4";
            label4.Size = new Size(168, 20);
            label4.TabIndex = 3;
            label4.Text = "label4";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(3, 165);
            label5.Name = "label5";
            label5.Size = new Size(168, 20);
            label5.TabIndex = 4;
            label5.Text = "label5";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(3, 204);
            label6.Name = "label6";
            label6.Size = new Size(168, 20);
            label6.TabIndex = 5;
            label6.Text = "label6";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(3, 243);
            label7.Name = "label7";
            label7.Size = new Size(168, 20);
            label7.TabIndex = 6;
            label7.Text = "label7";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Location = new Point(3, 282);
            label8.Name = "label8";
            label8.Size = new Size(168, 20);
            label8.TabIndex = 7;
            label8.Text = "label8";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Location = new Point(3, 324);
            label9.Name = "label9";
            label9.Size = new Size(168, 20);
            label9.TabIndex = 8;
            label9.Text = "label9";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(177, 6);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(169, 27);
            textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Location = new Point(177, 45);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(169, 27);
            textBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox3.Location = new Point(177, 84);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(169, 27);
            textBox3.TabIndex = 11;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox4.Location = new Point(177, 123);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(169, 27);
            textBox4.TabIndex = 12;
            // 
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox5.Location = new Point(177, 162);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(169, 27);
            textBox5.TabIndex = 13;
            // 
            // textBox6
            // 
            textBox6.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox6.Location = new Point(177, 201);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(169, 27);
            textBox6.TabIndex = 14;
            // 
            // textBox7
            // 
            textBox7.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox7.Location = new Point(177, 240);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(169, 27);
            textBox7.TabIndex = 15;
            // 
            // textBox8
            // 
            textBox8.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox8.Location = new Point(177, 279);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(169, 27);
            textBox8.TabIndex = 16;
            // 
            // textBox9
            // 
            textBox9.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox9.Location = new Point(177, 320);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(169, 27);
            textBox9.TabIndex = 17;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(buttonAdd, 0, 0);
            tableLayoutPanel3.Controls.Add(buttonUpdate, 1, 0);
            tableLayoutPanel3.Controls.Add(buttonDelete, 0, 1);
            tableLayoutPanel3.Controls.Add(buttonSearch, 1, 1);
            tableLayoutPanel3.Controls.Add(button5, 1, 2);
            tableLayoutPanel3.Controls.Add(buttonRefresh, 0, 2);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(830, 365);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.Size = new Size(349, 357);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // buttonAdd
            // 
            buttonAdd.Dock = DockStyle.Fill;
            buttonAdd.Location = new Point(3, 3);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(168, 113);
            buttonAdd.TabIndex = 0;
            buttonAdd.Text = "Thêm";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Dock = DockStyle.Fill;
            buttonUpdate.Location = new Point(177, 3);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(169, 113);
            buttonUpdate.TabIndex = 1;
            buttonUpdate.Text = "Sửa";
            buttonUpdate.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            buttonDelete.Dock = DockStyle.Fill;
            buttonDelete.Location = new Point(3, 122);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(168, 113);
            buttonDelete.TabIndex = 2;
            buttonDelete.Text = "Xóa";
            buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonSearch
            // 
            buttonSearch.Dock = DockStyle.Fill;
            buttonSearch.Location = new Point(177, 122);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(169, 113);
            buttonSearch.TabIndex = 3;
            buttonSearch.Text = "Tìm kiếm";
            buttonSearch.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Dock = DockStyle.Fill;
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(177, 241);
            button5.Name = "button5";
            button5.Size = new Size(169, 113);
            button5.TabIndex = 4;
            button5.Text = "Thoát";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // buttonRefresh
            // 
            buttonRefresh.Dock = DockStyle.Fill;
            buttonRefresh.Location = new Point(3, 241);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(168, 113);
            buttonRefresh.TabIndex = 5;
            buttonRefresh.Text = "Làm mới";
            buttonRefresh.UseVisualStyleBackColor = true;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 753);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewAll).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem bai01ToolStripMenuItem;
        private ToolStripMenuItem bai02ToolStripMenuItem;
        private ToolStripMenuItem bai03ToolStripMenuItem;
        private ToolStripMenuItem bai04ToolStripMenuItem;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dataGridViewAll;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
        private Label label1;
        private TextBox textBox1;
        private TableLayoutPanel tableLayoutPanel3;
        private Button buttonAdd;
        private Button buttonUpdate;
        private Button buttonDelete;
        private Button buttonSearch;
        private Button button5;
        private Button buttonRefresh;
    }
}
