using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class CutOutImg : Image
{
    public override Material materialForRendering
    {//materialForRendering�OUI����̲״�V�b�e���W�ɩҥΪ�����A�A�i�H�z�L�мg�ӧ���Ӷi��@�ǷL��
        get
        {
            Material mat = new Material(base.materialForRendering);
            //�קK���ʨ�쥻Image�b��?������A�]���B�~�ƻs�X�� (�ȷ|�v�T���LImage)
            mat.renderQueue -= 1; //������???���?��?�I�Q��V (���n���]�����ݭn�g)
            mat.SetInt("_UseUIAlphaClip", 1);
            //�]�wAlphaClip��true(0��false)�A�Ϩ�u���쥻���C?�������~�Q��V�A?���O�T�w?��?����V
            mat.SetInt("_Stencil", 1); //�]�wStencil Ref (������Q��V�ɡA�N�ù������Ӱ϶��аO��1��)
            mat.SetInt("_StencilComp", (int)CompareFunction.Always); //�L�ץ��eStencil Ref���󳣶i?��V�ʧ@
            mat.SetInt("_StencilOp", (int)StencilOp.Replace); //�H�{�b��Ref(1��)���N���쥻�ù����϶���Stencil Ref
            return mat;
        }
    }
}