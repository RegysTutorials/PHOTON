using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class RANDOMSPRITES : MonoBehaviour
{
 private int rand;

 public Sprite[] images;

void Start()
{
  changeImage();
 }

void changeImage()
{
  rand = Random.Range(0, images.Length);
  GetComponent<SpriteRenderer>().sprite = images[rand];
 }
}
