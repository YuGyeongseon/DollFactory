using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectTouch : MonoBehaviour
{
    public GameObject DotGenerator;
    void Start()
    {
        
    }

    private void OnMouseDown() 
    {
        DotGenerator.GetComponent<GenerateDots>();
    }
}
