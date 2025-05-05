using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Puzzle : MonoBehaviour
{
    public SpriteRenderer Sp1;
    public SpriteRenderer Sp2;

    public Vector2 WS;
    void Start()
    {

        Sp2.sprite.textureRect.height.ToString();

        print(Sp2.sprite.textureRect.height.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
