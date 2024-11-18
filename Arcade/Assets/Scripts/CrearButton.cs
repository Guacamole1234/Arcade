using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CrearButton : MonoBehaviour
{
    [SerializeField] GameObject listadoCanva;
    [SerializeField] GameObject listadoImage;
    bool enCreacion = false;
   
    void start()
    {
        listadoCanva.SetActive(false);
    }

    public void CrearUI()
    {
        enCreacion = !enCreacion;
        if (enCreacion)
        {
            listadoCanva.SetActive(true);
            LeanTween.moveLocalX(listadoImage, 118, 1).setEase(LeanTweenType.easeInExpo);
        }
    }
}
