using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCWinFormDemo
{
    //Controller
    public interface IController
    {
        void GetEnrolledStudents();
        List<string> AddStudent(string studentName);
        List<string> RemoveStudent(string studentName);
    }
    //Model
    public interface IModel
    {
        List<string> GetEnrolledStudentDetailsFromModel();
        List<string> AddStudentToModel(string studentName);
        List<string> RemoveStudentFromModel(string studentName);
    }
}
