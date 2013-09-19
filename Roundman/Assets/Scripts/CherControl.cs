using UnityEngine;
using System.Collections;

public class CherControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	public GameObject dude;
	public GameObject weapon;
	public GameObject weapTrigger;
	
	// Update is called once per frame
	void Update () {
		float moveZ = Input.GetAxis("Vertical")*Time.deltaTime*5;
		float rotY = Input.GetAxis ("Horizontal")*-5;
		float moveX = Input.GetAxis ("Horizontal")*Time.deltaTime*5;
		float rotX = Input.GetAxis ("Vertical")*5;
		
		this.transform.LookAt (new Vector3(moveX, 0, moveZ)+this.transform.position);
		this.transform.position += new Vector3(moveX, 0, moveZ);
		dude.transform.Rotate (new Vector3(rotX, 0, rotY), Space.World);
		
		if(Input.GetButton ("Attack")){
			weapon.animation.Play ("Attack");
		}
		
		if(weapon.animation.isPlaying){
			weapTrigger.collider.enabled = true;
		}else{
			weapTrigger.collider.enabled = false;
		}
	}
}
