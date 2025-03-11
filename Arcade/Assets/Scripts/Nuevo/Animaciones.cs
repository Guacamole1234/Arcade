using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animaciones : MonoBehaviour
{
    public static Animaciones instance;
    
    [SerializeField] private GameObject barraBaja;
    [SerializeField] private GameObject selectorObjetos;
    
    [SerializeField] private LeanTweenType animacionBarraMostrando;
    [SerializeField] private LeanTweenType animacionBarraOcultando;

    [SerializeField] private float duracionAnimacion;

    [SerializeField] private float barraBajaFuera;
    [SerializeField] private float barraBajaEnPantalla;
    private bool mostrandobarraBaja = false;

    [SerializeField] private float selectorObjetosFuera;
    [SerializeField] private float selectorObjetosEnPantalla;

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

    public void CambiarBarraBaja()
    {
        if (mostrandobarraBaja)
        {
            OcultarBarraBaja();
        }
        else
        {
            MostrarBarraBaja();
        }

        mostrandobarraBaja = !mostrandobarraBaja;
    }
    
    private void MostrarBarraBaja()
    {
        LeanTween.moveLocalY(barraBaja, barraBajaEnPantalla, duracionAnimacion).setEase(animacionBarraMostrando);
    }

    private void OcultarBarraBaja()
    {
        LeanTween.moveLocalY(barraBaja, barraBajaFuera, duracionAnimacion).setEase(animacionBarraOcultando);
    }

    public void MostrarSelectorObjetos()
    {
        LeanTween.moveLocalX(selectorObjetos, selectorObjetosEnPantalla, duracionAnimacion).setEase(animacionBarraMostrando);
    }

    public void OcultarSelectorObjetos()
    {
        LeanTween.moveLocalX(selectorObjetos, selectorObjetosFuera, duracionAnimacion).setEase(animacionBarraOcultando);
    }
}
