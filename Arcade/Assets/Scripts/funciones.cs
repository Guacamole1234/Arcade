using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class funciones : MonoBehaviour
{
    [SerializeField]
    GameObject abrirUI;
    [SerializeField]
    GameObject listado;
    [SerializeField]
    GameObject lasFunciones;
    bool sacarUI;

    void Start()
    {
        sacarUI = false;
        abrirUI.SetActive(true);
        lasFunciones.SetActive(false);
        listado.SetActive(false);   
    }

    void Update()
    {
        //OnButtonClick eliminar = true;
        
    }

    public void primeraUI()
    {
        sacarUI = !sacarUI;
        if (sacarUI == true)
        {
            abrirUI.SetActive(false);
            lasFunciones.SetActive(true);
        }
    }

    /*public void crearObjeto()
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
    public void eliminarObjeto()
    {

    }*/
}
