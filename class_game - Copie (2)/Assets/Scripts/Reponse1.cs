using UnityEngine;

public class Reponse1 : MonoBehaviour
{
    public GameObject question1;
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
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.C))
        {
            audioSource.PlayOneShot(wrongAnswerSound);
        }
        else if (Input.GetKeyDown(KeyCode.B))
        {
            question1.SetActive(false);
            arme.SetActive(true);
            audioSource.PlayOneShot(correctAnswerSound);
        }
    }
}
