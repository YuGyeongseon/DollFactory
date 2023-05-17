using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateDots : MonoBehaviour
{
    public GameObject dot;
    public GameObject panel;
    GameObject dot1;
    GameObject dot2;
    GameObject dot3;
    bool dot1_touched;
    bool dot2_touched;
    bool dot3_touched;
    public float timer = 0;
    float max_x;
    float max_y;
    float min_x;
    float min_y;
    float random_x;
    float random_y;
    public bool wave = false;
    public bool GameOver = false;
    public int a = 0;
    //int score = GetComponent<Score>().score;
    void Start()
    {
    max_x = panel.GetComponent<SpriteRenderer>().bounds.max.x - 0.3f;
    max_y = panel.GetComponent<SpriteRenderer>().bounds.max.y - 0.3f;
    min_x = panel.GetComponent<SpriteRenderer>().bounds.min.x + 0.3f;
    min_y = panel.GetComponent<SpriteRenderer>().bounds.min.y + 0.3f;
    }
    void Update()
    {
        if (GameOver == false)
        {
            timer += Time.deltaTime;
            if (timer > 0.25 && a == 0)
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
                wave = false;
            }    
            if (timer > 0.5 && a == 1)
            {
                wave = true;
                a++;
            }
            if (wave)
            {
                do
                {
                    random_x = Random.Range(min_x, max_x );
                    random_y = Random.Range(min_y, max_y);
                } while(random_x == dot1.transform.position.x || random_y == dot1.transform.position.y);
                dot2 = Instantiate(dot);
                dot2.transform.position = new Vector2(random_x, random_y);
                wave = false;
            }     
            if (timer > 0.75 && a == 2)
            {
                wave = true;
                a++;
            }
            if (wave)
            {
                do
                {
                    random_x = Random.Range(min_x, max_x );
                    random_y = Random.Range(min_y, max_y);
                } while(random_x == dot1.transform.position.x || random_y == dot1.transform.position.y || random_x == dot2.transform.position.x || random_y == dot1.transform.position.y);
                dot3 = Instantiate(dot);
                dot3.transform.position = new Vector2(random_x, random_y);
                timer = 0;
                wave = false;
            }            
            if (timer > 0.75 && a == 3)
            {
                dot1.GetComponent<SpriteRenderer>().enabled = false;
                dot2.GetComponent<SpriteRenderer>().enabled = false;
                dot3.GetComponent<SpriteRenderer>().enabled = false;
                a++; 
            }           
            if(dot1 != null && dot2 != null && dot3 != null)
            {
                if (dot1.GetComponent<Dot>().TouchDetector)
                {
                    Debug.Log("Dot1 Touched");
                    if (dot2.GetComponent<Dot>().TouchDetector)
                    {
                        Debug.Log("Dot2 Touched");
                        if (dot3.GetComponent<Dot>().TouchDetector)
                        {
                            Debug.Log("Dot3 Touched");
                            timer = 0;
                            a = 0;
                            Destroy(dot1);
                            Destroy(dot2);
                            Destroy(dot3);
                            Score.score ++;
                        }
                    }
                }
                if (timer > 1.5)
                {
                    Debug.Log("Game Over!");
                    GameOver = true;
                }   
            }
        }
    }
}
