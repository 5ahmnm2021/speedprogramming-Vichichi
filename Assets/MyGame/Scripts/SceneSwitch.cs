using UnityEngine;

public class SceneSwitch : MonoBehaviour
{
    public static int counter;

    public void Szene2()
    { 
        Application.LoadLevel(1);
        counter++;
    }

    public void Szene3()
    { 
        Application.LoadLevel(2);
        counter++;
    }
}
