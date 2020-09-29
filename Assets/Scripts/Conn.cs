using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class Conn : MonoBehaviourPunCallbacks
{
    // Start is called before the first frame update
    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void OnJoinedLobby()
    {
        Debug.Log("Estou no Lobby!");



    }
    public override void OnConnectedToMaster()
    {
        Debug.Log("Estou Conectado!");
    }
    public override void OnDisconnected(DisconnectCause cause)
    {
        Debug.Log("Disconectei!");
    }
    public override void OnJoinRoomFailed(short returnCode, string message)
    {
        base.OnJoinRoomFailed(returnCode, message);
    }

}
