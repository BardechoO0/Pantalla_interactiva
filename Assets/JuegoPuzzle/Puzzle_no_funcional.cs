
using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Windows.WebCam;
public class Puzzle : MonoBehaviour
{

    public WebCamTexture webCamera;

    public Material webCameraTexture;

    public GameObject pantallaCamara;

    public RenderTexture RT;

    public Texture2D sad;

    public GameObject dfds;

    public Material d;

    public SpriteRenderer m;

    public Sprite p;

    public Grid sfd;

    public string x;

    public GameObject[] proba;
    public GameObject[] Grupos;

    public Camera cam_Tex;
    public RenderTexture RT_Tex;
    public Texture2D[] LeerTextura;
    public Texture2D LeerTextura_Tex;
    public Sprite[] NuevoSpite;

    private Camera cam;

    public CameraParameters f1;
    public CameraParameters f2;


    public int i = 0;
    void Start()
    {
        //poner la textura de la WebCam en un material para poder renderizar;
        webCamera = new WebCamTexture();

        if(webCameraTexture != null)
        {
            webCameraTexture.mainTexture = webCamera;              
        }

        pantallaCamara.SetActive(false);
        webCamera.Stop();

        cam = Camera.main;

       

        activarCamara();

        
    }


    //Activar la Webcam
    public void activarCamara()
    {
        pantallaCamara.SetActive(true);
        webCamera.Play();

        
        
    }

    public void tomarFoto()
    {
        //Nombre de la captura y sacar la captura
        x = System.DateTime.Now.ToString("yyyy-MM-dd-HH-mm--ss");
        ScreenCapture.CaptureScreenshot("ScreenShot" + x + ".png", 4);

        //tiempo de espera para sacar conseguir la captura en el juego
        StartCoroutine(Holiuwu());

    }

    IEnumerator Holiuwu()
    {

        yield return new WaitForSeconds(5f);

        sad = ScreenCapture.CaptureScreenshotAsTexture(2);

        //Crear un Sprite que contega la textura
        p = Sprite.Create(sad, new Rect(0.0f, 0.0f, sad.width, sad.height), new Vector2(0.5f, 0.5f), 100.0f);

        
        m.sprite = p;

        


  

        for (int j = 0; j < Grupos.Length; j++)
        {
            int k;

            k = Grupos[j].transform.childCount;

            if (proba.Length <= 0)
            {
                proba = new GameObject[k * Grupos.Length];

                LeerTextura = new Texture2D[k * Grupos.Length];

                NuevoSpite = new Sprite[k * Grupos.Length];

            }

            for (int k2 = k; k2 > 0; k2--)
            {
                yield return new WaitForSeconds(0.1f);

                if (i == 0)
                {
                    i = k * Grupos.Length;
                }
                proba[i - 1] = Grupos[j].transform.GetChild(k2 - 1).gameObject;

                
                cam_Tex.enabled = true;

                cam_Tex.transform.position = proba[i - 1].transform.position;


               

                

                LeerTextura[i - 1] = ScreenCapture.CaptureScreenshotAsTexture(2); 

                NuevoSpite[i-1] = Sprite.Create(LeerTextura[i-1], new Rect(0.0f, 0.0f, LeerTextura[i-1].width, LeerTextura[i - 1].height), new Vector2(0.5f, 0.5f), 100.0f);

                proba[i - 1].GetComponent<SpriteRenderer>().sprite = NuevoSpite[i-1];

                //proba[i - 1].GetComponent<SpriteRenderer>().sprite = m.sprite;
                i--;

                cam_Tex.enabled = false;
                

            }


        }
    }

  
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.F)) 
        {
            tomarFoto();
        }
    }
}


/*
 Sabías que la "el poder de la doble pareja" tiene las letras pares.
Es decir
el = 2 letras
poder = 5 letras
de = 2
la = 2
doble= 5
pareja = 6

Entoces  2+5+2+2+5+6 = 22

y 22 es la suma de la pareja de 11 + 11 
entoces nos queda que 2 x 11, pero sabien que dos el la suma de la pareja de 1 nos queda (1+1) + (10+10) una pareja de sumas.
tambien si  sumamos todos los 2 de las letras nos quedan los numeros 6,5,5,6 lo que son dos parejas, entonces "el poder de la doble pareja" es un dobel pareja, todo encanja.

Y esto solo deja una conclusión posible visble: yo cuando doble pareja, tu cuando doble pareja.
Y esta frase tambien es una pareja porque si sumamos la cantidad de letras nos da que son 19 y 19.
Todo esta conectdo

 */