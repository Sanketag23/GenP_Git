
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
   public Rigidbody rb;
   public float forwardforce=2000f;
   public float sidewaysforce=500f;
  
    // Update is called once per frame
    void FixedUpdate()
    {
        // add a forward force
      
      if(Input.GetKey("d")){
        rb.AddForce(sidewaysforce*Time.deltaTime,0,0,ForceMode.VelocityChange);
      }
      if(Input.GetKey("a")){
        rb.AddForce(-sidewaysforce*Time.deltaTime,0,0,ForceMode.VelocityChange);
      }
     if(Input.GetKey("w")){
        rb.AddForce(0,0,forwardforce*Time.deltaTime);
      }
      if(Input.GetKey("x")){
        rb.AddForce(0,0,-forwardforce*Time.deltaTime);
    }
    if(rb.position.y<0){
 SceneManager. LoadScene (SceneManager.GetActiveScene (). buildIndex + 1) ;
    }
}
}