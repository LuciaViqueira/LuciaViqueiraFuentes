package org.example;

import javax.xml.bind.JAXBContext;
import javax.xml.bind.JAXBException;
import javax.xml.bind.Unmarshaller;
import java.io.File;
import java.util.Scanner;

public class Main {
    static Scanner teclado = new Scanner(System.in);
    public static void main(String[] args) throws JAXBException {

        boolean finalpartida = false;
        int escena = 0;
        int escoger = 0;
        Aventura aventura = realizarLecturaXML(".\\aventura.xml");
        //System.out.println(aventura);
        System.out.println(aventura.getTitulo());
        while(!finalpartida){
            escena = leerAventura(aventura, escena, finalpartida, escoger);
        }

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

    private static int leerAventura(Aventura aventura, int escena, boolean finalPartida, int escoger) {


        System.out.println(aventura.getEscenas().get(escena).getTexto());
        do {
            for (int i = 0; i < aventura.getEscenas().get(escena).getOpciones().size(); i++) {
                System.out.println((i + 1) + aventura.getEscenas().get(escena).getOpciones().get(i).getTexto());

            }
        }while (finalPartida != false) ;
            escoger = teclado.nextInt();

            escena = aventura.getEscenas().get(escena).getOpciones().get(escoger - 1).getResultado();


        return escena;

    }


}