using UnityEngine;    //�ޥ�Unity�����A�R�W�Ŷ�(namespace)API
namespace Comibast
{
    //C# �q�Ź��ܦ����骫��
    //1. �����W���C������
    //2. �N���}�����b�Ӫ����ܦ�����

    /// <summary>
    /// �]�B�t��
    /// </summary>
    public class SystemRun : MonoBehaviour
    {
        #region ��ơG�O�s�t�λݭn�����

        //���(Field): �O�s���
        //�y�k: 
        //�׹���: ���������(���},�p�H) ���ۭq�W��(���w �w�]��) 

        //�׹���
        //���}: ��ܦb���O, ���\��L���O�s��public
        //�p�H: ����ܦb���O, �����\��L���O�s��private(�ʸ�)

        //[] Attribute �ݩ�, �B�~�\��
        //SSerializeField �ǦC�����: �N�p�H������
        //Header ���D: �i�Τ���
        //Tooltip ����: �i�H�ϥΤ���
        // Range �d��: �ȭ���ƭ��������int, float, byte,long

        [SerializeField,Header("�]�B�t��"),Tooltip("�o�O���⪺�]�B�t��"),Range(0,100)]      
        private float speedRun = 3.5f;
        [SerializeField,Header("���D����"), Range(0, 3000)]      
        private float heightJump = 350;
        private Animator ani;
        private Rigidbody2D rig;

        #endregion


        #region �\��G��@�Өt�Ϊ���k

        #endregion


        #region �ƥ�G�{���J�f

        //����ƥ�: �}�l�e����@��, ���o����
        private void Awake()
        {
            ani = GetComponent<Animator>();
        }

        private void Start()
        {
            print("Hi! �p�D! :D");
        }

        //��s�ƥ�: �C��60��fps
        private void Update()
        {
            print("<color=yellow>��s�ƥ���椤</color>");
        }
        #endregion


    }
}

