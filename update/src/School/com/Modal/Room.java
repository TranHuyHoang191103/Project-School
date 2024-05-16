/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package School.com.Modal;

/**
 *
 * @author DO BINH
 */
public class Room {
    private String id;
    private boolean isParLab;
    private int numberOfSeat;

    public Room(String id, int numberOfSeat, boolean isParLab) {
        this.id = id;
        this.isParLab = isParLab;
        this.numberOfSeat = numberOfSeat;
    }

    public String getId() {
        return id;
    }

    public void setId(String id) {
        this.id = id;
    }

    public boolean isIsParLab() {
        return isParLab;
    }

    public void setIsParLab(boolean isParLab) {
        this.isParLab = isParLab;
    }

    public int getNumberOfSeat() {
        return numberOfSeat;
    }

    public void setNumberOfSeat(int numberOfSeat) {
        this.numberOfSeat = numberOfSeat;
    }
    
    
}
