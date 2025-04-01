using UnityEngine;
using UnityEngine.EventSystems;

public class ObtenerCaja2 : MonoBehaviour, IDropHandler
{
   

    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag != null)
        {
            Debug.Log("No todo bien :(");
            if (eventData.pointerDrag.tag == "Cocina")
            {
                eventData.pointerDrag.GetComponent<Caja2>().EstaEnZonaCarga2 = true;
               
                Debug.Log("todo bien :)");
            }
        }
    }
}
