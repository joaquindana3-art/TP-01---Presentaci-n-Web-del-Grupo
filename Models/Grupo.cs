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
        familiares.Add("Cintia Dorfman", "Juan Poniachik", "Micaela Poniachik");
        List<string> intereses = new List<string>();
        intereses.Add("Futbol", "Haxball", "San Lorenzo");
        Integrante integrante1 = new Integrante(50235406, "Martin Poniachik", 06/05/2010, "fotoponia.png", familiares, intereses);
        integrantes.Add(50235406, integrante1);

        List<string> familiares1 = new List<string>();
        familiares.Add("Patricia Goldstein", "Damian Grinblat", "Tomas Grinblat");
        List<string> intereses1 = new List<string>();
        intereses.Add("Padel", "HaxBall", "River Plate");
        Integrante integrante2 = new Integrante(50031293, "Alejo Grinblat", 17/12/2009, "fotoalejo.jpg", familiares1, intereses1);
        integrantes.Add(50031293, integrante2);

        List<string> familiares2 = new List<string>();
        familiares.Add("Sabrina Szlit", "Fabio Dana", "Ezequiel Dana");
        List<string> intereses2 = new List<string>();
        intereses.Add("Metal", "Boca", "Minecraft");
        Integrante integrante3 = new Integrante(50705111, "Joaquin Dana", 5/4/2010, "fotoalejo.jpg", familiares2, intereses2);
        integrantes.Add(50705111, integrante3);
        

    }
    public Dic<int, Integrante> DevolverIntegrantes()
    {
        return integrantes;
    }

    public Integrante getIntegrante(int dni) {

        return integrantes[dni];

    } 
}