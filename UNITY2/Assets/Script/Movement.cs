using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Movement : MonoBehaviour
{
    int num = 1;
    public float speed = 5.0f;


    // Update is called once per frame
    void Update()
    {
        float xMove = Input.GetAxisRaw("Horizontal");
        float yMove = Input.GetAxisRaw("Vertical");


        float xMovement = xMove * speed * Time.deltaTime;
        float yMovement = yMove * speed * Time.deltaTime;
        transform.Translate(xMovement, yMovement, 0);

      
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }



    private void OnTriggerEnter2D(Collider2D other)

    {
        Debug.Log("Triggered");

        if (other.gameObject.tag == "Goal")
        {
            Debug.Log("Area Cleared");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
               
        
        
        


        }



    }



}
