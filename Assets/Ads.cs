using UnityEngine;
using System.Collections;
using UnityEngine.Advertisements;

public class Ads : MonoBehaviour {
	public void ShowAd() {
		if (Advertisement.IsReady()) {
			Advertisement.Show();
		}
	}

	// Use this for initialization
	void Start () {
		//ShowAd();
	}
	
	// Update is called once per frame
	void Update () {
		ShowAd();
	}
}
