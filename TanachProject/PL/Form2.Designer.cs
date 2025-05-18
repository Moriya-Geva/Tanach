namespace PL
{
    partial class Form2
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
            search = new Button();
            browesChumash = new ListBox();
            Chumashim = new TextBox();
            dataGridView1 = new DataGridView();
            showRes = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lostLetter = new Button();
            button1 = new Button();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // search
            // 
            search.BackColor = Color.FromArgb(199, 167, 98);
            search.Cursor = Cursors.Hand;
            search.ImeMode = ImeMode.NoControl;
            search.Location = new Point(548, 290);
            search.Name = "search";
            search.Size = new Size(174, 41);
            search.TabIndex = 0;
            search.Text = "חפש";
            search.UseVisualStyleBackColor = false;
            search.Click += search_Click;
            // 
            // browesChumash
            // 
            browesChumash.BackColor = Color.FromArgb(205, 167, 98);
            browesChumash.Cursor = Cursors.Hand;
            browesChumash.Font = new Font("Stencil", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            browesChumash.FormattingEnabled = true;
            browesChumash.ItemHeight = 24;
            browesChumash.Items.AddRange(new object[] { "בראשית", "שמות", "ויקרא", "במדבר", "דברים" });
            browesChumash.Location = new Point(57, 207);
            browesChumash.Name = "browesChumash";
            browesChumash.RightToLeft = RightToLeft.Yes;
            browesChumash.Size = new Size(146, 124);
            browesChumash.TabIndex = 1;
            browesChumash.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // Chumashim
            // 
            Chumashim.AcceptsTab = true;
            Chumashim.BorderStyle = BorderStyle.FixedSingle;
            Chumashim.ForeColor = Color.FromArgb(0, 0, 64);
            Chumashim.Location = new Point(29, 357);
            Chumashim.Multiline = true;
            Chumashim.Name = "Chumashim";
            Chumashim.RightToLeft = RightToLeft.Yes;
            Chumashim.ScrollBars = ScrollBars.Vertical;
            Chumashim.Size = new Size(421, 242);
            Chumashim.TabIndex = 2;
            Chumashim.TextAlign = HorizontalAlignment.Center;
            // 
            // dataGridView1
            // 
            dataGridView1.AccessibleDescription = "";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(468, 357);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RightToLeft = RightToLeft.Yes;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.ScrollBars = ScrollBars.Vertical;
            dataGridView1.Size = new Size(762, 242);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // showRes
            // 
            showRes.BackColor = Color.FromArgb(199, 167, 98);
            showRes.Location = new Point(723, 169);
            showRes.Name = "showRes";
            showRes.Size = new Size(413, 27);
            showRes.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 13.2000008F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(48, 168);
            label1.Name = "label1";
            label1.Size = new Size(156, 26);
            label1.TabIndex = 5;
            label1.Text = "בחר חומש להציג:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cooper Black", 25.8000011F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(64, 0, 0);
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(559, 23);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(254, 50);
            label2.TabIndex = 6;
            label2.Text = "חיפוש בתנ\"ך";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cooper Black", 13.2000008F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ImeMode = ImeMode.NoControl;
            label3.Location = new Point(548, 170);
            label3.Name = "label3";
            label3.Size = new Size(174, 26);
            label3.TabIndex = 7;
            label3.Text = "הכנס מילה לחיפוש:";
            // 
            // lostLetter
            // 
            lostLetter.BackColor = Color.FromArgb(199, 167, 98);
            lostLetter.Cursor = Cursors.Hand;
            lostLetter.ImeMode = ImeMode.NoControl;
            lostLetter.Location = new Point(747, 290);
            lostLetter.Name = "lostLetter";
            lostLetter.Size = new Size(186, 41);
            lostLetter.TabIndex = 8;
            lostLetter.Text = "חפש כתיב חסר";
            lostLetter.UseVisualStyleBackColor = false;
            lostLetter.Click += lostLetter_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(199, 167, 98);
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(961, 290);
            button1.Name = "button1";
            button1.Size = new Size(175, 41);
            button1.TabIndex = 11;
            button1.Text = "חפש מילה שלימה";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cooper Black", 13.2000008F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(548, 239);
            label4.Name = "label4";
            label4.Size = new Size(150, 26);
            label4.TabIndex = 12;
            label4.Text = "אפשרויות חיפוש:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(1034, 9);
            label5.Name = "label5";
            label5.Size = new Size(200, 17);
            label5.TabIndex = 13;
            label5.Text = "© מוריה שמחה גבע 053-4133209";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(235, 235, 215);
            ClientSize = new Size(1235, 615);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(lostLetter);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(showRes);
            Controls.Add(dataGridView1);
            Controls.Add(Chumashim);
            Controls.Add(browesChumash);
            Controls.Add(search);
            Name = "Form2";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Text = "Form2";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button search;
        private ListBox browesChumash;
        private TextBox Chumashim;
        private DataGridView dataGridView1;
        private TextBox showRes;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button lostLetter;
        private Button button1;
        private Label label4;
        private Label label5;
    }
}