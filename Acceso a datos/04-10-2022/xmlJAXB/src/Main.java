import javax.xml.bind.JAXBContext;
import javax.xml.bind.JAXBException;
import javax.xml.bind.Marshaller;
import javax.xml.bind.Unmarshaller;
import java.io.File;
import java.io.IOException;
import java.util.ArrayList;

public class Main {
    public static void main(String[] args) throws JAXBException, IOException {

        System.out.println(realizarLecturaXML("C:\\Users\\FP\\Documents\\GitHub\\LuciaViqueiraFuentes\\Acceso a datos\\04-10-2022\\SAX.xml"));
        ArrayList<AlumnoJAXB> lista = realizarLecturaXML("C:\\Users\\FP\\Documents\\GitHub\\LuciaViqueiraFuentes\\Acceso a datos\\04-10-2022\\SAX.xml");

        lista.add (new AlumnoJAXB("lucia", 22));
        realizarGuardadoXML(lista, "C:\\Users\\FP\\Documents\\GitHub\\LuciaViqueiraFuentes\\Acceso a datos\\04-10-2022\\SAX2.xml");
    }
    private static ArrayList<AlumnoJAXB> realizarLecturaXML(String ruta) throws JAXBException {
        File file = new File(ruta);
        ArrayList<AlumnoJAXB> alumnos = new ArrayList<AlumnoJAXB>();

        if(file.exists()) {

            JAXBContext jaxbContext = JAXBContext.newInstance(Alumnos.class);
            Unmarshaller jaxbUnmarshaller = jaxbContext.createUnmarshaller();

            Alumnos listaAlumnos = (Alumnos) jaxbUnmarshaller.unmarshal(file);
            alumnos = (listaAlumnos != null ? listaAlumnos.getListaAlumnos() : new ArrayList<AlumnoJAXB>());

        }else{
            System.out.println("No se ha podido encontrar el fichero");
        }
        return alumnos;
    }

    private static void realizarGuardadoXML (ArrayList<AlumnoJAXB> alumnos, String ruta) throws JAXBException, IOException{
        File file = new File(ruta);

        if(!file.exists()){
            file.createNewFile();
        }
        JAXBContext jaxbContext = JAXBContext.newInstance(Alumnos.class);
        Marshaller jaxbMarshaller = jaxbContext.createMarshaller();

        jaxbMarshaller.setProperty(Marshaller.JAXB_FORMATTED_OUTPUT, true);

        Alumnos al = new Alumnos();
        al.setListaAlumnos(alumnos);
        jaxbMarshaller.marshal(al, file);
    }
}