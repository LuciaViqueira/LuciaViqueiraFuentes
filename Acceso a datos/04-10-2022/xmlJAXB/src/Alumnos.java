import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlRootElement;
import java.util.ArrayList;

@XmlRootElement(name="listaAlumnos")

public class Alumnos{
    private ArrayList<AlumnoJAXB> listaAlumnos;

    public void setListaAlumnos(ArrayList<AlumnoJAXB> listaAlumnos) {
        this.listaAlumnos = listaAlumnos;
    }
    @XmlElement(name= "alumno")
    public ArrayList<AlumnoJAXB> getListaAlumnos(){
        return this.listaAlumnos;
    }
}
