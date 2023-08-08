using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamepad : MonoBehaviour
{
    void OnMouseDown() 
    {
        GenerateDots.cycle_timer += 1000000;
        Debug.Log("click");
    }
}
