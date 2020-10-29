using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class Conn : MonoBehaviourPunCallbacks
{
    public GameObject playerPrefab;

    public string nameRoom;

    public static Conn instance;

    public void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }



    // Start is called before the first frame update
    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
        PhotonNetwork.AutomaticallySyncScene = true;

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void startGame()
    {

    }
    public void createRoom()
    {
        PhotonNetwork.JoinOrCreateRoom(nameRoom,new RoomOptions(),TypedLobby.Default);

    }

    public override void OnJoinedLobby()
    {
        Debug.Log("Estou no Lobby!");
        


    }

    public override void OnJoinedRoom()
    {
        if (PhotonNetwork.IsMasterClient)
        {
            //PhotonNetwork.LoadLevel("GamePlayTheSkeld");
        }

        

    }
    public override void OnConnectedToMaster()
    {
        Debug.Log("Estou Conectado!");
        PhotonNetwork.JoinLobby();
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
