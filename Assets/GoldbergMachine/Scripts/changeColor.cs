using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeColor : MonoBehaviour
{




    SpriteRenderer spriteRenderer;


    bool touched = false;


    

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        //this line needs to be in start to be executed 
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!touched && collision.gameObject.tag == "hitter")
            //if touched then don't change color
        {
           
            touched = true;
            Debug.Log("collided");
            float colorR = Random.Range(0f, 1f);
            float colorG = Random.Range(0f, 1f);
            float colorB = Random.Range(0f, 1f);

            spriteRenderer.color = new Color(colorR, colorG, colorB);
        }

        //if (collision.gameObject.tag == "hitter"){
    }
    void Update()
    {
        //if (touched == true){
            //variable type should only exist when declared
           // Debug.Log("collided bool = true");
            //float colorR = Random.Range(0f, 1f);
            //float colorG = Random.Range(0f, 1f);
            //float colorB = Random.Range(0f, 1f);

           // spriteRenderer.color = new Color(colorR, colorG, colorB);
        }
    }


    
