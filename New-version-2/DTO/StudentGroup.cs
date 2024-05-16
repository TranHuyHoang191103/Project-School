using System;

public class StudentGroup
{
	private string ID;
    private string idCoruse;
    private string name;
	private int numberOfMember;
	public StudentGroup(string ID, string idCoruse, string name,int numberOfMember)
	{
		this.ID = ID;
		this.idCoruse = idCoruse; 
		this.name = name;
		this.numberOfMember = numberOfMember;
	}
	public string getID() {  return ID; }
	public string getIdCoruse() {  return idCoruse; }
	public string getName() { return name; }
	public int getNumberOfMember() {  return numberOfMember; }

}
