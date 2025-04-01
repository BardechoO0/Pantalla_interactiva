using UnityEngine;
using UnityEngine.EventSystems;

public class ArrastrarCaja2 : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler
{

    private Vector2 PosicionInicialCajaArrastre2;
    public bool EstaArrastrando2 = false;
    //public Collider2D colliderObjeto;
    //public GameObject[] habitaciones;
    //public Collider2D collidersHabitaciones;

    // Start is called before the first frame update


    public void Start()
    {
        
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        //colliderObjeto = GetComponent<Collider2D>();
        //collidersHabitaciones = habitaciones[0].GetComponent<Collider2D>();
        //ocultarCollider();
        EmpezarArrastre2();
        //print("si");
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        TerminarArrastre2();
    }

    public void OnDrag(PointerEventData eventData)
    {
        if (EstaArrastrando2)
        {
            this.transform.position = new Vector2(eventData.pointerCurrentRaycast.worldPosition.x, eventData.pointerCurrentRaycast.worldPosition.y);
        }
    }
    public void TerminarArrastre2()
    {
        if (EstaArrastrando2)
        {
            if (!this.GetComponent<Caja2>().EstaEnZonaCarga2)
            {
                
                //collidersHabitaciones.enabled = true;
                //colliderObjeto.enabled = true;
                RetornarCajaAPosicion2();
            }
            EstaArrastrando2 = false;
        }
        
    }
    /*public void ocultarCollider()
    {
        colliderObjeto.enabled = false;
        collidersHabitaciones.enabled = false;
    }*/

    public void EmpezarArrastre2()
    {
        
        EstaArrastrando2 = true;
        PosicionInicialCajaArrastre2 = this.transform.position;
    }

    public void RetornarCajaAPosicion2()
    {
        this.transform.position = PosicionInicialCajaArrastre2;
        
    }
}
