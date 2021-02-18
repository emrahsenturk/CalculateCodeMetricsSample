using CalculateCodeMetricsSample.Models.Concrete;
using System;

namespace CalculateCodeMetricsSample.Business.Abstract
{
    public interface IStudentService
    {
        StudentModel GetById(Guid id);
        bool CheckStudentExist(Guid id);
        void CreateStudent(StudentModel model);
    }
}
