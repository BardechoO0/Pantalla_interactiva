using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

public class Cronometro : MonoBehaviour
{
    [SerializeField] public float Segundos;
    
    public static Cronometro ReferenciaCronometro;
   
    [SerializeField] TextMeshProUGUI SegundosTexto;
    [SerializeField] bool CheckerCorrutina;

    private void Awake()
    {
        if (ReferenciaCronometro == null)
        {
            ReferenciaCronometro = this;
        }

    }
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        Segundos = 0;
        CheckerCorrutina = true;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (CheckerCorrutina == true)
        {
            CheckerCorrutina = false;
            StartCoroutine(Tiempo());
        }
        SegundosTexto.text = Segundos.ToString("F2");
    }
    

    IEnumerator Tiempo()
    {
        yield return new WaitForSeconds((float)0.01);
        if (Application.isMobilePlatform)
        {
            Segundos = Segundos + 0.0665f;
        }
        else
        {
            Segundos = Segundos + 0.012f;
        }
        
        CheckerCorrutina = true;
    }
}
