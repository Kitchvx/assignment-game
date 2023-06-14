using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D PlayerSprite;
    float MoveX;
    Animator PlayerAni;
    SpriteRenderer PlayerImage;

    Transform Movement;
    public static float CamXpos; // Camera X movement

    // Start is called before the first frame update
    void Start()
    {
        PlayerSprite = GetComponent<Rigidbody2D>();
	PlayerAni = GetComponent<Animator>();
	PlayerImage = GetComponent<SpriteRenderer>();
        Movement = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveX = Input.GetAxis("Horizontal");
	PlayerSprite.velocity = new Vector2(MoveX * 7f, PlayerSprite.velocity.y);
	if (Input.GetButtonDown("Jump") && !Collisions.InAir)
	{
	    PlayerSprite.velocity = new Vector2(PlayerSprite.velocity.x, 8f);
	    Collisions.InAir = true;
	}
	
	if (MoveX > 0f) // To the right
	{
	    PlayerAni.SetBool("Idle", false);
	    PlayerImage.flipX = false;
	}
	
	if (MoveX < 0f) // To the left
	{
	    PlayerAni.SetBool("Idle", false);
	    PlayerImage.flipX = true;
	}

	if (MoveX == 0f) // No movement
	{
	    PlayerAni.SetBool("Idle", true);
	}
	
	CamXpos = Movement.position.x;
    }
}
