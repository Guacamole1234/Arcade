using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class funciones : MonoBehaviour
{
    [SerializeField]
    float timeAnim;
    [SerializeField]
    LeanTweenType animType;
    [SerializeField]
    GameObject lasFuncionesImage;
    bool sacarUI = false;

    public void primeraUI()
    {
        if (sacarUI == false)
        {
            LeanTween.moveLocalY(lasFuncionesImage, -416f, timeAnim).setEase(animType);
            sacarUI = true;
        }
        else if (sacarUI == true)
        {
            LeanTween.moveLocalY(lasFuncionesImage, -623f, timeAnim).setEase(animType);
            sacarUI = false;
        }
    }
}
