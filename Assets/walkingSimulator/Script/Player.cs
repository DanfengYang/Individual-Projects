using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    float speed = 0.02f;
    string titleText = "Snowmountain Meditation"+ "\r\n"+ "(Use right and left arrow to walk)";
    string leftText = "I'll check what's up behind.";
    string rightText = "I'll move forward.";
   

    [SerializeField] private TMP_Text textobj;
    [SerializeField] private TMP_FontAsset font1, font2;
    //serializeField: add it onto interface
    //private: only works on one object

    //Player.GetComponent<SpriteRenderer.color>();

    public SpriteRenderer sr;
    


    // Start is called before the first frame update
    void Start()
    {
        textobj.text = titleText;
        textobj.font = font2;

        //sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow)) {
            transform.Translate(-speed, 0f, 0f);
            //draw to screen 
            textobj.text = leftText;

            textobj.font = font1;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(speed, 0f, 0f);

            //change text to a different text
            textobj.text = rightText;
            //draw to screen
            textobj.font = font1;

        }

        if (Input.GetKeyDown(KeyCode.Space)) {

            //change text back to title
            textobj.text = titleText;
            textobj.font = font2;


            //change color of sprite

            float colorR = Random.Range(0f, 1f);
            float colorG = Random.Range(0f, 1f);
            float colorB = Random.Range(0f, 1f);

            sr.color = new Color(colorR, colorG, colorB);

        }
    }
}
