using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Chaos : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collider)
    {
        if(collider.gameObject.tag == "PT"){
            StartCoroutine(Destruir());
        }
    }
    private IEnumerator Destruir()
    {
        yield return new WaitForSeconds(1f);
        Destroy(gameObject);
    }
}
