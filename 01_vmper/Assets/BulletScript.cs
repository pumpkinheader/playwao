using UnityEngine;
using System.Collections;

public class BulletScript : MonoBehaviour {

	public Vector3 speed;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (this.gameObject.transform.position.x < -15f) {
			Destroy (this.gameObject);
		} else if(this.gameObject.transform.position.x > 10f) {
			Destroy (this.gameObject);
		}else {
			this.gameObject.transform.position += speed/20f;
		}
	}
}
