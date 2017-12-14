using UnityEngine;
using System.Collections;

public class SEKIBAN : MonoBehaviour
{
    // トリガーとの接触時に呼ばれるコールバック
    void OnTriggerEnter(Collider hit)
    {
        // 接触対象はPlayerタグですか？
        if (hit.CompareTag("Player"))
        {

            // このコンポーネントを持つGameObjectを破棄する
            Destroy(gameObject);
        }
    }
}

