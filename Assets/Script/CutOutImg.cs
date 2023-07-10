using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class CutOutImg : Image
{
    public override Material materialForRendering
    {//materialForRendering是UI物件最終渲染在畫面上時所用的材質，你可以透過覆寫該材質來進行一些微調
        get
        {
            Material mat = new Material(base.materialForRendering);
            //避免異動到原本Image在使?的材質，因此額外複製出來 (怕會影響到其他Image)
            mat.renderQueue -= 1; //讓此圖???般圖?早?點被渲染 (但好像也未必需要寫)
            mat.SetInt("_UseUIAlphaClip", 1);
            //設定AlphaClip為true(0為false)，使其只有原本有顏?的部分才被渲染，?不是固定?個?塊渲染
            mat.SetInt("_Stencil", 1); //設定Stencil Ref (當此物件被渲染時，將螢幕的那個區塊標記為1號)
            mat.SetInt("_StencilComp", (int)CompareFunction.Always); //無論先前Stencil Ref為何都進?渲染動作
            mat.SetInt("_StencilOp", (int)StencilOp.Replace); //以現在的Ref(1號)取代掉原本螢幕此區塊的Stencil Ref
            return mat;
        }
    }
}