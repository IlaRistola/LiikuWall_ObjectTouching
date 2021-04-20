using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchableItems : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite newSprite;
    public Transform itemItSelf;
    public AudioClip touchSound;
    bool firstTouch;
    //public Text txt;
    //private int currentscore = 0;
    //private GameObject ProjectileCollaider;

    //public GameObject ItemHolder;

    // Start is called before the first frame update
    void Start()
    {
    firstTouch = true;
        //txt = gameObject.GetComponent<Text>();
        //txt.text = "Score : " + currentscore + "/ 10";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ChangeSprite()
    {
        spriteRenderer.sprite = newSprite;
        
        if (firstTouch == true)
            {
           AudioSource touchSound = GetComponent<AudioSource>();
            touchSound.Play();
            firstTouch = false;
            //currentscore++;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        /*if (collision.gameObject.tag == "UnCollision")
        {
        
        }*/
        
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if (collision.gameObject.name == "RightHand" || collision.gameObject.name == "LeftHand")
        {
            ChangeSprite();
        }

        if (collision.gameObject.name == "BottomLine")
        {

            CreateObject();

        }

    }

    void CreateObject()
    {
        float range = Random.Range(-29.50f, 29.50f + 1);
        Instantiate(Resources.Load("Item"), new Vector3(range, 34, 42), Quaternion.identity);
        Destroy(this.gameObject);
    }
}

// Radical Rabbit 2020 //
