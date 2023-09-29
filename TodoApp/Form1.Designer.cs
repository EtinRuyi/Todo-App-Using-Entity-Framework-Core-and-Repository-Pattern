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
            components = new System.ComponentModel.Container();
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
            AddButton = new Button();
            Description = new Label();
            DescriptionTextBox = new TextBox();
            GridView1 = new DataGridView();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)GridView1).BeginInit();
            SuspendLayout();
            // 
            // Header
            // 
            Header.AllowDrop = true;
            Header.BackColor = Color.Black;
            Header.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            Header.ForeColor = Color.WhiteSmoke;
            Header.Location = new Point(1, 1);
            Header.Name = "Header";
            Header.Size = new Size(823, 53);
            Header.TabIndex = 1;
            Header.Text = "Todo App";
            Header.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // DueDate
            // 
            DueDate.Location = new Point(577, 161);
            DueDate.Name = "DueDate";
            DueDate.Size = new Size(235, 25);
            DueDate.TabIndex = 2;
            // 
            // Created
            // 
            Created.AllowDrop = true;
            Created.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Created.ForeColor = Color.WhiteSmoke;
            Created.Location = new Point(471, 130);
            Created.Name = "Created";
            Created.Size = new Size(100, 25);
            Created.TabIndex = 13;
            Created.Text = "Created Date";
            Created.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Due
            // 
            Due.AllowDrop = true;
            Due.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Due.ForeColor = Color.WhiteSmoke;
            Due.Location = new Point(501, 161);
            Due.Name = "Due";
            Due.Size = new Size(70, 25);
            Due.TabIndex = 17;
            Due.Text = "Due Date";
            Due.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Name
            // 
            Name.AllowDrop = true;
            Name.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Name.ForeColor = Color.WhiteSmoke;
            Name.Location = new Point(12, 118);
            Name.Name = "Name";
            Name.Size = new Size(58, 25);
            Name.TabIndex = 5;
            Name.Text = "Name";
            Name.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Task
            // 
            Task.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Task.ForeColor = Color.WhiteSmoke;
            Task.Location = new Point(12, 174);
            Task.Name = "Task";
            Task.Size = new Size(51, 25);
            Task.TabIndex = 6;
            Task.Text = "Task";
            Task.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(12, 146);
            NameTextBox.Multiline = true;
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(343, 25);
            NameTextBox.TabIndex = 8;
            // 
            // TaskTextBox
            // 
            TaskTextBox.Location = new Point(12, 202);
            TaskTextBox.Multiline = true;
            TaskTextBox.Name = "TaskTextBox";
            TaskTextBox.Size = new Size(343, 25);
            TaskTextBox.TabIndex = 9;
            // 
            // SearchBox
            // 
            SearchBox.Font = new Font("Times New Roman", 9F, FontStyle.Italic, GraphicsUnit.Point);
            SearchBox.Location = new Point(587, 18);
            SearchBox.Multiline = true;
            SearchBox.Name = "SearchBox";
            SearchBox.Size = new Size(155, 25);
            SearchBox.TabIndex = 11;
            SearchBox.Text = "Enter title";
            SearchBox.TextAlign = HorizontalAlignment.Center;
            // 
            // DateCreated
            // 
            DateCreated.Location = new Point(577, 130);
            DateCreated.Name = "DateCreated";
            DateCreated.Size = new Size(235, 25);
            DateCreated.TabIndex = 13;
            // 
            // SearchTodo
            // 
            SearchTodo.BackColor = SystemColors.ButtonFace;
            SearchTodo.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            SearchTodo.ForeColor = Color.Black;
            SearchTodo.Location = new Point(729, 18);
            SearchTodo.Name = "SearchTodo";
            SearchTodo.Size = new Size(83, 25);
            SearchTodo.TabIndex = 14;
            SearchTodo.Text = "Search";
            SearchTodo.UseVisualStyleBackColor = false;
            SearchTodo.Click += SearchTodo_Click;
            // 
            // UpdateButton
            // 
            UpdateButton.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            UpdateButton.ForeColor = Color.Black;
            UpdateButton.Image = (Image)resources.GetObject("UpdateButton.Image");
            UpdateButton.ImageAlign = ContentAlignment.MiddleLeft;
            UpdateButton.Location = new Point(615, 293);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(95, 45);
            UpdateButton.TabIndex = 15;
            UpdateButton.Text = "Update";
            UpdateButton.TextAlign = ContentAlignment.MiddleRight;
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateButton_Click_1;
            // 
            // DeleteButton
            // 
            DeleteButton.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            DeleteButton.ForeColor = Color.Black;
            DeleteButton.Image = (Image)resources.GetObject("DeleteButton.Image");
            DeleteButton.ImageAlign = ContentAlignment.MiddleLeft;
            DeleteButton.Location = new Point(716, 293);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(95, 45);
            DeleteButton.TabIndex = 16;
            DeleteButton.Text = "Delete";
            DeleteButton.TextAlign = ContentAlignment.MiddleRight;
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click_1;
            // 
            // EditButton
            // 
            EditButton.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            EditButton.ForeColor = Color.Black;
            EditButton.Image = (Image)resources.GetObject("EditButton.Image");
            EditButton.ImageAlign = ContentAlignment.MiddleLeft;
            EditButton.Location = new Point(534, 293);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(75, 45);
            EditButton.TabIndex = 17;
            EditButton.Text = "Edit";
            EditButton.TextAlign = ContentAlignment.MiddleRight;
            EditButton.UseVisualStyleBackColor = true;
            EditButton.Click += EditButton_Click_1;
            // 
            // AddButton
            // 
            AddButton.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            AddButton.ForeColor = Color.Black;
            AddButton.Image = (Image)resources.GetObject("AddButton.Image");
            AddButton.ImageAlign = ContentAlignment.MiddleLeft;
            AddButton.Location = new Point(453, 293);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(75, 45);
            AddButton.TabIndex = 19;
            AddButton.Text = "Add";
            AddButton.TextAlign = ContentAlignment.MiddleRight;
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click_1;
            // 
            // Description
            // 
            Description.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Description.ForeColor = Color.WhiteSmoke;
            Description.Location = new Point(11, 229);
            Description.Name = "Description";
            Description.Size = new Size(105, 33);
            Description.TabIndex = 20;
            Description.Text = "Description";
            Description.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.Location = new Point(11, 265);
            DescriptionTextBox.Multiline = true;
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.Size = new Size(344, 73);
            DescriptionTextBox.TabIndex = 21;
            // 
            // GridView1
            // 
            GridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GridView1.BackgroundColor = SystemColors.ControlDarkDark;
            GridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridView1.Location = new Point(11, 358);
            GridView1.Name = "GridView1";
            GridView1.RowTemplate.Height = 25;
            GridView1.Size = new Size(800, 189);
            GridView1.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.PaleGoldenrod;
            label1.Location = new Point(421, 63);
            label1.Name = "label1";
            label1.Size = new Size(390, 22);
            label1.TabIndex = 23;
            label1.Text = "Organize, prioritize, and conquer with TodoApp";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // TodoApp
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(823, 559);
            Controls.Add(label1);
            Controls.Add(GridView1);
            Controls.Add(DescriptionTextBox);
            Controls.Add(Description);
            Controls.Add(AddButton);
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
            ForeColor = Color.Black;
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
        private Button AddButton;
        private Label Description;
        private TextBox DescriptionTextBox;
        private DataGridView GridView1;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}