using UnityEngine;

public class CubeRotation : MonoBehaviour
{
    public float rotationSpeed = 30f; // �������� �������� ����

    void Update()
    {
        // �������� ���� ������ ��� ��� Y
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }
}
