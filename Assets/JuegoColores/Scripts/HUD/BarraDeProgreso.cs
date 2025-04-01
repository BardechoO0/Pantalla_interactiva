using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BarraDeProgreso : MonoBehaviour
{
    
    [SerializeField] public Slider awakeSlider;
    [SerializeField] public float awakePower;
    [SerializeField] float maxAwakePower;
    [SerializeField] float ValorMinimo;
    [SerializeField] float ValorMaximo;
    [SerializeField] float ValorActual;
    // Start is called before the first frame update
    void Start()
    {
        maxAwakePower = 20f;
        awakeSlider.value = 0.01f;
       
    }

    // Update is called once per frame
    void Update()
    {        
            awakeSlider.value = CalculateAwakePorcentage();
            
              
    }

    float CalculateAwakePorcentage()
    {
        return gameManager.Instance.Points / maxAwakePower;
    }


}
