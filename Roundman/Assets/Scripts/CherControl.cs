using UnityEngine;
using System.Collections;

public class CherControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	public GameObject dude;
	public GameObject weapon;
	public GameObject weapTrigger;
	bool ariel;
	float vertMove;
	
	// Update is called once per frame
	void FixedUpdate () {
		/*CharacterController controller = GetComponent<CharacterController>();
		
		float moveZ = Input.GetAxis("Vertical")*5;
		float rotY = Input.GetAxis ("Horizontal")*-5;
		float moveX = Input.GetAxis ("Horizontal")*5;
		float rotX = Input.GetAxis ("Vertical")*5;
		
		transform.LookAt (new Vector3(moveX, 0, moveZ)+this.transform.position);
		controller.SimpleMove (new Vector3(moveX, 0, moveZ));
		dude.transform.Rotate(new Vector3(controller.velocity.z, 0, -controller.velocity.x), Space.World);
		//dude.transform.Rotate (new Vector3(rotX, 0, rotY), Space.World);
		
		if(Input.GetButton ("Attack")){
			weapon.animation.Play ("Attack");
		}
		
		if(weapon.animation.isPlaying){
			weapTrigger.collider.enabled = true;
		}else{
			weapTrigger.collider.enabled = false;
		}*/
		
		if(rigidbody.velocity.y == 0){
			ariel = false;
		}
		
		float moveZ = Input.GetAxis("Vertical")*Time.deltaTime*5;
		float moveX = Input.GetAxis ("Horizontal")*Time.deltaTime*5;
		
		transform.LookAt (new Vector3(moveX, 0, moveZ)+this.transform.position);
		rigidbody.MovePosition (rigidbody.position+new Vector3(moveX, 0, moveZ));
		dude.transform.Rotate(new Vector3(rigidbody.velocity.z, 0, -rigidbody.velocity.x), Space.World);
		
		if(Input.GetButton ("Attack")){
			weapon.animation.Play ("Attack");
		}
		
		if(weapon.animation.isPlaying){
			weapTrigger.collider.enabled = true;
		}else{
			weapTrigger.collider.enabled = false;
		}
		
		if(Input.GetButton ("Jump") && !ariel){
			ariel = true;
		}
		
		if(ariel){
			//rigidbody.MovePosition(rigidbody.position+(Vector3.up*(
		}
	}
}
