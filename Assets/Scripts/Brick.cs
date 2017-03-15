using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {

    //public AudioClip crack;
    public Sprite[] hitSprites;
    public static int breakableCount = 0;
    private int timesHit;
    private LevelManager levelManager;
    private bool isBreakable;
    // Use this for initialization
    void Start() {
        isBreakable = (this.tag == "Breakable"); //liczenie brakable
        if (isBreakable)
        {
            breakableCount++;
            
        }

        levelManager = GameObject.FindObjectOfType<LevelManager>();
        timesHit = 0;
    }

    // Update is called once per frame
    void Update() {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //AudioSource.PlayClipAtPoint(crack, transform.position); - dźwięk przy uderzeniu 
        
        timesHit = timesHit + 1;
        int maxHits = hitSprites.Length + 1;
        if (timesHit >= maxHits)
        {
            breakableCount--;
            levelManager.BrickDestryed();
            Destroy(gameObject);
        } else
        {
            LoadSprite();
        }

    }
 
    void LoadSprite()
    {
        
        if (isBreakable)
        {
            
        handleHits();
        }
    }

    void handleHits()
    {
        int spriteIndex = timesHit - 1;
        // jeżeli nie ma sprita w componentach zostawia podstawowy
        if (hitSprites[spriteIndex])
        {
            this.GetComponent<SpriteRenderer>().sprite = hitSprites[spriteIndex];
        }
    }


}
    
   

