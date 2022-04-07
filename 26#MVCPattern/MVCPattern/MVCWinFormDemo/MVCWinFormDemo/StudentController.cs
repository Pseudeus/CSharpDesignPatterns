using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCWinFormDemo
{
    //Controller
    class StudentController : IController
    {
        private IModel model;
        private StudentForm view;

        public StudentController(IModel model, StudentForm view)
        {
            this.model = model;
            this.view = view;
        }
        public void GetEnrolledStudents()
        {
            var enrolledStudents = model.GetEnrolledStudentDetailsFromModel();
            view.ShowEnrolledStudents(enrolledStudents);
        }
        //Sending a request to model to add a student to the student list
        public List<string> AddStudent(string studentName)
        {
            var postAdditionStudentList = new List<string>();
            postAdditionStudentList = model.AddStudentToModel(studentName);
            return postAdditionStudentList;
        }
        //Sending a request to model to remove a student from the student list
        public List<string> RemoveStudent(string studentName)
        {
            List<string> postRemovalStudentList = new List<string>();
            postRemovalStudentList = model.RemoveStudentFromModel(studentName);
            return postRemovalStudentList;
        }
    }
}
