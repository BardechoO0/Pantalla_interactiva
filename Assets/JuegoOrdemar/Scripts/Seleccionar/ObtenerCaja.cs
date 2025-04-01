using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ObtenerCaja : MonoBehaviour, IDropHandler
{
   

    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag != null)
        {
            Debug.Log("No todo bien :(");
            if (eventData.pointerDrag.tag == "Cocina")
            {
                eventData.pointerDrag.GetComponent<Caja>().EstaEnZonaCarga = true;
               
                Debug.Log("todo bien :)");
            }
        }
    }
}
