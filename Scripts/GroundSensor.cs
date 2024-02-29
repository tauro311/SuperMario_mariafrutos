using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSensor : MonoBehaviour


{
 public bool isGrounded;
 public Animator anim;
 PlayerMove playerScript;

 void Awake()
 {
   anim = GetComponentInParent<Animator>();
   playerScript = GetComponentInParent<PlayerMove>();
 }
 void OnTriggerEnter2D(Collider2D collider)
 {
    if(collider.gameObject.tag == "Goombas")
    {
      //Destroy(collider.gameObject);
      Enemy goomba = collider.gameObject.GetComponent<Enemy>();
      playerScript.rBody.AddForce(new Vector2(0,1) * playerScript.jumpForce, ForceMode2D.Impulse);
      anim.SetBool("IsJumping", true);
      goomba.GoombaDeath();
    }
    isGrounded = true;
    anim.SetBool("IsJumping", false);
 }

 void OnTriggerExit2D(Collider2D collider)
 {
    isGrounded = false;
 }

 void OnTriggerStay2D(Collider2D collider)
 {
   isGrounded = true;
 }
}
