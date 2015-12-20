using UnityEngine;
using System.Collections;

public class PlayerBullet : BulletScript {

	static public GameObject player;
	// Use this for initialization
	void Start () {
			player = GameObject.Find ("images");
		speed = new Vector3 (0.5f,0f,0f);
		this.gameObject.transform.position = player.gameObject.transform.position + new Vector3 (1f,0f,0f);
	}
		

	void OnTriggerEnter2D(Collider2D collision){
		if (collision.gameObject.name.Contains ("vx_chara07_a_cvt_1_2_8")) {
			return ;
		}
		Destroy (collision.gameObject);
		Destroy (this.gameObject);
	}

}
