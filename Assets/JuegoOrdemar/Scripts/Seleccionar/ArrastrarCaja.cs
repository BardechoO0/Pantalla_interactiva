using UnityEngine;
using UnityEngine.EventSystems;

public class ArrastrarCaja : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler
{

    private Vector2 PosicionInicialCajaArrastre;
    public bool EstaArrastrando = false;
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
        EmpezarArrastre();
        //print("si");
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        TerminarArrastre();
    }

    public void OnDrag(PointerEventData eventData)
    {
        if (EstaArrastrando)
        {
            this.transform.position = new Vector2(eventData.pointerCurrentRaycast.worldPosition.x, eventData.pointerCurrentRaycast.worldPosition.y);
        }
    }
    public void TerminarArrastre()
    {
        if (EstaArrastrando)
        {
            if (!this.GetComponent<Caja>().EstaEnZonaCarga)
            {
                
                //collidersHabitaciones.enabled = true;
                //colliderObjeto.enabled = true;
                RetornarCajaAPosicion();
            }
            EstaArrastrando = false;
        }
        
    }
    /*public void ocultarCollider()
    {
        colliderObjeto.enabled = false;
        collidersHabitaciones.enabled = false;
    }*/

    public void EmpezarArrastre()
    {
        
        EstaArrastrando = true;
        PosicionInicialCajaArrastre = this.transform.position;
    }

    public void RetornarCajaAPosicion()
    {
        //this.transform.position = PosicionInicialCajaArrastre;
        
    }
}
