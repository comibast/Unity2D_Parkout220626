using UnityEngine;


namespace Comibast
{

    public class APIStatic : MonoBehaviour
    {
        private Vector3 a = new Vector3(1, 1, 1);
        private Vector3 b = new Vector3(22, 22, 22);
        private void Start()
        {
            #region �ǲ�
            //���o�R�A�ݩ�
            //�y�k: 
            //���O, �R�A�ݩʦW��
            //print("�H����:" + Random.value);
            //print("PI:" + Mathf.PI);
            //print("�L���j��:" + Mathf.Infinity);
            //Cursor.visible = false;      //���ù���
            
            Physics2D.gravity = new Vector2(0, -9.8f);   //�a�ߤޤO,�Y���t�ȷ|���_
            Time.timeScale = 10f;          //�ɶ��P�ɼv�T���z�M�ʵe�t��
            
            //�ϥ��R�A��k:
            //�y�k:
            //���O.�R�A��k�W��(�����޼�)
            
            float range = Random.Range(20.5f, 100.5f);
            print("�H���d��: " + range);        
            

            //print("�Ҧ���v���ƶq" + );    //Camera
            print("�Ҧ���v���ƶq: " + Camera.allCamerasCount);

            //print("���ε{�������x:" + );             //Application
            print("�ثe�����x: " + Application.platform);

            //print("3D ���z�ίv�{�ɭȳ]�w�� 10" + );    //Physics3D
            Physics.sleepThreshold = 10;
            print("�ίv�{�ɭ�: " + Physics.sleepThreshold);

            //print("�ɶ��j�p�]�w�� 0.5 (�C�ʧ@)" + );   //Time
            Time.timeScale = 0.5f;
            print("�ɶ��j�p:"+ Time.timeScale);

            //print("�� 9.999 �h�p���I (������h���覡):" + );   //Mathf
            print("9.999 �h���p���I�|�ˤ��J" + Mathf.Round(9.999f));

            //print("���o���I���Z��:" + );   //Vector3
            //new Vector3(1, 1, 1), new Vector3(22, 22, 22)
            float distance = Vector3.Distance(a, b);
            print("<color=yellow>�Z��: " + distance + "</color>");

            ////print("�}�ҳs�� https://unity.com/:" + );   //Application
            Application.OpenURL("http://unity.com/");
            #endregion


        }


        private void Update()
        {
            #region �ǲ�

            //print("�H�����1~2:(�]�����]�t3) " + rangeInt);
            //minInclusive:�]�t�̤p��, maxExclusive:���]�t�̤j��.
            int rangeInt = Random.Range(1, 3);

            //print("�O�_��J���N��: " + );            //Input
            print("�O�_���U���N��: " + Input.anyKeyDown);

            //print("�C���g�L�ɶ�: " + );            //Time
            print("�C���g�L�ɶ�: " + Time.timeSinceLevelLoad);

            //print("�O�_���U���� (���w���ť���): " + );   //Input
            print("<color=red>�O�_���U�ť���: "+ Input.GetKeyDown(KeyCode.Space)+"</color>");

            #endregion







        }





    }

}

