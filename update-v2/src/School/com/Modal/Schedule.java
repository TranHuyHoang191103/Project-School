/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package School.com.Modal;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.Random;

/**
 *
 * @author DO BINH
 */
public class Schedule implements Comparable<Schedule>{
      private final ArrayList<Class>classes;
    private double fitness;
    private final Data data;

      public Schedule(Data data) {
        classes=new ArrayList<>();
        fitness=0;
        this.data = data;
    }

    public double getFitness() {
        return fitness;
    }
    public void display(){
        for(int i=0;i<classes.size();i++)
            System.out.println(classes.get(i).getStudentGroup().getId()+" "+classes.get(i).getRoom().getId()+" "+classes.get(i).getTeacher().getId()+" "+classes.get(i).getCourse().getId()+" "+classes.get(i).getClassTime().toString());
    }
    public Class mutation(ArrayList<Room>rooms,ArrayList<Teacher> teachers,HashMap<String,Course>courses,StudentGroup studentGroup){

        Random rd=new Random();
        int rd_room=rd.nextInt(rooms.size());
        int rd_teacher=rd.nextInt(teachers.size());
        return (new Class(teachers.get(rd_teacher),rooms.get(rd_room),studentGroup, courses.get(studentGroup.getIdCourse())));
    }
    public double calFitness(){
        int number=0;
        for(int i=0;i<classes.size()-1;i++){
            if(classes.get(i).getCourse().isIsParCourse()!=classes.get(i).getRoom().isIsParLab())
                number++;
            if(classes.get(i).getRoom().getNumberOfSeat()<classes.get(i).getStudentGroup().getNumberOfMember())
                number++;
            if(!classes.get(i).getTeacher().check(classes.get(i).getCourse().getId()))
                number++;
            for(int j=i+1;j<classes.size();j++){
                if(classes.get(i).getRoom().getId() == null ? classes.get(j).getRoom().getId() == null : classes.get(i).getRoom().getId().equals(classes.get(j).getRoom().getId())){
                    if(!classes.get(i).getClassTime().check(classes.get(j).getClassTime()))
                        number++;
                }
                if(classes.get(i).getTeacher().getId() == null ? classes.get(j).getTeacher().getId() == null : classes.get(i).getTeacher().getId().equals(classes.get(j).getTeacher().getId())){
                    if(!classes.get(i).getClassTime().check(classes.get(j).getClassTime()))
                        number++;
                }
                if(classes.get(i).getStudentGroup().getId() == null ? classes.get(j).getStudentGroup().getId() == null : classes.get(i).getStudentGroup().getId().equals(classes.get(j).getStudentGroup().getId())){
                    if(!classes.get(i).getClassTime().check(classes.get(j).getClassTime()))
                        number++;
                }
            }

        }
        fitness=1.0/(number+1);
        return fitness;
    }

    public Schedule initialize(){
        ArrayList<Room>rooms=data.getRooms();
        ArrayList<StudentGroup>studentGroups=data.getStudentGroups();
        ArrayList<Teacher>teachers=data.getTeachers();
        HashMap<String,Course>courses=data.getCourses();
        for(int i=0;i<studentGroups.size();i++){
            classes.add(mutation(rooms,teachers,courses,studentGroups.get(i)));
        }
        calFitness();
        return this;
    }
    public Schedule mate(Schedule other){
        Schedule ret=new Schedule(data);
        Random rd=new Random();
        for(int i=0;i<classes.size();i++){
            float p=rd.nextFloat(101)/100;
            if(p<0.45)
                ret.classes.add(classes.get(i));
            else if(p<0.9)
                ret.classes.add(other.classes.get(i));
            else ret.classes.add(mutation(ret.data.getRooms(), ret.data.getTeachers(), ret.data.getCourses(),ret.data.getStudentGroups().get(i)));
        }
        ret.calFitness();
        return ret;
    }

    @Override
    public int compareTo(Schedule o) {
        return Double.compare(o.getFitness(), this.getFitness());
    }
    
    
}
