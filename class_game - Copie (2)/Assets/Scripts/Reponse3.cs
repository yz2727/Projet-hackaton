using UnityEngine;

public class Reponse3 : MonoBehaviour
{
    public GameObject question3;
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
        if (Input.GetKeyDown(KeyCode.A))
        {
            audioSource.PlayOneShot(wrongAnswerSound);
        }
        else if (Input.GetKeyDown(KeyCode.B))
        {
            question3.SetActive(false);
            arme.SetActive(true);
            audioSource.PlayOneShot(correctAnswerSound);
        }
    }
}
