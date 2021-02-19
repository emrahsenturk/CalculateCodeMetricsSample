using CalculateCodeMetricsSample.Business.Abstract;
using CalculateCodeMetricsSample.Enumerations;
using CalculateCodeMetricsSample.Exceptions;
using CalculateCodeMetricsSample.Models.Concrete;
using System;
using System.Collections.Generic;

namespace CalculateCodeMetricsSample.Business.Concrete
{
    public class StudentService : IStudentService
    {
        protected List<StudentModel> students = new List<StudentModel>
        {
            new StudentModel
            {
                Id = Guid.Parse("AAAAAAAA-0000-0000-0000-000000000000"),
                FirstName = "Emrah",
                LastName = "Şentürk",
                Email = "test1@test.com",
                TelephoneNumber = "05301234567",
                StudentTypeId = 1
            },
            new StudentModel
            {
                Id = Guid.Parse("BBBBBBBB-0000-0000-0000-000000000000"),
                FirstName = "Ersin",
                LastName = "Yıldız",
                Email = "test2@test.com",
                TelephoneNumber = "05307654321",
                StudentTypeId = 2
            },
            new StudentModel
            {
                Id = Guid.Parse("CCCCCCCC-0000-0000-0000-000000000000"),
                FirstName = "Serkan",
                LastName = "Çetintaş",
                Email = "test3@test.com",
                TelephoneNumber = "053011112233",
                StudentTypeId = 3
            }
        };

        public StudentService()
        {

        }

        public StudentModel GetById(Guid id)
        {
            var model = students.Find(p => p.Id == id);
            return model;
        }

        public bool CheckStudentExist(Guid id)
        {
            var model = GetById(id);
            if (model is null)
            {
                return false;
            }
            return true;
        }

        public void CreateStudent(StudentModel model)
        {
            var isExist = CheckStudentExist(model.Id);
            if (isExist)
            {
                throw new StudentAlreadyRegisteredException(model.Id);
            }

            switch (model.StudentTypeId)
            {
                case (byte)StudentTypes.Undergraduate:
                    //DoSomething();
                    break;
                case (byte)StudentTypes.Postgraduate:
                    //DoSomething();
                    break;
                case (byte)StudentTypes.Doctoral:
                    //DoSomething();
                    break;
                default:
                    break;
            }
            students.Add(model);
        }
    }
}
