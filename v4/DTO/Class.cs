using ConsoleApp;

using System;

public class Class
{
	private Teacher teacher;
	private Course coruse;
	private StudentGroup studentGroup;
	private Room room;
	private ClassTime classTime;
	public Class(Teacher teacher,Course course,StudentGroup studentGroup,Room room )
	{
		this.teacher = teacher;
		this.studentGroup = studentGroup;
		this.coruse = course;
		this.room = room;
		classTime = new ClassTime(coruse.getNumberOfLesson());
	}

	public Teacher getTeacher() { return this.teacher; }
	public Course getCourse() { return this.coruse; }
	public StudentGroup getStudentGroup() {  return this.studentGroup; }
	public Room GetRoom() { return this.room; }
	public ClassTime GetClassTime() { return this.classTime; }
}
