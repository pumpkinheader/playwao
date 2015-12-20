using UnityEngine;
using System.Collections;

public class EnemyBullet : BulletScript {

	static public GameObject player;

	// Use this for initialization
	void Start () {
		player = GameObject.Find ("images");
		//speed = new Vector3 (-0.1f,0f,0f);
		calDirection ();
	}

	void calDirection(){
		speed = player.gameObject.transform.position - this.gameObject.transform.position;
		speed = waru (speed, speed);
	}
	
	// static な追加メソッドで解決する
	private Vector3 waru(Vector3 p, Vector3 c){
		p.x /= -c.x;
		p.y /= -c.y;
		return p;
	}
}
