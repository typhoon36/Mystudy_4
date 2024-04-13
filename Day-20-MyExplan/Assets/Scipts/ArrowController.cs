using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ArrowController : MonoBehaviour
{

    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {

        //�����Ӹ��� ��� ����
        transform.Translate(0, -0.1f, 0);

        //������Ʈ �Ҹ�
        if(transform.position.y < -5.0f) //������Ʈ ��ġ y�� 5���� ������
        {
            Destroy(gameObject); //������Ʈ �Ҹ�
        }

        Vector2 p1 = transform.position;//ȭ�� �߽���ǥ
        Vector2 p2 = this.player.transform.position; //�÷��̾� �߽���ǥ
        Vector2 dir = p1 - p2; //�ڿ��� ������ ���ϴ� ���Ͱ� �Ǿ�����
        float d = dir.magnitude; //������ �ȴ�.
        float r1 = 0.5f; //ȭ��ݰ�
        float r2 = 1.0f; //�÷��̾� �ݰ�

        if (d < r1 + r2)
        {
            //���� ��ũ��Ʈ�� �÷��̾�� ȭ���� �浹�ߴٰ� ����.
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().DecreaseHp();

            Destroy(gameObject);//�浹������ ȭ���� �ı�
        }

    }
}