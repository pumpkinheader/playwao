using UnityEngine;
using System.Collections;

public class SceneManager : MonoBehaviour {

	private int count=0;
	public GameObject enemy;
	float s = 2f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		count ++;

//		if (count > s){
//			count = 0;
//			s = UnityEngine.Mathf.Exp ((float)count / 10f);
//			Instantiate (enemy);
//		}
		if (count > 15) {
			count = 0;
			Instantiate(enemy);
		}
	}
}
