using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Coroutine : MonoBehaviour
{
    //framerate dependent
    public Vector3 pointB = new Vector3(6, 3,0);
    public Vector3 pointC = new Vector3(6, -3, 0);
    public Vector3 pointD = new Vector3(-6, -3, 0);
    public Vector3 pointA = new Vector3(-6, 3, 0);

    bool phase1 = true;
    bool phase2 = false;
    bool phase3 = false;
    bool phase4 = false;
    bool phase5 = false;
    bool phase6 = false;

    //coroutine is a function running for more than one frame
    IEnumerator Position()
    {

        //Vector3 pointA = transform.position;
        float duration = 3f;


        SpriteRenderer theSprite = GetComponent<SpriteRenderer>();
        theSprite.drawMode = SpriteDrawMode.Sliced;

        //Color colorA = Color.yellow;

        while (phase1 == true)
        {
            for (float t = 0f; t < 1f; t += Time.deltaTime / duration)
            {

                transform.position = Vector3.Lerp(pointA, pointB, t);
                theSprite.color = Color.Lerp(Color.yellow, Color.black, t);
                theSprite.size += new Vector2(0.005f, 0.005f);
                yield return 0;
            }
            transform.position = pointB;
            phase1 = false;
            phase2 = true;
        }

        

            //Vector3 start = transform.position;



            while (phase2 == true)
            {

                for (float t = 0f; t < 1f; t += Time.deltaTime / duration)
            {

                transform.position = Vector3.Lerp(pointB, pointC, t);
                theSprite.color = Color.Lerp(Color.black, Color.red, t);
                theSprite.size += new Vector2(-0.006f, -0.006f);
                yield return 0;
            }
            transform.position = pointC;
            phase2 = false;
            phase3 = true;
        }

        while (phase3 == true)
        {

            for (float t = 0f; t < 1f; t += Time.deltaTime / duration)
            {

                transform.position = Vector3.Lerp(pointC, pointD, t);
                theSprite.color = Color.Lerp(Color.red, Color.blue, t);
                theSprite.size += new Vector2(0.004f, 0.004f);
                yield return 0;
            }
            transform.position = pointD;
            phase3 = false;
            phase4 = true;
        }
        while (phase4 == true)
        {

            for (float t = 0f; t < 1f; t += Time.deltaTime / duration)
            {

                transform.position = Vector3.Lerp(pointD, pointC, t);
                theSprite.color = Color.Lerp(Color.blue, Color.red, t);
                theSprite.size += new Vector2(-0.004f, -0.004f);
                yield return 0;
            }
            transform.position = pointC;
            phase4 = false;
            phase5 = true;
        }
        while (phase5 == true)
        {

            for (float t = 0f; t < 1f; t += Time.deltaTime / duration)
            {

                transform.position = Vector3.Lerp(pointC, pointB, t);
                theSprite.color = Color.Lerp(Color.red, Color.black, t);
                theSprite.size += new Vector2(0.006f, 0.006f);
                yield return 0;
            }
            transform.position = pointB;
            phase5 = false;
            phase6 = true;
        }
        while (phase6 == true)
        {

            for (float t = 0f; t < 1f; t += Time.deltaTime / duration)
            {

                transform.position = Vector3.Lerp(pointB, pointA, t);
                theSprite.color = Color.Lerp(Color.black, Color.yellow, t);
                theSprite.size += new Vector2(-0.005f, -0.005f);
                yield return 0;
            }
            transform.position = pointA;
            phase6 = false;


            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    

    


    //yield return null;//this also wait for 1 frame
    //yield return new WaitForSeconds(1.0f);//(Wait 1 frame)


    void Update()
    {

        //to call corountine you must call it
        if (Input.GetKeyDown(KeyCode.Space)){
            StartCoroutine(Position());
      
        }


        // smoothly move 10% to destination every frame without coroutine
        //transform.position += (destination - transform.position) * 0.1f;
    }
}
