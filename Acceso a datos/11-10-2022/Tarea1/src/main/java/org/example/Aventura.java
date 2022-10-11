package org.example;

import javax.xml.bind.annotation.XmlAttribute;
import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlRootElement;
import java.util.ArrayList;

@XmlRootElement (name="aventura")
public class Aventura {

    //Variables
    private String titulo;
    private ArrayList<Escena> escenas = new ArrayList<>();

    //Constructores
    public Aventura() {
    }

    public Aventura(String titulo, ArrayList<Escena> escenas) {
        this.titulo = titulo;
        this.escenas = escenas;
    }

    //Getters y Setters
    public String getTitulo() {
        return titulo;
    }
    @XmlAttribute(name="titulo")
    public void setTitulo(String titulo) {
        this.titulo = titulo;
    }

    public ArrayList<Escena> getEscenas() {
        return escenas;
    }
    @XmlElement (name="escena")
    public void setEscenas(ArrayList<Escena> escenas) {
        this.escenas = escenas;
    }

    //To String
    @Override
    public String toString() {
        return "Aventura{" +
                "titulo='" + titulo + '\'' +
                ", escenas=" + escenas +
                '}';
    }
}
