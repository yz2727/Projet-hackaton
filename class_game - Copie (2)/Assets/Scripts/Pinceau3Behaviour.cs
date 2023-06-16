using UnityEngine;

public class Pinceau3Behaviour : MonoBehaviour
{
    public GameObject pinceau3;
    public GameObject question3;

    private bool questionActive = false;

    void Start()
    {
        question3.SetActive(false);
        Debug.Log("Start() appelé");
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Destroy(this.gameObject);
            Debug.Log("objet détruit");

            if (!questionActive)
            {
                question3.SetActive(true);
                questionActive = true;
                Debug.Log("question active");
            }
        }
    }

    void Update()
    {
        Debug.Log("Update() appelé");
    }
}
