Shader "N3K/Outline"
{
    Properties
    {
        _Color("Main Color", Color) = (0.5,0.5,0.5,1)
        _MainTex ("Texture", 2D) = "white" {}
        _OutlineColor("Outline Color", color) = (0,0,0,1)
        _OutlineWidth("Outline Width", Range(1.0, 5.0))= 1.01
    }

        CGINCLUDE
#include "UnityCG.cginc"

        struct appdata
        {
            float4 vertex : POSITION;
            float2 normal : NORMAL;
        };

        struct v2f
        {
            float4 pos : POSITION;
            float3 normal: NORMAL;
        };

        float  _OutlineWidth;
        float4 _OutlineColor;

        v2f vert(appdata v) {
            v.vertex.xyz *= _OutlineWidth;
            v2f o;
            o.pos = UnityObjectToClipPos(v.vertex);
            return o;
        };
        ENDCG

            SubShader
        {
            Tags{"Queu" = "Transparent"}
            Pass //Outline renderer
            {
               ZWrite Off

               CGPROGRAM
                #pragma vertex vert
                #pragma fragment frag
                half4 frag(v2f i) : COLOR
               {
                return _OutlineColor;
           }
            ENDCG
           
        }
        Pass //Normal Renderer
        {
               ZWrite ON

               Material{
               Diffuse[_Color]
               Ambient[_Color]
               }

               Lighting ON

               SetTexture[_MainText]{
               ConstantColor[_Color]
                }
               SetTexture[_MainText]{
               Combine previous * primary DOUBLE
                }
        }
    }
}
