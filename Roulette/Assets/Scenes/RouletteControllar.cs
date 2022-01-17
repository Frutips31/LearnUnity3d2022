using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteControllar : MonoBehaviour
{
    float rotSpeed = 0;
    public float atten = 0.96f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            this.rotSpeed = 10;
        }

        transform.Rotate(0, 0, this.rotSpeed);

        this.rotSpeed *= 0.96f;
    }
}
