package com.example.table;

import android.os.Build;


import java.util.ArrayList;
import java.util.Collection;
import java.util.Collections;
import java.util.Comparator;
import java.util.List;

public class Places{
    List<Place> places;

    public Places(String json){

    }

    public void sortByPrice(){
        places.sort((p1, p2) -> Integer.compare((p1, p2)));
    }
}
