/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package BTLJaVa;
import Class.*;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Random;
/**
 *
 * @author 84397
 */
public class JavaBTL {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        ArrayList<Room> rooms = new ArrayList<>();
        rooms.add(new Room("123", 35, true));
        rooms.add(new Room("234", 40, false));
        rooms.add(new Room("235", 40, false));
        rooms.add(new Room("236", 40, false));
        rooms.add(new Room("124", 40, true));
        rooms.add(new Room("125", 40, true));
        
        // Add more rooms if needed

        HashMap<String, Course> courses = new HashMap<>();
        courses.put("111", new Course("111", "thuc tap lt", true, 3));
        courses.put("222", new Course("222", "huong doi tuong", false, 4));
        courses.put("112", new Course("112", "thuc tap huong doi tuong", true, 4));
        courses.put("223", new Course("223", "co so du lieu", false, 4));
        courses.put("225", new Course("225", "co so du lieu phan tan", false, 4));
        courses.put("227", new Course("227", "lap trinh .Net", false, 4));
        courses.put("229", new Course("229", "cong nghe java", false, 4));
        courses.put("226", new Course("226", "cong nghe phan mem", false, 2));
        
        // Add more courses if needed

        ArrayList<Teacher> teachers = new ArrayList<>();
        teachers.add(new Teacher("123", "Hoang", new ArrayList<>(List.of(courses.get("111"), courses.get("223")))));
teachers.add(new Teacher("125", "Hoang", new ArrayList<>(List.of(courses.get("227"), courses.get("112"), courses.get("229")))));
teachers.add(new Teacher("125", "Hoang", new ArrayList<>(List.of(courses.get("111"), courses.get("223"), courses.get("222")))));
teachers.add(new Teacher("234", "Nam", new ArrayList<>(List.of(courses.get("112"), courses.get("222"), courses.get("225"), courses.get("226")))));
teachers.add(new Teacher("235", "Nam Uq", new ArrayList<>(List.of(courses.get("111"), courses.get("222"), courses.get("112"), courses.get("223")))));
        
        // Add more teachers if needed

        ArrayList<StudentGroup> studentGroups = new ArrayList<>();
        studentGroups.add(new StudentGroup("hs1", "111", "dhti12", 23));
        studentGroups.add(new StudentGroup("hs2", "222", "dhti12", 32));
        studentGroups.add(new StudentGroup("hs3", "223", "dhti12", 32));
        studentGroups.add(new StudentGroup("hs4", "112", "dhti12", 32));
        studentGroups.add(new StudentGroup("hs5", "223", "dhti32", 32));
        studentGroups.add(new StudentGroup("hs6", "223", "dhti32", 32));
        studentGroups.add(new StudentGroup("hs7", "225", "dhti32", 32));
        studentGroups.add(new StudentGroup("hs8", "111", "dhti32", 32));
        studentGroups.add(new StudentGroup("hs9", "223", "dhti32", 32));
        studentGroups.add(new StudentGroup("hs10", "112", "dhti32", 32));
        studentGroups.add(new StudentGroup("hs11", "111", "dhti32", 32));
        studentGroups.add(new StudentGroup("hs12", "226", "dhti32", 32));
        studentGroups.add(new StudentGroup("hs13", "222", "dhti32", 32));
        studentGroups.add(new StudentGroup("hs14", "223", "dhti32", 32));
        studentGroups.add(new StudentGroup("hs15", "111", "dhti32", 32));
        studentGroups.add(new StudentGroup("hs16", "112", "dhti32", 32));
        studentGroups.add(new StudentGroup("hs17", "227", "dhti32", 32));
        studentGroups.add(new StudentGroup("hs18", "227", "dhti32", 32));
        studentGroups.add(new StudentGroup("hs19", "227", "dhti32", 32));
        studentGroups.add(new StudentGroup("hs20", "229", "dhti32", 32));
        studentGroups.add(new StudentGroup("hs21", "229", "dhti32", 32));
        studentGroups.add(new StudentGroup("hs22", "226", "dhti32", 32));
        studentGroups.add(new StudentGroup("hs23", "226", "dhti32", 32));
        
        // Add more student groups if needed

        Data data = new Data(teachers, rooms, studentGroups, courses);

        // Generate initial population
        List<Schedule> population = new ArrayList<>();
        for (int i = 0; i < 100; i++) {
            Schedule schedule = new Schedule(data);
            schedule.initialize();
            population.add(schedule);
        }

        // Genetic algorithm loop
        while (true) {
            population.sort(Schedule::compareTo);

            if (population.get(0).getFitness()>= 1) {
                population.get(0).display();
                break;
            }

            List<Schedule> newGeneration = new ArrayList<>();
            for (int i = 0; i < 10; i++) {
                newGeneration.add(population.get(i));
            }

            Random random = new Random();
            for (int i = 0; i < 90; i++) {
                int index1 = random.nextInt(population.size());
                int index2 = random.nextInt(population.size());

                Schedule offspring = population.get(index1).mate(population.get(index2));
                newGeneration.add(offspring);
            }

            population = newGeneration;
        }
    }
    
}
