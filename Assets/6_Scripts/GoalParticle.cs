using UnityEngine;

public class GoalParticle : MonoBehaviour
{
    public GameObject particleObject;

    private ParticleSystem particleSystem1;
    private ParticleSystem particleSystem2;

    private void Awake()
    {
        particleSystem1 = GetComponent<ParticleSystem>();
        particleSystem2 = GetComponent<ParticleSystem>();
        particleObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            particleObject.SetActive(true);
            particleSystem1.Play();
            particleSystem2.Play();
        }
    }
}
