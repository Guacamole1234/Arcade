using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtensibleButton : MonoBehaviour
{
    [SerializeField]
    GameObject funcionesImage;
    bool posicion = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void extensibleUI()
    {
        LeanTween.moveLocalY(funcionesImage, -816f, 1).setEase(LeanTweenType.easeOutBounce);
        /*if (posicion)
        {
            LeanTween.moveLocalY(funcionesImage, -416f, 1).setEase(LeanTweenType.easeOutBounce);
        }*/
    }
}
