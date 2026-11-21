
using UnityEngine;
using UnityEngine.SceneManagement;

public class NavegacionEscenas : MonoBehaviour
{
    [Header("PANELES DEL MENU PRINCIPAL")]
    public GameObject panelBienvenida;
    public GameObject panelSeleccionZona;

    // Permite volver directamente a elegir Norte o Sur
    private static bool regresarASeleccion = false;

    void Start()
    {
        // Los paneles solo se configuran en la escena principal.
        if (SceneManager.GetActiveScene().name
            != "AR_Campus_FI_Main")
        {
            return;
        }

        if (regresarASeleccion)
        {
            MostrarSeleccionZona();
            regresarASeleccion = false;
        }
        else
        {
            MostrarBienvenida();
        }
    }

    // PANTALLA DE BIENVENIDA

    public void MostrarBienvenida()
    {
        if (panelBienvenida != null)
            panelBienvenida.SetActive(true);

        if (panelSeleccionZona != null)
            panelSeleccionZona.SetActive(false);
    }

    // BOTON COMENZAR RECORRIDO

    public void ComenzarRecorrido()
    {
        MostrarSeleccionZona();
    }

    public void MostrarSeleccionZona()
    {
        if (panelBienvenida != null)
            panelBienvenida.SetActive(false);

        if (panelSeleccionZona != null)
            panelSeleccionZona.SetActive(true);
    }

    // ESCANEAR CONJUNTO NORTE

    public void AbrirEscanerNorte()
    {
        SceneManager.LoadScene("AR_Escanear_Norte");
    }

    // ESCANEAR CONJUNTO SUR

    public void AbrirEscanerSur()
    {
        SceneManager.LoadScene("AR_Escanear_Sur");
    }

    // REGRESAR A SELECCIONAR CONJUNTO

    public void VolverAConjuntos()
    {
        regresarASeleccion = true;
        SceneManager.LoadScene("AR_Campus_FI_Main");
    }

    // Compatibilidad con el nombre anterior
    public void VoloverAConjuntos()
    {
        VolverAConjuntos();
    }

    // REGRESAR AL MENU DE BIENVENIDA

    public void VolverAlMenu()
    {
        regresarASeleccion = false;
        SceneManager.LoadScene("AR_Campus_FI_Main");
    }

    // FINALIZAR RECORRIDO

    public void FinalizarRecorrido()
    {
        regresarASeleccion = false;
        SceneManager.LoadScene("AR_Finalizar_Recorrido");
    }
}
