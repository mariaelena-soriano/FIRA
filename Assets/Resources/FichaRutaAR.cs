
using UnityEngine;
using TMPro;

public class FichaRutaAR : MonoBehaviour
{
    [Header("FICHA INFORMATIVA")]
    public GameObject panelFicha;
    public TMP_Text textoNombre;
    public TMP_Text textoUbicacion;
    public TMP_Text textoDescripcion;
    public TMP_Text textoIndicaciones;

    [Header("AVISO DEL MARCADOR")]
    public GameObject avisoMarcador;

    [Header("BOTON DE RUTA (DESACTIVAR)")]
    public GameObject botonMostrarRuta;

    void Start()
    {
        // Ocultar la ficha al iniciar
        if (panelFicha != null)
            panelFicha.SetActive(false);

        // Ya no utilizaremos el boton Ruta
        if (botonMostrarRuta != null)
            botonMostrarRuta.SetActive(false);

        // Evitar que el aviso tape la pantalla al iniciar
        if (avisoMarcador != null)
            avisoMarcador.SetActive(false);
    }

    // ==================================
    // MOSTRAR FICHA INFORMATIVA
    // ==================================

    private void AbrirFicha(
        string nombre,
        string ubicacion,
        string descripcion)
    {
        if (textoNombre != null)
            textoNombre.text = nombre;

        if (textoUbicacion != null)
            textoUbicacion.text = ubicacion;

        if (textoDescripcion != null)
            textoDescripcion.text = descripcion;

        if (textoIndicaciones != null)
            textoIndicaciones.text =
                "Consulta la informacion del destino. " +
                "Cierra esta ficha para continuar.";

        if (panelFicha != null)
            panelFicha.SetActive(true);
    }

    // ==================================
    // CONJUNTO NORTE
    // ==================================

    public void MostrarDovali()
    {
        AbrirFicha(
            "Biblioteca Antonio Dovalí Jaime",
            "Conjunto Norte - Referencia 2",
            "Biblioteca identificada en el croquis " +
            "de la Facultad de Ingeniería. " +
            "Consulta su ubicación dentro del conjunto."
        );
    }

    public void MostrarBarros()
    {
        AbrirFicha(
            "Auditorio Javier Barros Sierra",
            "Conjunto Norte - Referencia 1",
            "Auditorio identificado en el croquis " +
            "de la Facultad de Ingeniería. " +
            "Consulta su ubicación dentro del conjunto."
        );
    }

    // ==================================
    // CONJUNTO SUR
    // ==================================

    public void MostrarRivero()
    {
        AbrirFicha(
            "Biblioteca Enrique Rivero Borrell",
            "Conjunto Sur - Referencia L",
            "Biblioteca identificada en el croquis " +
            "de la Facultad de Ingeniería. " +
            "Consulta su ubicación dentro del conjunto."
        );
    }

    public void MostrarEnzo()
    {
        AbrirFicha(
            "Biblioteca Enzo Levi",
            "Conjunto Sur - Referencia W",
            "Biblioteca identificada en el croquis " +
            "de la Facultad de Ingeniería. " +
            "Consulta su ubicación dentro del conjunto."
        );
    }

    public void MostrarSotero()
    {
        AbrirFicha(
            "Auditorio Sotero Prieto",
            "Conjunto Sur - Referencia M",
            "Auditorio identificado en el croquis " +
            "de la Facultad de Ingeniería. " +
            "Consulta su ubicación dentro del conjunto."
        );
    }

    public void MostrarMarsal()
    {
        AbrirFicha(
            "Auditorio Raúl J. Marsal",
            "Conjunto Sur - Referencia 1",
            "Auditorio identificado en el croquis " +
            "de la Facultad de Ingeniería. " +
            "Consulta su ubicación dentro del conjunto."
        );
    }

    // ==================================
    // CERRAR FICHA
    // ==================================

    public void CerrarFicha()
    {
        if (panelFicha != null)
            panelFicha.SetActive(false);
    }

    // ==================================
    // EVENTOS DE VUFORIA
    // ==================================

    public void MarcadorEncontrado()
    {
        if (avisoMarcador != null)
            avisoMarcador.SetActive(false);
    }

    public void MarcadorPerdido()
    {
        if (avisoMarcador != null)
            avisoMarcador.SetActive(true);
    }
}
