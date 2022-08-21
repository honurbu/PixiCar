using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopArkaplan : MonoBehaviour
{
    public float arkaplanHizi;
    public Renderer backgroundRenderer;

    // Update is called once per frame
    void Update()
    {
        backgroundRenderer.material.mainTextureOffset += new Vector2(arkaplanHizi * Time.deltaTime, 0f);
    }
}
