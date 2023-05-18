using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public static bool InAir = true;
    Animator PlayerAni;
    Rigidbody2D PlayerSprite;
    int GemsWon = 0;

    // Start is called before the first frame update
    void Start()
    {
        PlayerAni = GetComponent<Animator>();
        PlayerSprite = GetComponent<Rigidbody2D>();
    }

    void OnCollisionEnter2D(Collision2D Collide)
    {
	if (Collide.gameObject.CompareTag("Ground"))
	{
	    InAir = false; // Makes sure the player is not in the air
	}
	if (Collide.gameObject.CompareTag("Danger"))
	{
            SoundHandler.Deathsound.Play();
	    PlayerAni.SetTrigger("Death"); // Triggers the death animation
	    PlayerSprite.bodyType = RigidbodyType2D.Static; // Freezes the players movement
            Invoke("ReloadLevel", 3f);
	}
	if (Collide.gameObject.CompareTag("Win"))
	{
            SoundHandler.Winsound.Play();
	    PlayerSprite.bodyType = RigidbodyType2D.Static; // Freezes the players movement
            Invoke("NextLevel", 3f);
	}
    }
   
    void OnTriggerEnter2D(Collider2D Hit)
    {
        if (Hit.gameObject.CompareTag("Gem"))
        {
	   SoundHandler.Gemsound.Play();
	   GemsWon = GemsWon + 1;
	   FeedbackText.GemsMessage.text = "Gems = " + GemsWon;
	   Hit.gameObject.transform.position = new Vector3(-30f, 0f, 0f);
	}
    }

    void ReloadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
    void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
