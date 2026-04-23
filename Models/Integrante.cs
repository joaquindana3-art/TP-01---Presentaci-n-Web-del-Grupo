namespace TP01_Dana_Grinblat_Poniachik.Models;

public class Integrante
{
    private int DNI;
    private string nombre;
    private DateTime fechaDeNacimiento;
    private string foto;
    private List<string> familiares = new List<string>();
    private List<string> intereses = new List<string>();

    public Integrante(int DNI, string nombre, DateTime fechaDeNacimiento, string foto, List<string> familiares, List<string> intereses)
    {
        this.DNI = DNI;
        this.nombre = nombre;
        this.fechaDeNacimiento = fechaDeNacimiento;
        this.foto = foto;
        this.familiares = familiares;
        this.intereses = intereses;
    }

    public string getNombre() {

        return nombre;

    }

    public int getDNI() {

        return this.DNI;

    }

    public string mostrarInfo() {

        string msg = "";
        msg += "DNI: " + DNI;
        msg += "\n Nombre: " + nombre;
        msg += "\n Fecha de nacimiento: " + fechaDeNacimiento.Day + "/" + fechaDeNacimiento.Month + "/" + fechaDeNacimiento.Year;
        msg += "\n Familiares: ";
        for (int i = 0; i < familiares.Count; i++) {

            msg += familiares[i];

        }
        msg += "\n Intereses: ";
        for (int i = 0; i < intereses.Count; i++) {

            msg += intereses[i];

        }
        return msg;

    }

    public string getFoto() {

        return foto;

    }

}
