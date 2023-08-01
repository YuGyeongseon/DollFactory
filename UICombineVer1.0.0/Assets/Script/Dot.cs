using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Vibration
{
#if UNITY_ANDROID && !UNITY_EDITOR
    public static AndroidJavaClass AndroidPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
    public static AndroidJavaObject AndroidcurrentActivity = AndroidPlayer.GetStatic<AndroidJavaObject>("currentActivity");
    public static AndroidJavaObject AndroidVibrator = AndroidcurrentActivity.Call<AndroidJavaObject>("getSystemService", "vibrator");
#endif
    public static void Vibrate()
    {
#if UNITY_ANDROID && !UNITY_EDITOR
        AndroidVibrator.Call("vibrate");
#else
        Handheld.Vibrate();
#endif
    }

    public static void Vibrate(long milliseconds)
    {
#if UNITY_ANDROID && !UNITY_EDITOR
        AndroidVibrator.Call("vibrate", milliseconds);
#else
        Handheld.Vibrate();
#endif
    }
    public static void Vibrate(long[] pattern, int repeat)
    {


#if UNITY_ANDROID && !UNITY_EDITOR
        AndroidVibrator.Call("vibrate", pattern, repeat);
#else
        Handheld.Vibrate();
#endif
    }

    public static void Cancel()
    {
#if UNITY_ANDROID && !UNITY_EDITOR
            AndroidVibrator.Call("cancel");
#endif
    }
}
public class Dot : MonoBehaviour
{
    public static int touch_count = 0; // 터치된 점의 개수
    public static int touch_order = 0; //해당 점이 터치되는 순서가 저장되는 static 변수
    public int num; // 해당점이 생성된 순서가 저장되는 변수
    //public int[] order = new int[3]; //점 터치순서 저장하기 위한 배열
    void Start() 
    {
    }

    void OnMouseDown()// 클릭시
    {
        if (GenerateDots.dot_count >= GenerateDots.size + 1)
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if (GetComponent<CircleCollider2D>().OverlapPoint(mousePosition))
            {
            
            num = touch_order;
            touch_order++;
            touch_count++;
        }
        Handheld.Vibrate();
        Vibration.Vibrate(100);
    }
  }
}
    
 
