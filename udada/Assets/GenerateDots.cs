using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateDots : MonoBehaviour
{
    public GameObject dot;
    public GameObject TouchDetector;
    public GameObject panel;
    GameObject dot1;
    GameObject dot2;
    GameObject dot3;
    public float timer = 0;
    float max_x;
    float max_y;
    float min_x;
    float min_y;
    float random_x;
    float random_y;
    public bool wave = false;
    public int a = 0;
    void Start()
    {
    max_x = panel.GetComponent<SpriteRenderer>().bounds.max.x - 0.3f;
    max_y = panel.GetComponent<SpriteRenderer>().bounds.max.y - 0.3f;
    min_x = panel.GetComponent<SpriteRenderer>().bounds.min.x + 0.3f;
    min_y = panel.GetComponent<SpriteRenderer>().bounds.min.y + 0.3f;
    }
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 0.125 && a == 0)
        {
            wave = true;
            a++;
        }
        if (wave)
        {
            random_x = Random.Range(min_x, max_x );
            random_y = Random.Range(min_y, max_y);
            dot1 = Instantiate(dot);
            dot1.transform.position = new Vector2(random_x, random_y);
            Instantiate(TouchDetector);
            TouchDetector.transform.position = new Vector2(random_x, random_y);
            wave = false;
        }    
        if (timer > 0.25 && a == 1)
        {
            wave = true;
            a++;
        }
        if (wave)
        {
            random_x = Random.Range(min_x, max_x);
            random_y = Random.Range(min_y, max_y);
            dot2 = Instantiate(dot);
            dot2.transform.position = new Vector2(random_x, random_y);
            Instantiate(TouchDetector);
            TouchDetector.transform.position = new Vector2(random_x, random_y);
            wave = false;
        }     
        if (timer > 0.375 && a == 2)
        {
            wave = true;
            a++;
        }
        if (wave)
        {
            random_x = Random.Range(min_x, max_x);
            random_y = Random.Range(min_y, max_y);
            dot3 = Instantiate(dot);
            dot3.transform.position = new Vector2(random_x, random_y);
            Instantiate(TouchDetector);
            TouchDetector.transform.position = new Vector2(random_x, random_y);
            timer = 0;
            wave = false;
        }            
        if (timer > 0.5 && a == 3)
        {
            Destroy(dot1);
            a++;
        }    
        if (timer > 0.625 && a == 4)
        {
            Destroy(dot2);
            a++;
        }    
        if (timer > 0.75 && a == 5)
        {
            Destroy(dot3);
            a++;
        }                  
    }
}
