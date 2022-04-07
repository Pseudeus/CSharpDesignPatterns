using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCWinFormDemo
{
    //View
    public partial class StudentForm : Form
    {
        StudentController studentController;

        public StudentForm()
        {
            InitializeComponent();
        }
        private void StudentForm_Load(object sender, EventArgs e)
        {
            studentController = new StudentController(new StudentModel(), this);
            this.showStudentsListView.MultiSelect = false;
            this.showStudentsListView.HideSelection = false;
            //Show enrolled student at the beginning
            studentController.GetEnrolledStudents();
        }
        public void ShowEnrolledStudents(List<string> studentList)
        {
            //clear the list view first
            showStudentsListView.Items.Clear();
            //System.Text.StringBuilder sb = new System.Text.StringBuilder();
            foreach(string student in studentList)
            {
                showStudentsListView.Items.Add(student);
            }
        }
        private void addStudentButton_Click(object sender, EventArgs e)
        {
            //We will not adda n empty student name
            if (addStudentTextBox.Text != String.Empty)
            {
                //Get the name from GUI
                string newName = addStudentTextBox.Text;
                //List<string> updatedStudentList = new List<string>();
                //Add a student name and get the new student list through controller
                showStudentsListView.Items.Clear();
                studentController.AddStudent(newName);
                studentController.GetEnrolledStudents();
                //Cleaning the addStudentTextBox content
                addStudentTextBox.Clear();
            }
        }
        private void removeStudentButton_Click(object sender, EventArgs e)
        {
            //We can select only one iten at a time
            if (showStudentsListView.SelectedItems.Count == 1)
            {
                //Get the name from GUI
                string studentName = showStudentsListView.SelectedItems[0].Text;
                var updatedStudentList = new List<string>();
                //Remove the student name and get the new student list through controller
                updatedStudentList = studentController.RemoveStudent(studentName);
                //Now Display bach to GUI.This value is coming through the controller
                showStudentsListView.Items.Clear();
                studentController.GetEnrolledStudents();
            }
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
