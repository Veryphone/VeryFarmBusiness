using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using Prime31;


#if UNITY_ANDROID
public class VungleAndroidManager : AbstractManager
{
	// Fired when a Vungle ad starts
	public static event Action onAdStartEvent;

	// Fired when a Vungle ad finishes
	public static event Action onAdEndEvent;

	// Fired when a Vungle ad is cached and ready to be displayed
	public static event Action onCachedAdAvailableEvent;

	// Fired when a Vungle video is dismissed. Includes the watched and total duration in milliseconds.
	public static event Action<double,double> onVideoViewEvent;


	static VungleAndroidManager()
	{
		AbstractManager.initialize( typeof( VungleAndroidManager ) );
	}


	void onAdStart( string empty )
	{
		if( onAdStartEvent != null )
			onAdStartEvent();
	}


	void onAdEnd( string empty )
	{
		if( onAdEndEvent != null )
			onAdEndEvent();
	}


	void onCachedAdAvailable( string empty )
	{
		if( onCachedAdAvailableEvent != null )
			onCachedAdAvailableEvent();
	}


	void onVideoView( string str )
	{
		if( onVideoViewEvent != null )
		{
			var parts = str.Split( new char[] { '-' } );
			if( parts.Length == 2 )
				onVideoViewEvent( double.Parse( parts[0] ), double.Parse( parts[1] ) );
		}
	}

}
#endif
