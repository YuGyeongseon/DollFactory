using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dot : MonoBehaviour
{   
    public bool TouchDetector = false;
    
    void OnMouseDown() 
    {
        TouchDetector = true;   
    }
} 
