import org.w3c.dom.Document;
import org.w3c.dom.Element;
import org.w3c.dom.Node;
import org.w3c.dom.NodeList;

import javax.xml.parsers.DocumentBuilder;
import javax.xml.parsers.DocumentBuilderFactory;
import java.util.ArrayList;

public class Main {
    public static void main(String[] args) {

        ArrayList <Mascota> mascotas= new ArrayList<>();

        try{
            //Creamos la instancia de DocumentBuilderFactory
            DocumentBuilderFactory fabricaCreadorDocumento = DocumentBuilderFactory.newInstance();
            //Creamos la instancia de DocumentBuilder
            DocumentBuilder creadorDocumento = fabricaCreadorDocumento.newDocumentBuilder();
            //Creamos la instacia del Document indicando la ruta en donde tenemos nuestro fichero xml
            Document documento = creadorDocumento.parse("C:\\Users\\FP\\Documents\\GitHub\\LuciaViqueiraFuentes\\Acceso a datos\\29-09-2022\\Ejercicio1.xml");
            //Esto nos sirve para obtener el elemento raiz de nuestro xml en este caso mascota
            Element raiz = documento.getDocumentElement();
            //Con esto obtenemos la lista de los que tienen la etiqueta mascota
            NodeList listaMascotas = raiz.getElementsByTagName("mascota");

            for(int i= 0; i<listaMascotas.getLength(); i++){
                Node mascota = listaMascotas.item(i);

                if(mascota.getNodeType() == Node.ELEMENT_NODE) {
                    System.out.println("mascota " + i);
                    System.out.println("=======");

                    NodeList datosMascota = mascota.getChildNodes();

                    Element elemento = (Element) mascota;
                    Node nodoNombre = elemento.getAttributeNode("Nombre");
                    String valNombre = nodoNombre.getTextContent();
                    System.out.println("Nombre = " + valNombre);

                    Element elemento2 = (Element) mascota;
                    Node nodoTipo = elemento.getElementsByTagName("tipo").item(0);
                    String valTipo = nodoTipo.getTextContent();
                    System.out.println("Tipo = " + valTipo);

                    Element elemento3 = (Element) mascota;
                    Node nodoEdad = elemento.getElementsByTagName("edad").item(0);
                    String valEdad = nodoEdad.getTextContent();
                    System.out.println("Edad = " + valEdad);

                    Element elemento4 = (Element) mascota;
                    Node nodoGenero = elemento.getElementsByTagName("genero").item(0);
                    //Con esto comprobamos que si es disitinto de null nos printe el genero que tenemos en el xml sino un null
                    String valGenero = (nodoGenero != null) ? nodoGenero.getTextContent() : null;
                    System.out.println("Genero = " + valGenero);

                    Mascota mascota1 = new Mascota();
                    mascota1.setNombre(valNombre);
                    mascota1.setTipo(valTipo);

                    if(valEdad!=null){
                        mascota1.setEdad(Integer.parseInt(valEdad));
                    }
                    mascota1.setGenero(valGenero);


                }

            }

        }catch (Exception ex){
            ex.printStackTrace();
        }
    }
}