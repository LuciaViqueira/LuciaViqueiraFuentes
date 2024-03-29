package org.example;

import javax.persistence.*;
import java.io.Serializable;
import java.util.ArrayList;

@Entity
@Table(name = "Tvshow")
public class Tvshow implements Serializable {
    private int id;

    private String nameTv;

    private int idCharacter;

    private Character character;


    public Tvshow() {
    }


    public Tvshow(String nameTv, int idCharacter) {
        this.nameTv = nameTv;
        this.idCharacter = idCharacter;
    }

    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    @Column(name = "nameTVShow")
    public String getNameTv() {
        return nameTv;
    }

    public void setNameTv(String nameTv) {
        this.nameTv = nameTv;
    }

    @Column (name = "idCharacter")
    public int getIdCharacter() {
        return idCharacter;
    }

    public void setIdCharacter(int idCharacter) {
        this.idCharacter = idCharacter;
    }

    @ManyToOne()
    @JoinColumn(name = "idCharacter", insertable = false, updatable = false)
    public Character getCharacter(){
        return character;
    }
    public void setCharacter(Character character){
        this.character = character;
    }

    @Override
    public String toString() {
        return "Tvshow{" +
                "id=" + id +
                ", nameTv='" + nameTv + '\'' +
                ", idCharacter=" + idCharacter +
                ", character=" + character +
                '}';
    }
}
