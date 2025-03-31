using UnityEngine;

public class Moving : MonoBehaviour
{
    float translationSpeed = 2.0f;
    float rotationSpeed = 100.0f;
    Animator anim;

    void Start()
    {
        anim = this.GetComponent<Animator>();
    }

    void Update()
    {
        float translation = Input.GetAxis("Vertical") * translationSpeed * Time.deltaTime;
        transform.Translate(0, 0, translation);

        float rotation = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;
        transform.Rotate(0, rotation, 0);

        if (translation != 0)
        {
            anim.SetBool("enableWalking", true);
            if (translation < 0)
            {
                anim.SetFloat("playerSpeed", -1.0f);
            }
            else
            {
                anim.SetFloat("playerSpeed", 1.0f);
            }
        }
        else
        {
            anim.SetBool("enableWalking", false);
        }
    }
}
