using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevelOnCollision : MonoBehaviour
{
    

    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "PlayerTag")
        {
            Debug.Log("hit an object");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
