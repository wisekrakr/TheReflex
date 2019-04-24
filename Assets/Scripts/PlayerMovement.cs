using UnityEngine;

public class PlayerMovement : MonoBehaviour{

    public Rigidbody rigidBody;   

    public float forwardForce = 2000f;
    public float strafeForce = 15f;   
   

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();

        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey("d"))
        {           
            rigidBody.AddForce(strafeForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }else if (Input.GetKey("a"))
        {            
            rigidBody.AddForce(-strafeForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rigidBody.position.y < -1f)
        {
            FindObjectOfType<GameManager>().GameOver();
        }
    }

    void FixedUpdate()
    {
        rigidBody.AddForce(0, 0, forwardForce * Time.deltaTime);
    }
    
}
