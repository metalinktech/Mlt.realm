using Photon.Pun;
using Photon.Realtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhotonLobby : MonoBehaviourPunCallbacks
{
    public static PhotonLobby lobby;


    public GameObject battleButton;
    public GameObject cancelButton;


    private void Awake()
    {
        lobby = this; //Creates the singelton, lives withing the Main menu scene.
    }


    void Start()
    {
        PhotonNetwork.ConnectUsingSettings(); //Connects to Master photon server.
    }

    public override void OnConnectedToMaster()
    {
        Debug.Log("Player has connected to the Photon master server");
        PhotonNetwork.AutomaticallySyncScene = true; //Defines if all clients in a room should automatically load the same level as the Master Client.
        battleButton.SetActive(true);
    }

    public void OnBattlebuttonClicked()
    {

        Debug.Log("Battle Button was clicked");
        battleButton.SetActive(false);
        cancelButton.SetActive(true);
        PhotonNetwork.JoinRandomRoom();
    }

    public override void OnJoinRandomFailed(short returnCode, string message) //This function is called if the player has not connected to any room.
    {
        Debug.Log("Tried to join a random game but failed. There must be no open games available");
        CreateRoom();
    }

    void CreateRoom()
    {
        Debug.Log("Trying to create a new Room");
        int randomRoomName = Random.Range(0, 10000);
        RoomOptions roomOps = new RoomOptions() { IsVisible = true, IsOpen = true, MaxPlayers = (byte)MuliplayerSetting.muliplayerSetting.maxPlayers }; //Here are the parameters of the room
        PhotonNetwork.CreateRoom("Room" + randomRoomName, roomOps); //Create the new room
    }

    public override void OnCreateRoomFailed(short returnCode, string message) //Failed when trying to create a room.
    {
        Debug.Log("Tried to create a new room but failed, there must already be a room with the same name");
        CreateRoom();
    }

    public void OnCancelButtonClicked()
    {
        Debug.Log("Cancel Button was clicked");
        cancelButton.SetActive(false);
        battleButton.SetActive(true);
        PhotonNetwork.LeaveRoom();
    }





}
