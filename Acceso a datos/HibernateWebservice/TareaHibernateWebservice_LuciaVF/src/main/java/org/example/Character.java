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

    private Set<Tvshow> tvshows;



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

    @OneToMany (mappedBy = "character")
    public Set<Tvshow> getTvshows() {
        return tvshows;
    }

    public void setTvshows(Set<Tvshow> tvshows) {
        this.tvshows = tvshows;
    }

    @Override
    public String toString() {
        return "Character{" +
                "id=" + id +
                ", idAPI=" + idAPI +
                ", name='" + name + '\'' +
                ", tvshows=" + tvshows +
                '}';
    }
}
