using DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;

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
	public Teacher(string id, string name,List<Course> courses)
	{
		this.id= id;
		this.name= name;
		this.courses = courses;
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

	
	public string getName() { return name; }
}
