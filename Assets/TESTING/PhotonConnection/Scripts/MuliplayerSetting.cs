using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuliplayerSetting : MonoBehaviour
{
    public static MuliplayerSetting muliplayerSetting;

    public bool delayStart;
    public int maxPlayers;

    public int menuScene;
    public int multiplayerScene;


    private void Awake()
    {
        if (MuliplayerSetting.muliplayerSetting == null)
        {
            MuliplayerSetting.muliplayerSetting = this;
        }
        else
        {
            if (MuliplayerSetting.muliplayerSetting != null)
            {
                Destroy(this.gameObject);
            }
        }
        DontDestroyOnLoad(this.gameObject);
    }

}
