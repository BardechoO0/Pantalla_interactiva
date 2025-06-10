using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class piezas : MonoBehaviour
{
    [SerializeField] Conteo Ct;
    private void Awake()
    {
        Ct = FindAnyObjectByType<Conteo>();
    }
    void Start()
    {
        Ct.Empezar();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
   
        if (collision.gameObject.tag == gameObject.tag)
        {
            collision.gameObject.SetActive(false);
            Ct.Coantar();
            collision.gameObject.tag = "Player";
            this.gameObject.GetComponent<SpriteRenderer>().color = Color.white;
        }
    }
}
