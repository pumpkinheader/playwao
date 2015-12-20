using UnityEngine;
using System.Collections;

public class BossMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void move(){
		if (gameObject.transform.position.x > 3f){
			return;
		}
		this.gameObject.transform.position += new Vector3 (-0.1f, 0f, 0f);

	}
}
