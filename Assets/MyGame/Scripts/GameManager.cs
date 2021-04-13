using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text counterText;

    void Update()
    {
        counterText.text = counter.ToString();
    }
}
