using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class App : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        Vector2 PlayerPos = new Vector2(2, 3);
        Vector2 monsterPos = new Vector2(5, 8);

        var dir = monsterPos - PlayerPos;
        var distance=dir.magnitude; //±Ê¿Ã 
        Debug.Log(distance);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
