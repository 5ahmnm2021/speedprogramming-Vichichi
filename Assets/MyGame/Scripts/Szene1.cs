using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Szene1 : MonoBehaviour
{
    public GameObject falseImage;

    public void False()
    {
        StartCoroutine(Wait());
    }

    IEnumerator Wait()
    {
        falseImage.SetActive(true);
        yield return new WaitForSeconds(3);
        Application.LoadLevel(1);
    }
}
