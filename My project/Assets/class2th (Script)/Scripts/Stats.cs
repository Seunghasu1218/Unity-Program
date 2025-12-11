using UnityEngine;

public class Stats : MonoBehaviour
{
    public int strength = 5;
    public int wisdom = 1;
    public int dexterity = 0;

    void Start()
    {
        Debug.Log("strength : " + strength);
        Debug.Log("wisdom : " + wisdom);
        Debug.Log("dexterity : " + dexterity);
    }
}
