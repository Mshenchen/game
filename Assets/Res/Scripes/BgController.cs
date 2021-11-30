using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgController : MonoBehaviour
{
    Vector3 startPos;
    public float speed;
    public float weiyi;
    public bool isMove = true;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isMove) return; 
        if (transform.position.x < -10.0f+weiyi)
        {
            transform.position = startPos;
        }
        transform.Translate(speed, 0, 0);
    }
}
