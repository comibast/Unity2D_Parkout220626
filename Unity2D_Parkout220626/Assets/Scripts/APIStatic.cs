using UnityEngine;


namespace Comibast
{

    public class APIStatic : MonoBehaviour
    {
        private void Start()
        {
            #region �ǲ�
            //���o�R�A�ݩ�
            //�y�k: 
            //���O, �R�A�ݩʦW��
            print("�H����:" + Random.value);
            print("PI:" + Mathf.PI);
            print("�L���j��:" + Mathf.Infinity);

            //Cursor.visible = false;      //���ù���

            Physics2D.gravity = new Vector2(0, -9.8f);   //�a�ߤޤO,�Y���t�ȷ|���_

            Time.timeScale = 10f;          //�ɶ��P�ɼv�T���z�M�ʵe�t��

            //�ϥ��R�A��k:
            //�y�k:
            //���O.�R�A��k�W��(�����޼�)
            float range = Random.Range(20.5f, 100.5f);
            print("�H���d��: " + range);

            #endregion 

            //print("�Ҧ���v���ƶq" + );    //Camera

            //print("���ε{�������x:" + );             //Application

            //print("3D ���z�ίv�{�ɭȳ]�w�� 10" + );    //Physics3D

            //print("�ɶ��j�p�]�w�� 0.5 (�C�ʧ@)" + );   //Time

            //print("�� 9.999 �h�p���I (������h���覡):" + );   //Mathf

            //print("���o���I���Z��:" + );   //Vector3
            //new Vector3(1, 1, 1), new Vector3(22, 22, 22)

            ////print("�}�ҳs�� https://unity.com/:" + );   //Application


        }


        private void Update()
        {
            #region �ǲ�

            int rangeInt = Random.Range(1, 3);
            print("�H�����1~2:(�]�����]�t3) " + rangeInt);
            //minInclusive:�]�t�̤p��, maxExclusive:���]�t�̤j��.

            #endregion 

            //print("�O�_��J���N��: " + );            //Input

            //print("�C���g�L�ɶ�: " + );            //Time

            //print("�O�_���U���� (���w���ť���): " + );   //Input


        }





    }

}

