using Editor;
using Sandbox;

namespace TTT;

[ClassName( "ttt_ammo_random" )]
[EditorModel( "models/ammo/ammo_smg/ammo_smg.vmdl" )]
[HammerEntity]
[Title( "Random Ammo" )]
public class RandomAmmo : Entity
{
	public override void Spawn()
	{
		Transmit = TransmitType.Never;

		Ammo.Create( (AmmoType)Game.Random.Int( 1, 5 ) ).Transform = Transform;
	}
}
