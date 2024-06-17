using UnityEngine;

public class Coin : MonoBehaviour
{
    public int value = 1;

    [SerializeField] private AudioClip coinSoundClip;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.Instance.AddCoin(value);
            SoundManager.PlayClip(coinSoundClip);
            Destroy(gameObject);
        }
    }
}
