using UnityEngine;

public class SceneSwitch : MonoBehaviour
{
    public void Szene1()
    { Application.LoadLevel(0); }

    public void Szene2()
    { Application.LoadLevel(1); }

    public void Szene3()
    { Application.LoadLevel(2); }
}
