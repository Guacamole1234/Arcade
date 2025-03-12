using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class EscalarObjetos : MonoBehaviour
{
    [SerializeField] private float escalaMinima;
    [SerializeField] private float escalaMaxima;

    [SerializeField] private float multiplicadorEscalado;
    [SerializeField] private float divisorEscalado;

    private GameObject objetoSeleccionado;
    private float valorInicialRaton;

    private bool escalandoObjeto = false;
    private bool seleccionandoObjeto = false;

    void Update()
    {
        if (escalandoObjeto == true)
        {
            float escalaValor = ((Input.mousePosition.y - valorInicialRaton) + multiplicadorEscalado) / divisorEscalado;

            if (escalaValor >= escalaMinima && escalaValor <= escalaMaxima)
            {
                objetoSeleccionado.gameObject.transform.localScale = new Vector3(escalaValor, escalaValor, escalaValor);
            }
            if (Input.GetMouseButtonDown(0))
            {
                escalandoObjeto = false;
                seleccionandoObjeto = false;
            }
        }

        if (seleccionandoObjeto == true)
        {
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out RaycastHit hit) && Input.GetMouseButtonDown(0) && !hit.collider.gameObject.CompareTag("Suelo"))
            {
                valorInicialRaton = Input.mousePosition.y;

                objetoSeleccionado = hit.collider.gameObject;

                escalandoObjeto = true;
                seleccionandoObjeto = false;
            }
        }
    }
    public void ActivarEscaladoObjeto()
    {
        seleccionandoObjeto = true;
    }
}
