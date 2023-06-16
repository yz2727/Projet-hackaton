using UnityEngine;

public class Reponse4 : MonoBehaviour
{
    public GameObject question4;
    public GameObject arme;
    public AudioSource audioSource;
    public AudioClip correctAnswerSound;
    public AudioClip wrongAnswerSound;

    void Start()
    {
        arme.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            audioSource.PlayOneShot(wrongAnswerSound);
        }
        else if (Input.GetKeyDown(KeyCode.Q))
        {
            question4.SetActive(false);
            arme.SetActive(true);
            audioSource.PlayOneShot(correctAnswerSound);
        }
    }
}
