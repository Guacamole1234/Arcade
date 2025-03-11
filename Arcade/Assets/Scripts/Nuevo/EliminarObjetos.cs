using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EliminarObjetos : MonoBehaviour
{
    public static EliminarObjetos instance;
    
    [SerializeField] private LayerMask capaDeBase;

    [HideInInspector] public bool eliminandoObjeto = false;

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

    private void Update()
    {
        if (eliminandoObjeto)
        {
            SeleccionarObjetoAEliminar();
        }
    }

    private void SeleccionarObjetoAEliminar()
    {
        if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out RaycastHit hit) && Input.GetMouseButtonDown(0) && hit.collider.gameObject.layer != capaDeBase)
        {
            eliminandoObjeto = false;
            Destroy(hit.collider.gameObject);
        }
    }

    public void ActivarEliminarObjeto()
    {
        eliminandoObjeto = true;
    }
}
