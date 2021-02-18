using CalculateCodeMetricsSample.Business.Abstract;
using CalculateCodeMetricsSample.Exceptions;
using System;

namespace CalculateCodeMetricsSample.Business.Concrete
{
    public class StudentLessonService : IStudentLessonService
    {
        private readonly IStudentService studentService;
        private readonly IStudentService lessonService;
        private readonly IStudentLessonExamService studentLessonExamService;
        private readonly int PassingScore = 70;

        public StudentLessonService(
            IStudentService studentService,
            IStudentService lessonService,
            IStudentLessonExamService studentLessonExamService)
        {
            this.studentService = studentService;
            this.lessonService = lessonService;
            this.studentLessonExamService = studentLessonExamService;
        }

        private int CalculateLessonFinalScore(Guid studentId, Guid lessonId)
        {
            var studentModel = studentService.GetById(studentId);
            if(studentModel is null)
            {
                throw new StudentNotFoundException(studentId);
            }

            var lessonModel = lessonService.GetById(lessonId);
            if(lessonModel is null)
            {
                throw new LessonNotFoundException(lessonId);
            }

            var studentLessonExamResults = studentLessonExamService.GetExamResults(studentId, lessonId);

            var finalResult = 0;
            foreach(var studentLessonExamResult in studentLessonExamResults)
            {
                finalResult += studentLessonExamResult.Result * (studentLessonExamResult.LessonExam.Percent / 100);
            }

            return finalResult;
        }

        private string GetScoreText(int final)
        {
            if(final >= PassingScore)
            {
                return "Passed";
            }
            return "Fail";
        }

        public string GetResult(Guid studentId, Guid lessonId)
        {
            var score = CalculateLessonFinalScore(studentId, lessonId);
            return GetScoreText(score);
        }
    }
}
