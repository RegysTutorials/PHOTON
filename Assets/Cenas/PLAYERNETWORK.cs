using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PLAYERNETWORK : MonoBehaviour
{
 public MonoBehaviour[] ScriptsParaIgnorar;
 private PhotonView photonView;
 
 void Start()
    {
  photonView = GetComponent<PhotonView>();

  if (!photonView.IsMine)
  {
      foreach ( var script in ScriptsParaIgnorar)
      {
    script.enabled = false;
   }
  }
 }
  
}
