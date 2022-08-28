# Kogane DOTween Tween List

DOTween の Tween をリストで管理するクラス

## 使用例

```csharp
using DG.Tweening;
using Kogane;
using UnityEngine;

public class Example : MonoBehaviour
{
    private readonly TweenList m_tweenList = new();

    private void Update()
    {
        if ( Input.GetKeyDown( KeyCode.Space ) )
        {
            Play();
        }
    }

    private void Play()
    {
        m_tweenList.CompleteAll();

        transform.DOMoveX( 1, 10 ).AddToList( m_tweenList );
        transform.DOMoveY( 1, 10 ).AddToList( m_tweenList );
    }
}
```