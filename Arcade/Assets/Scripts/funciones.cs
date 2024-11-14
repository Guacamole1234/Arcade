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
    GameObject abrirUI;
    [SerializeField]
    GameObject lasFuncionesCanvas;
    [SerializeField]
    GameObject lasFuncionesImage;
    bool sacarUI;

    void Start()
    {
        sacarUI = false;
        abrirUI.SetActive(true);
        lasFuncionesCanvas.SetActive(false);  
    }

    public void primeraUI()
    {
        sacarUI = !sacarUI;
        if (sacarUI == true)
        {
            abrirUI.SetActive(false);
            lasFuncionesCanvas.SetActive(true);
            LeanTween.moveLocalY(lasFuncionesImage, -416f, timeAnim).setEase(animType);
        }
        else
        {
            sacarUI = false;
            abrirUI.SetActive(true);
            lasFuncionesCanvas.SetActive(false);
        }
    }
}
