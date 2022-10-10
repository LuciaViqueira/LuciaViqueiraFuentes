package org.example;

import com.google.gson.Gson;
import com.google.gson.GsonBuilder;

import java.io.FileNotFoundException;
import java.io.FileReader;
import java.util.ArrayList;
import java.util.Arrays;

public class Main {
    public static void main(String[] args) throws FileNotFoundException {

        String ruta = ".\\Json.json";
        System.out.println(leerJson(ruta));

    }
    public static ArrayList<AlumnoGSON> leerJson(String ruta) throws FileNotFoundException{
        Gson gson = new GsonBuilder().excludeFieldsWithoutExposeAnnotation().create();
        FileReader fr = new FileReader(ruta);
        AlumnoGSON[] alumnos = gson.fromJson(fr, AlumnoGSON[].class);
        return new ArrayList<AlumnoGSON>(Arrays.asList(alumnos));
    }
    //Genera un json en un string
    public static String generarJSON(ArrayList<AlumnoGSON> listaAlumnos) throws FileNotFoundException{
        Gson gson = new GsonBuilder().excludeFieldsWithoutExposeAnnotation().setPrettyPrinting().create();
        String json = gson.toJson(listaAlumnos);
        return json;
    }

}