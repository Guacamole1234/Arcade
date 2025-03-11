using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeleccionObjetos : MonoBehaviour
{
    [SerializeField] private GameObject[] objetosParaCrear;

    [SerializeField] private Vector3 posicionInicial;
    
    public void CrearObjeto(int identificadorObjeto)
    {
        GameObject objetoACrear = Instantiate(objetosParaCrear[identificadorObjeto], posicionInicial, Quaternion.identity);
        MoverObjetos.instance.ObjetoSeleccionado(objetoACrear);

        Animaciones.instance.OcultarSelectorObjetos();
    }
}
