Shader "Custom/TestShader"
{
    Properties
    {
        _MainTex("Texture", 2D) = "white" {}
    }

    SubShader
    {
        Tags
        {
            "RenderType" = "Opaque"
        }

        CGPROGRAM
        // ライティングモデルはここで指定
        // 頂点シェーダ関数やfinalcolor関数もここで指定
        #pragma surface surf Standard vertex:vert finalcolor:final

        struct Input
        {
            // 特定の名前の変数を定義するとUnityが値を入れてくれる
            float2 uv_MainTex;
            float3 viewDir;
            // 独自の変数を定義して頂点シェーダからsurfに値を受け渡すこともできる
            float3 rimColor;
        };

        sampler2D _MainTex;

        void vert(inout appdata_full v, out Input o)
        {
            // Input構造体は初期化が必要
            UNITY_INITIALIZE_OUTPUT(Input, o);
            // Input構造体を通してsurf関数に値を受け渡す
            o.rimColor = float3(1, 0, 0);
        }

        void surf(Input IN, inout SurfaceOutputStandard o)
        {
            o.Albedo = tex2D(_MainTex, IN.uv_MainTex).rgb;
            o.Metallic = 1;
            o.Smoothness = 0.5;
            o.Emission = (1 - dot(IN.viewDir, o.Normal)) * IN.rimColor;
        }

        void final(Input IN, SurfaceOutputStandard o, inout fixed4 color)
        {
            color = pow(color, 3);
        }
        ENDCG
    }

}