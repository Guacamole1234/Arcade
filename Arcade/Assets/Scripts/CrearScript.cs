using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearScript : MonoBehaviour
{
    [SerializeField]
    GameObject listado;
    [SerializeField]
    GameObject funcionesImage;
    bool lista;
    // Start is called before the first frame update
    void Start()
    {
        lista = false;
        listado.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Crear()
    {
        lista = !lista;
        if (lista == true)
        {
            funcionesImage.SetActive(false);
            listado.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            lista = false;
            funcionesImage.SetActive(true);
            listado.SetActive(false);
        }
    }
}
