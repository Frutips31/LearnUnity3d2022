using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    float speed = 0;

    Vector3 start;
    Vector3 end;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            this.start = Input.mousePosition;
        }
        else if(Input.GetMouseButtonUp(0))
        {
            var end = Input.mousePosition;
            float swipeLength = end.x - this.start.x;
            this.speed = swipeLength / 500.0f;
        }

        this.transform.Translate(this.speed, 0, 0);
        this.speed *= 0.96f;
/*
        if (Input.GetMouseButtonDown(0))
        {
            this.speed = 0.2f;
        }

        GameObject go = this.gameObject;
        Transform trans = go.GetComponent<Transform>();
        transform.Translate(this.speed, 0, 0);
        this.speed *= 0.96f;*/
    }
}
