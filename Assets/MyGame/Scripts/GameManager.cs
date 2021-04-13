using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text counterText;

    public GameObject sceneSwitch;

    private int counterNumber;

    void Update()
    {
        counterNumber = sceneSwitch.GetComponent<SceneSwitch>().counter;

        while(counterNumber < 1)
        {
            counterText.text = "Du kannst kein Programmieren!";
        }
        while(counterNumber > 1)
        {
            counterText.text = counterNumber.ToString();
        }
    }
}
