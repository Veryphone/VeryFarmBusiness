using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;




public class VungleAndroidEventListener : MonoBehaviour
{
#if UNITY_ANDROID
	void OnEnable()
	{
		// Listen to all events for illustration purposes
		VungleAndroidManager.onAdStartEvent += onAdStartEvent;
		VungleAndroidManager.onAdEndEvent += onAdEndEvent;
		VungleAndroidManager.onCachedAdAvailableEvent += onCachedAdAvailableEvent;
		VungleAndroidManager.onVideoViewEvent += onVideoViewEvent;
	}

	void OnDisable()
	{
		// Remove all event handlers
		VungleAndroidManager.onAdStartEvent -= onAdStartEvent;
		VungleAndroidManager.onAdEndEvent -= onAdEndEvent;
		VungleAndroidManager.onCachedAdAvailableEvent -= onCachedAdAvailableEvent;
		VungleAndroidManager.onVideoViewEvent -= onVideoViewEvent;
	}



	void onAdStartEvent()
	{
		Debug.Log( "onAdStartEvent" );
	}


	void onAdEndEvent()
	{
		Debug.Log( "onAdEndEvent" );
	}
	
	
	void onCachedAdAvailableEvent()
	{
		Debug.Log( "onCachedAdAvailableEvent" );
	}


	void onVideoViewEvent( double watched, double length )
	{
		Debug.Log( "onVideoViewEvent. watched: " + watched + ", length: " + length );
	}

#endif
}
