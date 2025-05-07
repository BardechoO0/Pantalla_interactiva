using UnityEngine;
using UnityEngine.UIElements;




public class Puzzle : MonoBehaviour
{

    public WebCamTexture Sp1;

    

    public Material re;

    public SpriteRenderer s;

    
   
    void Start()
    {

        Sp1 = new WebCamTexture();

        if(re != null)
        {
            re.mainTexture = Sp1;

            s.material.mainTexture = Sp1;

            
            
        }

        Sp1.Play();
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
