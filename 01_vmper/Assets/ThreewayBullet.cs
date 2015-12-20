using UnityEngine;
using System.Collections;

public class ThreewayBullet : BulletScript {

	
	// Use this for initialization
	void Start () {
		calDirection ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void calDirection(){
		Debug.Log("caldirection");
		speed = this.gameObject.transform.position - this.gameObject.transform.position;
		speed = waru (speed, speed);
	}
	
	// static な追加メソッドで解決する
	private Vector3 waru(Vector3 p, Vector3 c){
		p.x /= c.x;
		p.y /= c.y;
		return p;
	}
}
