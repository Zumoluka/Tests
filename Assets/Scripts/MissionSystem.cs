using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MissionSystem : MonoBehaviour
{
   
    public TextMeshProUGUI missionText;
    private bool isMissionAccepted = false;
    private bool isMissionCompleted = false;

    private void Update()
    {
        // Si la misi�n no est� aceptada y se presiona la tecla "E"
        if (!isMissionAccepted && Input.GetKeyDown(KeyCode.E))
        {
            AcceptMission();
        }
        // Si la misi�n est� aceptada y se presiona la tecla "Q"
        else if (isMissionAccepted && Input.GetKeyDown(KeyCode.Q))
        {
            CompleteMission();
        }
    }

    private void AcceptMission()
    {
        isMissionAccepted = true;
        isMissionCompleted = false;
        UpdateMissionText();
    }

    private void CompleteMission()
    {
        isMissionCompleted = true;
        UpdateMissionText();
    }

    private void UpdateMissionText()
    {
        if (isMissionCompleted)
        {
            missionText.text = "Misi�n completada!.";
            
        }
        else if (isMissionAccepted)
        {
            missionText.text = "Presiona 'Q' para completar la misi�n.";
        }
        else
        {
            missionText.text = "Presiona 'E' para aceptar la misi�n.";
        }
    }
}
