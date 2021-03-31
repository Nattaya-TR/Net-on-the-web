using System;

namespace dotnetClasses
{ 
	public class Teacher
	{
		public string TeacherName { get; set; }
		public int ClassId { get; set; }
		public string ClassName { get; set; } 

		public Teacher(string TeacherName, int ClassId, string ClassName)
		{
			this.TeacherName = TeacherName;
			this.ClassId = ClassId;
			this.ClassName = ClassName;
		}
	}
}