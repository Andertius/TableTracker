package Connection;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;

public class PGSQLCon {
    static final String url = "jdbc:postgresql://table-tracker-db.postgres.database.azure.com:5432/postgres";
    static final  String user = "TableTrackerMaster@table-tracker-db";
    static final String password ="`T@77n^FLBZzZ$sh";
    public Connection connection = null;
    public void connect() {
        try {
             connection = DriverManager.getConnection(url, user, password);
            System.out.println("Connected to the PostgreSQL server successfully.");

        } catch (SQLException e) {
            System.out.println(e.getMessage());
        }
    }
}
