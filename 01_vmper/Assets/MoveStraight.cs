using UnityEngine;
using System.Collections;

public class MoveStraight : MonoBehaviour {

	private Transform parentTransform;
	[SerializeField]
	private GameObject target;
	private Transform targetTransform;
	private Vector3 vector;
	
	[SerializeField]
	private float moveRatio;
	// Use this for initialization
	void Start () {
		Initialize();
	}
	
	// Update is called once per frame
	void Update () {
		UpdatePosition();
	}
	
	public void Initialize(){
		parentTransform = GetParentTransform();
		targetTransform = GetTragetTransform();
	}
	public Transform GetParentTransform(){
		return gameObject.transform.parent.gameObject.transform;
	}
	public Transform GetTragetTransform(){
		return target.gameObject.transform;
	}
	
	public void UpdatePosition(){
		parentTransform.position = parentTransform.position + GetDirection() * moveRatio;
	}
	
	public Vector3 GetDirection(){
		return Normalized(targetTransform.position - parentTransform.position) ;
	}
	
	private Vector3 Normalized(Vector3 vector){
		float length = Mathf.Sqrt(vector.x * vector.x + vector.y * vector.y);
		return new Vector3(vector.x / length, vector.y / length);
	}
}
