package org.example;

import com.google.gson.Gson;
import com.google.gson.GsonBuilder;

import java.io.FileNotFoundException;
import java.io.FileReader;
import java.util.ArrayList;
import java.util.Arrays;

public class Main {
    public static void main(String[] args) throws FileNotFoundException {

        String ruta = ".\\Mascota.json";
        System.out.println(leerJson(ruta));
    }
    public static ArrayList<MascotaGSON> leerJson(String ruta) throws FileNotFoundException {
        Gson gson = new GsonBuilder().excludeFieldsWithoutExposeAnnotation().create();
        FileReader fr = new FileReader(ruta);
        MascotaGSON[] mascota = gson.fromJson(fr, MascotaGSON[].class);
        return new ArrayList<MascotaGSON>(Arrays.asList(mascota));
    }
    //Genera un json en un string
    public static String generarJSON(ArrayList<MascotaGSON> listaMascotas) throws FileNotFoundException{
        Gson gson = new GsonBuilder().excludeFieldsWithoutExposeAnnotation().setPrettyPrinting().create();
        String json = gson.toJson(listaMascotas);
        return json;
    }
}