using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class habilitarcomponente : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;


    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            spriteRenderer.enabled = false;
        }


        if (Input.GetKeyDown(KeyCode.K))
        {
            spriteRenderer.enabled = true;
        }
    }
}

