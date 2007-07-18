using System;
using System.Collections;
using Server;

namespace Server.Mobiles
{
	public class MasterFisherman : BaseVendor
	{
		private ArrayList m_SBInfos = new ArrayList();
		protected override ArrayList SBInfos{ get { return m_SBInfos; } }

		public override NpcGuild NpcGuild{ get{ return NpcGuild.FishermensGuild; } }

		[Constructable]
		public MasterFisherman() : base( "the angler" )
		{
			SetSkill( SkillName.Fishing, 75.0, 98.0 );
		}

		public override void InitSBInfo()
		{
			m_SBInfos.Add( new SBMasterFisherman() );
		}

		public override void InitOutfit()
		{
			base.InitOutfit();

			AddItem( new Server.Items.FishingPole() );
		}

		public MasterFisherman( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}
	}
}