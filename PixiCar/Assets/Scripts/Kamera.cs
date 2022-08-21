using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kamera : MonoBehaviour
{
   
   public float kameraHizi;

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(kameraHizi * Time.deltaTime,0,0);
    }
}
