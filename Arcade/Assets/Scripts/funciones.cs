using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class funciones : MonoBehaviour
{
    [SerializeField]
    GameObject listado;
    [SerializeField]
    GameObject lasFunciones;

    void Start()
    {
        lasFunciones.SetActive(true);
        listado.SetActive(false);   
    }

    void Update()
    {
        OnButtonClick eliminar = true;
        
    }

    public void crearObjeto()
    {
        lasFunciones.SetActive(false);
        listado.SetActive(true);
    }

    public void rotarObjeto()
    {

    }

    public void moverObjeto()
    {

    }
    public void eliminarObjeto(click)
    {

    }
}
