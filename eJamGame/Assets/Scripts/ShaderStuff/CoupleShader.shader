Shader "Custom/CoupleShader"
{
	Properties{ }

		SubShader
	{
		Tags { "Queue" = "Geometry" "RenderType" = "Opaque" }

		Pass
		{
			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag

			#include "UnityCG.cginc"

			struct appdata
			{
				float4 vertex : POSITION;
				float4 color : COLOR;
			};

			struct v2f
			{
				float4 vertex : SV_POSITION;
				fixed4 color : COLOR;
			};

			v2f vert(appdata v)
			{
				v2f o;

				o.vertex = UnityObjectToClipPos(v.vertex);
				o.color = fixed4(v.color.rgb, v.color.a);

				return o;
			}

			fixed4 frag(v2f i) : Color // was SV_Target
			{
				return i.color;
			}

			ENDCG
		}
	}
}
