﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentsManagement.Models
{
    /// <summary>
    /// 学生模型
    /// </summary>
    public class Student
    {
        public int Id{ get; set; }
        public string Name{ get; set; }
        public ClassNameEnum ClassName { get; set; }
        public string Email { get; set; }
    }
}
