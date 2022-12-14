public class Mascota {
    private String nombre;
    private String tipo;
    private int edad;
    private String genero;


    public Mascota() {
    }

    public Mascota(String nombre, String tipo, int edad, String genero) {
        this.nombre = nombre;
        this.tipo = tipo;
        this.edad = edad;
        this.genero = genero;
    }

    /**
     *
     *
     * @return
     */

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public String getTipo() {
        return tipo;
    }

    public void setTipo(String tipo) {
        this.tipo = tipo;
    }

    public int getEdad() {
        return edad;
    }

    public void setEdad(int edad) {
        this.edad = edad;
    }

    public String getGenero() {
        return genero;
    }

    public void setGenero(String genero) {
        this.genero = genero;
    }

    @Override
    public String toString() {
        return "Mascota{" +
                "nombre='" + nombre + '\'' +
                ", tipo='" + tipo + '\'' +
                ", edad=" + edad +
                ", genero='" + genero + '\'' +
                '}';
    }

}
