using System;
using System.Collections;
using System.Collections.Generic;
//using UnityEditor.Search;
using UnityEngine;
using UnityEngine.SceneManagement;

public class swipe : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip swipeSound;
    private void control(int a)
    {
        switch (Page_control.pagenum)
        {
            case 7:
                break;

            case 0:
                if (a == 1)
                {
                    if (Settings.is_Sound)
                    {
                        audioSource.PlayOneShot(swipeSound);
                    }
                    Page_control.pagenum++;
                    Page_control.page();
                }
                else
                { 
                    if (Settings.is_Sound)
                {
                    audioSource.PlayOneShot(swipeSound);
                }

                    Page_control.pagenum += 2;
                    Page_control.page();
                }
                break;
            case 3:
                if (a == 1)
                {
                    if(Settings.is_Sound) { 
                        audioSource.PlayOneShot(swipeSound);
                    }
                    Page_control.pagenum++;
                    Page_control.page();
                }
                break;
            case 1:
            case 4:
                if (a != 1)
                {
                    if (Settings.is_Sound)
                        audioSource.PlayOneShot(swipeSound);

                    Page_control.pagenum--;
                    Page_control.page();
                }
                
                break;
            case 2:
                if (a == 1)
                {
                    if (Settings.is_Sound)
                        audioSource.PlayOneShot(swipeSound);

                    Page_control.pagenum-=2;
                    Page_control.page();
                }

                break;
            case 5:
                break;

        } 
    }
   

    

    private Vector2 beganPos;
    private Vector2 endPos;   

    public void Swipe(Vector2 a,Vector2 b) {
        
        double len =  a[0] - b[0];
        
        //Debug.Log($"Swipe: {len}");

        if (len < -100)
        {
            Debug.Log("<");
            control(1);
            
        }
        else if (len > 100)
        {
            Debug.Log(">");
            control(0);
        }
    }

    

    // Start is called before the first frame update
    void Start()
    {

        var obj = FindObjectsOfType<swipe>();
        if (obj.Length == 1)
        {
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            
            beganPos = Input.mousePosition;
            //Debug.Log(beganPos);
        }

        if (Input.GetMouseButtonUp(0))
        {
            endPos = Input.mousePosition;
            //Debug.Log(endPos);
            Swipe(beganPos, endPos);
        }

    }
}
