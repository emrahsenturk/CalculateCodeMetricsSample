using CalculateCodeMetricsSample.Business.Abstract;
using CalculateCodeMetricsSample.Models.Concrete;
using System;
using System.Collections.Generic;

namespace CalculateCodeMetricsSample.Business.Concrete
{
    public class LessonService : ILessonService
    {
        protected List<LessonModel> lessons = new List<LessonModel>
        {
            new LessonModel
            {
                Id = Guid.Parse("11111111-0000-0000-0000-000000000000"),
                Code = "CmpE 160",
                Name = "Introduction to Object Oriented Programming"
            },
            new LessonModel
            {
                Id = Guid.Parse("22222222-0000-0000-0000-000000000000"),
                Code = "CmpE 260",
                Name = "Principles of Programming Languages"
            },
            new LessonModel
            {
                Id = Guid.Parse("33333333-0000-0000-0000-000000000000"),
                Code = "CmpE 322",
                Name = "Operating Systems"
            },
            new LessonModel
            {
                Id = Guid.Parse("44444444-0000-0000-0000-000000000000"),
                Code = "CmpE 436",
                Name = "Concurrent and Distributed Programming"
            }
        };

        public LessonService()
        {

        }

        public LessonModel GetById(Guid id)
        {
            var model = lessons.Find(p => p.Id == id);
            return model;
        }
    }
}
