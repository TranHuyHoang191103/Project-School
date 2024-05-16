/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package School.com.Modal;

import java.util.ArrayList;
import java.util.Random;

/**
 *
 * @author DO BINH
 */
public class ClassTime {
     private int day; // Assuming you want to store the day, but it's not used in the constructor
    private int st; // Start time
    private int ed; // End time
    private int dur;
    
     public ClassTime(int dur) {
        this.dur = dur;
        ArrayList<Integer> time = new ArrayList<Integer>();
        Random rd = new Random();
        day=rd.nextInt(2, 8);
        // Adding available start times based on duration
        for (int i = 1; i <= 7 - dur; i++) {
            time.add(i);
        }
        for (int i = 7; i <= 13 - dur; i++) {
            time.add(i);
        }

        // Randomly select a start time from the available options

        int k = rd.nextInt(time.size());
        st = time.get(k);
        ed = st + this.dur-1;
    }

    public int getDay() {
        return day;
    }

    public void setDay(int day) {
        this.day = day;
    }

    public int getSt() {
        return st;
    }

    public void setSt(int st) {
        this.st = st;
    }

    public int getEd() {
        return ed;
    }

    public void setEd(int ed) {
        this.ed = ed;
    }

    public int getDur() {
        return dur;
    }

    public void setDur(int dur) {
        this.dur = dur;
    }
     
     public boolean check(ClassTime other){
        if(this.day==other.day){
            if((this.st>=other.st &&st<=other.ed)||(st<=other.st &&ed>=other.st))
                return false;
        }
        return true;
    }

    @Override
    public String toString() {
        return "ClassTime{" + "day=" + day + ", st=" + st + ", ed=" + ed + ", dur=" + dur + '}';
    }

    
     
}
