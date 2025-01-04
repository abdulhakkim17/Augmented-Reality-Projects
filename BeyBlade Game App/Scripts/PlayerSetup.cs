using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using TMPro;

public class PlayerSetup : MonoBehaviourPun
{
    public TextMeshProUGUI playerNameText;
    // Start is called before the first frame update
    void Start()
    {
        if (photonView.IsMine)
        {
            //Plater is local player
            transform.GetComponent<MovementController>().enabled = true;
            transform.GetComponent<MovementController>().joystick.gameObject.SetActive(true);
        }
        else
        {
            //Plater is remote player
            transform.GetComponent<MovementController>().enabled = false;
            transform.GetComponent<MovementController>().joystick.gameObject.SetActive(false);
        }
        SetPlayerName();
    }

    void SetPlayerName()
    {
        if (playerNameText != null)
        {
            if (photonView.IsMine)
            {
                playerNameText.text = "You";
                playerNameText.color = Color.red;
            }
            
            else
            {
                playerNameText.text = photonView.Owner.NickName;
            }
        }
    }
}
