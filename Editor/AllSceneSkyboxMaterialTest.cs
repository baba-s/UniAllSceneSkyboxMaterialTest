using NUnit.Framework;
using UnityEngine;

namespace Kogane.Internal
{
	internal sealed class AllSceneSkyboxMaterialTest
	{
		[Category( nameof( Kogane ) )]
		[Test]
		public void Skybox_Material_が無効になっているか()
		{
			AllSceneTester.Test( _ => RenderSettings.skybox == null );
		}
	}
}