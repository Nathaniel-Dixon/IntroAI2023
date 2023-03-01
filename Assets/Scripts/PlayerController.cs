using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   
   
    public float speed = 20f;
	public float jumpHeight = 1.0f;
	
	//public float gravity = 5f;
	
	//float velocityY = 0;
    
   // public enum Movement {KeyCode.W, KeyCode.S, KeyCode.A, KeyCode.D,}
	//public enum MovementDirection
    //public enum Movement {Fowards, Backwards, Left, Right,}
	//private CharacterController controller;

 void Start()
 {
     //controller = GetComponent<CharacterController>();
	 //controller = gameObject.AddComponent<CharacterController>();
 }
    // Update is called once per frame
    /*void Update()
    {
		//getkeydown (tapping key) semi auto getkey (pressing key down) full auto
       // bool input = Input.GetKey(KeyCode.D);
		
		if(Input.GetKey(KeyCode.W))
			//if(
		{
			Vector3 playerPosition = transform.position;
			//delta time, keeping movement the same across framerates
			//playerPosition.x = playerPosition.x + 1f * Time.deltaTime;
			playerPosition.z += speed * Time.deltaTime;
			
			transform.position = playerPosition;
			//Debug.Log(input);
		}
		if(Input.GetKeyDown(KeyCode.Space))
			//if(
		{
			Vector3 playerPosition = transform.position;
			//delta time, keeping movement the same across framerates
			//playerPosition.x = playerPosition.x + 1f * Time.deltaTime;
			playerPosition.y += speed * Time.deltaTime;
			
			transform.position = playerPosition;
			//Debug.Log(input);
		}
		if(Input.GetKey(KeyCode.S))
			//if(
		{
			Vector3 playerPosition = transform.position;
			//delta time, keeping movement the same across framerates
			//playerPosition.x = playerPosition.x + 1f * Time.deltaTime;
			playerPosition.z -= speed * Time.deltaTime;
			
			transform.position = playerPosition;
			//Debug.Log(input);
		}
		if(Input.GetKey(KeyCode.A))
			//if(
		{
			Vector3 playerPosition = transform.position;
			//delta time, keeping movement the same across framerates
			//playerPosition.x = playerPosition.x + 1f * Time.deltaTime;
			playerPosition.x -= speed * Time.deltaTime;
			
			transform.position = playerPosition;
			//Debug.Log(input);
		}
		if(Input.GetKey(KeyCode.D))
			//if(
		{
			Vector3 playerPosition = transform.position;
			//delta time, keeping movement the same across framerates
			//playerPosition.x = playerPosition.x + 1f * Time.deltaTime;
			playerPosition.x += speed * Time.deltaTime;
			
			transform.position = playerPosition;
			//Debug.Log(input);
		} */
		void Update()
	{
			float horizontal = Input.GetAxis("Horizontal"); //A - left   D - right
		float vertical = Input.GetAxis("Vertical");        // W - foward S - back
		
		Camera camera = Camera.main;
		
		Vector3 forward = camera.transform.forward;
		Vector3 right = camera.transform.right;
		
		forward.y = 0f;
		right.y = 0f;
		forward.Normalize();
		right.Normalize();
		
		Vector3 desiredMoveDirection = (forward * vertical) + ( right * horizontal);
desiredMoveDirection.Normalize();
		//Vector3 moveDirection = new Vector3(vertical,0f,horizontal);
		transform.position += desiredMoveDirection * speed * Time.deltaTime;
    }
}
