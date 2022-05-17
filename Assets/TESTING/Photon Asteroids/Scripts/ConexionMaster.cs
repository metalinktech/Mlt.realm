using Photon.Pun;
using Photon.Realtime;
using UnityEngine;

public class ConexionMaster : MonoBehaviourPunCallbacks
{


    void Start()
    {
        //Controlamos la vers�on del juego
        PhotonNetwork.GameVersion = "0.1";

        PhotonNetwork.ConnectUsingSettings();
        Debug.Log("Se va conectar al servidor Master");
    }


    public override void OnConnectedToMaster()
    {
        Debug.Log("Se ha conectado al servidor Maestro");
    }

    public override void OnDisconnected(DisconnectCause cause)
    {
        Debug.Log("Problema al conectar al servidor Master");
    }


}
