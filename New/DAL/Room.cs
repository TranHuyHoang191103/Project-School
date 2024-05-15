using System;

public class Room
{
	private string ID;
	private string name;
	private int numberOfSeat;
	bool isParctiacalLab;
	public Room(string ID,string name,int numberOfSeat,bool isParctiacalLab)
	{
		this.isParctiacalLab = isParctiacalLab;
		this.ID = ID;
		this.name = name;
		this.numberOfSeat = numberOfSeat;
	}
	public string getID() { return ID;}
	public string getName() { return name;}
	public int getNumberOfSeat() {  return numberOfSeat;}
	public bool getIsParcticalLab() {  return isParctiacalLab; }

}
