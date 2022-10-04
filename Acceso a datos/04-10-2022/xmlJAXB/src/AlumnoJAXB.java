import javax.xml.bind.annotation.XmlAttribute;
import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlRootElement;
import java.util.ArrayList;

public class AlumnoJAXB {
    private String  nombre;
    private int edad;


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

    @XmlRootElement (name="listaAlumnos")

    public class Alumnos{
        private ArrayList<AlumnoJAXB> listaAlumnos;

        public void setListaAlumnos(ArrayList<AlumnoJAXB> listaAlumnos) {
            this.listaAlumnos = listaAlumnos;
        }
        @XmlElement (name= "alumno")
        public ArrayList<AlumnoJAXB> getListaAlumnos(){
            return this.listaAlumnos;
        }
    }
}
