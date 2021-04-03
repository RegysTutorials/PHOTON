using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class PHOTONMANAGER : MonoBehaviourPunCallbacks
{

 //ADICIONE ESTE SCRIPT EM UM GAMEOJECT VAZIO E NOMEIE ELE COMO PHOTONMANAGER
 void Start()
    {
  PhotonNetwork.ConnectUsingSettings();
 }
  

 public override void OnConnectedToMaster()
 {
  PhotonNetwork.JoinLobby();
 }

 public override void OnJoinedLobby()
 {
  PhotonNetwork.JoinOrCreateRoom("room", new RoomOptions { MaxPlayers = 4 }, TypedLobby.Default);


 }

 public override void OnJoinedRoom()
 {
PhotonNetwork.Instantiate("player", new Vector2(Random.Range(0f, 0f), transform.position.y), Quaternion.identity);

 
 }


}
