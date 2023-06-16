using UnityEngine;

public class Pinceau2Behaviour : MonoBehaviour
{
    public GameObject pinceau2;
    public GameObject question2;

    private bool questionActive = false;

    void Start()
    {
        question2.SetActive(false);
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
                question2.SetActive(true);
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
