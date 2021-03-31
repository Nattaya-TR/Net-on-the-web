using System;

namespace dotnetClasses
{ 
	public class Student
	{
		
		public int Id { get; set; }
		public string Name { get; set; }
		public int ClassId { get; }

		public Student(int Id, string Name, int ClassId)
		{
			this.Id = Id;
			this.Name = Name;
			this.ClassId = ClassId;
		}
	}
}