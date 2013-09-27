using UnityEngine;
using System.Collections;

public class CherControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
		collider.material.dynamicFriction = 1;
	}
	
	public GameObject dude;
	public GameObject weapon;
	public GameObject weapTrigger;
	bool ariel;
	float vertMove;
	
	public int incSpeed;
	public int maxSpeed;
	//int horzSpeed;
	//int vertSpeed;
	
	// Update is called once per frame
	void FixedUpdate () {		
		if(Input.GetButton("Horizontal") && Mathf.Abs (rigidbody.velocity.x) < maxSpeed){
			rigidbody.velocity = new Vector3((rigidbody.velocity.x+(incSpeed*(int)Input.GetAxis("Horizontal"))), rigidbody.velocity.y, rigidbody.velocity.z);
		}
		
		if(Input.GetButton ("Vertical") && Mathf.Abs (rigidbody.velocity.z) < maxSpeed){
			rigidbody.velocity = new Vector3(rigidbody.velocity.x, rigidbody.velocity.y, (rigidbody.velocity.z+(incSpeed*(int)Input.GetAxis("Vertical"))));
		}
		
		//transform.LookAt (+this.transform.position);
		dude.transform.Rotate(new Vector3(rigidbody.velocity.z, 0, -rigidbody.velocity.x), Space.World);
		
		if(Input.GetButton ("Attack")){
			weapon.animation.Play ("Attack");
		}
		
		if(weapon.animation.isPlaying){
			weapTrigger.collider.enabled = true;
		}else{
			weapTrigger.collider.enabled = false;
		}
		
		if(Input.GetButton ("Jump")){
			rigidbody.velocity = Vector3.up*10;
		}
	}
		
	void OnGUI(){
		GUI.Box (new Rect(20, 20, 100, 100), rigidbody.velocity.ToString ());
	}
}
