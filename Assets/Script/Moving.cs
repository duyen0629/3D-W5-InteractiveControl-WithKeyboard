using UnityEngine;

public class Moving : MonoBehaviour
{
    float translationSpeed = 2.0f;

    void Update()
    {
        float translation = Input.GetAxis("Vertical") * translationSpeed * Time.deltaTime;
        transform.Translate(0, 0, translation);
    }
}
