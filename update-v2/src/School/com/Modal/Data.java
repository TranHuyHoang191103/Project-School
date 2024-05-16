/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package School.com.Modal;

import java.util.ArrayList;
import java.util.HashMap;

/**
 *
 * @author DO BINH
 */
public class Data {
     private ArrayList<Teacher> teachers;
    private ArrayList<Room>Rooms;
    private ArrayList<StudentGroup>studentGroups;
    private HashMap<String,Course>courses;

    public Data(ArrayList<Teacher> teachers, ArrayList<Room> Rooms, ArrayList<StudentGroup> studentGroups, HashMap<String, Course> courses) {
        this.teachers = teachers;
        this.Rooms = Rooms;
        this.studentGroups = studentGroups;
        this.courses = courses;
    }

    public ArrayList<Teacher> getTeachers() {
        return teachers;
    }

    public void setTeachers(ArrayList<Teacher> teachers) {
        this.teachers = teachers;
    }

    public ArrayList<Room> getRooms() {
        return Rooms;
    }

    public void setRooms(ArrayList<Room> Rooms) {
        this.Rooms = Rooms;
    }

    public ArrayList<StudentGroup> getStudentGroups() {
        return studentGroups;
    }

    public void setStudentGroups(ArrayList<StudentGroup> studentGroups) {
        this.studentGroups = studentGroups;
    }

    public HashMap<String, Course> getCourses() {
        return courses;
    }

    public void setCourses(HashMap<String, Course> courses) {
        this.courses = courses;
    }
    
    
}
