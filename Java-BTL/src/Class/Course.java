/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package Class;

/**
 *
 * @author 84397
 */
public class Course {
    private String id;
    private String name;
    private boolean isParCourse;
    private int numberOfLesson;

    public Course(String id, String name, boolean isParCourse, int numberOfLesson) {
        this.id = id;
        this.name = name;
        this.isParCourse = isParCourse;
        this.numberOfLesson = numberOfLesson;
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

    public boolean isIsParCourse() {
        return isParCourse;
    }

    public void setIsParCourse(boolean isParCourse) {
        this.isParCourse = isParCourse;
    }

    public int getNumberOfLesson() {
        return numberOfLesson;
    }

    public void setNumberOfLesson(int numberOfLesson) {
        this.numberOfLesson = numberOfLesson;
    }
    
    
}
