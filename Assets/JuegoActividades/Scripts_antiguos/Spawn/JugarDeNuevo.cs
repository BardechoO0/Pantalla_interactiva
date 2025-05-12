using UnityEngine;
using UnityEngine.SceneManagement;

public class JugarDeNuevo : MonoBehaviour
{
    [SerializeField] public GameObject Juego;
    public static JugarDeNuevo ReferenciaJugarDeNuevo;
    [SerializeField] public GameObject Botones;
    // Start is called before the first frame update

    public void Awake()
    {
        if (ReferenciaJugarDeNuevo == null)
        {
            ReferenciaJugarDeNuevo = this;
        }
    }
    void Start()
    {
        Botones.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void EmpezarDeNuevo()
    {
        SceneManager.LoadScene(3);
    }
}
