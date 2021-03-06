using System;
using System.Collections.Generic;

namespace dotnetClasses
{ 
	public class Class
	{
		public int ClassId { get; set; } 
		public string ClassName { get; set; }
		public List<Student> Students { get; set; }
		public string Teacher { get; set; }

		public Class(int ClassId, string ClassName, List<Student> Students, string Teacher)
		{
			this.ClassId = ClassId;
			this.ClassName = ClassName;
			this.Students = Students;
			this.Teacher = Teacher;
		}
	}
}