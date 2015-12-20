using UnityEngine;
using System.Collections;

public class BossController : MonoBehaviour{

	int count = 0;
	// Use this for initialization
	private EnemyMove em;
	public string enemyType;
	public GameObject bulletObj;
	public GameObject bulletObj2;

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
		if (count % 30 == 0) {
			attack();
		}else if (count % 45 == 0){
			count = 0;
			attack2();
		}
	
	}
	public void attack(){
		var pos = this.gameObject.transform.position + new Vector3 (1f, 0f, 0f);
		Instantiate (bulletObj, pos, this.gameObject.transform.rotation);
	}
	void attack2(){
		var pos = this.gameObject.transform.position + new Vector3 (1f, 0f, 0f);
		Instantiate (bulletObj2, pos, this.gameObject.transform.rotation);
	}
	
}
