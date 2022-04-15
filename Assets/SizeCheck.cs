using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizeCheck : MonoBehaviour
{
    // ���s��AInspector�\���p
    public Vector3 originalSize;
    public Vector3 realSize;

    // Start is called before the first frame update
    void Start()
    {
        // ���b�V���́i�o�E���Y�j�T�C�Y���擾
        Mesh mesh = transform.GetComponent<MeshFilter>().mesh;
        Bounds bounds = mesh.bounds;
        originalSize = bounds.size;

        // �X�P�[�����|�����킹�����ۂ̃T�C�Y���擾
        realSize = bounds.size;
        realSize.x *= transform.localScale.x;
        realSize.y *= transform.localScale.y;
        realSize.z *= transform.localScale.z;

        // Console�֕\��
        print(string.Format("name = {0} : Original Size(m) = ({1}, {2}, {3}), Real Size(m) = ({4}, {5}, {6})",
            this.name,
            originalSize.x, originalSize.y, originalSize.z,
            realSize.x, realSize.y, realSize.z));
    }

    // Update is called once per frame
    void Update()
    {
        // ���b�V���́i�o�E���Y�j�T�C�Y���擾
        Mesh mesh = transform.GetComponent<MeshFilter>().mesh;
        Bounds bounds = mesh.bounds;
        originalSize = bounds.size;

        // �X�P�[�����|�����킹�����ۂ̃T�C�Y���擾
        realSize = bounds.size;
        realSize.x *= transform.localScale.x;
        realSize.y *= transform.localScale.y;
        realSize.z *= transform.localScale.z;

        // Console�֕\��
        print(string.Format("name = {0} : Original Size(m) = ({1}, {2}, {3}), Real Size(m) = ({4}, {5}, {6})",
            this.name,
            originalSize.x, originalSize.y, originalSize.z,
            realSize.x, realSize.y, realSize.z));

    }
}