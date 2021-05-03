package com.example.table;

import org.json.JSONException;
import org.json.JSONObject;

import java.io.FileWriter;
import java.io.IOException;

public class User {
    int id;
    String username;
    String password;
    String email;
    String avatar;
    String salt;
    int roles;

    public String registration() throws JSONException {
        JSONObject obj = new JSONObject();
        obj.put("email", email);
        obj.put("username", username);
        obj.put("password", password);
        obj.put("roles", roles);
        try(FileWriter file = new FileWriter("J.json")) {
            file.write(obj.toString());
            file.flush();
        } catch (IOException e) {
            e.printStackTrace();
        }
        return obj.toString();
    }

    public String login() throws JSONException {
        JSONObject obj = new JSONObject();
        obj.put("email", email);
        obj.put("password", password);
        return obj.toString();
    }


}
