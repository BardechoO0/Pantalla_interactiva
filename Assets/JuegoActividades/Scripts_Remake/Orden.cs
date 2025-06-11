using TMPro;
using UnityEngine;

public class Orden : MonoBehaviour
{
    [SerializeField] Juego Jg;
    public AudioSource Ac;
    public TextMeshProUGUI Texto;
    public GameObject panel;

    public string Oracion;

    public bool ElCorrecto;
    void Start()
    {
        if (ElCorrecto)
        {
            Jg = FindAnyObjectByType<Juego>();
            Ac = this.gameObject.GetComponent<AudioSource>();
            Texto.enabled = true;
            panel.SetActive(true);
            
            Texto.text = Oracion;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        
       if (ElCorrecto){
            if (other.gameObject.tag == "Player")
            {
                Texto.enabled = false;
                panel.SetActive(false);
                Ac.GetComponent<AudioSource>().Stop();
                Texto.enabled = false;

                Jg.Correcto();
                Destroy(this.gameObject);
            }
        }
    }
}
