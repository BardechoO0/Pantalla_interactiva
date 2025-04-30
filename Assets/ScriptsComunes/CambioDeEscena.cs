using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioDeEscena : MonoBehaviour
{
   
    public static CambioDeEscena ReferenciaCambioDeEscena;


    private void Awake()
    {
        if (ReferenciaCambioDeEscena == null)
        {
            ReferenciaCambioDeEscena = this;
        }
    }

     public void CambioDeEscena_2(int x)
    {
        SceneManager.LoadScene(x);
    }

}