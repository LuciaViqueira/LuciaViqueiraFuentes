package org.example;

import javax.xml.bind.JAXBContext;
import javax.xml.bind.JAXBException;
import javax.xml.bind.Unmarshaller;
import java.io.File;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.SQLException;

/**
 * Hello world!
 *
 */
public class App 
{
    public static void main( String[] args ) throws JAXBException {

         Location l = leerXML(".\\es.xml");
    }
    private  static Location leerXML(String ruta) throws JAXBException {

        File file = new File (".\\es.xml");
        Location location = null;

        if(file.exists()){
            JAXBContext jaxbContext = JAXBContext.newInstance(Location.class);
            Unmarshaller jaxbUnmarshaller = jaxbContext.createUnmarshaller();
            location = (Location) jaxbUnmarshaller.unmarshal(file);

        }else{
            System.out.println("No se ha podido encontrar el fichero indicado");
        }
        for (int i = 0; i<location.getCountryRegion().size(); i++){
            System.out.println(location.getCountryRegion().get(i));
        }
        return location;
    }

    public static void insertarBDUnoaUno(Location location) throws SQLException {
        //Recorrer con while o for

        //Insertamos Ciudad
        Connection c = ConexionHikari.obtenerConexion();
        PreparedStatement s = null;

        try {
            s = c.prepareStatement("INSERT INTO Ciudades (codigo, nombre) VALUES (?,?)");

            //Para que mande los datos a la base
            s.executeUpdate();
            System.out.println("Insertado ciudad Ok");

        }catch (SQLException e){
            System.out.println("Insertado ciudad KO");
            throw new RuntimeException(e);
        }finally {
            if(s!=null) s.close();
            if(c!=null) c.close();
        }


    }
    public static void insertarLote(Location location){

    }
}
