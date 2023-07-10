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
            //避免異動到原本Image在使?的材質，因此額外複製出來 (怕會影響到其他Image)
            mat.SetInt("_Stencil", 1);//設定Stencil Ref (當此物件被渲染時，將螢幕的那個區塊標記為1號)
            mat.SetInt("_StencilComp", (int)CompareFunction.NotEqual);
            //只在螢幕區塊之Stencil Ref不同時才渲染 (迴避先前的圖?)
            mat.SetInt("_StencilOp", (int)StencilOp.Zero);//將??區塊的Stencil Ref設回0
            return mat;
        }
    }
}