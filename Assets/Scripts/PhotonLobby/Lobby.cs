using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

public class Lobby : MonoBehaviourPunCallbacks
{

    public Text log;

    void Start()
    {
        PhotonNetwork.NickName = "Player " + Random.Range(0, 100);
        Log("Player's name is set to " + PhotonNetwork.NickName);

        PhotonNetwork.AutomaticallySyncScene = true; // синхронизация переключения сцены
        PhotonNetwork.GameVersion = "1";
        PhotonNetwork.ConnectUsingSettings();
    }

    public void OnCreateRoom()
    {
        PhotonNetwork.CreateRoom(null, new Photon.Realtime.RoomOptions { MaxPlayers = 2 });
    }

    public void OnJoinToRandomRoom()
    {
        PhotonNetwork.JoinRandomRoom();
    }


    public override void OnConnectedToMaster()
    {
        Log("Connected to Master");
    }


    public override void OnJoinedRoom()
    {
        Log("Joined the room");
        PhotonNetwork.LoadLevel("Game");
    }


    private void Log(string mes)
    {
        Debug.Log(mes);
        log.text += "\n";
        log.text += mes;
    }
}
