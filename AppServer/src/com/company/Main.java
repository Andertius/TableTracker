package com.company;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;

public class Main {
    static final String url = "jdbc:postgresql://table-tracker-db.postgres.database.azure.com:5432/postgres";
    static final  String user = "TableTrackerMaster@table-tracker-db";
    static final String password ="`T@77n^FLBZzZ$sh";
    static public Connection connect() {
        Connection conn = null;
        try {
            conn = DriverManager.getConnection(url, user, password);
            System.out.println("Connected to the PostgreSQL server successfully.");
            conn.prepareStatement("");
        } catch (SQLException e) {
            System.out.println(e.getMessage());
        }

        return conn;
    }
    public static void main(String[] args) {

            connect();


    }
}
