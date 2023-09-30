using System.ComponentModel;
using TodoApp.Core.Services;
using TodoApp.Data;
using TodoApp.Data.Repositories.Interfaces;
using TodoApp.Model;

namespace TodoApp
{
    public partial class TodoApp : Form
    {
        private readonly TodoAppService _toDoListService;
        private readonly ITodoAppRepositories _todoRepositories;
        private int selectedTaskId;

        public TodoApp(TodoAppService toDoListService, ITodoAppRepositories todoRepositories)
        {
            InitializeComponent();
            timer1.Start();
            _toDoListService = toDoListService;
            _todoRepositories = todoRepositories;

            RefreshDataGridView();
        }
        public void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AddButton_Click_1(object sender, EventArgs e)
        {
            AddTodoItem();
        }

        public void AddTodoItem()
        {
            try
            {
                if (TaskTextBox.Text == "" || DescriptionTextBox.Text == "" || NameTextBox.Text == "")
                {
                    MessageBox.Show("Please input all fields");
                    return;
                }

                TodoItem newItem = new TodoItem
                {
                    Name = NameTextBox.Text,
                    Task = TaskTextBox.Text,
                    Description = DescriptionTextBox.Text,
                    DateCreated = DateCreated.Value,
                    DueDate = DueDate.Value,

                };
                _toDoListService.AddTodoItem(newItem);
                RefreshDataGridView();
                MessageBox.Show("Added successfully");
                Reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void RefreshDataGridView()
        {
            List<TodoItem> todoItems = _toDoListService.GetAllTodoItems();
            var bindingList = new BindingList<TodoItem>(todoItems);
            GridView1.DataSource = bindingList;

            GridView1.Columns["ID"].Width = 40;
            GridView1.Columns["Name"].Width = 120;
            GridView1.Columns["Task"].Width = 150;
            GridView1.Columns["Description"].Width = 200;
            GridView1.Columns["DateCreated"].Width = 100;
            GridView1.Columns["DueDate"].Width = 100;
            GridView1.Columns["IsCompleted"].Width = 85;
        }

        private void Reset()
        {
            NameTextBox.Text = "";
            DescriptionTextBox.Text = "";
            TaskTextBox.Text = "";
            DateCreated.Value = DateTime.Now;
            DueDate.Value = DateTime.Now;
        }

        private void EditButton_Click_1(object sender, EventArgs e)
        {
            using (var dbContext = new TodoAppDBContext())
            {
                if (GridView1.SelectedRows.Count > 0)
                {
                    selectedTaskId = Convert.ToInt32(GridView1.SelectedRows[0].Cells["ID"].Value);
                    string existingName = GridView1.SelectedRows[0].Cells["Name"].Value.ToString();
                    string existingTask = GridView1.SelectedRows[0].Cells["Task"].Value.ToString();
                    string existingDescription = GridView1.SelectedRows[0].Cells["Description"].Value.ToString();
                    DateTime existingDateCreated = (DateTime)(GridView1.SelectedRows[0].Cells["DateCreated"].Value);
                    DateTime existingDueDate = (DateTime)(GridView1.SelectedRows[0].Cells["DueDate"].Value);

                    NameTextBox.Text = existingName;
                    TaskTextBox.Text = existingTask;
                    DescriptionTextBox.Text = existingDescription;
                    DateCreated.Value = existingDateCreated;
                    DueDate.Value = existingDueDate;
                    dbContext.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Please select a task to edit");
                }
            }
        }

        private void SearchTodo_Click(object sender, EventArgs e)
        {
            try
            {
                string searchTerm = SearchBox.Text.Trim().ToLower();
                if (string.IsNullOrEmpty(searchTerm))
                {
                    MessageBox.Show("Please enter a search keyword");
                    return;
                }

                List<TodoItem> allTodoItems = _toDoListService.GetAllTodoItems();

                var filteredItems = allTodoItems.Where(item =>
                    item.Name.ToLower().Contains(searchTerm) ||
                    item.Task.ToLower().Contains(searchTerm) ||
                    item.DateCreated.ToString("yyyy-MM-dd").Contains(searchTerm)
                ).ToList();

                if (filteredItems.Any())
                {
                    GridView1.DataSource = filteredItems;
                    //MessageBox.Show("Search result loaded successfully");
                }
                else
                {
                    GridView1.DataSource = null;
                    MessageBox.Show("No items matching the search keyword found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void DeleteButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (GridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select one or more tasks to delete");
                    return;
                }

                DialogResult result = MessageBox.Show("Are you sure you want to delete the selected task(s) ?", "Confirm delete", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    List<int> selectedTaskIds = new List<int>();
                    foreach (DataGridViewRow row in GridView1.SelectedRows)
                    {
                        int taskIdToDelete = Convert.ToInt32(row.Cells["ID"].Value);
                        selectedTaskIds.Add(taskIdToDelete);
                    }

                    foreach (int itemId in selectedTaskIds)
                    {
                        _toDoListService.DeleteTodoItem(itemId);
                    }

                    if (!_toDoListService.GetAllTodoItems().Any())
                    {
                        _todoRepositories.ResetAutoIncrement();
                    }
                }

                RefreshDataGridView();

                Reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }


        private void UpdateButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (selectedTaskId == 0)
                {
                    MessageBox.Show("Please select a to-do item to update.");
                    return;
                }

                TodoItem existingItem = _toDoListService.GetTodoItemById(selectedTaskId);

                if (existingItem == null)
                {
                    MessageBox.Show("Selected to-do item not found.");
                    return;
                }

                existingItem.Name = NameTextBox.Text;
                existingItem.Task = TaskTextBox.Text;
                existingItem.Description = DescriptionTextBox.Text;
                existingItem.DateCreated = DateCreated.Value;
                existingItem.DueDate = DueDate.Value;

                _toDoListService.UpdateTodoItem(existingItem);
                RefreshDataGridView();
                Reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (label1.Right > 0)
            {
                label1.Left -= 5;
            }
            else
            {
                label1.Left = this.Width;
            }
        }
    }
}