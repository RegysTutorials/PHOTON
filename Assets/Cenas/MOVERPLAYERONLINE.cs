using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class MOVERPLAYERONLINE : MonoBehaviour
{
  float Mover_X;
  float Velocidade =3.5f;
  private float jumpForce = 5;
  public bool isjumpbuttonpressed= false;
  Rigidbody2D rb;


void Start ()
{
rb = GetComponent<Rigidbody2D>();
}

void Update()
{
  Vector3 Move = Vector3.zero;

Move.x =Input.GetAxisRaw("Horizontal");
 
transform.position += new Vector3(Move.x , 0f, 0f)*Time.deltaTime *Velocidade;
 
  if(Input.GetButtonDown("Jump"))
  {
  isjumpbuttonpressed=true;
  }

if(isjumpbuttonpressed==true)
{
 rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
 isjumpbuttonpressed=false;
  }
 }
 

}
