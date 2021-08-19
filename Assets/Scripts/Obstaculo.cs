using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo : MonoBehaviour
{
    
    void Update()
    {
        this.transform.Translate((Vector3.left) * 0.5f);
    }
}
