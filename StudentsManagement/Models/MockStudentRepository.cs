using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentsManagement.Models
{
    /// <summary>
    /// 模拟类
    /// </summary>
    public class MockStudentRepository : IStudentRepository
    {
        private List<Student> _studentsList;
        /// <summary>
        /// 数据模拟
        /// </summary>
        public MockStudentRepository()
        {
            _studentsList = new List<Student>()
            {
                new Student(){Id=1,Name="张三",ClassName=ClassNameEnum.FirstGrade,Email="123@163.com"},
                new Student(){Id=2,Name="李四",ClassName=ClassNameEnum.FirstGrade,Email="456@163.com"},
                new Student(){Id=3,Name="王五",ClassName=ClassNameEnum.FirstGrade,Email="789@163.com"},
            };
        }

        public IEnumerable<Student> GetAllStudents()
        {
            return _studentsList;
        }

        public Student GetStudent(int id)
        {
            return _studentsList.FirstOrDefault(a => a.Id == id);
        }
    }
}
