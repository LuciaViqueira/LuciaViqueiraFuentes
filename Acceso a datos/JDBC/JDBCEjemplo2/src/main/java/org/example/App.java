package org.example;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;

/**
 * Hello world!
 *
 */
public class App 
{
    public static void main( String[] args ) throws SQLException{
       // insertarEquipo();
        //actualizarEquipo();
        //borradoEquipo();
       // consultarEquipos();
       // consultarEquipoTitulos();
        //consultarUruguay();
        consultarPartidosViernes();
    }

    public static void insertarEquipo() throws SQLException {
        Connection c = ConexionHikari.obtenerConexion();
        PreparedStatement s = null;

        try {
            s = c.prepareStatement("INSERT INTO Equipos (nombre, pais, titulos, diasPartido) VALUES (?,?,?,?)");
            s.setString(1, "Benfica");
            s.setString(2, "Portugal");
            s.setInt(3, 87);
            s.setString(4, "SD");
            //Para que mande los datos a la base
            s.executeUpdate();
            System.out.println("Insertado equipo Ok");

        }catch (SQLException e){
            System.out.println("Insertado equipo KO");
            throw new RuntimeException(e);
        }finally {
            if(s!=null) s.close();
            if(c!=null) c.close();
        }
    }

    public static void borradoEquipo() throws SQLException {
        Connection c = ConexionHikari.obtenerConexion();
        PreparedStatement s = null;

        try {
            s = c.prepareStatement("DELETE FROM Equipos WHERE id = ?");
            s.setInt(1, 3);

            //Para que mande los datos a la base
            s.executeUpdate();
            System.out.println("Borrar equipo Ok");

        }catch (SQLException e){
            System.out.println("Borrar equipo KO");
            throw new RuntimeException(e);
        }finally {
            if(s!=null) s.close();
            if(c!=null) c.close();
        }


    }

    public static void actualizarEquipo() throws SQLException {
        Connection c = ConexionHikari.obtenerConexion();
        PreparedStatement s = null;

        try{
            s = c.prepareStatement("UPDATE  Equipos  SET nombre = ? WHERE id = ?");
            s.setString(1, "Nacional");
            s.setInt(2, 1);
            s.executeUpdate();
            System.out.println("Modificado equipo Ok");
        }catch (SQLException e){
            System.out.println("Modificado equipo KO");
            throw new RuntimeException(e);
        }finally {
            if(s!=null) s.close();
            if(c!=null) c.close();
        }
    }

    public static void consultarEquipos() throws SQLException {
        Connection c = ConexionHikari.obtenerConexion();
        PreparedStatement s = null;

        try{
            s= c.prepareStatement("SELECT * FROM Equipos");

            ResultSet res = s.executeQuery();
            while (res.next()){
                String impresion = "ID="
                        +res.getInt("id")
                        + ", Nombre="
                        +res.getString("nombre")
                        + ", Pais="
                        + res.getString("pais")
                        +", Titulos="
                        +res.getInt("titulos")
                        +", Dias Partidos="
                        +res.getString("diasPartido");

                System.out.println(impresion);
            }
        }catch (SQLException e){
            System.out.println("Consulta KO");
            throw new RuntimeException(e);
        }finally {
            if(s!=null) s.close();
            if(c!=null) c.close();
        }
    }

    public static void consultarEquipoTitulos() throws SQLException {
        Connection c = ConexionHikari.obtenerConexion();
        PreparedStatement s = null;

        try{
            s = c.prepareStatement("SELECT TOP 1 * FROM Equipos ORDER BY titulos DESC");
            ResultSet res = s.executeQuery();
            while (res.next()){
                String impresion = "ID="
                        +res.getInt("id")
                        + ", Nombre="
                        +res.getString("nombre")
                        + ", Pais="
                        + res.getString("pais")
                        +", Titulos="
                        +res.getInt("titulos")
                        +", Dias Partidos="
                        +res.getString("diasPartido");

                System.out.println(impresion);
            }
        }catch (SQLException e){
            System.out.println("Modificado equipo KO");
            throw new RuntimeException(e);
        }finally {
            if(s!=null) s.close();
            if(c!=null) c.close();
        }
    }
    public static void consultarUruguay() throws SQLException {
        Connection c = ConexionHikari.obtenerConexion();
        PreparedStatement s = null;

        try{
            s = c.prepareStatement("SELECT  * FROM Equipos WHERE pais= 'Uruguay'");
            ResultSet res = s.executeQuery();
            while (res.next()){
                String impresion = "ID="
                        +res.getInt("id")
                        + ", Nombre="
                        +res.getString("nombre")
                        + ", Pais="
                        + res.getString("pais")
                        +", Titulos="
                        +res.getInt("titulos")
                        +", Dias Partidos="
                        +res.getString("diasPartido");

                System.out.println(impresion);
            }
        }catch (SQLException e){
            System.out.println("Modificado equipo KO");
            throw new RuntimeException(e);
        }finally {
            if(s!=null) s.close();
            if(c!=null) c.close();
        }
    }
    public static void consultarPartidosViernes() throws SQLException {
        Connection c = ConexionHikari.obtenerConexion();
        PreparedStatement s = null;

        try{
            s = c.prepareStatement("SELECT  * FROM Equipos WHERE diasPartido LIKE 'V%'");
            ResultSet res = s.executeQuery();
            while (res.next()){
                String impresion = "ID="
                        +res.getInt("id")
                        + ", Nombre="
                        +res.getString("nombre")
                        + ", Pais="
                        + res.getString("pais")
                        +", Titulos="
                        +res.getInt("titulos")
                        +", Dias Partidos="
                        +res.getString("diasPartido");

                System.out.println(impresion);
            }
        }catch (SQLException e){
            System.out.println("Modificado equipo KO");
            throw new RuntimeException(e);
        }finally {
            if(s!=null) s.close();
            if(c!=null) c.close();
        }
    }


}
