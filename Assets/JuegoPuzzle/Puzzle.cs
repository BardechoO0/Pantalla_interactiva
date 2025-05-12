
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
