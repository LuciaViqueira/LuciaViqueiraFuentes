import org.xml.sax.InputSource;
import org.xml.sax.XMLReader;
import org.xml.sax.helpers.XMLReaderFactory;

import java.util.ArrayList;

public class Main {
    public static void main(String[] args) {
        try{
            XMLReader lector =  XMLReaderFactory.createXMLReader();
            ParseadorMascotasSAX parser = new ParseadorMascotasSAX();
            lector.setContentHandler(parser);
            InputSource fichero = new InputSource("C:\\Users\\FP\\Documents\\GitHub\\LuciaViqueiraFuentes\\Acceso a datos\\03-10-2022\\Ejercicio2.xml");
            lector.parse(fichero);
            ArrayList<Mascota> lista = parser.obtenerResultado();
            System.out.println(lista);

        }catch (Exception ex){
            System.out.println("Excepcion en el procesamiento del XLM");
            ex.printStackTrace();
        }

    }
}