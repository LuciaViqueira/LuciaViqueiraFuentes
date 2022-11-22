package org.example;

import javax.xml.bind.JAXBContext;
import javax.xml.bind.JAXBException;
import javax.xml.bind.Unmarshaller;
import java.io.File;
import java.util.Scanner;

public class Main {
    static Scanner teclado = new Scanner(System.in);
    public static void main(String[] args) throws JAXBException {

        boolean finalPartida = false;
        int escena = 0;
        Aventura aventura = realizarLecturaXML(".\\aventura.xml");
        //System.out.println(aventura);
        System.out.println(aventura.getTitulo());
        while(finalPartida== false){
            escena = leerAventura(aventura,finalPartida, escena);
        }
        System.out.println("Fin de la aventura");
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

    private static int leerAventura(Aventura aventura, boolean finalPartida, int escena) {
        int escogerEscena = 0;
        //En esta linea nos muestra la escena
        System.out.println(aventura.getEscenas().get(escena).getTexto());

            do {

                  for (int i = 0; i < aventura.getEscenas().get(escena).getOpciones().size(); i++) {
                        //Nos muestra las opciones para cada escena
                        System.out.println((i+1) + " " +aventura.getEscenas().get(escena).getOpciones().get(i).getTexto());

                    }

                if(aventura.getEscenas().get(escena).getOpciones()==null){
                    finalPartida = true;
                }

                escogerEscena = teclado.nextInt();

                //en esta linea actualizamos escena para que nos vaya a la siguiente
                escena = aventura.getEscenas().get(escena).getOpciones().get(escogerEscena - 1).getResultado();

            }while(finalPartida==true|| aventura.getEscenas().get(escena).getOpciones()==null);


        return escena;
    }

}