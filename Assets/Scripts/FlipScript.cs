using System.Collections;
using UnityEngine;

public class FlipScript : MonoBehaviour
{
    SpriteRenderer SR;
    public Sprite[] sides;
    public int flipCount = 0;

    private void OnMouseDown()
    {
        StartCoroutine(wait(0.0001f, 1.0f));
    }
    IEnumerator wait(float duration, float size)
    {
        while(size > 0.1)
        {
            size = size - 0.07f;
            transform.localScale = new Vector3(1, size, 1);
            yield return new WaitForSeconds(duration);
        }
        SR.sprite = sides[flipCount % 2];
        while(size < .99)
        {
            size = size + 0.07f;
            transform.localScale = new Vector3(1, size, size);
            yield return new WaitForSeconds(duration);
        }
        flipCount++;
    }
    private void Awake()
    {
        SR = GetComponent<SpriteRenderer>();
    }
}
