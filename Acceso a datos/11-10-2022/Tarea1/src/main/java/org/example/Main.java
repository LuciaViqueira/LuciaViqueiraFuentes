package org.example;

import javax.xml.bind.JAXBContext;
import javax.xml.bind.JAXBException;
import javax.xml.bind.Unmarshaller;
import java.io.File;
import java.util.ArrayList;

public class Main {
    public static void main(String[] args) throws JAXBException {

        boolean finalpartida = false;
        int escena = 1;
        Aventura aventura = realizarLecturaXML(".\\aventura.xml");
        System.out.println(aventura.getTitulo());



    }
    private static Aventura realizarLecturaXML (String ruta) throws JAXBException{
        File file = new File (".\\aventura.xml");
        Aventura aventura = null;
        if(file.exists()){
            JAXBContext jaxbContext = JAXBContext.newInstance(Aventura.class);
            Unmarshaller jaxbUnmarshaller = jaxbContext.createUnmarshaller();

           aventura = (Aventura) jaxbUnmarshaller.unmarshal(file);

        }else{
            System.out.println("No se ha podido encontrar el fichero indicado");
        }
        return aventura;
    }

}