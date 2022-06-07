using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameSetup : MonoBehaviour
{
    public static GameSetup GS;

    public Text healthDisplay;

    public int nextPlayersTeam;

    public Transform[] spawnPointsTeamOne;
    public Transform[] spawnPointsTeamTwo;

    private void OnEnable()
    {
        if (GameSetup.GS == null)
            GameSetup.GS = this;
    }

    public void DisconnectPlayer()
    {
        
    }

    IEnumerator DisconnectAndLoad()
    {
        PhotonNetwork.Disconnect();
        while (PhotonNetwork.IsConnected)
            yield return null;
        //SceneManager.LoadScene(Mul)
    }


}
