using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioDeEscena : MonoBehaviour
{
   
    public static CambioDeEscena ReferenciaCambioDeEscena;

    // Start is called before the first frame update

    private void Awake()
    {
        if (ReferenciaCambioDeEscena == null)
        {
            ReferenciaCambioDeEscena = this;
        }
    }
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void Volver()
    {
        
        SceneManager.LoadScene(0);        
    }
    public void CargarJuegoColores()
    {
        
        SceneManager.LoadScene(1);        
    }
    public void CargarJuegoOrdenar()
    {
        SceneManager.LoadScene(2);
    }
    public void CargarJuegoActividades()
    {
        SceneManager.LoadScene(3);
    }
}