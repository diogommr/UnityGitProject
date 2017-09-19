using UnityEngine;
using System.Collections;
using UnityEngine.Analytics;
using System.Collections.Generic;

public class AnalyticsScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		LevelUp();
		Transaction();
		DemographicInfo();
	}

	void LevelUp() {
		Analytics.CustomEvent("levelUp", new Dictionary<string, object>
		{
			{ "newLevel", 2 },
			{ "trigger", "purchase" }
		});
	}

	void Transaction() {
		Analytics.Transaction("levelUp", 1.00m, "EUR", null, null);
	}

	void DemographicInfo() {
		Gender gender = Gender.Male;
		Analytics.SetUserGender(gender);

		int birthYear = 1994;
		Analytics.SetUserBirthYear(birthYear);
	}
	

	// Update is called once per frame
	void Update () {
	
	}
}
