using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCWinFormDemo
{
    //Model
    class StudentModel : IModel
    {
        private List<string> enrolledStudents = new List<string> { "Amith", "Jhon", "Sam" };
        
        public List<string> GetEnrolledStudentDetailsFromModel()
        {
            return enrolledStudents;
        }
        //Adding a student to the model(student list)
        public List<string> AddStudentToModel(string studentName)
        {
            enrolledStudents.Add(studentName);
            return enrolledStudents;
        }
        //Removing a student from model(student list)
        public List<string> RemoveStudentFromModel(string studentName)
        {
            enrolledStudents.Remove(studentName);
            //After the removal of a student name, send the updated list to controller
            return enrolledStudents;
        }
    }
}
