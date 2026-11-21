
using UnityEngine;

public class ControlModelosAR : MonoBehaviour
{
    [Header("CONJUNTO NORTE")]
    public GameObject bibliotecaDovali;
    public GameObject auditorioBarrosSierra;

    [Header("CONJUNTO SUR")]
    public GameObject bibliotecaRivero;
    public GameObject bibliotecaEnzo;
    public GameObject auditorioSotero;
    public GameObject auditorioMarsal;

    void Start()
    {
        OcultarTodos();
    }

    public void OcultarTodos()
    {
        if (bibliotecaDovali != null)
            bibliotecaDovali.SetActive(false);

        if (auditorioBarrosSierra != null)
            auditorioBarrosSierra.SetActive(false);

        if (bibliotecaRivero != null)
            bibliotecaRivero.SetActive(false);

        if (bibliotecaEnzo != null)
            bibliotecaEnzo.SetActive(false);

        if (auditorioSotero != null)
            auditorioSotero.SetActive(false);

        if (auditorioMarsal != null)
            auditorioMarsal.SetActive(false);
    }

    private void MostrarSolo(GameObject modelo)
    {
        OcultarTodos();

        if (modelo != null)
        {
            modelo.SetActive(true);
        }
        else
        {
            Debug.LogWarning(
                "No se ha asignado el modelo 3D."
            );
        }
    }

    // CONJUNTO NORTE

    public void MostrarDovali()
    {
        MostrarSolo(bibliotecaDovali);
    }

    public void MostrarBarrosSierra()
    {
        MostrarSolo(auditorioBarrosSierra);
    }

    // CONJUNTO SUR

    public void MostrarRivero()
    {
        MostrarSolo(bibliotecaRivero);
    }

    public void MostrarEnzo()
    {
        MostrarSolo(bibliotecaEnzo);
    }

    public void MostrarSotero()
    {
        MostrarSolo(auditorioSotero);
    }

    public void MostrarMarsal()
    {
        MostrarSolo(auditorioMarsal);
    }
}
