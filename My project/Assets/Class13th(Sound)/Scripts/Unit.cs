using UnityEngine;

public class Unit : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;

    public void Enit()
    {
        audioSource.clip = Resources.Load<AudioClip>("Attack");

        audioSource.Play();
    }
}
