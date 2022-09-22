import java.io.RandomAccessFile;

public class Alumnos {
    //Atributos
    String nombre = "";
    int edad;
    double media;

    //Constructores
    public Alumnos() {

    }

    public Alumnos(String nombre, int edad, double media) {
        this.nombre = nombre;
        this.edad = edad;
        this.media = media;
    }

    //Getters y Setters
    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public int getEdad() {
        return edad;
    }

    public void setEdad(int edad) {
        this.edad = edad;
    }

    public double getMedia() {
        return media;
    }

    public void setMedia(double media) {
        this.media = media;
    }
}
