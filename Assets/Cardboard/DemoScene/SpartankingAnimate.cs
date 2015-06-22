using UnityEngine;
using System.Collections;

public class SpartankingAnimate : MonoBehaviour {
	string mAnimationName;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Animation> ().PlayQueued (mAnimationName);
		if(!GetComponent<Animation> ().IsPlaying(mAnimationName))
			GetComponent<Animation> ().Play (mAnimationName);
	}

	public void SetGazedAt(bool gazedAt) {
		//	System.Console.WriteLine("kevin debug test");
		if (gazedAt)
			mAnimationName = "run";
		else
			mAnimationName = "idle";
	}
}
