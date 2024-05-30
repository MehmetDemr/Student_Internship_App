using KuyrukUygulama;
using System.Collections.Generic;

namespace Veri_Yapılari_Odev
{
    public partial class Form1 : Form
    {

        private PriorityQueue priorityQueue;
        public Form1()
        {
            InitializeComponent();

            priorityQueue = new PriorityQueue(20);
        }
        private void DisplayQueue()
        {
            Student[] studentsArray = priorityQueue.ToArray();
            HeapSort heapSort = new HeapSort(studentsArray);
            Student[] sortedStudents = heapSort.Sort();
            listBox1.Items.Clear();
            foreach (var student in sortedStudents)
            {
                listBox1.Items.Add(student);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int studentNumber = int.Parse(textBox1.Text);
                string name = textBox2.Text;
                double gpa = double.Parse(textBox3.Text);
                string roleInOrganizations = " ";

                if (checkBox1.Checked)
                {
                    roleInOrganizations = "Yes";
                }
                else
                {
                    roleInOrganizations = "No";
                }

                int absenteeism = int.Parse(textBox4.Text);

                Student student = new Student(studentNumber, name, gpa, roleInOrganizations, absenteeism);
                priorityQueue.Insert(student);
                DisplayQueue();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Student removedStudent = priorityQueue.Remove();
                MessageBox.Show($"Removed: {removedStudent}");
                DisplayQueue();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                Student selectedStudent = (Student)listBox1.SelectedItem;
                textBox8.Text = selectedStudent.StudentNumber.ToString();
                textBox7.Text = selectedStudent.Name;
                textBox6.Text = selectedStudent.GPA.ToString();
                textBox5.Text = selectedStudent.Absenteeism.ToString();

                if (selectedStudent.RoleInOrganizations == "Yes")
                {

                    checkBox2.Checked = true;
                }
            }
        }


    }
}
