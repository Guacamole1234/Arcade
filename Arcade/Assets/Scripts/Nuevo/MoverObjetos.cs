using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverObjetos : MonoBehaviour
{
    public static MoverObjetos instance;

    [SerializeField] private LayerMask capaDeBase;

    private bool moviendoObjeto = false;
    private bool seleccionandoObjeto = false;

    [SerializeField] private GameObject objetoActual;
    [SerializeField] private GameObject sombraSeleccion;

    [SerializeField] private Vector3 escalaAnimacionSombra;
    [SerializeField] private float duracionAnimacionSombra;
    [SerializeField] private LeanTweenType animacionSombra;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this);
        }
    }

    private void Start()
    {
        sombraSeleccion.SetActive(false);
        escalaAnimacionSombra.y = sombraSeleccion.transform.localScale.y;
        LeanTween.scale(sombraSeleccion, escalaAnimacionSombra, duracionAnimacionSombra).setEase(animacionSombra).setLoopPingPong();
    }

    private void Update()
    {
        if (moviendoObjeto)
        {
            MoverObjeto();
            AceptarPosicionObjeto();
        }

        if (seleccionandoObjeto)
        {
            SeleccionarObjetoManualmente();
        }
    }

    private void MoverObjeto()
    {
        if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out RaycastHit hit, Mathf.Infinity, capaDeBase))
        {
            if (objetoActual != null)
            {
                objetoActual.transform.position = hit.point;

                sombraSeleccion.SetActive(true);
                sombraSeleccion.transform.position = objetoActual.transform.position;
            }
        }
    }

    private void AceptarPosicionObjeto()
    {
        if (Input.GetMouseButtonDown(0))
        {
            sombraSeleccion.SetActive(false);
            moviendoObjeto = false;
            objetoActual = null;
        }
    }

    public void ObjetoSeleccionado(GameObject objetoSeleccionado)
    {
        objetoActual = objetoSeleccionado;
        moviendoObjeto = true;
    }

    public void ActivarSeleccionDeObjeto()
    {
        moviendoObjeto = false;
        seleccionandoObjeto = true;
    }

    private void SeleccionarObjetoManualmente()
    {
        if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out RaycastHit hit) && Input.GetMouseButtonDown(0) && !hit.collider.gameObject.CompareTag("Suelo"))
        {
            seleccionandoObjeto = false;
            moviendoObjeto = true;

            objetoActual = hit.collider.gameObject;
        }
    }
}
