import javax.xml.bind.annotation.XmlAttribute;
import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlRootElement;
import java.util.ArrayList;

public class AlumnoJAXB {
    private String  nombre;
    private int edad;

    public AlumnoJAXB() {
    }

    public AlumnoJAXB(String nombre, int edad) {
        this.nombre = nombre;
        this.edad = edad;
    }

    public String getNombre() {
        return nombre;
    }
    @XmlElement
    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public int getEdad() {
        return edad;
    }
    @XmlElement
    public void setEdad(int edad) {
        this.edad = edad;
    }

    @Override
    public String toString() {
        return "AlumnoJAXB{" +
                "nombre='" + nombre + '\'' +
                ", edad=" + edad +
                '}';
    }
}
