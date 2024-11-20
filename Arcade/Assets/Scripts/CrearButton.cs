using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CrearButton : MonoBehaviour
{
    [Header("Objetos")]
    public GameObject Objeto_Gancho;
    public GameObject Objeto_Bailesote;
    public GameObject Objeto_Pinball;
    public GameObject Objeto_Suelo;
    public GameObject Objeto_Columna;
    public GameObject Objeto_Muro;
    public GameObject Objeto_Esquina;
    public GameObject Objeto_Puerta;
    public GameObject Objeto_Ventana;
    public GameObject Objeto_Cliente;
    public GameObject Objeto_Furro;
    public GameObject Objeto_Ludopatia;
    public GameObject Objeto_Arcade;
    public GameObject Objeto_BalonJuego;
    public GameObject Objeto_LaCaja;
    public GameObject Objeto_LaFortunosa;
    public GameObject Objeto_Ticketadora;
    public GameObject Objeto_Expendedora;


    [SerializeField]
    GameObject Gancho;
    [SerializeField]
    GameObject Bailesote;
    [SerializeField]
    GameObject Pinball;
    [SerializeField]
    GameObject Suelo;
    [SerializeField]
    GameObject Columna;
    [SerializeField]
    GameObject Muro;
    [SerializeField]
    GameObject Esquina;
    [SerializeField]
    GameObject Puerta;
    [SerializeField]
    GameObject Ventana;
    [SerializeField]
    GameObject Cliente;
    [SerializeField]
    GameObject Furro;
    [SerializeField]
    GameObject Ludopatia;
    [SerializeField]
    GameObject Arcade;
    [SerializeField]
    GameObject BalonJuego;
    [SerializeField]
    GameObject LaCaja;
    [SerializeField]
    GameObject LaFortunosa;
    [SerializeField]
    GameObject Ticketadora;
    [SerializeField]
    GameObject Expendedora;

    [SerializeField]
    GameObject listadoCanva;
    [SerializeField]
    GameObject listadoImage;
    [SerializeField]
    GameObject funcionesImage;
    bool enFunciones = true;
    bool enCreacion = false;
    public GameObject selectObject;
   
    void start()
    {
        listadoCanva.SetActive(false);
    }

    void update ()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                if (hit.transform.CompareTag("Suelo"))
                {
                    //selecciona el objeto al hacer click
                    selectObject = hit.transform.gameObject;
                }
            }
        }
    }

    public void CrearUI()
    {
        enCreacion = !enCreacion;
        if (enCreacion)
        {
            listadoCanva.SetActive(true);
            LeanTween.moveLocalX(listadoImage, 118, 1).setEase(LeanTweenType.easeInExpo);
            LeanTween.moveLocalY(funcionesImage, -623f, 1).setEase(LeanTweenType.easeOutBounce);
            enFunciones = false;
        }
        else if (!enCreacion)
        {
            listadoCanva.SetActive(false);
            LeanTween.moveLocalX(listadoImage, -288, 1).setEase(LeanTweenType.easeInExpo);
            LeanTween.moveLocalY(funcionesImage, -416f, 1).setEase(LeanTweenType.easeOutBounce);
            enFunciones = false;
        }
    }
    private void CrearObjeto(GameObject Objetos, int objetoId)
    {
        if (Objetos != null)
        {
            Vector3 posicionInicial = new Vector3(0, 0, 0); // Cambiar si se requiere otra posición
            GameObject nuevoObjeto = Instantiate(Objetos, posicionInicial, Quaternion.identity);
            nuevoObjeto.tag = "Objects";
            nuevoObjeto.name = "Objetos" + objetoId;
        }
    }
    public void ObjetoNum1()
    {
        CrearObjeto(Objeto_Gancho, 1);
    }
    public void ObjetoNum2()
    {
        CrearObjeto(Objeto_Bailesote, 2);
    }
    public void ObjetoNum3()
    {
        CrearObjeto(Objeto_Pinball, 3);
    }
    public void ObjetoNum4()
    {
        CrearObjeto(Objeto_Suelo, 4);
    }
    public void ObjetoNum5()
    {
        CrearObjeto(Objeto_Columna, 5);
    }
    public void ObjetoNum6()
    {
        CrearObjeto(Objeto_Muro, 6);
    }
    public void ObjetoNum7()
    {
        CrearObjeto(Objeto_Esquina, 7);
    }
    public void ObjetoNum8()
    {
        CrearObjeto(Objeto_Puerta, 8);
    }
    public void ObjetoNum9()
    {
        CrearObjeto(Objeto_Ventana, 9);
    }
    public void ObjetoNum10()
    {
        CrearObjeto(Objeto_Cliente, 10);
    }
    public void ObjetoNum11()
    {
        CrearObjeto(Objeto_Furro, 11);
    }
    public void ObjetoNum12()
    {
        CrearObjeto(Objeto_Ludopatia, 12);
    }
    public void ObjetoNum13()
    {
        CrearObjeto(Objeto_Arcade, 13);
    }
    public void ObjetoNum14()
    {
        CrearObjeto(Objeto_BalonJuego, 14);
    }
    public void ObjetoNum15()
    {
        CrearObjeto(Objeto_LaCaja, 15);
    }
    public void ObjetoNum16()
    {
        CrearObjeto(Objeto_LaFortunosa, 16);
    }
    public void ObjetoNum17()
    {
        CrearObjeto(Objeto_Ticketadora, 17);
    }
    public void ObjetoNum18()
    {
        CrearObjeto(Objeto_Expendedora, 18);
    }
}
