import org.w3c.dom.Document;
import org.w3c.dom.Element;
import org.w3c.dom.Node;
import org.w3c.dom.NodeList;

import javax.xml.parsers.DocumentBuilder;
import javax.xml.parsers.DocumentBuilderFactory;

public class Main {
    public static void main(String[] args) {

        try{
            //Creamos la instancia de DocumentBuilderFactory
            DocumentBuilderFactory fabricaCreadorDocumento = DocumentBuilderFactory.newInstance();
            //Creamos la instancia de DocumentBuilder
            DocumentBuilder creadorDocumento = fabricaCreadorDocumento.newDocumentBuilder();
            //Creamos la instacia del Document indicando la ruta en donde tenemos nuestro fichero xml
            Document documento = creadorDocumento.parse("C:\\Users\\FP\\Documents\\GitHub\\LuciaViqueiraFuentes\\Acceso a datos\\27-09-2022\\Ejercicio1.xml");
            //Esto nos sirve para obtener el elemento raiz de nuestro xml en este caso animal
            Element raiz = documento.getDocumentElement();
            //Con esto obtenemos la lista de los que tienen la etiqueta animal
            NodeList listaSelva = raiz.getElementsByTagName("animal");

            //REcorremos animal
            for(int i=0; i < listaSelva.getLength(); i++){
                //Con esto optenemos los datos de un animal
                Node animal = listaSelva.item(i);

                //Imprimimos el primer animal con la posicion 0
                System.out.println("animal" + i);
                System.out.println("========");

                //Obtenemos la lista que tiene cada animal en este caso es nombre, tipo, color y edad
                NodeList datosAnimal = animal.getChildNodes();

                //Haciendo todo esto conseguimos un dato que queramos de animal en mi caso nombre
                Element elemento = (Element) animal;
                Node nodoNombre = elemento.getElementsByTagName("nombre").item(0);
                String valNombre = nodoNombre.getTextContent();
                System.out.println("Nombre = " +valNombre);

                //Aqui volvemos a recorrer la lista de todos los datos de animal
                for (int x=0; x< datosAnimal.getLength(); x++){
                    //Sacamos los datos de animal uno a uno, el nombre,tipo, color y edad
                    Node dato = datosAnimal.item(x);

                    //Aqui comprobamos que el dato es tipo Element
                    if (dato.getNodeType()==Node.ELEMENT_NODE){
                        //Imprimimos el nombre del dato que en este caso es nombre, tipo, color y edad
                        System.out.println(dato.getNodeName()+ ": ");

                        //Es el texto que hay dentro del elemento ejemplo Nombre: Werthers
                        Node datoContenido = dato.getFirstChild();
                        if(datoContenido!=null && datoContenido.getNodeType()==Node.TEXT_NODE){
                            System.out.println(datoContenido.getNodeValue());
                        }
                    }
                    //HAcemos un salto de linea para dejar separacion entre nombre, tipo, color y edad
                    System.out.println();
                }
            }
        }catch(Exception ex){
            ex.printStackTrace();
        }
    }
}