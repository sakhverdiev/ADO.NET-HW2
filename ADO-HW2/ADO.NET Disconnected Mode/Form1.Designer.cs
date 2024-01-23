namespace ADO.NET_Disconnected_Mode
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
            SearchButton = new Button();
            InsertButton = new Button();
            UpdateButton = new Button();
            DeleteButton = new Button();
            dataGridView1 = new DataGridView();
            SearchTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(10, 34);
            SearchButton.Margin = new Padding(3, 2, 3, 2);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(91, 22);
            SearchButton.TabIndex = 2;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // InsertButton
            // 
            InsertButton.Location = new Point(781, 34);
            InsertButton.Margin = new Padding(3, 2, 3, 2);
            InsertButton.Name = "InsertButton";
            InsertButton.Size = new Size(82, 22);
            InsertButton.TabIndex = 3;
            InsertButton.Text = "Insert";
            InsertButton.UseVisualStyleBackColor = true;
            InsertButton.Click += InsertButton_Click;
            // 
            // UpdateButton
            // 
            UpdateButton.Location = new Point(869, 34);
            UpdateButton.Margin = new Padding(3, 2, 3, 2);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(82, 22);
            UpdateButton.TabIndex = 4;
            UpdateButton.Text = "Update";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(956, 34);
            DeleteButton.Margin = new Padding(3, 2, 3, 2);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(82, 22);
            DeleteButton.TabIndex = 5;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(10, 60);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1028, 496);
            dataGridView1.TabIndex = 6;
            // 
            // SearchTextBox
            // 
            SearchTextBox.Location = new Point(10, 9);
            SearchTextBox.Margin = new Padding(3, 2, 3, 2);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Size = new Size(1029, 23);
            SearchTextBox.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1049, 565);
            Controls.Add(SearchTextBox);
            Controls.Add(dataGridView1);
            Controls.Add(DeleteButton);
            Controls.Add(UpdateButton);
            Controls.Add(InsertButton);
            Controls.Add(SearchButton);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button SearchButton;
        private Button InsertButton;
        private Button UpdateButton;
        private Button DeleteButton;
        private DataGridView dataGridView1;
        private TextBox SearchTextBox;
    }
}