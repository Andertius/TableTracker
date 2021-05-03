package com.example.table;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;

import org.json.JSONException;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        User u = new User();
        u.username = "Petro";
        u.email = "Poshta";
        u.password = "555";
        u.roles = 47;
        try {
            u.registration();
        } catch (JSONException e) {
            e.printStackTrace();
        }
    }
}