using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds;
using GoogleMobileAds.Api;

public class repair_button : MonoBehaviour
{
#if UNITY_ANDROID
    private string _adUnitId = "ca-app-pub-7205007845595607~4945814421";
#endif
    private RewardedAd rewardedAd;

    public void LoadRewardedAd()
    {
        if (rewardedAd != null)
        {
            rewardedAd.Destroy();
            rewardedAd = null;
        }

        Debug.Log("Loading the rewarded ad.");

        // create our request used to load the ad.
        var adRequest = new AdRequest();
        adRequest.Keywords.Add("unity-admob-sample");

        // send the request to load the ad.
        RewardedAd.Load(_adUnitId, adRequest,
            (RewardedAd ad, LoadAdError error) =>
            {
                // if error is not null, the load request failed.
                if (error != null || ad == null)
                {
                    Debug.LogError("Rewarded ad failed to load an ad " +
                                   "with error : " + error);
                    return;
                }

                Debug.Log("Rewarded ad loaded with response : "
                          + ad.GetResponseInfo());

                rewardedAd = ad;
            });
    }
    public void repaired()
    {
        Settings.complete_doll += repair_station.repair_doll;
        repair_station.repair_doll = 0;
    }
    public void sell_now()
    {
        Settings.coin += Settings.incomplete_doll;
        Settings.incomplete_doll = 0;
    }

    public void advertise()
    {
        Debug.Log("ad");
        Settings.coin += 3 * Settings.incomplete_doll;
        Settings.incomplete_doll = 0;
        LoadRewardedAd();
    }
    public void Upgrade()
    {
        if(repair_station.station_level == 1&&Settings.coin>=1000) {
            repair_station.station_level++;
            Settings.coin -= 1000;
        }
        if (repair_station.station_level == 2 && Settings.coin >= 1500)
        {
            repair_station.station_level++;
            Settings.coin -= 1500;
        }

    }
    // Start is called before the first frame update
    void Start()
    {
        MobileAds.Initialize((InitializationStatus initStatus) =>
        {

        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
