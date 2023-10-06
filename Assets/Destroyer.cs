using UnityEngine;

public class ObjectDestroyer : MonoBehaviour
{
    public float destroyYThreshold = 5.0f; // 破棄のy座標閾値
    private Transform objTransform; // オブジェクトのTransformコンポーネント

    void Start()
    {
        // オブジェクトのTransformコンポーネントを取得
        objTransform = GetComponent<Transform>();
    }

    void Update()
    {
        // オブジェクトの現在のy座標が閾値を超えたら破棄する
        if (objTransform.position.y >= destroyYThreshold)
        {
            Destroy(gameObject);
        }
    }
}
