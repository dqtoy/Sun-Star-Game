using UnityEngine;
using System.Collections;

public class AnimateFruitBox : MonoBehaviour
{

    public Sprite pic;
    public SpriteRenderer r;

    public static int x = 700;

    void Start()
    {
        x = 700;
        InvokeRepeating("AnimateIt", 0, 0.1f);
    }
    void AnimateIt()
    {
        Sprite cropped = new Sprite();
        cropped = Sprite.Create(pic.texture, new Rect(pic.rect.x, pic.rect.y, pic.rect.width, pic.rect.height - x), new Vector2(0.5f, 0f), pic.pixelsPerUnit);
        x -= 7;
        r.sprite = cropped;
        if (x <= 0)
            CancelInvoke("AnimateIt");
    }
}
