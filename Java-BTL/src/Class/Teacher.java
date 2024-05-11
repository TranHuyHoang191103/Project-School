/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package Class;

import java.util.ArrayList;

/**
 *
 * @author 84397
 */
public class Teacher {
    private String id;
    private String name;
    private ArrayList<Course>courses;

    public Teacher(String id, String name, ArrayList<Course> courses) {
        this.id = id;
        this.name = name;
        this.courses = courses;
    }

    public String getId() {
        return id;
    }

    public void setId(String id) {
        this.id = id;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public ArrayList<Course> getCourse() {
        return courses;
    }

    public void setCourse(ArrayList<Course> course) {
        this.courses = course;
    }
    public boolean check(String id){
        for(int i=0;i<courses.size();i++)
            if(courses.get(i).getId() == null ? id == null : courses.get(i).getId().equals(id))
                return true;
        return false;
    }
    
}
