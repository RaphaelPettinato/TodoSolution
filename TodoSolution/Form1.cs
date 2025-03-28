using TodoSolution.task;

namespace TodoSolution
{
    public partial class Form1 : Form
    {
        List<taskDto> createdTasks = new List<taskDto>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            String newTaskName = textBox1.Text;

            taskDto newClass = new taskDto
            {
                Id = Guid.NewGuid(),
                TaskName = newTaskName,
                Completed = false,
                CompletedAt = DateTime.MinValue,
                InsertedAt = DateTime.Now
            };

            createdTasks.Add(newClass);

            listBox1.DataSource = null;
            listBox1.DataSource = createdTasks;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem is taskDto selectedTask)
            {
                createdTasks.Remove(selectedTask);

                listBox1.DataSource = null;
                listBox1.DataSource = createdTasks;
            }
            else
            {
                MessageBox.Show("Seleziona un task da eliminare.");
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedItem is taskDto selectedTask)
            {
                selectedTask.Completed = !selectedTask.Completed;
                selectedTask.CompletedAt = DateTime.Now;

                listBox1.DataSource = null;
                listBox1.DataSource = createdTasks;
            } else
            {
                MessageBox.Show("Seleziona un task da aggiornare.");
            }
        }
    }
}
