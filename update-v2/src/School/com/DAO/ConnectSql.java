/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package School.com.DAO;

import com.microsoft.sqlserver.jdbc.SQLServerDataSource;
import java.sql.*;

/**
 *
 * @author DO BINH
 */
public class ConnectSql {
    protected Connection conn =null;
    
    public ConnectSql()
    {
        try {
            // / Tải trình điều khiển JDBC của SQL Server             
            Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver");
            
            /// Xác định URL kết nối
            String connectionUrl = "jdbc:sqlserver://localhost:1433;databaseName=ScheduleManagement";
            
            //  Thiết lập kết nối
            conn = DriverManager.getConnection(connectionUrl, "sa", "123");
            
            // Nếu kết nối thành công, in thông báo
            if (conn != null) {
                System.out.println("Connection established successfully!");
            }
        } catch (Exception e) {
            // In bất kỳ ngoại lệ nào xảy ra
            e.printStackTrace();
        } finally {
             // Đóng kết nối nếu nó được thiết lập
            if (conn != null) {
                try {
                    conn.close();
                } catch (Exception e) {
                    e.printStackTrace();
                }
            }
        }
    }
   
}
