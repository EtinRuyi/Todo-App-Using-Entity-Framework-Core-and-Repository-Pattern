namespace TodoApp
{
    partial class TodoApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TodoApp));
            Header = new Label();
            DueDate = new DateTimePicker();
            Created = new Label();
            Due = new Label();
            Name = new Label();
            Task = new Label();
            NameTextBox = new TextBox();
            TaskTextBox = new TextBox();
            SearchBox = new TextBox();
            DateCreated = new DateTimePicker();
            SearchTodo = new Button();
            UpdateButton = new Button();
            DeleteButton = new Button();
            EditButton = new Button();
            LoadButton = new Button();
            AddButton = new Button();
            Description = new Label();
            DescriptionTextBox = new TextBox();
            GridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)GridView1).BeginInit();
            SuspendLayout();
            // 
            // Header
            // 
            Header.AllowDrop = true;
            Header.BackColor = Color.Khaki;
            Header.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            Header.Location = new Point(1, 1);
            Header.Name = "Header";
            Header.Size = new Size(1193, 53);
            Header.TabIndex = 1;
            Header.Text = "Todo App";
            Header.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // DueDate
            // 
            DueDate.Location = new Point(948, 143);
            DueDate.Name = "DueDate";
            DueDate.Size = new Size(235, 25);
            DueDate.TabIndex = 2;
            // 
            // Created
            // 
            Created.AllowDrop = true;
            Created.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Created.Location = new Point(840, 102);
            Created.Name = "Created";
            Created.Size = new Size(111, 25);
            Created.TabIndex = 13;
            Created.Text = "Created Date :";
            Created.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Due
            // 
            Due.AllowDrop = true;
            Due.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Due.Location = new Point(870, 143);
            Due.Name = "Due";
            Due.Size = new Size(81, 25);
            Due.TabIndex = 17;
            Due.Text = "Due Date :";
            // 
            // Name
            // 
            Name.AllowDrop = true;
            Name.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Name.Location = new Point(12, 102);
            Name.Name = "Name";
            Name.Size = new Size(75, 36);
            Name.TabIndex = 5;
            Name.Text = "Name :";
            Name.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Task
            // 
            Task.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Task.Location = new Point(12, 171);
            Task.Name = "Task";
            Task.Size = new Size(75, 34);
            Task.TabIndex = 6;
            Task.Text = "Task : ";
            Task.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(12, 130);
            NameTextBox.Multiline = true;
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(277, 38);
            NameTextBox.TabIndex = 8;
            // 
            // TaskTextBox
            // 
            TaskTextBox.Location = new Point(12, 199);
            TaskTextBox.Multiline = true;
            TaskTextBox.Name = "TaskTextBox";
            TaskTextBox.Size = new Size(277, 38);
            TaskTextBox.TabIndex = 9;
            // 
            // SearchBox
            // 
            SearchBox.Font = new Font("Times New Roman", 9F, FontStyle.Italic, GraphicsUnit.Point);
            SearchBox.Location = new Point(948, 18);
            SearchBox.Multiline = true;
            SearchBox.Name = "SearchBox";
            SearchBox.Size = new Size(155, 25);
            SearchBox.TabIndex = 11;
            SearchBox.Text = "Enter title";
            SearchBox.TextAlign = HorizontalAlignment.Center;
            // 
            // DateCreated
            // 
            DateCreated.Location = new Point(948, 102);
            DateCreated.Name = "DateCreated";
            DateCreated.Size = new Size(235, 25);
            DateCreated.TabIndex = 13;
            // 
            // SearchTodo
            // 
            SearchTodo.BackColor = SystemColors.ButtonFace;
            SearchTodo.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            SearchTodo.Location = new Point(1100, 18);
            SearchTodo.Name = "SearchTodo";
            SearchTodo.Size = new Size(83, 25);
            SearchTodo.TabIndex = 14;
            SearchTodo.Text = "Search";
            SearchTodo.UseVisualStyleBackColor = false;
            SearchTodo.Click += SearchTodo_Click;
            // 
            // UpdateButton
            // 
            UpdateButton.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            UpdateButton.Location = new Point(779, 335);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(172, 45);
            UpdateButton.TabIndex = 15;
            UpdateButton.Text = "Update";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateButton_Click_1;
            // 
            // DeleteButton
            // 
            DeleteButton.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            DeleteButton.Location = new Point(1020, 335);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(162, 45);
            DeleteButton.TabIndex = 16;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click_1;
            // 
            // EditButton
            // 
            EditButton.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            EditButton.Location = new Point(513, 335);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(178, 45);
            EditButton.TabIndex = 17;
            EditButton.Text = "Edit Selected";
            EditButton.UseVisualStyleBackColor = true;
            EditButton.Click += EditButton_Click_1;
            // 
            // LoadButton
            // 
            LoadButton.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            LoadButton.Location = new Point(262, 335);
            LoadButton.Name = "LoadButton";
            LoadButton.Size = new Size(166, 45);
            LoadButton.TabIndex = 18;
            LoadButton.Text = "Load All Todo";
            LoadButton.UseVisualStyleBackColor = true;
            LoadButton.Click += LoadButton_Click_1;
            // 
            // AddButton
            // 
            AddButton.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            AddButton.Location = new Point(12, 335);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(178, 45);
            AddButton.TabIndex = 19;
            AddButton.Text = "Add/Save";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click_1;
            // 
            // Description
            // 
            Description.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Description.Location = new Point(12, 240);
            Description.Name = "Description";
            Description.Size = new Size(127, 43);
            Description.TabIndex = 20;
            Description.Text = "Description : ";
            Description.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.Location = new Point(12, 276);
            DescriptionTextBox.Multiline = true;
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.Size = new Size(1171, 53);
            DescriptionTextBox.TabIndex = 21;
            // 
            // GridView1
            // 
            GridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GridView1.BackgroundColor = Color.DodgerBlue;
            GridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridView1.Location = new Point(12, 386);
            GridView1.Name = "GridView1";
            GridView1.RowTemplate.Height = 25;
            GridView1.Size = new Size(1171, 303);
            GridView1.TabIndex = 22;
            // 
            // TodoApp
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DodgerBlue;
            ClientSize = new Size(1194, 701);
            Controls.Add(GridView1);
            Controls.Add(DescriptionTextBox);
            Controls.Add(Description);
            Controls.Add(AddButton);
            Controls.Add(LoadButton);
            Controls.Add(EditButton);
            Controls.Add(DeleteButton);
            Controls.Add(UpdateButton);
            Controls.Add(SearchTodo);
            Controls.Add(DateCreated);
            Controls.Add(SearchBox);
            Controls.Add(TaskTextBox);
            Controls.Add(NameTextBox);
            Controls.Add(Task);
            Controls.Add(Name);
            Controls.Add(Due);
            Controls.Add(Created);
            Controls.Add(DueDate);
            Controls.Add(Header);
            Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            //Name = "TodoApp";
            Text = "TodoApp";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)GridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label Header;
        private DateTimePicker DueDate;
        private Label Created;
        private Label Due;
        private Label Name;
        private Label Task;
        private TextBox NameTextBox;
        private TextBox TaskTextBox;
        private TextBox SearchBox;
        private DateTimePicker DateCreated;
        private Button SearchTodo;
        private Button UpdateButton;
        private Button DeleteButton;
        private Button EditButton;
        private Button LoadButton;
        private Button AddButton;
        private Label Description;
        private TextBox DescriptionTextBox;
        private DataGridView GridView1;
    }
}