using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class RoomController : MonoBehaviourPunCallbacks
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("spawPlayer",2f);
    }

    public void spawPlayer()
    {
        PhotonNetwork.Instantiate("Player", transform.position, transform.localRotation);
    }
  

}
