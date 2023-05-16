using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GenerateDots : MonoBehaviour
{
    public GameObject dotInGame;
    public GameObject TouchDetectorInGame;
    public GameObject panelInGame;
    GameObject dot1InGame;
    GameObject dot2InGame;
    GameObject dot3InGame;
    public float timerInGame = 0;
    float max_xInGame;
    float max_yInGame;
    float min_xInGame;
    float min_yInGame;
    float random_xInGame;
    float random_yInGame;
    public bool waveInGame = false;
    public int aInGame = 0;
    void Start()
    {
        max_xInGame = panelInGame.GetComponent<SpriteRenderer>().bounds.max.x - 0.3f;
        max_yInGame = panelInGame.GetComponent<SpriteRenderer>().bounds.max.y - 0.3f;
        min_xInGame = panelInGame.GetComponent<SpriteRenderer>().bounds.min.x + 0.3f;
        min_yInGame = panelInGame.GetComponent<SpriteRenderer>().bounds.min.y + 0.3f;
    }
    void Update()
    {
        timerInGame += Time.deltaTime;
        if (timerInGame > 0.125 && aInGame == 0)
        {
            waveInGame = true;
            aInGame++;
        }
        if (waveInGame)
        {
            random_xInGame = Random.Range(min_xInGame, max_xInGame );
            random_yInGame = Random.Range(min_yInGame, max_yInGame);
            dot1InGame = Instantiate(dotInGame);
            dot1InGame.transform.position = new Vector2(random_xInGame, random_yInGame);
            Instantiate(TouchDetectorInGame);
            TouchDetectorInGame.transform.position = new Vector2(random_xInGame, random_yInGame);
            waveInGame = false;
        }    
        if (timerInGame > 0.25 && aInGame == 1)
        {
            waveInGame = true;
            aInGame++;
        }
        if (waveInGame)
        {
            random_xInGame = Random.Range(min_xInGame, max_xInGame);
            random_yInGame = Random.Range(min_yInGame, max_yInGame);
            dot2InGame = Instantiate(dotInGame);
            dot2InGame.transform.position = new Vector2(random_xInGame, random_yInGame);
            Instantiate(TouchDetectorInGame);
            TouchDetectorInGame.transform.position = new Vector2(random_xInGame, random_yInGame);
            waveInGame = false;
        }     
        if (timerInGame > 0.375 && aInGame == 2)
        {
            waveInGame = true;
            aInGame++;
        }
        if (waveInGame)
        {
            random_xInGame = Random.Range(min_xInGame, max_xInGame);
            random_yInGame = Random.Range(min_yInGame, max_yInGame);
            dot3InGame = Instantiate(dotInGame);
            dot3InGame.transform.position = new Vector2(random_xInGame, random_yInGame);
            Instantiate(TouchDetectorInGame);
            TouchDetectorInGame.transform.position = new Vector2(random_xInGame, random_yInGame);
            timerInGame = 0;
            waveInGame = false;
        }            
        if (timerInGame > 0.5 && aInGame == 3)
        {
            Destroy(dot1InGame);
            aInGame++;
        }    
        if (timerInGame > 0.625 && aInGame == 4)
        {
            Destroy(dot2InGame);
            aInGame++;
        }    
        if (timerInGame > 0.75 && aInGame == 5)
        {
            Destroy(dot3InGame);
            aInGame++;
        }                  
    }
}
