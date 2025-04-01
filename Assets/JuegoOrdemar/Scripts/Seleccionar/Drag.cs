using UnityEngine;

public class Drag : MonoBehaviour
{

    [SerializeField] public Vector2 Tomate;
    
    Vector2 difference = Vector2.zero;

    public static Drag ReferenciaDrag;
    // Start is called before the first frame update


    void Awake()
    {
        if (ReferenciaDrag == null)
        {
            ReferenciaDrag = this;
        }
    }
    private void Start()
    {
        Tomate = this.gameObject.transform.position;
    }
    private void OnMouseDown()
    {
        difference = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition) - (Vector2)transform.position;

        
    }

    private void OnMouseDrag()
    {
        transform.position = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition) - difference;
    }

    private void OnMouseUp()
    {

       // this.gameObject.transform.position = Tomate;
       /* if (this.gameObject.tag == "Taller")
        {
            transform.position = new Vector2(0.98f, -1.08f);
        }
        else if (this.gameObject.tag == "Excursion")
        {
            transform.position = new Vector2(-0.52f, -3.5f);
        }
        else if (this.gameObject.tag == "Cocina")
        {
            transform.position = new Vector2(8.48f, -3.5f);
        }
        else if (this.gameObject.tag == "Vestidor")
        {
            transform.position = new Vector2(6.98f, -6.08f);
        }
        else if (this.gameObject.tag == "Salon")
        {
            transform.position = new Vector2(0.98f, -6.08f);
        }
        else if (this.gameObject.tag == "Baño")
        {
            transform.position = new Vector2(6.98f, -1.08f);
        }
       */
    }

  

}
