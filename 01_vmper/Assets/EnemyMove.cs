using UnityEngine;
using System.Collections;

public class EnemyMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void move(){
		this.gameObject.transform.position += new Vector3 (-0.1f, 0f, 0f);
	}
}
