using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class belt_ani : MonoBehaviour
{

    public float speed = 30;

    Rigidbody2D rigid;

    // Start is called before the first frame update
    void Start()
    {

        rigid = GetComponent<Rigidbody2D>();

        rigid.AddForce(new Vector2 (-speed, 0));
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
