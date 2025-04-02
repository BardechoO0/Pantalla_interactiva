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
            
            if (eventData.pointerDrag.tag == "Cocina")
            {
                eventData.pointerDrag.GetComponent<Caja>().EstaEnZonaCarga = true;
               
                Debug.Log("todo bien :)");
            }else if (eventData.pointerDrag.tag != "Cocina")
            {
                Debug.Log("No todo bien :(");
            }
        }
    }
}
