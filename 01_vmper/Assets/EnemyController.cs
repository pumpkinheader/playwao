using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {

	public GameObject bulletObj;
	public string enemyType; //後でenumに帰ること。
	private EnemyMove em;
	int count = 0;

	// Use this for initialization
	void Start () {
		//float y = (float) UnityEngine.Random.Range (3,-3);
		//this.gameObject.transform.position = new Vector3 (12f,y,0f);
		if(enemyType == "st")
			em = this.gameObject.GetComponent<EnemyMove>();
	}
	
	// Update is called once per frame
	void Update () {
		count++;
		em.move ();
		if (count > 30) {
			count = 0;
			attack();
		}
	}

	public void attack(){
		var pos = this.gameObject.transform.position + new Vector3 (1f, 0f, 0f);
		Instantiate (bulletObj, pos, this.gameObject.transform.rotation);
	}

}
