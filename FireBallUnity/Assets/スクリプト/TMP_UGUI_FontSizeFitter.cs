using UnityEngine;
using TMPro;

public class TMP_UGUI_FontSizeFitter : MonoBehaviour
{
    const float CONTENT_RATE = 0.95f;

    [SerializeField] bool updateOnAwake = true, everyUpdate = true;
    [SerializeField] TextMeshProUGUI text;
    float startFontSize;
    Rect rect;

    private void Start()
    {
        text.overflowMode = TextOverflowModes.Overflow;
        startFontSize = text.fontSize;
        rect = text.rectTransform.rect;

        if (updateOnAwake) UpdateFontSize(rect, text, startFontSize);
    }

    private void Update()
    {
        if (everyUpdate) UpdateFontSize(rect, text, startFontSize);
    }

    private void OnValidate()
    {
        if (text == null) TryGetComponent<TextMeshProUGUI>(out text);
    }

    /// <summary>
    /// �t�H���g�T�C�Y���X�V
    /// </summary>
    /// <param name="rect">Text��\������Rect�Bnull�ł���</param>
    /// <param name="text">Text</param>
    /// <param name="baseSize">�������\�������ő�̃t�H���g�T�C�Y��菭���������l���w�肵�Ă��������B���x�ɉe�����܂�</param>
    public static void UpdateFontSize(Rect rect, TextMeshProUGUI text, float baseSize = 300f)
    {
        text.fontSize = baseSize;
        float rateX = text.preferredWidth / rect.width;
        float rateY = text.preferredHeight / rect.height;

        if (rateX > rateY)
        {
            text.fontSize = baseSize / rateX * CONTENT_RATE;
        }
        else
        {
            text.fontSize = baseSize / rateY * CONTENT_RATE;
        }
    }
    public static void UpdateFontSize(TextMeshProUGUI text, int baseSize = 300) => UpdateFontSize(text.rectTransform.rect, text, baseSize);
}