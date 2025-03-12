using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class RotarObjetos : MonoBehaviour
{
    [SerializeField] float multiplicadorRotacion;
    float valorRotacion;

    private GameObject objetoActual;

    public bool rotandoObjeto;
    bool buscandoObjeto;

    void Update()
    {
        if (rotandoObjeto)
        {
            if (Input.GetAxis("Mouse ScrollWheel") != 0 && !objetoActual.gameObject.CompareTag("Suelo"))
            {
                valorRotacion = -Input.mouseScrollDelta.y * multiplicadorRotacion;

                objetoActual.gameObject.transform.Rotate(0, valorRotacion, 0);
            }
            if (Input.GetMouseButtonDown(0))
            {
                rotandoObjeto = false;
                buscandoObjeto = false;
            }
        }

        if (buscandoObjeto)
        {
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out RaycastHit hit))
            {
                objetoActual = hit.collider.gameObject;
                rotandoObjeto = true;
            }
        }
    }

    public void RotarObjeto()
    {
        buscandoObjeto = true;
    }
}
