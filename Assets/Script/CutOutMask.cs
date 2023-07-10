using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class CutOutMask : Image
{
    public override Material materialForRendering
    {
        get
        {
            Material mat = new Material(base.materialForRendering);
            //�קK���ʨ�쥻Image�b��?������A�]���B�~�ƻs�X�� (�ȷ|�v�T���LImage)
            mat.SetInt("_Stencil", 1);//�]�wStencil Ref (������Q��V�ɡA�N�ù������Ӱ϶��аO��1��)
            mat.SetInt("_StencilComp", (int)CompareFunction.NotEqual);
            //�u�b�ù��϶���Stencil Ref���P�ɤ~��V (�j�ץ��e����?)
            mat.SetInt("_StencilOp", (int)StencilOp.Zero);//�N??�϶���Stencil Ref�]�^0
            return mat;
        }
    }
}