using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Vector3 = System.Numerics.Vector3;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] private Sprite deathPose;
    [SerializeField] private Sprite happy;
    private SpriteRenderer spriteRenderer;
    private Rigidbody2D rb2d;
    // Start is called before the first frame update
    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        rb2d = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Ground") 
        {
            Debug.Log("You Lose!");
            spriteRenderer.sprite = deathPose;
            spriteRenderer.enabled = true;
            foreach (Transform child in transform)
            {
                child.gameObject.SetActive(false);
            }
            transform.Translate(0, 2, 0);
            transform.Rotate(0,0,180);
            rb2d.constraints = RigidbodyConstraints2D.FreezeAll;
            Invoke("ReloadScene", 1f);
        }
        else if (other.gameObject.tag == "Finish")
        {
            spriteRenderer.sprite = happy;
            spriteRenderer.enabled = true;
            foreach (Transform child in transform)
            {
                child.gameObject.SetActive(false);
            }
            Invoke("ReloadScene", 2f);
        }
    }

    private void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
