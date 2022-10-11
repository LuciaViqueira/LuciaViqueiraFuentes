package org.example;

import javax.xml.bind.annotation.XmlAttribute;

public class Opcion {

    //Variables
    private int id;
    private String texto;
    private int resultado;

    //Constructores
    public Opcion() {
    }

    public Opcion(int id, String texto, int resultado) {
        this.id = id;
        this.texto = texto;
        this.resultado = resultado;
    }

    //Getters y Setters
    public int getId() {
        return id;
    }
    @XmlAttribute (name="id")
    public void setId(int id) {
        this.id = id;
    }

    public String getTexto() {
        return texto;
    }
    @XmlAttribute (name = "texto")
    public void setTexto(String texto) {
        this.texto = texto;
    }

    public int getResultado() {
        return resultado;
    }
    @XmlAttribute (name="resultado")
    public void setResultado(int resultado) {
        this.resultado = resultado;
    }

    //To String
    @Override
    public String toString() {
        return "Opcion{" +
                "id=" + id +
                ", texto='" + texto + '\'' +
                ", resultado=" + resultado +
                '}';
    }
}
