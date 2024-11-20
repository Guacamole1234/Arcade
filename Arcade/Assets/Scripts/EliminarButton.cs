using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EliminarButton : MonoBehaviour
{
    [SerializeField]
    GameObject funcionesImage;
    bool enFunciones = true;
    bool enCreacion = false;

    public void CrearUI()
    {
        enCreacion = !enCreacion;
        if (enCreacion)
        {
            LeanTween.moveLocalY(funcionesImage, -623f, 1).setEase(LeanTweenType.easeOutBounce);
            enFunciones = false;
        }
        else if (!enCreacion)
        {
            LeanTween.moveLocalY(funcionesImage, -416f, 1).setEase(LeanTweenType.easeOutBounce);
            enFunciones = false;
        }
    }
}
