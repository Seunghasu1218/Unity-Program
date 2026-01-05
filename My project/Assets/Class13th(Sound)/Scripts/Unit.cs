using UnityEngine;

public enum AnimationState
{
    Idle,
    Walk,
    Attack,
    Die
}

public class Unit : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;
    [SerializeField] Animator animator;
    [SerializeField] int index = 0;
    [SerializeField] AnimationState state;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void Transtion(int count)
    {
        if (count == 0)
        {
            state = (AnimationState)((int)state % 3);

            return;
        }

        index += count;

        if (index % 3 == 0)
        {
            state++;
        }
    }

    public void Enit()
    {
        Debug.Log(state.ToString());

        Debug.Log(animator.GetCurrentAnimatorStateInfo(0).IsName(state.ToString()));

        audioSource.clip = Resources.Load<AudioClip>(state.ToString());

        audioSource.Play();
    }
}
