using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody2D myRigidBody;

        public float speedX = 100;        
        public float speedY = 100;        

    // Start is called before the first frame update
    void Start()
    {
        myRigidBody = this.gameObject.GetComponent<Rigidbody2D>();

        Vector2 force = new Vector2(speedX, speedY);

        myRigidBody.AddForce(force);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
