
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    
   public int speed = 5; // Speed of the player movement s1
   Rigidbody2D rb; // Reference to the Rigidbody2D component s1
   public GameObject bulletPrefab; // Reference to the bullet prefab s2
   public Transform spawnBullet; // Reference to the spawn point for bullets s2



   //step3
   public SpriteRenderer playerSpriteRenderer; // Reference to the SpriteRenderer component of the player s3

   //step4
   public Transform gunTransform; // Reference to the gun's transform for rotation s4

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // Get the Rigidbody2D component attached to the player s1
        
    }

    // Update is called once per frame
    void Update()
    {
        //step1
        // to get the input from the player for movement
        float moveX = Input.GetAxis("Horizontal");//A,D
float moveY = Input.GetAxis("Vertical");//W,S

Vector2 move = new Vector2(moveX,moveY);// join the tow cordinates to make a single direction vector

rb.linearVelocity  = move*speed;//forces to go 
        

//step2
        //shooting 
        if(Input.GetKeyDown(KeyCode.Space))//IF SPACE WAS PRESSED
        {
            Instantiate(bulletPrefab,spawnBullet.position,spawnBullet.rotation);//loads bullet prefab and shoots it
        }


  if(move.sqrMagnitude>0)//if player was moving
  {
   
  
//step3
      // flipping player according to w,a,s,d direction along with gun

      if(moveX<0)//if plsyer was movig left
      {
        playerSpriteRenderer.flipX =true;// moves player left
      }
      if (moveX>0)//if player was moving right
      {
        playerSpriteRenderer.flipX =false;// moves player right or unchanged
      }


//step4 gun rotation while pressing w,a,s,d keys

      float angle = Mathf.Atan2(moveY,moveX)*Mathf.Rad2Deg;//calculates angle of rotation of gun according to player movement
      gunTransform.rotation = Quaternion.Euler(0,0,angle);//rotates gun according to player movement 


    }

    }
}
