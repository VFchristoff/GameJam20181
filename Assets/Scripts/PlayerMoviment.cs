using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoviment : MonoBehaviour
{

    //Velocidade do Player
    public float speed;
	Animator animator;

	//private bool soundon = false;
    private Rigidbody2D rb2d;
    private Vector3 movement;
    private float horizontal_movement;
    private float vertical_movement;


    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
		animator = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        horizontal_movement = Input.GetAxisRaw("Horizontal");
        vertical_movement = Input.GetAxisRaw("Vertical");
        Move(horizontal_movement, vertical_movement);
		animator.SetFloat("horizontal", horizontal_movement);
		animator.SetFloat("vertical", vertical_movement);
		/*

		if (Input.GetKeyDown (KeyCode.DownArrow) || Input.GetKeyDown (KeyCode.UpArrow) || 
			Input.GetKeyDown (KeyCode.RightArrow) || Input.GetKeyDown (KeyCode.LeftArrow)) {
			soundon = true;
		} else if (
			(Input.GetKeyUp (KeyCode.DownArrow) || Input.GetKeyUp (KeyCode.UpArrow) || Input.GetKeyDown (KeyCode.RightArrow) || Input.GetKeyDown (KeyCode.LeftArrow)) &&
			!(Input.GetKey (KeyCode.DownArrow) || Input.GetKey (KeyCode.UpArrow) || Input.GetKey (KeyCode.RightArrow) || Input.GetKey (KeyCode.LeftArrow))
		) {
			soundon = false;
		}

		if (soundon && !this.GetComponent<AudioSource>().isPlaying) {
			this.GetComponent<AudioSource> ().Play ();
		} else if (!soundon) {
			this.GetComponent<AudioSource> ().Stop ();
		}
*/
    }

	public void AnimationEvent () {
		this.GetComponent<AudioSource> ().Play ();
	}

    private void Move(float hm, float vm)
    {
        movement.Set(hm, vm, 0);
        movement.z = 0f;
        movement = movement.normalized * speed * Time.deltaTime;
        rb2d.MovePosition(transform.position + movement);
    }

}
