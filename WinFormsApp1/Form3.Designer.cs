namespace WinFormsApp1
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            textBoxSearch = new TextBox();
            buttonSearch = new Button();
            button3 = new Button();
            button2 = new Button();
            button4 = new Button();
            button5 = new Button();
            label1 = new Label();
            listBoxBooks = new ListBox();
            SuspendLayout();
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(255, 101);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(227, 23);
            textBoxSearch.TabIndex = 0;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(488, 101);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(75, 23);
            buttonSearch.TabIndex = 1;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += ButtonSearch_Click;
            // 
            // button3
            // 
            button3.Location = new Point(446, 244);
            button3.Name = "button3";
            button3.Size = new Size(223, 54);
            button3.TabIndex = 3;
            button3.Text = "Manage Members";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(186, 244);
            button2.Name = "button2";
            button2.Size = new Size(223, 54);
            button2.TabIndex = 5;
            button2.Text = "Manage Books";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.Location = new Point(310, 318);
            button4.Name = "button4";
            button4.Size = new Size(223, 54);
            button4.TabIndex = 6;
            button4.Text = "Borrow and return ";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(334, 415);
            button5.Name = "button5";
            button5.Size = new Size(185, 23);
            button5.TabIndex = 7;
            button5.Text = "Sign out ";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(333, 63);
            label1.Name = "label1";
            label1.Size = new Size(149, 15);
            label1.TabIndex = 8;
            label1.Text = "Library Mangment System ";
            label1.Click += label1_Click;
            // 
            // listBoxBooks
            // 
            listBoxBooks.FormattingEnabled = true;
            listBoxBooks.ItemHeight = 15;
            listBoxBooks.Location = new Point(282, 130);
            listBoxBooks.Name = "listBoxBooks";
            listBoxBooks.Size = new Size(264, 94);
            listBoxBooks.TabIndex = 9;
            listBoxBooks.SelectedIndexChanged += listBoxBooks_SelectedIndexChanged;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(listBoxBooks);
            Controls.Add(label1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(buttonSearch);
            Controls.Add(textBoxSearch);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxSearch;
        private Button buttonSearch;
        private Button button3;
        private Button button2;
        private Button button4;
        private Button button5;
        private Label label1;
        private ListBox listBoxBooks;
    }
}