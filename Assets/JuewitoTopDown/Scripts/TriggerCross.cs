using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCross : MonoBehaviour
{
    [SerializeField] private GameObject PlayerLight;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Cross"))
        {
            //PlayerLight.SetActive(true);
            StartCoroutine(Flash());
        }
    }

    IEnumerator Flash()
    {
        PlayerLight.SetActive(true);
        yield return new WaitForSeconds(0.2f);
        PlayerLight.SetActive(false);
    }
}
