using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class IDRegister : MonoBehaviour
{
    public TMP_InputField inputField;
    public TextMeshProUGUI errorText;

    [SerializeField] private List<string> usersID;

    void Start()
    {
        RandomdId();
    }


    public void Create()
    {
        errorText.text = " ";

        if (usersID.Contains(inputField.text))
            errorText.text = "Ese ID ya existe";
        else
            usersID.Add(inputField.text);
    }

    public void RandomdId()
    {
        inputField.text = "metaverso" + Random.Range(0000, 9999);
    }

}
