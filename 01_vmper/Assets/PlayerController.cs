using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public GameObject bullet;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		float mn = 0.08f; 
		if (Input.GetKey (KeyCode.W)) {
			move (new Vector3(0f,mn,0f));
		} else if (Input.GetKey (KeyCode.S)) {
			move (new Vector3(0f,-mn,0f));
		} else if (Input.GetKey (KeyCode.A)) {
			move (new Vector3(-mn,0f,0f));
		} else if (Input.GetKey (KeyCode.D)) {
			move (new Vector3(mn,0f,0f));
		}
		if (Input.GetKey(KeyCode.J)){
			Instantiate(bullet);
		}
	}

	void move(Vector3 v){
		this.gameObject.transform.position += v;
	}
}
