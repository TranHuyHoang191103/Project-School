using System;
using System.Collections.Generic;
public class Teacher
{
	private string id;
	private string name;
	private List<Course> courses;
	public Teacher()
	{
		id = "";
		name = "";
        courses = new List<Course>();
	}
	public bool check(string id)
	{
		for(int i=0;i<courses.Count;i++)
		{
			if (courses[i].getID() == id)
				return true;
		}
		return false;
	}
	public string getID() { return id; }
}
