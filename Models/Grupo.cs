namespace TP01_Dana_Grinblat_Poniachik.Models;

public class Grupo
{
    private Dictionary<int,Integrante> integrantes = new Dictionary<int,Integrante>();

    public Grupo()
    {
        
        CargaDatosManual();

    }
    public void CargaDatosManual()
    {

        List<string> familiares = new List<string>();
        familiares.Add("Cintia Dorfman");
        familiares.Add("Juan Poniachik");
        familiares.Add("Micaela Poniachik");
        List<string> intereses = new List<string>();
        intereses.Add("Futbol");
        intereses.Add("Haxball");
        intereses.Add("San Lorenzo");
        DateTime date = new DateTime(2010, 05, 06);
        Integrante integrante1 = new Integrante(50235406, "Martin Poniachik", date, "fotoponia.png", familiares, intereses);
        integrantes.Add(50235406, integrante1);

        List<string> familiares1 = new List<string>();
        familiares.Add("Patricia Goldstein");
        familiares.Add("Damian Grinblat");
        familiares.Add("Tomas Grinblat");
        List<string> intereses1 = new List<string>();
        intereses.Add("HaxBall");
        intereses.Add("Padel");
        intereses.Add("River Plate");
        DateTime date1 = new DateTime(2009, 12, 17);
        Integrante integrante2 = new Integrante(50031293, "Alejo Grinblat", date1, "fotoalejo.jpg", familiares1, intereses1);
        integrantes.Add(50031293, integrante2);

        List<string> familiares2 = new List<string>();
        familiares.Add("Sabrina Szlit");
        familiares.Add("Fabio Dana");
        familiares.Add("Ezequiel Dana");
        List<string> intereses2 = new List<string>();
        intereses.Add("Metal");
        intereses.Add("Boca");
        intereses.Add("Minecraft");
        DateTime date2 = new DateTime(2010, 04, 05);
        Integrante integrante3 = new Integrante(50705111, "Joaquin Dana", date2, "fotodana.jpg", familiares2, intereses2);
        integrantes.Add(50705111, integrante3);
        

    }
    public Dictionary<int, Integrante> DevolverIntegrantes()
    {
        return integrantes;
    }

    public Integrante getIntegrante(int dni) {

        return integrantes[dni];

    } 
}