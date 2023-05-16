using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dot : MonoBehaviour
{   
    
    public bool TouchDetector = false;
    public int num = 0; // 해당점이 생성된 순서가 저장되는 변수
    public static int i = 0; //해당 점이 터치되는 순서가 저장되는 static 변수
    int[] order = new int[3]; //점 터치순서 저장하기 위한 배열
    void Start() 
    {
        GameObject DotGenerator = GameObject.Find("DotGenerator");
        order = DotGenerator.GetComponent<GenerateDots>().order;    
    }
    
    void OnMouseDown() 
    {
        TouchDetector = true;
        if (i <= 2)
        {
            order[i] = num; 
        }
        i++;
        Debug.Log(i);
    }
} 
