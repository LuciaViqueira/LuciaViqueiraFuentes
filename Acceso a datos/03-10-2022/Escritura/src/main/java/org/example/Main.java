package org.example;

import org.w3c.dom.Document;
import org.w3c.dom.Element;

import javax.xml.parsers.DocumentBuilder;
import javax.xml.parsers.DocumentBuilderFactory;
import javax.xml.transform.OutputKeys;
import javax.xml.transform.Transformer;
import javax.xml.transform.TransformerFactory;
import javax.xml.transform.dom.DOMSource;
import javax.xml.transform.stream.StreamResult;
import java.io.File;

public class Main {
    public static void main(String[] args) {

        try {
            //Creamos la instancia de DocumentBuilderFactory
            DocumentBuilderFactory fabricaCreadorDocumento = DocumentBuilderFactory.newInstance();
            //Creamos la instancia de DocumentBuilder
            DocumentBuilder creadorDocumento = fabricaCreadorDocumento.newDocumentBuilder();
            //Creamos la instacia del Document indicando la ruta en donde tenemos nuestro fichero xml
            Document documento = creadorDocumento.parse("C:\\Users\\FP\\Documents\\GitHub\\LuciaViqueiraFuentes\\Acceso a datos\\03-10-2022\\Ejercicio1.xml");

            Element raiz = documento.getDocumentElement();
            System.out.println(raiz.getTagName());

            Element mascota = documento.createElement("mascota");
            raiz.appendChild(mascota);

            mascota.setAttribute("Nombre", "Toby");


            Element animalTipo = documento.createElement("tipo");
            animalTipo.appendChild(documento.createTextNode("Perro"));
            mascota.appendChild(animalTipo);

            Element animalEdad = documento.createElement("edad");
            animalEdad.appendChild(documento.createTextNode("2"));
            mascota.appendChild(animalEdad);

            Element animalGenero = documento.createElement("genero");
            animalGenero.appendChild(documento.createTextNode("Macho"));
            mascota.appendChild(animalGenero);

            TransformerFactory transformerFactory = TransformerFactory.newInstance();
            Transformer transformer = transformerFactory.newTransformer();
            transformer.setOutputProperty(OutputKeys.INDENT, "yes");
            transformer.setOutputProperty("{http://xml.apache.org/xslt}indent-amount", "3");
            DOMSource domSource = new DOMSource(documento);
            StreamResult resultado = new StreamResult(new File("C:\\Users\\FP\\Documents\\GitHub\\LuciaViqueiraFuentes\\Acceso a datos\\03-10-2022\\Ejercicio2.xml"));
            transformer.transform(domSource,resultado);


        }catch (Exception ex){
            ex.printStackTrace();
        }

    }
}