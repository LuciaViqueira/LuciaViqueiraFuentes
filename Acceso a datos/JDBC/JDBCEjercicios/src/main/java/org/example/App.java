package org.example;

import java.sql.*;

/**
 * Hello world!
 *
 */
public class App 
{
    public static void main( String[] args ) throws SQLException {

      //  conectarBD();
       // contarJugador();
      //  llamarProcedimientos();
       // llamarProcedimientosActualizar();
       // gestionTransacciones();
        insertarJugador();
    }
    public static Connection conectarBD(){
        String connectionUrl = "jdbc:sqlserver://localhost:1433;"+
                "database=Pruebas;" +
                "user=sa;"+
                "password=Aulanosa123;"+
                "encrypt=true;"+
                "trustServerCertificate=true;"+
                "loginTimeout=30;";
        try{
            Connection connection = DriverManager.getConnection(connectionUrl);
            System.out.println("Conexion OK");
            return connection;
        }catch (SQLException e){
            System.out.println("Conexion KO");
            throw new RuntimeException(e);
        }
    }

    public static void crearTabla() throws SQLException{
        Connection c = ConexionHikari.obtenerConexion();
        Statement s = null;

        try{
            s = c.createStatement();
            String sentenciaDDL = "CREATE TABLE Jugadores("
                    + "id int IDENTITY(1,1) PRIMARY KEY,"
                    +"nombre varchar(20) NOT NULL,"
                    +"dorsal int NOT NULL)";

            s.executeUpdate(sentenciaDDL);
            System.out.println("Crear tabla OK");

        }catch (SQLException e){
            System.out.println("Crear tabla KO");
            throw new RuntimeException(e);
        }finally {
            if(s!=null) s.close();
            if(c!=null) c.close();
        }
    }
    public static void modificarTabla() throws SQLException{
        Connection c = conectarBD();
        Statement s = null;

        try{
            s = c.createStatement();
            String sentenciaDDL = "ALTER TABLE Jugadores "
                    + "ADD equipo varchar(20) NOT NULL";

            s.executeUpdate(sentenciaDDL);
            System.out.println("Añadir campo OK");

        }catch (SQLException e){
            System.out.println("Añadir campo KO");
            throw new RuntimeException(e);
        }finally {
            if(s!=null) s.close();
            if(c!=null) c.close();
        }
    }

    public static void insertarJugador() throws SQLException {
        Connection c = ConexionHikari.obtenerConexion();
        PreparedStatement s = null;

        try {
            s = c.prepareStatement("INSERT INTO Jugadores (nombre, dorsal, equipo) VALUES (?,?,?)");
            s.setString(1, "Soriano");
            s.setInt(2, 25);
            s.setString(3, "depor");
            //Para que mande los datos a la base
            s.executeUpdate();
            System.out.println("Insertado jugador Ok");

        }catch (SQLException e){
            System.out.println("Insertado jugador KO");
            throw new RuntimeException(e);
        }finally {
            if(s!=null) s.close();
            if(c!=null) c.close();
        }
    }

    public static void actualizarJugador() throws SQLException{
        Connection c = ConexionHikari.obtenerConexion();
        PreparedStatement s = null;

        try{
            s = c.prepareStatement("UPDATE  Jugadores  SET dorsal = ? WHERE nombre = ?");
            s.setInt(1, 10);
            s.setString(2, "Lucas");
            s.executeUpdate();
            System.out.println("Modificado jugador Ok");
        }catch (SQLException e){
            System.out.println("Modificado jugador KO");
            throw new RuntimeException(e);
        }finally {
            if(s!=null) s.close();
            if(c!=null) c.close();
        }
    }

    public static void buscarJugadores() throws SQLException{
        Connection c = ConexionHikari.obtenerConexion();
        PreparedStatement s = null;

        try{
            s= c.prepareStatement("SELECT * FROM Jugadores WHERE nombre = ?");
            s.setString(1,"Lucas");
            ResultSet res = s.executeQuery();
            while (res.next()){
                String impresion = "ID="
                        +res.getInt("id")
                        + ", Nombre="
                        +res.getString("nombre");
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

    public static void contarJugador() throws SQLException{
        Connection c = conectarBD();
        PreparedStatement s = null;

        try{
            s= c.prepareStatement("SELECT COUNT (nombre) as contador FROM Jugadores WHERE nombre = ?");
            s.setString(1, "Lucas");
            ResultSet res = s.executeQuery();
            while (res.next()){
                String impresion = "Numero de Lucas="
                        +res.getInt("contador");


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

    public static void llamarProcedimientos() throws SQLException{
        Connection c = conectarBD();
        CallableStatement s = null;

        try{
            s = c.prepareCall("{call obtenerJugadores(?)}");
            s.setString(1,"Lucas");
            ResultSet res  = s.executeQuery();

            while(res.next()){
                String impresion = "ID ="
                        +res.getInt("id")
                        +", Nombre="
                        +res.getString("nombre");
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

    public static void llamarProcedimientosActualizar() throws SQLException{
        Connection c = conectarBD();
        CallableStatement s = null;
        int columnas = 0;

        try{
            s = c.prepareCall("{call ficharJugadores(?,?)}");
            s.setString(1,"Lucas");
            s.setString(2,"Rapido");
           columnas=  s.executeUpdate();
            System.out.println(columnas);
        }catch (SQLException e){
            System.out.println("Consulta KO");
            throw new RuntimeException(e);
        }finally {
            if(s!=null) s.close();
            if(c!=null) c.close();
        }
    }

    public static void gestionTransacciones() throws SQLException{
        Connection c = conectarBD();
        c.setAutoCommit(true);
        PreparedStatement s = null;

        try {
            s = c.prepareStatement("INSERT INTO Jugadores "
            + "(nombre,dorsal, equipo) VALUES (?,?,?)");
            s.setString(1,"Mackay2");
            s.setInt(2,1);
            s.setString(3,"Depor");
            s.executeUpdate();
            System.out.println("Insertado jugador 1 OK");

            if(c!=null) throw new RuntimeException("ERROR");

            s.setString(1,"Quiles2");
            s.setInt(2, 9);
            s.setString(3,"Depor");
            s.executeUpdate();
            System.out.println("Insertado jugador 2 OK");

            c.commit();
        }catch (Exception e){
            c.rollback();
            System.out.println("Insertado jugador KO");
            throw new RuntimeException(e);
        }finally {
            if(s!=null) s.close();
            c.close();
        }
    }

}
