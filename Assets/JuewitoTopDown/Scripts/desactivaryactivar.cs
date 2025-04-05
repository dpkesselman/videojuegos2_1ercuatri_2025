using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class desactivaryactivar : MonoBehaviour
{
    public GameObject deactivateObj;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            deactivateObj.SetActive(true);
        }
       
        if (Input.GetKeyDown(KeyCode.G))
        {
            deactivateObj.SetActive(false);
        }
    }
}

