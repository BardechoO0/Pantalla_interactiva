using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proporcion : MonoBehaviour
{
    // Start is called before the first frame update
     public void Start()
    {
        
        float aspectRatio = (float)Screen.width / Screen.height;

        if (Mathf.Approximately(aspectRatio, 16f / 9f))
        {
            Debug.Log("La pantalla tiene una relación de aspecto de 16:9");

            gameManager.Instance.LimitesX = 8f;
            gameManager.Instance.LimitesY = 4f;
            // Coloca aquí tu código específico para pantallas 16:9
        }

        else
        {
            gameManager.Instance.LimitesX = (8f * (aspectRatio) / (16f/9f) );
            gameManager.Instance.LimitesY = (4f * (aspectRatio) / (16f/9f) );
        }
    }
}
