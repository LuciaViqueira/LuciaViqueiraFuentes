package org.example;

import javax.persistence.*;
import java.io.Serializable;
import java.util.ArrayList;
import java.util.Set;

@Entity
@Table(name = "Character")
public class Character implements Serializable {

    private int id;
    private int idAPI;
    private String name;




    public Character() {
    }




    public Character(int idAPI, String name) {
        this.idAPI = idAPI;
        this.name = name;
    }

    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    @Column(name = "name")
    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    @Column(name = "idAPI")
    public int getIdAPI() {
        return idAPI;
    }

    public void setIdAPI(int idAPI) {
        this.idAPI = idAPI;
    }



    @Override
    public String toString() {
        return "Character{" +
                "id=" + id +
                ", idAPI=" + idAPI +
                ", name='" + name + '\'' +
                '}';
    }
}
