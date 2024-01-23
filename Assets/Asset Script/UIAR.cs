using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class UIAR : MonoBehaviour
{
    public RectTransform Panel;
    // Start is called before the first frame update
    void Start()
    {
        Panel.DOAnchorPos(new Vector2(0, -2500), 1.0f);
    }
    public void Kembalibutton()
    {
        Panel.DOAnchorPos(new Vector2(0, -2500), 1.0f);
    }
    public void Panggil()
    {
        Panel.DOAnchorPos(new Vector2(0, 0), 1.0f);
    }
}
