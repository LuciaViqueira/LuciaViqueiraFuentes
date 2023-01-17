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
    public static void main( String[] args ) throws JAXBException, SQLException {

         Location l = leerXML(".\\es.xml");
       //  insertarBDUnoaUno(l);
        insertarLote(l);
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
        Connection c = ConexionHikari.obtenerConexion();
        PreparedStatement s = null;
        long inicio = System.currentTimeMillis();
        try {
            s = c.prepareStatement("INSERT INTO Ciudades (codigo, nombre) VALUES (?,?)");

            for (CountryRegion contry: location.getCountryRegion()) {
                if (contry.getState() != null) {
                    for (State state: contry.getState()) {
                        if(state.getCity()!=null){
                            for (City city: state.getCity()) {
                                s.setString(1, city.getCode());
                                s.setString(2, city.getName());
                                s.executeUpdate();
                            }
                        }

                    }
                }
                }

            System.out.println("Insertado ciudad Ok");
            long tiempo = System.currentTimeMillis() - inicio ;
            System.out.println(tiempo);
        }catch (SQLException e){
            System.out.println("Insertado ciudad KO");
            throw new RuntimeException(e);
        }finally {
            if(s!=null) s.close();
            if(c!=null) c.close();
        }


    }
    public static void insertarLote(Location location) throws SQLException {
        Connection c = ConexionHikari.obtenerConexion();
        PreparedStatement s = null;
        long inicio = System.currentTimeMillis();
        try {
            s = c.prepareStatement("INSERT INTO Ciudades (codigo, nombre) VALUES (?,?)");

            for (CountryRegion contry: location.getCountryRegion()) {
                if (contry.getState() != null) {
                    for (State state: contry.getState()) {
                        if(state.getCity()!=null){
                            for (City city: state.getCity()) {
                                s.setString(1, city.getCode());
                                s.setString(2, city.getName());
                                s.addBatch();
                            }
                        }

                    }
                }
            }
            s.executeBatch();
            System.out.println("Insertado lote Ok");
            long tiempo = System.currentTimeMillis() - inicio ;
            System.out.println(tiempo);
        }catch (SQLException e){
            System.out.println("Insertado lote KO");
            throw new RuntimeException(e);
        }finally {
            if(s!=null) s.close();
            if(c!=null) c.close();
        }

    }
}
