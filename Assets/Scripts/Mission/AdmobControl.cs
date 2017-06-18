using UnityEngine;
using System.Collections;

public class AdmobControl : MonoBehaviour
{

    private const string AD_UNIT_ID = "ca-app-pub-4128501448856864/2872480833";
    private const string INTERSTITIAL_ID = "ca-app-pub-4128501448856864/5825947238";
    private AdMobPlugin admob;

    public bool ShowFullOnStart = false;

    void Start()
    {
        admob = GetComponent<AdMobPlugin>();
        admob.CreateBanner(adUnitId: AD_UNIT_ID,
                           adSize: AdMobPlugin.AdSize.BANNER,
                           isTopPosition: true,
                           interstitialId: INTERSTITIAL_ID,
                           isTestDevice: false);
        if (ShowFullOnStart)
        {
            int rd = Random.Range(0, 100);
            if (rd <= 30 && LoadingStartMenu.showFullBanner)
            {
                admob.RequestInterstitial();
            }
        }
    }

    void OnEnable()
    {
        AdMobPlugin.AdClosed += () => { Debug.Log("AdClosed"); };
        AdMobPlugin.AdFailedToLoad += () => { Debug.Log("AdFailedToLoad"); };
        AdMobPlugin.AdLeftApplication += () => { Debug.Log("AdLeftApplication"); };
        AdMobPlugin.AdOpened += () => { Debug.Log("AdOpened"); };

        AdMobPlugin.InterstitialClosed += () => { Debug.Log("InterstitialClosed"); };
        AdMobPlugin.InterstitialFailedToLoad += () => { Debug.Log("InterstitialFailedToLoad"); };
        AdMobPlugin.InterstitialLeftApplication += () => { Debug.Log("InterstitialLeftApplication"); };
        AdMobPlugin.InterstitialOpened += () => { Debug.Log("InterstitialOpened"); };

        AdMobPlugin.AdLoaded += HandleAdLoaded;
        AdMobPlugin.InterstitialLoaded += HandleInterstitialLoaded;
    }

    void OnDisable()
    {
        AdMobPlugin.AdLoaded -= HandleAdLoaded;
        AdMobPlugin.InterstitialLoaded -= HandleInterstitialLoaded;
    }

    void HandleAdLoaded()
    {
#if !UNITY_EDITOR
		admob.ShowBanner();
#endif
    }

    void HandleInterstitialLoaded()
    {
#if !UNITY_EDITOR
		admob.ShowInterstitial();
#endif
    }

    public void ShowBanner()
    {
#if !UNITY_EDITOR
        admob.RequestAd();
#endif
    }

    public void HideBanner()
    {
#if !UNITY_EDITOR
        admob.HideBanner();
#endif
    }
}
